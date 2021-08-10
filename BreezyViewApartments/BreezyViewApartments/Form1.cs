using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreezyViewApartments
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            getTotal();
        }

        public void getTotal()
        {
            //get the selected from the first listBox
            double bedroomNum = Convert.ToDouble(lbBedrooms.SelectedItem.ToString());

            switch (bedroomNum)
            {
                case 1:
                    myGlobals.totalCost += 450;
                    break;
                case 2:
                    myGlobals.totalCost += 550;
                    break;
                case 3:
                    myGlobals.totalCost += 700;
                    break;
                default:
                    myGlobals.totalCost += 0;
                    break;
            }

            double bathroomNum = Convert.ToDouble(lbBathrooms.SelectedItem.ToString());
            if(bathroomNum > 1)
            {
                myGlobals.totalCost += 75;
            }

            string selectedBtn = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            System.Diagnostics.Debug.WriteLine(selectedBtn);
            if(selectedBtn == "rbLake")
            {
                myGlobals.totalCost += 50;
            }
            lblTotal.Text = Convert.ToString(myGlobals.totalCost);
            //reset total cost
            myGlobals.totalCost = 0;
        }
    }
}


public static class myGlobals
{
    public static double totalCost = 0;
}
