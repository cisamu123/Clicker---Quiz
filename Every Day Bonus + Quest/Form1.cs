using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Every_Day_Bonus___Quest
{
    
    public partial class Form1 : Form
    {
        int money = 0;
        int attemps = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money++;
            label1.Text = "Your Money: " + money;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Your Attemps: " + attemps;
            if (attemps == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                label8.Text = "There are no more attempts!";
            }
            else
            {
                label8.Text = "YOU WIN!";
                bool True = true;
                byte limit = 0;
                while (True) {
                    money++;
                    label1.Text = "Your Money: " + money;
                    limit++;
                    if (limit == 50)
                    {
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        label8.Text = "STOP YOU HAVE ALREADY GIVED THE RIGHT ANSWER!";
                        label1.Text = "Your Money: " + money;
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            attemps--;
            label6.Text = "Your Attemps: " + attemps;
            label8.Text = "Wrong answer!";
            if (attemps == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                label8.Text = "There are no more attempts!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            attemps--;
            label6.Text = "Your Attemps: " + attemps;
            label8.Text = "Wrong answer!";
            if (attemps == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                label8.Text = "There are no more attempts!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            attemps--;
            label6.Text = "Your Attemps: " + attemps;
            label8.Text = "Wrong answer!";
            if (attemps == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                label8.Text = "There are no more attempts!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ALL RIGHTS RESERVED (2022) BY CISAMU
            //IF YOU WANT TO MODIFY THIS PROJECT. JUST MARK THE AUTHOR UNDER YOUR MODIFICATION!
        }
    }
}
