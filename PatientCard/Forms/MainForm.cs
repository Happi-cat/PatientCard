using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientCard.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void patientCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PatientCardForm();
            form.Show(this);
        }

        private void diagnosticFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DiagnosticForm();
            form.Show(this);
        }

        private void historyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HistoryForm();
            form.Show(this);
        }

        private void curePlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CurePlanForm();
            form.Show(this);
        }

        private void researchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ResearchForm();
            form.Show(this);
        }

    }
}
