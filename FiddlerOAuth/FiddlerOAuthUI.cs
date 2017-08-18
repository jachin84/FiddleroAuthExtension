using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;

namespace FiddlerOAuth
{
    public partial class FiddlerOAuthUI : UserControl
    {
        public event EventHandler ExtensionEnabled;
        public event EventHandler ExtensionDisabled;

        public FiddlerOAuthUI(bool initialState)
        {
            InitializeComponent();

            enableFilter.Checked = initialState;
            enableFilter.CheckedChanged += enableFilter_CheckedChanged;
            txtThumbprint.Enabled = false;
        }

        private void enableFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (enableFilter.Checked)
            {
                // Bubble this up to the parent
                ExtensionEnabled?.Invoke(this, e);
            }
            else
            {
                ExtensionDisabled?.Invoke(this,e);
            }
        }

        private void cmbSignMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThumbprint.Enabled = cmbSignMethod.Text == "RSA-SHA1";
        }
    }
}
