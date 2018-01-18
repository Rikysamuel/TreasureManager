using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreasureManager.Business.Manager.Form;
using TreasureManager.Business.Utils;
using TreasureManager.Forms.Configuration;
using TreasureManager.Forms.Secure;

namespace TreasureManager.Forms.Master
{
    public partial class MasterForm : Form
    {
        private int activeForm = 0;

        public MasterForm()
        {
            InitializeComponent();
            closeTabToolStripMenuItem.Enabled = false;
        }

        private void propertyFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = TMConstants.Form.PROPERTY;
            _SetUp();
        }

        private void savingsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = TMConstants.Form.SAVINGS;
            _SetUp();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = TMConstants.Form.CONFIGURATION;
            _SetUp();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = TMConstants.Form.EMPLOYEE;
            _SetUp();
        }

        private void findReferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = TMConstants.Form.REFERENCES;
            _SetUp();
        }

        private void loginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeForm = TMConstants.Form.LOGINS;
            _SetUp();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetUp()
        {
            exportTocsvToolStripMenuItem.Enabled = true;
            Form form = null;

            if (activeForm == TMConstants.Form.PROPERTY)
            {
                form = new PropertyForm {TopLevel = false, AutoScroll = true};
            }

            if (activeForm == TMConstants.Form.SAVINGS)
            {
                form = new SavingForm {TopLevel = false, AutoScroll = true};
            }

            if (activeForm == TMConstants.Form.CONFIGURATION)
            {
                form = new ConfigurationForm {TopLevel = false, AutoScroll = true};
            }

            if (activeForm == TMConstants.Form.EMPLOYEE)
            {
                form = new Employee {TopLevel = false, AutoScroll = true};
            }

            if (activeForm == TMConstants.Form.REFERENCES)
            {
                form = new ReferenceForm {TopLevel = false, AutoScroll = true};
            }

            if (activeForm == TMConstants.Form.LOGINS)
            {
                form = new Logins() { TopLevel = false, AutoScroll = true };
            }

            if (form != null)
            {
                form.Visible = true;

                var formTab = new TabPage(form.Name);
                formTab.Controls.Add(form);

                TabPg.TabPages.Add(formTab);
                TabPg.SelectedTab = formTab;

                closeTabToolStripMenuItem.Enabled = true;
                LblIntro.Visible = false;
            }
        }

        private void exportTocsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFormBehavior form = null;

            if (TabPg.SelectedTab.Controls[0].GetType() == typeof(PropertyForm))
            {
                form = (PropertyForm) TabPg.SelectedTab.Controls[0];
            }

            if (TabPg.SelectedTab.Controls[0].GetType() == typeof(SavingForm))
            {
                form = (SavingForm) TabPg.SelectedTab.Controls[0];
            }

            if (form != null)
            {
                var saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Comma Separated Values|*.csv";
                saveDialog.Title = "Export To CSV";
                saveDialog.ShowDialog();

                if (!string.IsNullOrEmpty(saveDialog.FileName))
                {
                    form.ExportToCSv(saveDialog.FileName);
                }
            }
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabPg.TabPages.Count > 0)
            {
                TabPg.TabPages.Remove(TabPg.SelectedTab);
            }

            if (TabPg.TabPages.Count < 1)
            {
                LblIntro.Visible = true;
                closeTabToolStripMenuItem.Enabled = false;
            }
        }

        private void TabPg_MouseClick(object sender, MouseEventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl != null)
            {
                var tabs = tabControl.TabPages;

                if (e.Button == MouseButtons.Middle)
                {
                    tabs.Remove(tabs.Cast<TabPage>()
                        .Where((t, i) => tabControl.GetTabRect(i).Contains(e.Location))
                        .First());
                }
            }

            if (TabPg.TabPages.Count < 1)
            {
                LblIntro.Visible = true;
                closeTabToolStripMenuItem.Enabled = false;
            }
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            var authenticateForm = new Secure.Password();
            authenticateForm.Closed += authenticateFormClosed;
            authenticateForm.TopMost = true;
            authenticateForm.ShowDialog();
        }

        private void authenticateFormClosed(object sender, EventArgs e)
        {
            if (!Secure.Password.success)
            {
                this.Close();
            }
        }
    }
}
