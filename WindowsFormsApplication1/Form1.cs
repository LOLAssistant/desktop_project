using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            //int s_int = Convert.ToInt32(s);
            localhost.CheckUserService Service = new localhost.CheckUserService();

            localhost.IDSoapHeader header = new localhost.IDSoapHeader();
            header.UserName = "wangchao";
            header.PassWord = "wangchao";
            Service.IDSoapHeaderValue = header;
            //string helloWorld = Service.HelloWorld();
            //textBox2.Text = textBox2.Text + helloWorld;
            //bool tempA = Service.extractCode_record("123456789","wang");
            //bool tempB = Service.check_extractCode(s);
            if (true)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
           
        }

        
    }
}
