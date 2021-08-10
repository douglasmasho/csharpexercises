using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dayandnight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine(MyGlobals.timeOfDay);
            ChangeColor(MyGlobals.timeOfDay);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ChangeColor(string time)
        {
            lblTime.ForeColor = Color.FromArgb(255, 255, 255);
            lblTime.Text = time;
            switch (time)
            {
                case "day":
                    this.BackColor = Color.FromArgb(255, 165, 0);
                    break;
                case "night":
                    this.BackColor = Color.FromArgb(0, 0, 128);
                    break;
                default:
                    this.BackColor = Color.FromArgb(255, 255, 255);
                    break;
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            ChangeColor("day");
        }

        private void btnNight_Click(object sender, EventArgs e)
        {
            ChangeColor("night");
        }
    }
}


public static class MyGlobals
{
    public static string timeOfDay = "day";
}
