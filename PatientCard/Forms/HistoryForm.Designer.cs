namespace PatientCard.Forms
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.Size = new System.Drawing.Size(706, 465);
            this.dataGridHistory.TabIndex = 0;
            // 
            // DiagnosticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 465);
            this.Controls.Add(this.dataGridHistory);
            this.Name = "DiagnosticForm";
            this.Text = "DiagnosticForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistory;
    }
}