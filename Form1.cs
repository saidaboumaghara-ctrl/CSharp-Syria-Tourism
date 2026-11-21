using SyrianTurizm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SyrianTurizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtuEnter_Click(object sender, EventArgs e)
        {    
            if (textBox1.Text == "" || textBox2.Text == "" )
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول","Syrian Tourism", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

               

            }
            else
            {
                
                Form2 form2 = new Form2(textBox1.Text,textBox2.Text);
                form2.Show();
                this.Hide();
            }
               
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}



