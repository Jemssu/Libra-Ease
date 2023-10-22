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
    public partial class AuthorizationInputForm : Form
    {
        public string AuthCodeBoxValue { get; set; }
        public AuthorizationInputForm()
        {
            InitializeComponent();
        }

        private void AuthCodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {
              
                AuthCodeBoxValue = AuthCodeBox.Text;

                // Close the form with OK result
                DialogResult = DialogResult.OK;
                Close();

        }

        private void AuthorizationInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
