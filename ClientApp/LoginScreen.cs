using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;


namespace ClientApp
{
    public partial class LoginScreen : Form
    {
        localhost.WebService1 webservice = new localhost.WebService1();
        HttpClient client = new HttpClient();
        public LoginScreen()
        {
            InitializeComponent();
        }




        private void LogInButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text.ToString();
            string surname = SurnameTextBox.Text.ToString();
   
            client.BaseAddress = new Uri("http://localhost:60836/WebService1.asmx/");
            HttpResponseMessage result = client.GetAsync("Find?name=" + name +"&surname="+surname+"").Result;
            //calls an asyhnchronous call to server


            string information = result.Content.ReadAsStringAsync().Result;
           // MessageBox.Show(information);

            if (information.Contains("true")) MessageBox.Show("Welcome to Algotech, you are a VIP user!");
            else MessageBox.Show("Welcome to Algotech, you are a regular user.");



        }
    }
}
