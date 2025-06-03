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

namespace Lab4
{
    public partial class frmLab4 : Form
    {
        public frmLab4()
        {
            InitializeComponent();
        }

        private void frmLab4_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                string result = await GetApiResponse();
                MessageBox.Show(result);
            });
        }

        private async Task<string> GetApiResponse()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]); // 讀取配置
                    HttpResponseMessage response = await client.GetAsync("/api/SimpleGetAPI/SimpleGetMethod");

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                        MessageBox.Show(error);
                        return error;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}");
                return $"Request error: {e.Message}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return $"An error occurred: {ex.Message}";
            }
        }

        private async void btnHTTPGet_Click(object sender, EventArgs e)
        {
            string response = await GetApiResponse();
            lblResult.Text = response;
        }

    }
}