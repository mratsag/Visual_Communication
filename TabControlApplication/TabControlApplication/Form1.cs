using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = dlg.Color;
                textColor.Text = selectedColor.Name;
            }
        }

        private void BtnSent_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Value = 10;
            listBox1.Items.Add("Your name : "+textName.Text);
            listBox1.Items.Add("Your surname : " + textSurname.Text);
            listBox1.Items.Add("Your age : " + (DateTime.Now.Year-dateTimePicker.Value.Year));
            listBox1.Items.Add("Your country : " + comboBox1.Text);
            if(BtnGender1.Checked) 
                listBox1.Items.Add("Your gender: "+BtnGender1.Text);
            else
                listBox1.Items.Add("Your gender: "+BtnGender2.Text);
            if(checkBox1.Checked) 
                listBox1.Items.Add("Your position: "+checkBox1.Text);
            else 
                listBox1.Items.Add("Your position: "+checkBox2.Text);
            progressBar1.Value = 100;
            tabPage1.Refresh();
        }
    }
}
