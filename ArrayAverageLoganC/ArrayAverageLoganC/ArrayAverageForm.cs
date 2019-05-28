/*
 * Created by: Logan Cantin 
 * Created on: April 23rd, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program generates 10 random numbers and calculates their average
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

namespace ArrayAverageLoganC
{
    public partial class ArrayAverageForm : Form
    {
        // Array of numbers and random number generator
        int[] numbers;
        Random rand;

        public ArrayAverageForm()
        {
            InitializeComponent();

            //initialize numbers array and random number generator
            numbers = new int[10];
            rand = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare random number and clear list box
            int randomNumber;
            lstNumbers.Items.Clear();

            // Loop through all the indexes of array numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                //Generate the random number, assign it to the appropriate position in the array, and add it to the list box.
                randomNumber = rand.Next(1, 11);
                numbers[i] = randomNumber;
                lstNumbers.Items.Add(randomNumber);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (lstNumbers.Items.Count == 10)
            {
                //Initialize the sum variable
                int sum = 0;

                // Add each number to the sum
                foreach (int n in numbers)
                {
                    sum += n;
                }

                // Calculate average
                double average = (double)sum / (double)numbers.Length;

                // Update label
                lblAnswer.Text = "Average: " + Convert.ToString(average);
            }
            else
            {
                lblAnswer.Text = "Please press start to generate some random numbers.";
            }
            
        }
    }
}
