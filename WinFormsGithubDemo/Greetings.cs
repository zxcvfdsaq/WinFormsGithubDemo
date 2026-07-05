using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGithubDemo
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

        }
    }
}
