using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void addNumberButton_Click(object sender, EventArgs e)
        {
           int number;

            number = int.Parse(numberTextBox.Text);
         
          
            for (int i = 0; i <= number; i++)
            {
                numberListBox.Items.Add(i);
            }
            numberTextBox.Text = "";
        }

        private void numberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Number Index is: " + (numberListBox.SelectedIndex+1));
        }



       

      
    }
}
