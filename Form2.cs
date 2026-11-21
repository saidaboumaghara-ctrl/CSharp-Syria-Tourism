using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyrianTurizm
{
    public partial class Form2 : Form
    {
        int count = 0;

        public Form2(string name,string Id)
        {
            InitializeComponent();
            textBox5.Text = name;
            textBox6.Text = Id;
            button1.Text = "Enter";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            if (radioButton1.Checked)
            {
                textBox1.Text = radioButton1.Text;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            if(radioButton2.Checked)
            {
                textBox1.Text = radioButton2.Text;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            UpdateTotalPrice();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

            textBox4.Text = comboBox1.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         float GoTomenuPrice()
        {
            float TotalPrice = 0;
            if(checkBox1.Checked)
            {
                TotalPrice+=Convert.ToSingle(checkBox1.Tag);
            }
            if(checkBox2.Checked)
            {
                TotalPrice += Convert.ToSingle(checkBox2.Tag);
            }
            if(checkBox3.Checked)
            {
                TotalPrice += Convert.ToSingle(checkBox3.Tag);
            }

            return TotalPrice;

        }
        float GoToBusType()
        {
            if (radioButton1.Checked)
            {
                return Convert.ToSingle(radioButton1.Tag);
            }
            else
            {
                return Convert.ToSingle(radioButton2.Tag);
            }



        }
        float GoTochairnum()
        {
            int number;

            if (!int.TryParse(comboBox1.Text, out number))
            {
                return 0;
            }

            if (number >= 10 && number <= 30)
            {
                return Convert.ToSingle(comboBox1.Tag);
            }

            return 0;
        }

         float AddPrice()
        {
            
            return GoTomenuPrice()+ GoTochairnum()+ GoToBusType() + 1200;
        }
        void UpdateTotalPrice()
        {
            label1.Text = AddPrice().ToString();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        

       
       
        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                textBox2.Text = comboBox3.Text;
      
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
                textBox3.Text = comboBox2.Text;
           
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure ?","Syrian Tourism", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);











        }
    }
}
