/*
 * Created by: Logan Cantin 
 * Created on: May 29th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - Lists
 * This program finds the average of a list of numbers
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

namespace Lists
{
    public partial class frmlists : Form
    {
        // List of marks
        List<int> marks = new List<int>();

        public frmlists()
        {
            InitializeComponent();
        }

        private double FindAverage(ref List<int> inputMarks)
        {
            // Sum and count variables
            int sum = 0, count = 0;

            // Adding each number to the sum and increasing the count
            foreach (int i in inputMarks)
            {
                sum += i;
                count++;
            }

            // Return the average
            return (double)sum / (double)count;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Getting the mark from the user
            int currentMark = (int)nudMark.Value;

            // Making sure that the mark is between 0-100
            if (currentMark < 101 && currentMark > -1)
            {
                // Add the mark to this listbox
                lstMarks.Items.Add(currentMark);

                // Find the average
                double average = FindAverage(ref marks);
                

                // Update the sum
                lblAverage.Text = "Average: " + Convert.ToString(average);
            }
            else
            {
                // Alert the user that their number is not valid
                MessageBox.Show("Please enter a number from 0 to 100");
            }
        }
    }
}
