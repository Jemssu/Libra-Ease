using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_PROJECT
{
    public partial class BorrowerInputForm : Form
    {
        public string BorrowerID_INPUT { get; set; }
        public BorrowerInputForm()
        {
            InitializeComponent();
        }

        private void BorrowerInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            // Check if the input is a valid 8-digit integer
            if (int.TryParse(BorrowerInputBox.Text, out int BorrowerInput) && BorrowerInputBox.Text.Length == 8)
            {
                // Input is a valid 8-digit integer, set the AuthCodeBoxValue
                BorrowerID_INPUT = BorrowerInput.ToString();

                // Close the form with OK result
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // Display an error message for invalid input
                MessageBox.Show("INVALID ID. MUST BE 8 DIGITS");
            }
        }

    }
}
