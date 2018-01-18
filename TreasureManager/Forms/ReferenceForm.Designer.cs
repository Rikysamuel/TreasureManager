namespace TreasureManager.Forms
{
    partial class ReferenceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GVReferences = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbProperty = new System.Windows.Forms.RadioButton();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.rbDeposito = new System.Windows.Forms.RadioButton();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRefId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVReferences)).BeginInit();
            this.SuspendLayout();
            // 
            // GVReferences
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVReferences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GVReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVReferences.Location = new System.Drawing.Point(4, 205);
            this.GVReferences.Name = "GVReferences";
            this.GVReferences.Size = new System.Drawing.Size(1720, 422);
            this.GVReferences.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1728, 169);
            this.label1.TabIndex = 1;
            this.label1.Text = "REFERENCES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbProperty
            // 
            this.rbProperty.AutoSize = true;
            this.rbProperty.Checked = true;
            this.rbProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProperty.Location = new System.Drawing.Point(18, 150);
            this.rbProperty.Name = "rbProperty";
            this.rbProperty.Size = new System.Drawing.Size(103, 29);
            this.rbProperty.TabIndex = 5;
            this.rbProperty.TabStop = true;
            this.rbProperty.Text = "Property";
            this.rbProperty.UseVisualStyleBackColor = true;
            this.rbProperty.CheckedChanged += new System.EventHandler(this.rbProperty_CheckedChanged);
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSavings.Location = new System.Drawing.Point(127, 151);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(101, 29);
            this.rbSavings.TabIndex = 6;
            this.rbSavings.Text = "Savings";
            this.rbSavings.UseVisualStyleBackColor = true;
            this.rbSavings.CheckedChanged += new System.EventHandler(this.rbSavings_CheckedChanged);
            // 
            // rbDeposito
            // 
            this.rbDeposito.AutoSize = true;
            this.rbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeposito.Location = new System.Drawing.Point(234, 151);
            this.rbDeposito.Name = "rbDeposito";
            this.rbDeposito.Size = new System.Drawing.Size(107, 29);
            this.rbDeposito.TabIndex = 7;
            this.rbDeposito.Text = "Deposito";
            this.rbDeposito.UseVisualStyleBackColor = true;
            this.rbDeposito.CheckedChanged += new System.EventHandler(this.rbDeposito_CheckedChanged);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilter.Location = new System.Drawing.Point(367, 105);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(112, 40);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Find";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ref Id:";
            // 
            // TxtRefId
            // 
            this.TxtRefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefId.Location = new System.Drawing.Point(113, 106);
            this.TxtRefId.Name = "TxtRefId";
            this.TxtRefId.Size = new System.Drawing.Size(248, 38);
            this.TxtRefId.TabIndex = 3;
            // 
            // ReferenceForm
            // 
            this.AcceptButton = this.BtnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 642);
            this.Controls.Add(this.TxtRefId);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbDeposito);
            this.Controls.Add(this.rbSavings);
            this.Controls.Add(this.rbProperty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GVReferences);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReferenceForm";
            this.Text = "ReferenceForm";
            ((System.ComponentModel.ISupportInitialize)(this.GVReferences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVReferences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbProperty;
        private System.Windows.Forms.RadioButton rbSavings;
        private System.Windows.Forms.RadioButton rbDeposito;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRefId;
    }
}