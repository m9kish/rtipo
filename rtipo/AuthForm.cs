using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rtipo
{
    public partial class AuthForm : Form
    {
        private StartMenuForm startMenuForm;
        public AuthForm()
        {
            InitializeComponent();
            startMenuForm = new StartMenuForm(this) { Visible = false };
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            startMenuForm.Visible = true;
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
