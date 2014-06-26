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

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new HistoryForm();
            form.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new PatientCardForm();
            form.Show(this);
        }

    }
}
