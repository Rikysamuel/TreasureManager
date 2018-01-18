namespace TreasureManager.Forms.CRUD
{
    partial class EmployeeEdit
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdValidation = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNameValidation = new System.Windows.Forms.Label();
            this.TxtPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rTxtAddress = new System.Windows.Forms.RichTextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(412, 477);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 46);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Batal";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(269, 477);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 46);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Simpan";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(197, 74);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(318, 30);
            this.TxtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // LblIdValidation
            // 
            this.LblIdValidation.AutoSize = true;
            this.LblIdValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdValidation.ForeColor = System.Drawing.Color.Red;
            this.LblIdValidation.Location = new System.Drawing.Point(194, 46);
            this.LblIdValidation.Name = "LblIdValidation";
            this.LblIdValidation.Size = new System.Drawing.Size(140, 25);
            this.LblIdValidation.TabIndex = 33;
            this.LblIdValidation.Text = "Id harus diisi.";
            this.LblIdValidation.Visible = false;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(197, 13);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(318, 30);
            this.TxtId.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id";
            // 
            // LblNameValidation
            // 
            this.LblNameValidation.AutoSize = true;
            this.LblNameValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameValidation.ForeColor = System.Drawing.Color.Red;
            this.LblNameValidation.Location = new System.Drawing.Point(192, 107);
            this.LblNameValidation.Name = "LblNameValidation";
            this.LblNameValidation.Size = new System.Drawing.Size(172, 25);
            this.LblNameValidation.TabIndex = 47;
            this.LblNameValidation.Text = "Nama harus diisi";
            this.LblNameValidation.Visible = false;
            // 
            // TxtPlace
            // 
            this.TxtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlace.Location = new System.Drawing.Point(197, 135);
            this.TxtPlace.Name = "TxtPlace";
            this.TxtPlace.Size = new System.Drawing.Size(318, 30);
            this.TxtPlace.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tempat Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tanggal Lahir";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Location = new System.Drawing.Point(197, 196);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(318, 26);
            this.dtpBirth.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alamat Rumah";
            // 
            // rTxtAddress
            // 
            this.rTxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtAddress.Location = new System.Drawing.Point(197, 253);
            this.rTxtAddress.Name = "rTxtAddress";
            this.rTxtAddress.Size = new System.Drawing.Size(318, 139);
            this.rTxtAddress.TabIndex = 10;
            this.rTxtAddress.Text = "";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(197, 423);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(318, 30);
            this.TxtPhone.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nomor Telepon";
            // 
            // EmployeeEdit
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 535);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rTxtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblNameValidation);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblIdValidation);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label6);
            this.Name = "EmployeeEdit";
            this.Text = "EmployeeEdit";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdValidation;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblNameValidation;
        private System.Windows.Forms.TextBox TxtPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rTxtAddress;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label7;
    }
}