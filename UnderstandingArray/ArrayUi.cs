using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandingArray
{
    public partial class ArrayUi : Form
    {
        
        public ArrayUi()
        {
            InitializeComponent();
        }
        int size = 4;
        int index = 0;
        int[] number; 
        private void ArrayUi_Load(object sender, EventArgs e)
        {
            //int[] number = new int[10];
            //number[1] = 10;
            //number[2] = 20;
            //number[9] = 30;

            //string messsage = null;
            //for (int index=0; index< number.Length; index++)
            //{
            //    if(number[index]!=0)
            //    messsage = messsage + "Value of Index " + index + " is: " + number[index] + "\n";
            //}
            //displayRichTextBox.Text = messsage;
            number = new int[size];
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Clear();
           
                if (index != size)
                {
                    number[index] = Convert.ToInt32(inputTextBox.Text);
                    displayRichTextBox.Text = "Value " + inputTextBox.Text + " is added to storage";
                    index++;
                }
                else displayRichTextBox.Text = "Storage is full";
                    
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "Elements are: ";
            for(int index=0; index<size; index++)
            {
                if (number[index] != null)
                {
                    message = message + number[index]+ " ";
                }
                displayRichTextBox.Text = message;
            }
        }
    }
}
