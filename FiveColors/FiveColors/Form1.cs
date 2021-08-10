using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeColor("cyan");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeColor("navy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeColor("lime");
        }

        private void ChangeColor(string color)
        {
            lblColor.Text = color;
            switch (color)
            {
                case "cyan":
                    this.BackColor = Color.FromArgb(0, 255, 255);
                    lblColor.ForeColor = Color.FromArgb(0, 0, 0);
                    break;
                case "rose":
                    this.BackColor = Color.FromArgb(255, 102, 204);
                    break;
                case "lime":
                    this.BackColor = Color.FromArgb(120, 190, 33);
                    break;
                case "gold":
                    this.BackColor = Color.FromArgb(225, 169, 95);
                    lblColor.ForeColor = Color.FromArgb(255, 255, 255);
                    break;
                case "navy":
                    this.BackColor = Color.FromArgb(0, 35, 149);
                    lblColor.ForeColor = Color.FromArgb(255, 255, 255);
                    break;
                case "default":
                    this.BackColor = Color.FromArgb(255, 255, 255);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeColor("rose");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeColor("gold");
        }

        private void radioLime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLime.Checked)
            {
                ChangeColor("lime");
            }
        }

        private void radioRose_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRose.Checked)
            {
                ChangeColor("rose");
            }
        }

        private void radioCyan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCyan.Checked)
            {
                ChangeColor("cyan");
            }
        }

        private void radioNavy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNavy.Checked)
            {
                ChangeColor("navy");
            }
        }

        private void radioGold_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGold.Checked)
            {
                ChangeColor("gold");
            }
        }
    }
}

public static class MyGlobals
{
    public static string color = "";
}
