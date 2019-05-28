using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsLoganC
{
    public partial class ListsForm : Form
    {
        List<int> marks = new List<int>();

        public ListsForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt16(tbxInput.Text);
                if (input < 0 || input > 100) {
                    throw new Exception();
                }

                marks.Add(input);
                lstMarks.Items.Add(input);

                tbxInput.Clear();

                float average = 0;

                foreach (int n in marks)
                {
                    average += n;
                }

                average /= marks.Count();

                lblAverage.Text = "Average: " + Convert.ToString(Math.Round(average, 1));
            }
            catch
            {
                MessageBox.Show("Please enter a number from 0 - 100.");
            }
            
        }
    }
}
