using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace excellmachina
{
    public partial class InputDialogBox : Form
    {
        public InputDialogBox()
        {
            InitializeComponent();
        }

        private void InputDialogBox_Load(object sender, EventArgs e)
        {

        }
        public string InputText 
        { 
            get { return textBox1.Text; } 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Check if the input is valid
            if (!isValidInput(textBox1.Text))
            {
                // Set the focus to the textbox and change its background color
                textBox1.Focus();
                textBox1.BackColor = Color.Red;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool isValidInput(string input)
        {
            // Check if the input is valid
            // Return true if it is, false otherwise
            return input.Length > 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Reset the background color of the textbox on text change
            textBox1.BackColor = SystemColors.Window;
        }
    }
}
