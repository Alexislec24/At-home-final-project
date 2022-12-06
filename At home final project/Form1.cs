using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_home_final_project
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkBox5.Visible = true;
                label3.Visible = true;
            }
            else
            {
                checkBox5.Visible = false;
                checkBox5.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                checkBox6.Visible = true;
                label3.Visible = true;
            }
            else
            {
                checkBox6.Visible = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double m = double.Parse(textBox1.Text);
            if (count > 2)
            {
                MessageBox.Show("You can't pay because you have more than 2 toppings");
            }
            else if (count <= 2)
            {
                textBox2.Text = null;
                if (checkBox5.Checked == true || checkBox6.Checked == true)
                {

                    if (m > ((count * 0.75) + 2 + 0.5))
                    {
                        button1.Enabled = true;
                        textBox2.AppendText("Cash received: " + m + "$");
                        textBox2.AppendText("\r\n");
                        textBox2.AppendText("Total price: " + ((count * 0.75) + 2 + 0.5 + "$"));
                        textBox2.AppendText("\r\n");
                        textBox2.AppendText("Cash back: " + (m - ((count * 0.75) + 2 + 0.5)) + "$");
                    }
                    else if (m < ((count * 0.75) + 2 + 0.5))
                    {
                        MessageBox.Show("You don't have enough cash to pay.");
                    }


                }
                else
                {
                    if (m > ((count * 0.75) + 2))
                    {
                        button1.Enabled = true;
                        textBox2.AppendText("Cash received: " + m + "$");
                        textBox2.AppendText("\r\n");
                        textBox2.AppendText("Total price: " + ((count * 0.75) + 2 + "$"));
                        textBox2.AppendText("\r\n");
                        textBox2.AppendText("Cash back: " + (m - ((count * 0.75) + 2)) + "$");
                    }
                    else if (m < ((count * 0.75) + 2))
                    {
                        MessageBox.Show("You don't have enough cash to pay.");
                    }
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
