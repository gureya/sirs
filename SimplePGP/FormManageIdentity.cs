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
    public partial class FormManageIdentity : Form
    {
        public FormManageIdentity(String who)
        {
            InitializeComponent();
            this.Text = this.Text.Replace("%S%", who);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            importFileDialog.ShowDialog();
            // TODO import file you can use importFileDialog.Open()
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            // TODO export to file default extension is pgp use .Open()
        }
    }
}
