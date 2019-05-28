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

namespace FinsMaxValueLoganC
{
    public partial class frmMinValue : Form
    {
        //Initializing constants and number generator
        const int MAX_ARRAY_SIZE = 10;
        const int MIN_RANDOM = 1;
        const int MAX_RANDOM = 500;
        Random generator = new Random();

        public frmMinValue()
        {
            InitializeComponent();
        }

        private int FindMinValue(int[] arr)
        {
            //Initializing minValue at the largest possible int, so all numbers generated will be lower than it.
            int minValue =int.MaxValue;

            foreach (int n in arr)
            {
                // If the number is larger than the current largest number, update the smallest number variable
                if (n < minValue)
                {
                    minValue = n;
                }
            }
            

            return minValue;
        }


        private void btnRandom_Click(object sender, EventArgs e)
        {
            //Declaring variables
            int[] numbers = new int[MAX_ARRAY_SIZE];
            int randomNumber;
            int minNum;

            //Clear list box
            lstNumbers.Items.Clear();

            //Loop through the array
            for (int i = 0; i < MAX_ARRAY_SIZE; i++)
            {
                //Generate a random number, assign it to the current index in the array and add it to the list box
                randomNumber = generator.Next(MIN_RANDOM, MAX_RANDOM);
                numbers[i] = randomNumber;
                lstNumbers.Items.Add(randomNumber);  
            }

            minNum = FindMinValue(numbers);

            //Notifying the user of the largest number
            lblResponse.Text = "The smallest number is: " + Convert.ToString(minNum);
        
        }
    }
}
