using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingApp
{
    public partial class Greetings : Form
    {
        public Greetings()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lblGreeting.Text = "";
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string name = txtName.Text.Trim();
                int age = (int)nudAge.Value;
                lblGreeting.Text = $"Hello, {name}! You are {age} years old.";
            }
        }

        private bool ValidateInput()
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (nudAge.Value == 0)
            {
                MessageBox.Show("Please enter your age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudAge.Focus();
                return false;
            }

            return true;
        }
    }
}
