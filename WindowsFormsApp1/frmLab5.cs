using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SDP_EntityModels;

namespace WindowsFormsApp1
{
    public partial class frmLab5: Form
    {
        public frmLab5()
        {
            InitializeComponent();
        }


        private async void frmLab5_Load(object sender, EventArgs e)
        {
            DataTable dt = await GetCustomerDataFromApiResponse();
            dgvCustomerDetails.DataSource = dt;
            dt.AcceptChanges();
        }
        private async Task<DataTable> GetCustomerDataFromApiResponse()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);
                    HttpResponseMessage response = await client.GetAsync("/api/SimpleGetAPI/GetCustomerData");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonString = await response.Content.ReadAsStringAsync();
                        DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(jsonString);
                        return dataTable;
                    }
                    else
                    {
                        throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Log the exception message
                MessageBox.Show($"Request error: {e.Message}");
                throw e;
            }
            catch (Exception ex)
            {
                // Log any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                throw ex;
            }

        }

        private async Task<int> UpdateCustomerDataToAPI(DataTable dtUpdated)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);

                    // Serialize DataTable to JSON
                    // New Row
                    DataTable dtAdded = dtUpdated.GetChanges(DataRowState.Added);
                    string jsonAdded = JsonConvert.SerializeObject(dtAdded, Formatting.Indented);

                    // Modified Row
                    DataTable dtModified = dtUpdated.GetChanges(DataRowState.Modified);
                    string jsonModified = JsonConvert.SerializeObject(dtModified, Formatting.Indented);

                    // Deleted Row
                    DataTable dtDeleted = dtUpdated.GetChanges(DataRowState.Deleted);
                    foreach (DataRow row in dtDeleted.Rows)
                    {
                        // Access the original values before deletion
                        var deletedCustomerNumber = row["CustomerNumber", DataRowVersion.Original];
                        // You can use the deletedCustomerNumber to delete the row from the database
                    }
                    string jsonDeleted = JsonConvert.SerializeObject(dtDeleted, Formatting.Indented);

                    // Create a new instance of JsonDataTable and set its properties
                    JsonDataTable jsonDT = new JsonDataTable();
                    jsonDT.dtAdded = jsonAdded;
                    jsonDT.dtModified = jsonModified;
                    jsonDT.dtDeleted = jsonDeleted;
                    string jsonString = JsonConvert.SerializeObject(jsonDT);

                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    // Send POST request to the Web API
                    HttpResponseMessage response = await client.PostAsync("/api/SimpleGetAPI/UpdateCustomerData", content);

                    // Ensure the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseString = await response.Content.ReadAsStringAsync();

                        // Parse the response string to an integer
                        int rowsUpdated = int.Parse(responseString);

                        return rowsUpdated;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return 0;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Log the exception message
                MessageBox.Show($"Request error: {e.Message}");
                throw e;
            }
            catch (Exception ex)
            {
                // Log any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                throw ex;
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable dtUpdated = (DataTable)dgvCustomerDetails.DataSource;
            dtUpdated = dtUpdated.GetChanges();

            if (dtUpdated != null)
            {
                int rowsUpdated = await UpdateCustomerDataToAPI(dtUpdated);
                if (rowsUpdated > 0)
                {
                    dtUpdated.AcceptChanges();
                    dgvCustomerDetails.DataSource = dtUpdated.Copy();
                }
                MessageBox.Show($"{rowsUpdated} rows updated successfully.");
            }
        }

    }

}
