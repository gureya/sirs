using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace SimplePGP
{
    public partial class FormCreateNew : Form
    {
        public FormCreateNew()
        {
            InitializeComponent();
            Outlook.Accounts accounts = Globals.ThisAddIn.Application.Session.Accounts;
            List<String> emails = new List<String>();
            foreach ( Outlook.Account current in accounts)
            {
                System.Diagnostics.Debug.WriteLine(current.DisplayName);
                emails.Add(current.UserName+" <"+current.DisplayName+">");
            }
            comboBoxOutlookAccounts.DataSource = emails;
        }


    }
}
