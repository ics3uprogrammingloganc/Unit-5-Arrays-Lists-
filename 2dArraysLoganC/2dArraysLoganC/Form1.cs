/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - 2D Arrays
 * This program generates a 2d array and calculates the a
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

namespace _2dArraysLoganC
{
    public partial class frm2darr : Form
    {
        // Random number generator
        Random rand = new Random();

        public frm2darr()
        {
            InitializeComponent();
        }

        // finds the sum of the matrix
        private double arrayaverage(int[,] arr)
        {
            int sum = 0, num = 0;
            foreach (int i in arr)
            {
                sum += i;
                num++;
            }

            return (double)sum/(double)num;
        }

        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Clear text box
            tbxDisplay.Clear();

            // Get input
            int xSize = (int)nudX.Value;
            int ySize = (int)nudY.Value;

            // Create new array of specified size
            int[,] array = new int[xSize, ySize];

            // Iterate through each item
            for (int i = 0; i < ySize; i++)
            {
                for (int j = 0; j < xSize; j++)
                {
                    // Generate a random number
                    int r = rand.Next(0, 10);
                    array[j,i] = r; // set it in the array
                    tbxDisplay.Text += Convert.ToString(r) + " "; // add it to the display
                }

                tbxDisplay.Text += Environment.NewLine; // Newline
            }

            // Updating average
            lblavg.Text = "Average is: " + Convert.ToString(arrayaverage(array));
        }
    }
}
