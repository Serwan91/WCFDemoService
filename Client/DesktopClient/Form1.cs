using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DesktopClient.WCFServiceDemo;

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WCFServiceDemo.Service1Client service = new WCFServiceDemo.Service1Client(comboBox1.SelectedItem.ToString());
            MessageBox.Show(service.GetMessage(textBox1.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("WSHttpBindingDemo");
            comboBox1.Items.Add("BasicHttpBindingDemo");
            comboBox1.Items.Add("NetTcpBindingDemo");
        }
    }
}
