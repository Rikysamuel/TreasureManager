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
    public partial class SavingsEdit : Form
    {
        private bool _isValid = true;
        private bool _updateMode = false;

        public SavingsEdit()
        {
            InitializeComponent();
        }

        private void SavingsEdit_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            if (!String.IsNullOrEmpty(SavingForm.SavingsId))
            {
                _updateMode = true;
                _LoadPropertyData(SavingForm.SavingsId);
            }
            else
            {
                if (SavingForm.SavingsMode == TMConstants.Properties.Savings.DEBET)
                {
                    rbDebet.Checked = true;
                }
                else
                {
                    rbCredit.Checked = true;
                }

                this.Text = this.Text + ": " + SavingForm.UserId.Text;
                TxtId.Text = Business.Utils.Configuration.GetId("SavingsId", TMConstants.Table.SAVINGS, "UserId");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadPropertyData(string id)
        {
            var dt = ModuleManager.GetInstance().Select(TMConstants.Table.SAVINGS, "\"SavingsId\"='" + id + "'");
            TxtId.Text = dt.Rows[0][0].ToString();
            RTxtDesc.Text = dt.Rows[0][1].ToString();

            if (String.IsNullOrEmpty(dt.Rows[0][2].ToString()))
            {
                TxtValue.Text = dt.Rows[0][3].ToString();
                rbCredit.Checked = true;
            }
            else
            {
                TxtValue.Text = dt.Rows[0][2].ToString();
                rbDebet.Checked = true;
            }

            dtpTime.Text = dt.Rows[0][4].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var id = Utility.Escape(TxtId.Text);

            if (String.IsNullOrEmpty(id))
            {
                _isValid = false;
                LblIdValidation.Visible = true;
            }
            else
            {
                _isValid = true;
                LblIdValidation.Visible = false;
            }

            var remarks = Utility.Escape(RTxtDesc.Text);
            var value = Utility.Escape(TxtValue.Text).Replace(" ", "").Replace(",", "");

            decimal valueLong;
            if (!decimal.TryParse(value, out valueLong))
            {
                _isValid = false;
                LblValueValidation.Visible = true;
            }
            else
            {
                _isValid = true;
                LblValueValidation.Visible = false;
            }

            var kind = rbDebet.Checked;

            var date = dtpTime.Text;

            var refId = Utility.Escape(TxtRefId.Text);

            if (_isValid)
            {

                if (_updateMode)
                {
                    string set = String.Empty;

                    if (kind)
                    {
                        set = "\"Remarks\"= '" + remarks + "', " +
                              "\"Debet\"= '" + value + "', " +
                              "\"Credit\"= NULL, " +
                              "\"Tanggal\"= '" + date + "', " +
                              "\"ReferenceId\"= '" + refId + "'";
                    }
                    else
                    {
                        set = "\"Remarks\"= '" + remarks + "', " +
                              "\"Debet\"= NULL, " +
                              "\"Credit\"= '" + value + "', " +
                              "\"Tanggal\"= '" + date + "', " +
                              "\"ReferenceId\"= '" + refId + "'";
                    }
                    string where = "\"SavingsId\"='" + SavingForm.SavingsId + "'";
                    ModuleManager.GetInstance().Update(TMConstants.Table.SAVINGS, set, where);
                }
                else
                {
                    string values = String.Empty;
                    if (kind)
                    {
                        values = "('" + id + "', "
                                 + "'" + remarks + "', "
                                 + value + ", NULL, "
                                 + "'" + date + "', "
                                 + "'" + refId + "', "
                                 + "'" + SavingForm.UserId.Value + "');";
                    }
                    else
                    {
                        values = "('" + id + "', "
                                 + "'" + remarks + "', "
                                 + "NULL, " + value + ", "
                                 + "'" + date + "', "
                                 + "'" + refId + "', "
                                 + "'" + SavingForm.UserId.Value + "');";
                    }

                    ModuleManager.GetInstance().Insert(TMConstants.Table.SAVINGS, values);
                }
                this.Close();
            }
        }
    }
}
