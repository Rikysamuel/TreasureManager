namespace TreasureManager.Forms
{
    partial class SavingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.GVSaving = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnCredit = new System.Windows.Forms.Button();
            this.BtnDebet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboNames = new System.Windows.Forms.ComboBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.LblActiveUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVSaving)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1744, 169);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIST OF SAVINGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GVSaving
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVSaving.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GVSaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSaving.Location = new System.Drawing.Point(12, 172);
            this.GVSaving.Name = "GVSaving";
            this.GVSaving.Size = new System.Drawing.Size(1720, 460);
            this.GVSaving.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1261, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saldo:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(1355, 643);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(24, 31);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "-";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1591, 128);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(141, 38);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(1483, 128);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(102, 38);
            this.BtnEdit.TabIndex = 10;
            this.BtnEdit.Text = "EDIT";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCredit
            // 
            this.BtnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCredit.Location = new System.Drawing.Point(1375, 128);
            this.BtnCredit.Name = "BtnCredit";
            this.BtnCredit.Size = new System.Drawing.Size(102, 38);
            this.BtnCredit.TabIndex = 9;
            this.BtnCredit.Text = "CR";
            this.BtnCredit.UseVisualStyleBackColor = true;
            this.BtnCredit.Click += new System.EventHandler(this.BtnCredit_Click);
            // 
            // BtnDebet
            // 
            this.BtnDebet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDebet.Location = new System.Drawing.Point(1267, 128);
            this.BtnDebet.Name = "BtnDebet";
            this.BtnDebet.Size = new System.Drawing.Size(102, 38);
            this.BtnDebet.TabIndex = 12;
            this.BtnDebet.Text = "DB";
            this.BtnDebet.UseVisualStyleBackColor = true;
            this.BtnDebet.Click += new System.EventHandler(this.BtnDebet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nama:";
            // 
            // ComboNames
            // 
            this.ComboNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboNames.FormattingEnabled = true;
            this.ComboNames.Location = new System.Drawing.Point(115, 126);
            this.ComboNames.Name = "ComboNames";
            this.ComboNames.Size = new System.Drawing.Size(147, 33);
            this.ComboNames.TabIndex = 15;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilter.Location = new System.Drawing.Point(268, 122);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(112, 40);
            this.BtnFilter.TabIndex = 16;
            this.BtnFilter.Text = "Load";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // LblActiveUser
            // 
            this.LblActiveUser.AutoSize = true;
            this.LblActiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActiveUser.Location = new System.Drawing.Point(12, 643);
            this.LblActiveUser.Name = "LblActiveUser";
            this.LblActiveUser.Size = new System.Drawing.Size(75, 25);
            this.LblActiveUser.TabIndex = 17;
            this.LblActiveUser.Text = "Nama:";
            // 
            // SavingForm
            // 
            this.AcceptButton = this.BtnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 681);
            this.Controls.Add(this.LblActiveUser);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.ComboNames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDebet);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCredit);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GVSaving);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SavingForm";
            this.Text = "SavingForm";
            this.Load += new System.EventHandler(this.SavingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVSaving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GVSaving;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnCredit;
        private System.Windows.Forms.Button BtnDebet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboNames;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label LblActiveUser;
    }
}