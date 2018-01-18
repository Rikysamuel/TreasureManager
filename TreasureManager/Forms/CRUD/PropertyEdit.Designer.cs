namespace TreasureManager.Forms.CRUD
{
    partial class PropertyEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RTxtDesc = new System.Windows.Forms.RichTextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RTxtRemarks = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblYearValidation = new System.Windows.Forms.Label();
            this.LblValueValidation = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRefId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblRefIdValidation = new System.Windows.Forms.Label();
            this.chcSold = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Properti";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(203, 95);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(318, 30);
            this.TxtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deskripsi";
            // 
            // RTxtDesc
            // 
            this.RTxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtDesc.Location = new System.Drawing.Point(203, 156);
            this.RTxtDesc.Name = "RTxtDesc";
            this.RTxtDesc.Size = new System.Drawing.Size(318, 30);
            this.RTxtDesc.TabIndex = 5;
            this.RTxtDesc.Text = "";
            // 
            // TxtYear
            // 
            this.TxtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYear.Location = new System.Drawing.Point(203, 217);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(318, 30);
            this.TxtYear.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tahun Perolehan";
            // 
            // TxtValue
            // 
            this.TxtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValue.Location = new System.Drawing.Point(203, 278);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(318, 30);
            this.TxtValue.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga Perolehan";
            // 
            // RTxtRemarks
            // 
            this.RTxtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtRemarks.Location = new System.Drawing.Point(203, 339);
            this.RTxtRemarks.Name = "RTxtRemarks";
            this.RTxtRemarks.Size = new System.Drawing.Size(318, 132);
            this.RTxtRemarks.TabIndex = 11;
            this.RTxtRemarks.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Keterangan";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(317, 587);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(99, 40);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Simpan";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(422, 587);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(99, 40);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Batal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblYearValidation
            // 
            this.LblYearValidation.AutoSize = true;
            this.LblYearValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYearValidation.ForeColor = System.Drawing.Color.Red;
            this.LblYearValidation.Location = new System.Drawing.Point(198, 250);
            this.LblYearValidation.Name = "LblYearValidation";
            this.LblYearValidation.Size = new System.Drawing.Size(183, 25);
            this.LblYearValidation.TabIndex = 16;
            this.LblYearValidation.Text = "Tahun tidak valid.";
            this.LblYearValidation.Visible = false;
            // 
            // LblValueValidation
            // 
            this.LblValueValidation.AutoSize = true;
            this.LblValueValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValueValidation.ForeColor = System.Drawing.Color.Red;
            this.LblValueValidation.Location = new System.Drawing.Point(202, 311);
            this.LblValueValidation.Name = "LblValueValidation";
            this.LblValueValidation.Size = new System.Drawing.Size(179, 25);
            this.LblValueValidation.TabIndex = 17;
            this.LblValueValidation.Text = "Harga tidak valid.";
            this.LblValueValidation.Visible = false;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(203, 34);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(318, 30);
            this.TxtId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // TxtRefId
            // 
            this.TxtRefId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtRefId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefId.Location = new System.Drawing.Point(203, 500);
            this.TxtRefId.Name = "TxtRefId";
            this.TxtRefId.Size = new System.Drawing.Size(318, 30);
            this.TxtRefId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reference Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Status";
            // 
            // LblRefIdValidation
            // 
            this.LblRefIdValidation.AutoSize = true;
            this.LblRefIdValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRefIdValidation.ForeColor = System.Drawing.Color.Red;
            this.LblRefIdValidation.Location = new System.Drawing.Point(198, 474);
            this.LblRefIdValidation.Name = "LblRefIdValidation";
            this.LblRefIdValidation.Size = new System.Drawing.Size(244, 25);
            this.LblRefIdValidation.TabIndex = 21;
            this.LblRefIdValidation.Text = "Reference Id harus diisi.";
            this.LblRefIdValidation.Visible = false;
            // 
            // chcSold
            // 
            this.chcSold.AutoSize = true;
            this.chcSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcSold.Location = new System.Drawing.Point(203, 536);
            this.chcSold.Name = "chcSold";
            this.chcSold.Size = new System.Drawing.Size(139, 29);
            this.chcSold.TabIndex = 22;
            this.chcSold.Text = "Sudah dijual";
            this.chcSold.UseVisualStyleBackColor = true;
            // 
            // PropertyEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 642);
            this.Controls.Add(this.chcSold);
            this.Controls.Add(this.LblRefIdValidation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtRefId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblValueValidation);
            this.Controls.Add(this.LblYearValidation);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.RTxtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTxtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PropertyEdit";
            this.Text = "Property Management";
            this.Load += new System.EventHandler(this.PropertyEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTxtDesc;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RTxtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblYearValidation;
        private System.Windows.Forms.Label LblValueValidation;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRefId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblRefIdValidation;
        private System.Windows.Forms.CheckBox chcSold;
    }
}