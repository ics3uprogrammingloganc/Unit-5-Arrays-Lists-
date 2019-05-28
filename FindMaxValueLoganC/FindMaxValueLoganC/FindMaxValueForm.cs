/*
 * Created by: Logan Cantin
 * Created on: April 24, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - Find Min Value
 * This program finds the max value in a list of random numbers
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMaxValueLoganC
{
    public partial class frmMaxValue : Form
    {
        //Initializing constants and number generator
        const int MAX_ARRAY_SIZE = 10;
        const int MIN_RANDOM = 1;
        const int MAX_RANDOM = 500;
        Random generator = new Random();

        public frmMaxValue()
        {
            InitializeComponent();
        }

        private int FindMaxValue(int[] arr)
        {
            // Variable to hold the largest number
            int maxNum = -1;

            //Cycling through each number in the array and replacing maxnum if n is larger
            foreach (int n in arr)
            {
                if (n > maxNum)
                {
                    maxNum = n;
                }
            }

            //return maxNum
            return maxNum;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declaring variables
            int[] numbers = new int[MAX_ARRAY_SIZE];
            int randomNumber;
            int maxNum;

            //Clear list box
            lstArray.Items.Clear();

            //Loop through the array
            for (int i = 0; i < MAX_ARRAY_SIZE; i++)
            {
                //Generate a random number, assign it to the current index in the array and add it to the list box
                randomNumber = generator.Next(MIN_RANDOM, MAX_RANDOM);
                numbers[i] = randomNumber;
                lstArray.Items.Add(randomNumber);
            }

            //Determine max number
            maxNum = FindMaxValue(numbers);

            //Notifying the user of the largest number
            lblMax.Text = "The largest number is: " + Convert.ToString(maxNum);
        }
    }
}




       
