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
        int size = 0;
        int index = 0;
        int[] number;
        int[] copiedNumber;
        string message;
        int count;
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

            displayRichTextBox.Text = "Input the number of elements to store in the array and confirm";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Clear();


            if (index != size)
            {
                if (String.IsNullOrEmpty(inputTextBox.Text))
                {
                    displayRichTextBox.Text = "Please, input value";
                }
                else
                {
                    number[index] = Convert.ToInt32(inputTextBox.Text);

                    message = message + "Value entered at " + index + " index is: " + inputTextBox.Text + "\n";
                    displayRichTextBox.Text = message;
                    index++;
                    inputTextBox.Clear();
                }


            }
            else displayRichTextBox.Text = "Storage is full";


        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "Elements are: ";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index] + " ";
                }
                displayRichTextBox.Text = message;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            
            size = 0;
            
            if (String.IsNullOrEmpty(arraySizeTextBox.Text))
            {
                MessageBox.Show("Please give array size");
            }
            else
            {
                size = Convert.ToInt32(arraySizeTextBox.Text);
                displayRichTextBox.Text = "Confirmed, Now you can store " + size + " element ";
                number = new int[size];
                arraySizeTextBox.Clear();
            }

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "Elements are: ";
            string reverseMessage = "Reverse elements are: ";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index] + ", ";
                }

            }
            for (int index = size - 1; index > -1; index--)
            {
                if (number[index] != null)
                {
                    reverseMessage = reverseMessage + number[index] + ", ";
                }

            }
            displayRichTextBox.Text = message + "\n" + reverseMessage;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            string message = "Elements are: ";
            string sumMessage = "Sum of all elements stored in the array is: ";
            int sum = 0;
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index] + ", ";
                }

            }
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                {
                    sum = sum + number[index];

                }

            }
            displayRichTextBox.Text = message + "\n" + sumMessage + sum;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string firstArryMessage = "The elements stored in the first array are: ";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                {
                    firstArryMessage = firstArryMessage + number[index] + " , ";
                }

            }

            string secondArrayMessage = "The elements copied into the second array are: ";
            copiedNumber = new int[number.Length];
            for (int index = 0; index < number.Length; index++)
            {
                copiedNumber[index] = number[index];
                secondArrayMessage = secondArrayMessage + copiedNumber[index] + " , ";

            }
            displayRichTextBox.Text = firstArryMessage + "\n" + secondArrayMessage;
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {


            string allElements = AllElements();
            int totalDuplicateCount = 0;
            int[] elementChecked = new int[size];

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != elementChecked[i])
                {
                    for (int j = i + 1; j < number.Length; j++)
                    {
                        if (number[i] == number[j])
                        {
                            totalDuplicateCount++;
                            for (int k = 0; k < size; k++)
                            {
                                elementChecked[k] = number[i];
                            }
                        }
                    }
                }

            }

            displayRichTextBox.Text = allElements + "\nTotal number of duplicate elements found in the array is: " + totalDuplicateCount;


        }
        private string AllElements()
        {
            string message = "Elements are: ";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index] + ", ";
                }

            }
            return message;
        }

        private void UniqueButton_Click(object sender, EventArgs e)
        {

            int[] copyNumber = number;
            int[] uniqueNumber = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                count = 0;
                for (int j = 0; j < copyNumber.Length; j++)
                {
                    if (number[i] == copyNumber[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    uniqueNumber[i] = number[i];

                }
            }
            string uniqueNumberInfo = "Unique Elements are: ";
            for (int k = 0; k < uniqueNumber.Length; k++)
            {
                if (uniqueNumber[k] != 0)
                {
                    uniqueNumberInfo = uniqueNumberInfo + " " + uniqueNumber[k];
                }

            }
            displayRichTextBox.Text = AllElements() + "\n" + uniqueNumberInfo;


        }

        private void MaxMinButton_Click(object sender, EventArgs e)
        {
            int max= number[0];
            int min = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                
                if (number[i] > max)
                {
                    max = number[i];
                }
                if(number[i]< min)
                {
                    min = number[i];
                }
                
            }
            string messaage= "Max: " + max + "\nMin: " + min;
            displayRichTextBox.Text = messaage;
        }

        private void OddEvenButton_Click(object sender, EventArgs e)
        {
            string oddNumber = "Odd Number: ";
            string evenNumber = "Even Number: ";
            for (int i = 0; i < number.Length; i++)
            {

                if (number[i]%2==0)
                {
                    evenNumber = evenNumber +" "+ number[i];
                }
                else oddNumber = oddNumber +" "+ number[i];
            }
            displayRichTextBox.Text =AllElements()+"\n"+ oddNumber + "\n" + evenNumber;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            int temp;
            for(int i=0; i < number.Length; i++)
            {
                for(int j=i+1; j<number.Length; j++)
                {
                    if (number[i] < number[j])
                    {

                    }else if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
            displayRichTextBox.Text = AllElements();
        }

        private void DescendingSortButton_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {

                    }
                    else if (number[i] < number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
            displayRichTextBox.Text = AllElements();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
           
            if (number[index] == size)
            {
                displayRichTextBox.Text = "Storage is full";
            }else
            {
                for(int i=0; i<number.Length; i++)
                {

                }
                number[index] = Convert.ToInt32( inputTextBox.Text);
            }
            index++;
        }
    }
}