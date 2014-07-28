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
            if (EditMode != EditMode.CreateNew)
            {
                textBoxAid.Text = Row.FirstAid;
                textBoxProfilactic1.Text = Row.Profilactic1;
                textBoxProfilactic2.Text = Row.Profilactic2;
                textBoxProfilactic3.Text = Row.Profilactic3;
                textBoxProfilactic4.Text = Row.Profilactic4;
                textBoxTherapy1.Text = Row.Therapy1;
                textBoxTherapy2.Text = Row.Therapy2;
                textBoxTherapy3.Text = Row.Therapy3;
                textBoxTherapy4.Text = Row.Therapy4;
                textBoxTherapy5.Text = Row.Therapy5;
                textBoxTherapy6.Text = Row.Therapy6;
                textBoxTherapy7.Text = Row.Therapy7;
                textBoxSurgery1.Text = Row.Surgery1;
                textBoxSurgery2.Text = Row.Surgery2;
                textBoxSurgery3.Text = Row.Surgery3;
                textBoxSurgery4.Text = Row.Surgery4;
                textBoxSurgery5.Text = Row.Surgery5;
                textBoxSurgery6.Text = Row.Surgery6;
                textBoxOrtoped.Text = Row.Ortoped;
                textBoxOrtodont.Text = Row.Ortodont;
                textBoxAdvanced.Text = Row.Advanced;
                textBoxConsult.Text = Row.Consult;
                textBoxDoctor.Text = Row.Doctor;
                dateOccured.Value = Row.Created;
            }
            if (EditMode == EditMode.CreateNew && AuthManager.CurrentUser != null)
            {
                textBoxDoctor.Text =
                    string.Format("{0} {1} {2}", AuthManager.CurrentUser.LastName, AuthManager.CurrentUser.FirstName,
                                  AuthManager.CurrentUser.MiddleName);
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
            if (EditMode == EditMode.CreateNew)
            {
                Row.Created = dateOccured.Value;
            }
            if (EditMode != EditMode.ReadOnly)
            {
                if (!ValidateChildren())
                {
                    DialogResult = DialogResult.None;
                    return;
                }
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
}
