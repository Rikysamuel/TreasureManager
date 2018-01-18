namespace TreasureManager.Forms
{
    partial class PropertyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GVProperty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.ComboNames = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblActiveUser = new System.Windows.Forms.Label();
            this.ChckSold = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // GVProperty
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVProperty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GVProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVProperty.Location = new System.Drawing.Point(12, 197);
            this.GVProperty.Name = "GVProperty";
            this.GVProperty.Size = new System.Drawing.Size(1720, 450);
            this.GVProperty.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1744, 169);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIST OF PROPERTY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(1380, 118);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(102, 38);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(1488, 118);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(102, 38);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "EDIT";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1596, 118);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(136, 38);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilter.Location = new System.Drawing.Point(269, 116);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(112, 40);
            this.BtnFilter.TabIndex = 19;
            this.BtnFilter.Text = "Load";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // ComboNames
            // 
            this.ComboNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboNames.FormattingEnabled = true;
            this.ComboNames.Location = new System.Drawing.Point(116, 120);
            this.ComboNames.Name = "ComboNames";
            this.ComboNames.Size = new System.Drawing.Size(147, 33);
            this.ComboNames.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nama:";
            // 
            // LblActiveUser
            // 
            this.LblActiveUser.AutoSize = true;
            this.LblActiveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActiveUser.Location = new System.Drawing.Point(13, 650);
            this.LblActiveUser.Name = "LblActiveUser";
            this.LblActiveUser.Size = new System.Drawing.Size(75, 25);
            this.LblActiveUser.TabIndex = 20;
            this.LblActiveUser.Text = "Nama:";
            // 
            // ChckSold
            // 
            this.ChckSold.AutoSize = true;
            this.ChckSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChckSold.Location = new System.Drawing.Point(12, 159);
            this.ChckSold.Name = "ChckSold";
            this.ChckSold.Size = new System.Drawing.Size(265, 29);
            this.ChckSold.TabIndex = 21;
            this.ChckSold.Text = "Tampilkan Property Terjual";
            this.ChckSold.UseVisualStyleBackColor = true;
            this.ChckSold.CheckedChanged += new System.EventHandler(this.ChckSold_CheckedChanged);
            // 
            // PropertyForm
            // 
            this.AcceptButton = this.BtnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 681);
            this.Controls.Add(this.ChckSold);
            this.Controls.Add(this.LblActiveUser);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.ComboNames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GVProperty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyForm";
            this.Text = "PropertyForm";
            this.Load += new System.EventHandler(this.PropertyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVProperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.ComboBox ComboNames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblActiveUser;
        private System.Windows.Forms.CheckBox ChckSold;
    }
}