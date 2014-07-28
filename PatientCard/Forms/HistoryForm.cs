using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatientCard.Logic;

namespace PatientCard.Forms
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(int cardId)
        {
            InitializeComponent();

            CardId = cardId;
        }

        public int CardId { get; set; }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            this.curePlansTableAdapter.FillByCard(this.clinicDataSet.CurePlans, CardId);
            this.diagnosticsTableAdapter.FillByCard(this.clinicDataSet.Diagnostics, CardId);
        }

        private void diagnosticsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridRow = diagnosticsDataGridView.Rows[e.RowIndex];
            var row = clinicDataSet.Diagnostics.FindByDiagnosticId(Utility.GetDataGridViewCellValue<int>(gridRow, "DiagnosticId"));
            
            var form = new DiagnosticForm(row);
            form.EditMode = EditMode.EditCurrent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                diagnosticsTableAdapter.Update(row);
            }
        }

        private void curePlansDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridRow = curePlansDataGridView.Rows[e.RowIndex];
            var row = clinicDataSet.CurePlans.FindByPlanId(Utility.GetDataGridViewCellValue<int>(gridRow, "PlanId"));

            var form = new CurePlanForm(row);
            form.EditMode = EditMode.EditCurrent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                curePlansTableAdapter.Update(row);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var row = clinicDataSet.Diagnostics.NewDiagnosticsRow();
            row.CardId = CardId;
            var form = new DiagnosticForm(row);
            form.EditMode = EditMode.CreateNew;
            if (form.ShowDialog() == DialogResult.OK)
            {
                clinicDataSet.Diagnostics.AddDiagnosticsRow(row);
                diagnosticsTableAdapter.Update(row);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                foreach (DataGridViewRow selectedRow in diagnosticsDataGridView.SelectedRows)
                {
                    var row = clinicDataSet.Diagnostics.FindByDiagnosticId(Utility.GetDataGridViewCellValue<int>(selectedRow, "DiagnosticId"));
                    clinicDataSet.Diagnostics.RemoveDiagnosticsRow(row);
                }
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            var row = clinicDataSet.CurePlans.NewCurePlansRow();
            row.CardId = CardId;

            var form = new CurePlanForm(row);
            form.EditMode = EditMode.CreateNew;
            if (form.ShowDialog() == DialogResult.OK)
            {
                clinicDataSet.CurePlans.AddCurePlansRow(row);
                curePlansTableAdapter.Update(row);
            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Удалить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                foreach (DataGridViewRow selectedRow in curePlansDataGridView.SelectedRows)
                {
                    var row = clinicDataSet.CurePlans.FindByPlanId(Utility.GetDataGridViewCellValue<int>(selectedRow, "PlanId"));
                    clinicDataSet.CurePlans.RemoveCurePlansRow(row);
                }
            }
        }
    }
}
