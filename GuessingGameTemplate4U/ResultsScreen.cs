using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();
        }

        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            //number of guesses
            resultsLabel.Text = "\n        Guesses:     " + (Form1.guessesList.Count - 1);

            //guesses in order
            resultsLabel.Text += "\n\n        Original Order:\n        ";
            for (int i = 0; i < Form1.guessesList.Count; i++)
            {
                resultsLabel.Text += " " + Form1.guessesList[i];
            }

            //guesses sorted
            resultsLabel.Text += "\n\n        Sorted Order:\n        ";

            Form1.guessesList.Sort();
            for (int i = 0; i < Form1.guessesList.Count; i++)
            {
                resultsLabel.Text += " " + Form1.guessesList[i];
            }
        }
    }
}
