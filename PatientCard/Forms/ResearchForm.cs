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
    public partial class ResearchForm : Form
    {
        public ResearchForm(int cardId)
        {
            InitializeComponent();

            CardId = cardId;
        }

        public int CardId { get; set; }

        private void ResearchForm_Load(object sender, EventArgs e)
        {
            researchsTableAdapter.FillByCard(clinicDataSet.Researchs, CardId);
        }

        private void dataGridView1_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var gridRow = e.Row;
            Utility.SetDataGridViewCellValue<int>(gridRow, "CardId", CardId);
            Utility.SetDataGridViewCellValue(gridRow, "Doctor",
                                                      string.Format("{0} {1} {2}", AuthManager.CurrentUser.LastName,
                                                                    AuthManager.CurrentUser.FirstName,
                                                                    AuthManager.CurrentUser.MiddleName));
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var row = clinicDataSet.Researchs.NewResearchsRow();
            row.CardId = CardId;
            row.Doctor = string.Format("{0} {1} {2}", AuthManager.CurrentUser.LastName,
                                       AuthManager.CurrentUser.FirstName,
                                       AuthManager.CurrentUser.MiddleName);
            row.Created = DateTime.Now;
            clinicDataSet.Researchs.AddResearchsRow(row);
            researchsTableAdapter.Update(row);

            bindingSource.MoveLast();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var gridRow = dataGridView1.Rows[e.RowIndex];
            var row = clinicDataSet.Researchs.FindByResearchId(Utility.GetDataGridViewCellValue<int>(gridRow, "ResearchId"));
            row[gridRow.Cells[e.ColumnIndex].OwningColumn.DataPropertyName] = gridRow.Cells[e.ColumnIndex].Value;
            researchsTableAdapter.Update(clinicDataSet.Researchs);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Вы ввели некоретные данные", "Ввод данных", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
