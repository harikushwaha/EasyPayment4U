using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyPayment4u.WindowsApp
{
    public partial class Form1 : Form
    {
       
        SimpleServiceClient.SimpleServiceClient service;
        public Form1()
        {
            InitializeComponent();
            service = new SimpleServiceClient.SimpleServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleServiceClient.SimpleServiceClient service = new SimpleServiceClient.SimpleServiceClient();
            string str = service.GetData(10);
            Console.WriteLine(str);

            int number = service.IncrementNumber();
            MessageBox.Show(number.ToString());

        }
    }
}
