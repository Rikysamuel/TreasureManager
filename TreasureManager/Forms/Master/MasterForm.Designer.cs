namespace TreasureManager.Forms.Master
{
    partial class MasterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTocsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPg = new System.Windows.Forms.TabControl();
            this.LblIntro = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTocsvToolStripMenuItem,
            this.closeTabToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportTocsvToolStripMenuItem
            // 
            this.exportTocsvToolStripMenuItem.Enabled = false;
            this.exportTocsvToolStripMenuItem.Name = "exportTocsvToolStripMenuItem";
            this.exportTocsvToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportTocsvToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exportTocsvToolStripMenuItem.Text = "Export to .csv";
            this.exportTocsvToolStripMenuItem.Click += new System.EventHandler(this.exportTocsvToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFormsToolStripMenuItem,
            this.findReferencesToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // loadFormsToolStripMenuItem
            // 
            this.loadFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyFormToolStripMenuItem,
            this.savingsFormToolStripMenuItem,
            this.depositoFormToolStripMenuItem});
            this.loadFormsToolStripMenuItem.Name = "loadFormsToolStripMenuItem";
            this.loadFormsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.loadFormsToolStripMenuItem.Text = "Load Forms";
            // 
            // propertyFormToolStripMenuItem
            // 
            this.propertyFormToolStripMenuItem.Name = "propertyFormToolStripMenuItem";
            this.propertyFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertyFormToolStripMenuItem.Text = "Property Form";
            this.propertyFormToolStripMenuItem.Click += new System.EventHandler(this.propertyFormToolStripMenuItem_Click);
            // 
            // savingsFormToolStripMenuItem
            // 
            this.savingsFormToolStripMenuItem.Name = "savingsFormToolStripMenuItem";
            this.savingsFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.savingsFormToolStripMenuItem.Text = "Savings Form";
            this.savingsFormToolStripMenuItem.Click += new System.EventHandler(this.savingsFormToolStripMenuItem_Click);
            // 
            // depositoFormToolStripMenuItem
            // 
            this.depositoFormToolStripMenuItem.Name = "depositoFormToolStripMenuItem";
            this.depositoFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.depositoFormToolStripMenuItem.Text = "Deposito Form";
            // 
            // findReferencesToolStripMenuItem
            // 
            this.findReferencesToolStripMenuItem.Name = "findReferencesToolStripMenuItem";
            this.findReferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findReferencesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.findReferencesToolStripMenuItem.Text = "Find References";
            this.findReferencesToolStripMenuItem.Click += new System.EventHandler(this.findReferencesToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.configToolStripMenuItem,
            this.loginsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configToolStripMenuItem.Text = "Settings";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // loginsToolStripMenuItem
            // 
            this.loginsToolStripMenuItem.Name = "loginsToolStripMenuItem";
            this.loginsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginsToolStripMenuItem.Text = "Logins";
            this.loginsToolStripMenuItem.Click += new System.EventHandler(this.loginsToolStripMenuItem_Click);
            // 
            // TabPg
            // 
            this.TabPg.Location = new System.Drawing.Point(0, 27);
            this.TabPg.Name = "TabPg";
            this.TabPg.SelectedIndex = 0;
            this.TabPg.Size = new System.Drawing.Size(1754, 733);
            this.TabPg.TabIndex = 1;
            this.TabPg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabPg_MouseClick);
            // 
            // LblIntro
            // 
            this.LblIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblIntro.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntro.Location = new System.Drawing.Point(0, 24);
            this.LblIntro.Name = "LblIntro";
            this.LblIntro.Size = new System.Drawing.Size(1754, 737);
            this.LblIntro.TabIndex = 6;
            this.LblIntro.Text = "Welcome!";
            this.LblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 761);
            this.Controls.Add(this.LblIntro);
            this.Controls.Add(this.TabPg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MasterForm";
            this.Text = "Treasure Manager";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTocsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingsFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.TabControl TabPg;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.Label LblIntro;
        private System.Windows.Forms.ToolStripMenuItem findReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginsToolStripMenuItem;
    }
}