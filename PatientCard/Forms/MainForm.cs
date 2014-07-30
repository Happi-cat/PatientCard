using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

		private void dataGridPatients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (Utility.GetDataGridViewCellValue<string>(dataGridPatients.Rows[e.RowIndex], "Gender") == "M")
			{
				e.CellStyle.BackColor = Color.LightCyan;
			}
			else
			{
				e.CellStyle.BackColor = Color.MistyRose;
			}
		}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName =  Path.Combine(Application.StartupPath , @"Help\index.htm");
                myProcess.Start();

            }
            catch (Exception exception)
            {
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У вас самая последняя версия программы", "Обновление", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

    }
}
