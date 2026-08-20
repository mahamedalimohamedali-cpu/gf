using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gusse_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        short Counter = 0;
        int Rand = 0;
        int GetRandomNumber() 
        {
            Random r = new Random();

            int Number =  r.Next(1, 100);

            return Number;
        }

            
        bool ChecktheNumber(int  ComputerNumber) 
        {
            int UserNumber = Convert.ToInt32(textBox1.Text);
            if (UserNumber == ComputerNumber) 
                    return true;

            return false;
        }

        string Rang(int ComputerNumber)
        {

            int UserNumber = Convert.ToInt32(textBox1.Text);

            if (ComputerNumber > UserNumber) 
            {
                return "Up";
            }

            return "Low";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!ChecktheNumber(Rand))
            {
                textBox3.Text = Rang(Rand);
                Counter++;
                textBox2.Text =" "+Counter;
            }
            else 
            {

                textBox3.Text = "You Go It";
            }

            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ComputerNumber = GetRandomNumber();

            Rand = ComputerNumber;

            button1.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = true;
         

        }
    }
}
