namespace TreasureManager.Forms.Configuration
{
    partial class ConfigurationForm
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
            this.TxtSavingsId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LblSuccess = new System.Windows.Forms.Label();
            this.TxtPropertyId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1744, 169);
            this.label1.TabIndex = 5;
            this.label1.Text = "Configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSavingsId
            // 
            this.TxtSavingsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSavingsId.Location = new System.Drawing.Point(915, 235);
            this.TxtSavingsId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtSavingsId.Name = "TxtSavingsId";
            this.TxtSavingsId.Size = new System.Drawing.Size(497, 30);
            this.TxtSavingsId.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Savings Id Format";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(430, 530);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(200, 55);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Simpan";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtUserId
            // 
            this.TxtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserId.Location = new System.Drawing.Point(915, 287);
            this.TxtUserId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(497, 30);
            this.TxtUserId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Id Format";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(430, 356);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(987, 148);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Gunakan [year] untuk tahun saat ini\nGunakan [month] untuk bulan saat ini\nGunakan " +
    "[date] untuk tanggal saat ini\nGunakan [no] untuk \'auto-increment\' angka";
            // 
            // LblSuccess
            // 
            this.LblSuccess.AutoSize = true;
            this.LblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblSuccess.Location = new System.Drawing.Point(427, 592);
            this.LblSuccess.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblSuccess.Name = "LblSuccess";
            this.LblSuccess.Size = new System.Drawing.Size(240, 25);
            this.LblSuccess.TabIndex = 9;
            this.LblSuccess.Text = "Data berhasil di update.";
            this.LblSuccess.Visible = false;
            // 
            // TxtPropertyId
            // 
            this.TxtPropertyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPropertyId.Location = new System.Drawing.Point(915, 180);
            this.TxtPropertyId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtPropertyId.Name = "TxtPropertyId";
            this.TxtPropertyId.Size = new System.Drawing.Size(497, 30);
            this.TxtPropertyId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Property Id Format";
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 681);
            this.Controls.Add(this.TxtPropertyId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblSuccess);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtSavingsId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSavingsId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LblSuccess;
        private System.Windows.Forms.TextBox TxtPropertyId;
        private System.Windows.Forms.Label label3;
    }
}