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

        private void ArrayUi_Load(object sender, EventArgs e)
        {
            int[] number = new int[10];
            number[1] = 10;
            number[2] = 20;
            number[9] = 30;

            string messsage = null;
            for (int index=0; index< number.Length; index++)
            {
                if(number[index]!=0)
                messsage = messsage + "Value of Index " + index + " is: " + number[index] + "\n";
            }
            displayRichTextBox.Text = messsage;
        }
    }
}
