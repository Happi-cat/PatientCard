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
        }

        public EditMode EditMode { get; set; }
		public ClinicDataSet.DiagnosticsRow Row { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            if (EditMode == EditMode.ReadOnly)
            {
                Utility.LockTextBoxes(this);
            }
			if (EditMode != EditMode.CreateNew)
			{
				dateRequest.Value = Row.Created;
				textBoxReason.Text = Row.Reason;

				textBoxHeart.Text = Row.Heart;
				textBoxNeuro.Text = Row.Neuro;
				textBoxEndocrine.Text = Row.Endocrine;
				textBoxStomach.Text = Row.Stomach;
				textBoxLungs.Text = Row.Lungs;
				textBoxInfection.Text = Row.Infection;
				textBoxAlergic.Text = Row.Alergic;
				textBoxDrugs.Text = Row.Drugs;
				textBoxIndustry.Text = Row.Industry;
				textBoxPragnant.Text = Row.Pregnant;
				textBoxOther.Text = Row.Other;

				radioYesHeart.Checked = Row.IsHeart;
				radioYesNeuro.Checked = Row.IsNeuro;
				radioYesEndocrine.Checked = Row.IsEndocrine;
				radioYesStomach.Checked = Row.IsStomach;
				radioYesLungs.Checked = Row.IsLungs;
				radioYesInfection.Checked = Row.IsInfection;
				radioYesAlergic.Checked = Row.IsAlergic;
				radioYesDrugs.Checked = Row.IsDrugs;
				radioYesIndustry.Checked = Row.IsIndustry;
				radioYesPragnant.Checked = Row.IsPregnant;
				radioYesOther.Checked = Row.IsOther;

				radioNoHeart.Checked = !Row.IsHeart;
				radioNoNeuro.Checked = !Row.IsNeuro;
				radioNoEndocrine.Checked = !Row.IsEndocrine;
				radioNoStomach.Checked = !Row.IsStomach;
				radioNoLungs.Checked = !Row.IsLungs;
				radioNoInfection.Checked = !Row.IsInfection;
				radioNoAlergic.Checked = !Row.IsAlergic;
				radioNoDrugs.Checked = !Row.IsDrugs;
				radioNoIndustry.Checked = !Row.IsIndustry;
				radioNoPragnant.Checked = !Row.IsPregnant;
				radioNoOther.Checked = !Row.IsOther;

				textBoxFace.Text = Row.Face;
				textBoxSkin.Text = Row.Skin;
				textBoxLimb.Text = Row.Limb;
				textBoxBone.Text = Row.Bone;
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
