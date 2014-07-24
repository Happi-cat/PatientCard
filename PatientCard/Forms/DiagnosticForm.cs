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
    public partial class DiagnosticForm : Form
    {
        public DiagnosticForm(ClinicDataSet.DiagnosticsRow row)
        {
            InitializeComponent();
			
	        Row = row;

	        dateRequest.Value = row.Created;
	        textBoxReason.Text = row.Reason;

	        textBoxHeart.Text = row.Heart;
	        textBoxNeuro.Text = row.Neuro;
	        textBoxEndocrine.Text = row.Endocrine;
	        textBoxStomach.Text = row.Stomach;
	        textBoxLungs.Text = row.Lungs;
	        textBoxInfection.Text = row.Infection;
	        textBoxAlergic.Text = row.Alergic;
	        textBoxDrugs.Text = row.Drugs;
	        textBoxIndustry.Text = row.Industry;
	        textBoxPragnant.Text = row.Pregnant;
	        textBoxOther.Text = row.Other;

			radioYesHeart.Checked = row.IsHeart;
			radioYesNeuro.Checked = row.IsNeuro;
			radioYesEndocrine.Checked = row.IsEndocrine;
			radioYesStomach.Checked = row.IsStomach;
			radioYesLungs.Checked = row.IsLungs;
			radioYesInfection.Checked = row.IsInfection;
			radioYesAlergic.Checked = row.IsAlergic;
			radioYesDrugs.Checked = row.IsDrugs;
			radioYesIndustry.Checked = row.IsIndustry;
			radioYesPragnant.Checked = row.IsPregnant;
			radioYesOther.Checked = row.IsOther;

			radioNoHeart.Checked = ! row.IsHeart;
			radioNoNeuro.Checked = ! row.IsNeuro;
			radioNoEndocrine.Checked = ! row.IsEndocrine;
			radioNoStomach.Checked = ! row.IsStomach;
			radioNoLungs.Checked = ! row.IsLungs;
			radioNoInfection.Checked = ! row.IsInfection;
			radioNoAlergic.Checked = ! row.IsAlergic;
			radioNoDrugs.Checked = ! row.IsDrugs;
			radioNoIndustry.Checked = ! row.IsIndustry;
			radioNoPragnant.Checked = ! row.IsPregnant;
			radioNoOther.Checked = ! row.IsOther;

	        textBoxFace.Text = row.Face;
	        textBoxSkin.Text = row.Skin;
	        textBoxLimb.Text = row.Limb;
	        textBoxBone.Text = row.Bone;
        }

        public EditMode EditMode { get; set; }
		public ClinicDataSet.DiagnosticsRow Row { get; set; }

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
		    Row.Reason = textBoxReason.Text;

		    Row.Heart = textBoxHeart.Text;
		    Row.Neuro = textBoxNeuro.Text;
		    Row.Endocrine = textBoxEndocrine.Text;
		    Row.Stomach = textBoxStomach.Text;
		    Row.Lungs = textBoxLungs.Text;
		    Row.Infection = textBoxInfection.Text;
		    Row.Alergic = textBoxAlergic.Text;
		    Row.Drugs = textBoxDrugs.Text;
		    Row.Industry = textBoxIndustry.Text;
		    Row.Pregnant = textBoxPragnant.Text;
		    Row.Other = textBoxOther.Text;

		    Row.IsHeart = radioYesHeart.Checked;
		    Row.IsNeuro = radioYesNeuro.Checked;
		    Row.IsEndocrine = radioYesEndocrine.Checked;
		    Row.IsStomach = radioYesStomach.Checked;
		    Row.IsLungs = radioYesLungs.Checked;
		    Row.IsInfection = radioYesInfection.Checked;
		    Row.IsAlergic = radioYesAlergic.Checked;
		    Row.IsDrugs = radioYesDrugs.Checked;
		    Row.IsIndustry = radioYesIndustry.Checked;
		    Row.IsPregnant = radioYesPragnant.Checked;
		    Row.IsOther = radioYesOther.Checked;

		    Row.Face = textBoxFace.Text;
		    Row.Skin = textBoxSkin.Text;
		    Row.Limb = textBoxLimb.Text;
		    Row.Bone = textBoxBone.Text;
	    }
    }
}
