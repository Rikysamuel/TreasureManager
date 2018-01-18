using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreasureManager.Business.Manager;

namespace TreasureManager.Forms.Configuration
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            TxtPropertyId.Text = ModuleManager.GetInstance().Select("Configuration", "\"Key\"='PropertyId'").Rows[0][1].ToString();
            TxtSavingsId.Text = ModuleManager.GetInstance().Select("Configuration", "\"Key\"='SavingsId'").Rows[0][1].ToString();
            TxtUserId.Text = ModuleManager.GetInstance().Select("Configuration", "\"Key\"='EmployeeId'").Rows[0][1].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ModuleManager.GetInstance().Update("Configuration", "\"Value\"='" + TxtPropertyId.Text + "'", "\"Key\"='PropertyId'");
            ModuleManager.GetInstance().Update("Configuration", "\"Value\"='" + TxtSavingsId.Text + "'", "\"Key\"='SavingsId'");
            ModuleManager.GetInstance().Update("Configuration", "\"Value\"='" + TxtUserId.Text + "'", "\"Key\"='EmployeeId'");

            LblSuccess.Visible = true;
        }
    }
}
