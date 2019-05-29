/*
 * Created by: Logan Cantin
 * Created on: 28 May 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program checks strings separated by tabs for equality
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

namespace ReadWriteLoganC
{
    public partial class ReadWriteForm : Form
    {
        public ReadWriteForm()
        {
            InitializeComponent();
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            // Reads all data from input.txt into an array of strings
            string[] data = System.IO.File.ReadAllLines(@"input.txt");

            // String to hold the output data
            string output = "";

            // Looping through each comparison
            foreach (string s in data)
            {
                // Split the current line by the tab character
                string[] currentLine = s.Split('\t');

                // If the first half is equal to the second half
                if (currentLine[0].ToLower() == currentLine[1].ToLower())
                {
                    // Output true
                    output += "True\r\n";
                }
                else // Otherwise
                {
                    // Output false
                    output += "False\r\n";
                }
            }

            // Write the output to output.txt
            System.IO.File.WriteAllText("output.txt", output);
           
        }
    }
}
