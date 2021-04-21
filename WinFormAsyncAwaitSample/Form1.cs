using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAsyncAwaitSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> urlContentLengthTask =  GetUrlContentAsync();

            DoMyWork();

            int urlContentLength = await urlContentLengthTask;

            this.label1.Text += urlContentLength;
        }

        private void DoMyWork()
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetUrlContentAsync()
        {
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://www.google.com/");
            DoIndipendentWork();

            string contents = await getStringTask;
            return contents.Length;

        }

        void DoIndipendentWork()
        {
            this.label2.Text = "Making indipendent work.....";
        }




    }
}
