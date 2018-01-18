using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TreasureManager.Business.Manager;
using TreasureManager.Business.Utils;

namespace TreasureManager.Forms.CRUD
{
    public partial class PropertyEdit : Form
    {
        private bool _isValid = true;
        private bool _updateMode = false;
        public PropertyEdit()
        {
            InitializeComponent();
        }

        private void PropertyEdit_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            if (!String.IsNullOrEmpty(PropertyForm.PropertyId))
            {
                _updateMode = true;
                _LoadPropertyData(int.Parse(PropertyForm.PropertyId));
            }
            else
            {
                this.Text = this.Text + ": " + PropertyForm.UserId.Text;
                TxtId.Text = Business.Utils.Configuration.GetId("PropertyId", TMConstants.Table.PROPERTY, "TransactionId");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var id = Utility.Escape(TxtId.Text);
            var propName = Utility.Escape(TxtName.Text);
            var remarks = Utility.Escape(RTxtRemarks.Text);
            var year = Utility.Escape(TxtYear.Text);
            var refId = Utility.Escape(TxtRefId.Text);

            int yearInt;
            if (!Int32.TryParse(year, out yearInt))
            {
                _isValid = false;
                LblYearValidation.Visible = true;
            }
            else
            {
                _isValid = true;
            }

            var value = Utility.Escape(TxtValue.Text);

            decimal valueDec;
            if (!decimal.TryParse(value, out valueDec))
            {
                _isValid = false;
                LblValueValidation.Visible = true;
            }
            else
            {
                _isValid = true;
            }

            var desc = Utility.Escape(RTxtDesc.Text);

            var status = true;
            if (chcSold.Checked)
            {
                if (string.IsNullOrEmpty(refId))
                {
                    _isValid = false;
                    LblRefIdValidation.Visible = true;
                }
                else
                {
                    status = false;
                }
            }

            if (_isValid)
            {
                if (_updateMode)
                {
                    string set =
                        "\"Id\"=" + PropertyForm.PropertyId + ", " +
                        "\"TransactionId\"= '" + id + "', " +
                        "\"ReferenceId\"= '" + refId + "', " +
                        " \"PropertyName\"= '" + propName + "', " +
                        " \"Remarks\"= '" + remarks + "', " +
                        " \"Year\"=" + year + ", " +
                        " \"Value\"= " + value + ", " +
                        " \"Description\"= '" + desc + "', " +
                        " \"Status\"= " + status;
                    string where = "\"Id\"=" + PropertyForm.PropertyId;
                    ModuleManager.GetInstance().Update(TMConstants.Table.PROPERTY, set, where);
                }
                else
                {
                    string values = "(DEFAULT, '" + propName + "', "
                                    + "'" + remarks + "', "
                                    + year + ", "
                                    + value + ", "
                                    + "'" + desc + "', "
                                    + "'" + id + "', "
                                    + "'" + refId + "', "
                                    + "'" + status + "', "
                                    + "'" + PropertyForm.UserId.Value + "');";
                    ModuleManager.GetInstance().Insert(TMConstants.Table.PROPERTY, values);
                }

                this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref message, keyData);
        }

        private void _LoadPropertyData(int id)
        {
            var dt = ModuleManager.GetInstance().Select(TMConstants.Table.PROPERTY, "\"Id\"=" + id);
            TxtName.Text = dt.Rows[0][1].ToString();
            RTxtRemarks.Text = dt.Rows[0][2].ToString();
            TxtYear.Text = dt.Rows[0][3].ToString();
            TxtValue.Text = dt.Rows[0][4].ToString();
            RTxtDesc.Text = dt.Rows[0][5].ToString();
            TxtId.Text = dt.Rows[0][6].ToString();
            TxtRefId.Text = dt.Rows[0][7].ToString();
        }
    }
}
