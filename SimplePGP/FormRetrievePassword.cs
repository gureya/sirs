using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePGP
{
    public partial class FormRetrievePassword : Form
    {
        public String password;
        public FormRetrievePassword(String title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Passphrase", "Passphrase is Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            password = textBoxPassword.Text;
            this.Close();
        }
    }
}
