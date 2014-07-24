using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatientCard.Data;
using PatientCard.Logic;

namespace PatientCard.Forms
{
    public partial class CurePlanForm : Form
    {
        public CurePlanForm(ClinicDataSet.CurePlansRow row)
        {
            InitializeComponent();

	        textBoxAid.Text = row.FirstAid;
	        textBoxProfilactic1.Text = row.Profilactic1;
			textBoxProfilactic2.Text = row.Profilactic2;
			textBoxProfilactic3.Text = row.Profilactic3;
			textBoxProfilactic4.Text = row.Profilactic4;
	        textBoxTherapy1.Text = row.Therapy1;
			textBoxTherapy2.Text = row.Therapy2;
			textBoxTherapy3.Text = row.Therapy3;
			textBoxTherapy4.Text = row.Therapy4; 
			textBoxTherapy5.Text = row.Therapy5;
			textBoxTherapy6.Text = row.Therapy6;
			textBoxTherapy7.Text = row.Therapy7;
	        textBoxSurgery1.Text = row.Surgery1;
			textBoxSurgery2.Text = row.Surgery2;
			textBoxSurgery3.Text = row.Surgery3;
			textBoxSurgery4.Text = row.Surgery4;
			textBoxSurgery5.Text = row.Surgery5;
			textBoxSurgery6.Text = row.Surgery6;
	        textBoxOrtoped.Text = row.Ortoped;
	        textBoxOrtodont.Text = row.Ortodont;
	        textBoxAdvanced.Text = row.Advanced;
	        textBoxConsult.Text = row.Consult;
	        textBoxDoctor.Text = row.Doctor;
	        dateOccured.Value = row.Created;

	        Row = row;
        }

        public EditMode EditMode { get; set; }
		public ClinicDataSet.CurePlansRow Row { get; set; }

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

	    private void buttonOk_Click(object sender, EventArgs e)
	    {
		    Row.FirstAid = textBoxAid.Text;
		    Row.Profilactic1 = textBoxProfilactic1.Text;
		    Row.Profilactic2 = textBoxProfilactic2.Text;
		    Row.Profilactic3 = textBoxProfilactic3.Text;
		    Row.Profilactic4 = textBoxProfilactic4.Text;
		    Row.Therapy1 = textBoxTherapy1.Text;
		    Row.Therapy2 = textBoxTherapy2.Text;
		    Row.Therapy3 = textBoxTherapy3.Text;
		    Row.Therapy4 = textBoxTherapy4.Text;
		    Row.Therapy5 = textBoxTherapy5.Text;
		    Row.Therapy6 = textBoxTherapy6.Text;
		    Row.Therapy7 = textBoxTherapy7.Text;
		    Row.Surgery1 = textBoxSurgery1.Text;
		    Row.Surgery2 = textBoxSurgery2.Text;
		    Row.Surgery3 = textBoxSurgery3.Text;
		    Row.Surgery4 = textBoxSurgery4.Text;
		    Row.Surgery5 = textBoxSurgery5.Text;
		    Row.Surgery6 = textBoxSurgery6.Text;
		    Row.Ortoped = textBoxOrtoped.Text;
		    Row.Ortodont = textBoxOrtodont.Text;
		    Row.Advanced = textBoxAdvanced.Text;
		    Row.Consult = textBoxConsult.Text;
		    Row.Doctor = textBoxDoctor.Text;
	    }
    }
}
