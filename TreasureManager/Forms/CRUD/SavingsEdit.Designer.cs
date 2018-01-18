namespace TreasureManager.Forms.CRUD
{
    partial class SavingsEdit
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblIdValidation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RTxtDesc = new System.Windows.Forms.RichTextBox();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDebet = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.LblValueValidation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtRefId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(201, 22);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(318, 30);
            this.TxtId.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Id";
            // 
            // LblIdValidation
            // 
            this.LblIdValidation.AutoSize = true;
            this.LblIdValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdValidation.ForeColor = System.Drawing.Color.Red;
            this.LblIdValidation.Location = new System.Drawing.Point(198, 55);
            this.LblIdValidation.Name = "LblIdValidation";
            this.LblIdValidation.Size = new System.Drawing.Size(140, 25);
            this.LblIdValidation.TabIndex = 17;
            this.LblIdValidation.Text = "Id harus diisi.";
            this.LblIdValidation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Keterangan";
            // 
            // RTxtDesc
            // 
            this.RTxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtDesc.Location = new System.Drawing.Point(201, 83);
            this.RTxtDesc.Name = "RTxtDesc";
            this.RTxtDesc.Size = new System.Drawing.Size(318, 96);
            this.RTxtDesc.TabIndex = 19;
            this.RTxtDesc.Text = "";
            // 
            // TxtValue
            // 
            this.TxtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValue.Location = new System.Drawing.Point(201, 210);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(318, 30);
            this.TxtValue.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nominal";
            // 
            // rbDebet
            // 
            this.rbDebet.AutoSize = true;
            this.rbDebet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebet.Location = new System.Drawing.Point(201, 269);
            this.rbDebet.Name = "rbDebet";
            this.rbDebet.Size = new System.Drawing.Size(82, 29);
            this.rbDebet.TabIndex = 22;
            this.rbDebet.TabStop = true;
            this.rbDebet.Text = "Debet";
            this.rbDebet.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredit.Location = new System.Drawing.Point(310, 269);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(81, 29);
            this.rbCredit.TabIndex = 23;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Kredit";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // LblValueValidation
            // 
            this.LblValueValidation.AutoSize = true;
            this.LblValueValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValueValidation.ForeColor = System.Drawing.Color.Red;
            this.LblValueValidation.Location = new System.Drawing.Point(196, 243);
            this.LblValueValidation.Name = "LblValueValidation";
            this.LblValueValidation.Size = new System.Drawing.Size(193, 25);
            this.LblValueValidation.TabIndex = 24;
            this.LblValueValidation.Text = "Nominal tidak valid";
            this.LblValueValidation.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tanggal";
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Location = new System.Drawing.Point(201, 304);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(318, 27);
            this.dtpTime.TabIndex = 26;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(377, 412);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(142, 32);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.Text = "Batal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(229, 412);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(142, 32);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Simpan";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtRefId
            // 
            this.TxtRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefId.Location = new System.Drawing.Point(201, 362);
            this.TxtRefId.Name = "TxtRefId";
            this.TxtRefId.Size = new System.Drawing.Size(318, 30);
            this.TxtRefId.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Reference Id";
            // 
            // SavingsEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 461);
            this.Controls.Add(this.TxtRefId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblValueValidation);
            this.Controls.Add(this.rbCredit);
            this.Controls.Add(this.rbDebet);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTxtDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblIdValidation);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label6);
            this.Name = "SavingsEdit";
            this.Text = "Savings Edit";
            this.Load += new System.EventHandler(this.SavingsEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblIdValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTxtDesc;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDebet;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.Label LblValueValidation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtRefId;
        private System.Windows.Forms.Label label3;
    }
}