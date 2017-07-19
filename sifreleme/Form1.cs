using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Skymoon" && textBox2.Text == "12345")
            {
                Form2 asama2 = new Form2();
                asama2.Show();
                this.Hide();
            }

            else if (textBox1.Text == "Koray" && textBox2.Text == "7561")
            {
                Form2 asama2 = new Form2();
                asama2.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Huso" && textBox2.Text == "huso_571")
            {
                Form2 asama2 = new Form2();
                asama2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("You can NOT enter!");
                textBox1.Clear();
                textBox2.Clear();
           
             
                     
        }
    }
}
