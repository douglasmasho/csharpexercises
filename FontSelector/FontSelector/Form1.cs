using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fam = lbFontFamily.SelectedItem.ToString();
            string size = lbFontSize.SelectedItem.ToString();
            SayHello(fam, size);    
        }

        private void SayHello(string family, string size)
        {
            //create a list 
            List<string> fontList = new List<string>();
            //populate the list
            fontList.Add(family);
            fontList.Add(size);

            //convert the list to an array
            string[] fontArr = fontList.ToArray();

            //join the list as a string with a comma seperator
            string fontStr = String.Join(", ", fontArr);

                // Create the FontConverter.
             System.ComponentModel.TypeConverter converter = 
            System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));
            System.Diagnostics.Debug.WriteLine(fontStr);

            //create a font object using the font converter with the string
            Font selectedFont = (Font)converter.ConvertFromString(fontStr);

            //make helloLbl say hello
            helloLbl.Text = "Hello";

            //change the font of helloLbl
            helloLbl.Font = selectedFont;

        }

        private void helloLbl_Click(object sender, EventArgs e)
        {
         
        }
    }
}


public static class MyGlobals
{
    public static string fontFamily = "";
    public static string fontSize = "";
}
