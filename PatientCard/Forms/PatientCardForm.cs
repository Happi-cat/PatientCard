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
    public partial class PatientCardForm : Form
    {
        public PatientCardForm(ClinicDataSet.PatientCardsRow row)
        {
            InitializeComponent();

	        textBoxFirstName.Validating += Utility.TextBoxEmptyValidating;
			textBoxLastName.Validating += Utility.TextBoxEmptyValidating;
			textBoxMiddleName.Validating += Utility.TextBoxEmptyValidating;

			textBoxAddress.Validating += Utility.TextBoxEmptyValidating;
			textBoxSocial.Validating += Utility.TextBoxEmptyValidating;
			textBoxWork.Validating += Utility.TextBoxEmptyValidating;


	        Row = row;
        }

        public EditMode EditMode { get; set; }
		public ClinicDataSet.PatientCardsRow Row { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            if (EditMode == EditMode.ReadOnly)
            {
                Utility.LockTextBoxes(this);
            }
			if (EditMode != EditMode.CreateNew)
			{
				dateFill.Value = Row.Created;
				dateBirth.Value = Row.BirthDate;

				textBoxFirstName.Text = Row.FirstName;
				textBoxLastName.Text = Row.LastName;
				textBoxMiddleName.Text = Row.MiddleName;

				textBoxAddress.Text = Row.Address;
				textBoxPhone.Text = Row.Phone;
				textBoxSocial.Text = Row.SocialStatus;
				textBoxWork.Text = Row.Work;

				radioMale.Checked = (Row.Gender == "M");
				radioFemale.Checked = (Row.Gender == "F");
			}
            base.OnLoad(e);
        }

        private void multiText_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var editText = new EditTextForm(((TextBox) sender).Text);
            if (editText.ShowDialog() == DialogResult.OK)
            {
                ((TextBox) sender).Text = editText.ResultText;
            }
        }

	    private void buttonOk_Click(object sender, EventArgs e)
	    {
			if (EditMode == EditMode.CreateNew)
			{
				Row.Created = dateFill.Value;
			}
		    Row.BirthDate = dateBirth.Value;

		    Row.FirstName = textBoxFirstName.Text;
		    Row.LastName = textBoxLastName.Text;
		    Row.MiddleName = textBoxMiddleName.Text;

		    Row.Address = textBoxAddress.Text;
		    Row.Phone = textBoxPhone.Text;
		    Row.SocialStatus = textBoxSocial.Text;
		    Row.Work = textBoxWork.Text;

		    Row.Gender = radioMale.Checked ? "M" : "F";
	    }

	    private void buttonResearchs_Click(object sender, EventArgs e)
	    {
		    var form = new ResearchForm();
		    form.ShowDialog();
	    }

		private void buttonHistory_Click(object sender, EventArgs e)
		{
			var form = new HistoryForm();
			form.ShowDialog();
		}
    }
}
