using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.LastName = textBox1.Text;
            user.FirstName = textBox2.Text;
            user.County = textBox3.Text;
            user.City = textBox4.Text;
            user.Phone = textBox5.Text;
            user.birthDay = Convert.ToDateTime(dateTimePicker1.Text);

            if (womanButton.Checked)
                user.Sex = womanButton.Text;
            else
                if (manButton.Checked)
                user.Sex = manButton.Text;
            else
                user.Sex = "No Identefication";

            Repository.WriteToXML(user);
            ClearForm();
        }

        public void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
            womanButton.Checked = false;
            manButton.Checked = false;
        }
    }
}
