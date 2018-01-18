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
using TreasureManager.Business.Utils;

namespace TreasureManager.Forms.CRUD
{
    public partial class EmployeeEdit : Form
    {
        private bool _updateMode;
        private bool _isValid;

        public EmployeeEdit()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            if (!String.IsNullOrEmpty(Employee.EmployeeId))
            {
                _updateMode = true;
                _LoadPropertyData(Employee.EmployeeId);
            }
            else
            {
                TxtId.Text = Business.Utils.Configuration.GetId("EmployeeId", TMConstants.Table.EMPLOYEE, "UserId");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var id = Utility.Escape(TxtId.Text);

            if (string.IsNullOrEmpty(id))
            {
                _isValid = false;
                LblIdValidation.Visible = true;
            }
            else
            {
                _isValid = true;
                LblIdValidation.Visible = false;
            }

            var name = Utility.Escape(TxtName.Text);

            if (string.IsNullOrEmpty(name))
            {
                _isValid = false;
                LblNameValidation.Visible = true;
            }
            else
            {
                _isValid = true;
                LblNameValidation.Visible = false;
            }

            var birthPlace = Utility.Escape(TxtPlace.Text);
            var birthDate = dtpBirth.Text;
            var address = Utility.Escape(rTxtAddress.Text);
            var phone = Utility.Escape(TxtPhone.Text);

            if (_isValid)
            {

                if (_updateMode)
                {
                    var set = "\"Name\"= '" + name + "', " +
                              "\"BirthPlace\"= '" + birthPlace + "', " +
                              "\"BirthDate\"= '" + birthDate + "', " +
                              "\"Address\"= '" + address + "', " +
                              "\"Phone\"= '" + phone + "'";
                    
                    var where = "\"UserId\"='" + Employee.EmployeeId + "'";
                    ModuleManager.GetInstance().Update(TMConstants.Table.EMPLOYEE, set, where);
                }
                else
                {
                    string values = "('" + id + "', "
                        + "'" + name + "', "
                        + "'" + birthPlace + "', "
                        + "'" + birthDate + "', "
                        + "'" + address + "', "
                        + "'" + phone + "')";

                    ModuleManager.GetInstance().Insert(TMConstants.Table.EMPLOYEE, values);
                }

                this.Close();
            }
        }

        private void _LoadPropertyData(string employeeId)
        {
            var dt = ModuleManager.GetInstance().Select(TMConstants.Table.EMPLOYEE, "\"UserId\"='" + employeeId + "'");
            TxtId.Text = dt.Rows[0][0].ToString();
            TxtName.Text = dt.Rows[0][1].ToString();
            TxtPlace.Text = dt.Rows[0][2].ToString();
            dtpBirth.Text = dt.Rows[0][3].ToString();
            rTxtAddress.Text = dt.Rows[0][4].ToString();
            TxtPhone.Text = dt.Rows[0][5].ToString();
        }
    }
}
