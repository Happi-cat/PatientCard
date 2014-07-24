using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatientCard.Data;
using PatientCard.Data.ClinicDataSetTableAdapters;
using PatientCard.Logic;

namespace PatientCard.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
	        Visible = false;
        }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			Visible = false;
			var form = new LoginForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				Visible = true;
			}
			else
			{
				MessageBox.Show("Неверные данные для входа", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}

        private void patientCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
			//var form = new PatientCardForm();
			//form.EditMode = EditMode.CreateNew;
			//form.ShowDialog(this);
        }

        private void diagnosticFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HistoryForm();
            form.Show(this);
        }

        private void historyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
			//var form = new DiagnosticForm(new ClinicDataSet.DiagnosticsRow(new DataRowBuilder()));
			//form.Show(this);
        }

        private void curePlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
			//var form = new CurePlanForm();
			//form.ShowDialog(this);
        }

        private void researchToolStripMenuItem_Click(object sender, EventArgs e)
        {
			//var form = new ResearchForm();
			//form.Show(this);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
	        var gridRow = dataGridPatients.Rows[e.RowIndex];
	        var row = clinicDataSet.PatientCards.FindByCardId(Utility.GetDataGridViewCellValue<int>(gridRow, "CardId"));
	        var form = new PatientCardForm(row);
			form.EditMode = EditMode.EditCurrent;
	        if (form.ShowDialog() == DialogResult.OK)
	        {
		        patientCardsTableAdapter.Update(row);
	        }
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'clinicDataSet.PatientCards' table. You can move, or remove it, as needed.
			this.patientCardsTableAdapter.Fill(this.clinicDataSet.PatientCards);

		}

		private void dataGridPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			var row = clinicDataSet.PatientCards.NewPatientCardsRow();
			var form = new PatientCardForm(row);
			form.EditMode = EditMode.CreateNew;
			if (form.ShowDialog() == DialogResult.OK)
			{
				clinicDataSet.PatientCards.AddPatientCardsRow(row);
				patientCardsTableAdapter.Update(row);
			}
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы точно хотите удалить?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
			    DialogResult.Yes)
			{
				foreach (DataGridViewRow selectedRow in dataGridPatients.SelectedRows)
				{
					var row = clinicDataSet.PatientCards.FindByCardId(Utility.GetDataGridViewCellValue<int>(selectedRow, "CardId"));
					clinicDataSet.PatientCards.RemovePatientCardsRow(row);
				}
			}
		}

    }
}
