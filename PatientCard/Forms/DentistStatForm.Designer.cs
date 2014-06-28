namespace PatientCard.Forms
{
    partial class DentistStatForm
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
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabKPU = new System.Windows.Forms.TabPage();
            this.tabOHIS = new System.Windows.Forms.TabPage();
            this.tabKPI = new System.Windows.Forms.TabPage();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.panelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMain.Controls.Add(this.flowButtons, 0, 1);
            this.panelMain.Controls.Add(this.mainTab, 0, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 2;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMain.Size = new System.Drawing.Size(948, 508);
            this.panelMain.TabIndex = 0;
            // 
            // flowButtons
            // 
            this.flowButtons.AutoSize = true;
            this.flowButtons.Controls.Add(this.buttonCancel);
            this.flowButtons.Controls.Add(this.buttonOk);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButtons.Location = new System.Drawing.Point(3, 409);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(942, 96);
            this.flowButtons.TabIndex = 71;
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(861, 6);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 50);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.AutoSize = true;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(774, 6);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 50);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabInfo);
            this.mainTab.Controls.Add(this.tabKPU);
            this.mainTab.Controls.Add(this.tabOHIS);
            this.mainTab.Controls.Add(this.tabKPI);
            this.mainTab.Controls.Add(this.tabOther);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTab.Location = new System.Drawing.Point(3, 3);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(942, 400);
            this.mainTab.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.panelInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 29);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(934, 367);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Условные обозначения";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tabKPU
            // 
            this.tabKPU.Location = new System.Drawing.Point(4, 22);
            this.tabKPU.Name = "tabKPU";
            this.tabKPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabKPU.Size = new System.Drawing.Size(934, 374);
            this.tabKPU.TabIndex = 1;
            this.tabKPU.Text = "КПУ";
            this.tabKPU.UseVisualStyleBackColor = true;
            // 
            // tabOHIS
            // 
            this.tabOHIS.Location = new System.Drawing.Point(4, 22);
            this.tabOHIS.Name = "tabOHIS";
            this.tabOHIS.Size = new System.Drawing.Size(934, 374);
            this.tabOHIS.TabIndex = 2;
            this.tabOHIS.Text = "OHIS";
            this.tabOHIS.UseVisualStyleBackColor = true;
            // 
            // tabKPI
            // 
            this.tabKPI.Location = new System.Drawing.Point(4, 22);
            this.tabKPI.Name = "tabKPI";
            this.tabKPI.Size = new System.Drawing.Size(934, 374);
            this.tabKPI.TabIndex = 3;
            this.tabKPI.Text = "КПИ";
            this.tabKPI.UseVisualStyleBackColor = true;
            // 
            // tabOther
            // 
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(934, 374);
            this.tabOther.TabIndex = 4;
            this.tabOther.Text = "Разное";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.ColumnCount = 3;
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelInfo.Controls.Add(this.label1, 0, 0);
            this.panelInfo.Controls.Add(this.label2, 1, 0);
            this.panelInfo.Controls.Add(this.label3, 2, 0);
            this.panelInfo.Controls.Add(this.label4, 0, 1);
            this.panelInfo.Controls.Add(this.label5, 1, 1);
            this.panelInfo.Controls.Add(this.label6, 2, 1);
            this.panelInfo.Controls.Add(this.label7, 0, 2);
            this.panelInfo.Controls.Add(this.label8, 1, 2);
            this.panelInfo.Controls.Add(this.label9, 2, 2);
            this.panelInfo.Controls.Add(this.label10, 0, 3);
            this.panelInfo.Controls.Add(this.label11, 1, 3);
            this.panelInfo.Controls.Add(this.label12, 2, 3);
            this.panelInfo.Controls.Add(this.label13, 0, 4);
            this.panelInfo.Controls.Add(this.label14, 1, 4);
            this.panelInfo.Controls.Add(this.label15, 2, 4);
            this.panelInfo.Controls.Add(this.label16, 0, 5);
            this.panelInfo.Controls.Add(this.label17, 1, 5);
            this.panelInfo.Controls.Add(this.label18, 2, 5);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(3, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RowCount = 7;
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelInfo.Size = new System.Drawing.Size(928, 361);
            this.panelInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здоровый зуб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(699, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(699, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(467, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(699, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(467, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(699, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "label18";
            // 
            // DentistStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.panelMain);
            this.Name = "DentistStatForm";
            this.Text = "Стоматологический статус";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.flowButtons.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabKPU;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabPage tabOHIS;
        private System.Windows.Forms.TabPage tabKPI;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TableLayoutPanel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;

    }
}