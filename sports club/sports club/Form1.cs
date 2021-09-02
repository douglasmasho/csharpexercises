using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sports_club
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                lblAskName.ForeColor = System.Drawing.Color.Red;
            }else if(numAge.Value == 0)
            {
                lblAskAge.ForeColor = System.Drawing.Color.Red;

            }else if(lbGender.SelectedItems.Count == 0)
            {
                lblAskGender.ForeColor = System.Drawing.Color.Red;
            }else if(listSport.SelectedItems.Count == 0)
            {
                lblAskSport.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblName.Text = $"Your name is {txtName.Text}";
                lblAge.Text = $"Your age is {Convert.ToString(numAge.Value)}";
                lblGender.Text = $"Your Gender is {lbGender.SelectedItem.ToString()}";
                List<string> arr = new List<string>();

                for(int x=0; x<listSport.Items.Count; ++x)
                {
                    System.Diagnostics.Debug.WriteLine(x);
                    //if the item is selected, add it to the list
                    System.Diagnostics.Debug.WriteLine(listSport.GetSelected(x));
                    if (listSport.GetSelected(x))
                    {
                        arr.Add(listSport.Items[x].ToString());
                    }
                }

                //convert the list to an array and save it
                string[] newArr = arr.ToArray();

                string word = String.Join("\n", newArr);
                lblSports.Text = word;

            }
        }
    }
}
