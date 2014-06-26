using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatientCard.Logic;

namespace PatientCard.Forms
{
    public partial class DiagnosticForm : Form
    {
        public DiagnosticForm()
        {
            InitializeComponent();
        }

        public EditMode EditMode { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            if (EditMode == EditMode.ReadOnly)
            {
                Utility.LockTextBoxes(this);
            }
            base.OnLoad(e);
        }

        private void multiText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var editText = new EditTextForm(((TextBox)sender).Text);
            if (editText.ShowDialog() == DialogResult.OK)
            {
                ((TextBox)sender).Text = editText.ResultText;
            }
        }
    }
}
