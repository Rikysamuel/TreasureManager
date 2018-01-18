using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreasureManager.Business.Manager;
using TreasureManager.Business.Manager.Form;
using TreasureManager.Business.Utils;
using TreasureManager.Forms.CRUD;

namespace TreasureManager.Forms
{
    public partial class SavingForm : Form, IFormBehavior
    {
        public static string SavingsId { get; set; }
        public static int SavingsMode { get; set; }

        public static Business.DataModel.Employee UserId { get; set; }
        public SavingForm()
        {
            InitializeComponent();
            _LoadComboBox();
        }

        private void BtnDebet_Click(object sender, EventArgs e)
        {
            SavingsMode = TMConstants.Properties.Savings.DEBET;
            var propForm = new SavingsEdit();
            propForm.Closed += propFormClosed;
            propForm.Show();
        }

        private void BtnCredit_Click(object sender, EventArgs e)
        {
            SavingsMode = TMConstants.Properties.Savings.KREDIT;
            var propForm = new SavingsEdit();
            propForm.Closed += propFormClosed;
            propForm.Show();
        }

        private void SavingForm_Load(object sender, EventArgs e)
        {
            _LoadData();
            _SetDataViewProperties();
        }

        private void propFormClosed(object sender, EventArgs e)
        {
            SavingsId = String.Empty;
            _LoadData();
        }

        private void _LoadData()
        {
            var selection = "\"SavingsId\", \"Remarks\", \"Debet\", \"Credit\", \"Tanggal\", \"ReferenceId\"";

            UserId = ComboNames.SelectedItem as Business.DataModel.Employee;

            if (UserId != null)
            {
                if (UserId.Value.Equals("-"))
                {
                    _DisableButtons();
                }
                else
                {
                    _EnableButtons();
                }
                GVSaving.DataSource = ModuleManager.GetInstance().Select(TMConstants.Table.SAVINGS, "\"UserId\"='" + UserId.Value + "'", selection);
            }

            _CalculateBalance();
        }

        private void _SetDataViewProperties()
        {
            GVSaving.Columns[0].HeaderText = "Id";
            GVSaving.Columns[1].HeaderText = "Keterangan";
            GVSaving.Columns[2].HeaderText = "Debet";
            GVSaving.Columns[3].HeaderText = "Kredit";
            GVSaving.Columns[4].HeaderText = "Tanggal";
            GVSaving.Columns[5].HeaderText = "Reference Id";

            foreach (DataGridViewColumn gvSavingColumn in GVSaving.Columns)
            {
                gvSavingColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvSavingColumn.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15F, GraphicsUnit.Pixel);
            }

            GVSaving.Columns[2].DefaultCellStyle.Format = "C3";
            GVSaving.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            GVSaving.Columns[3].DefaultCellStyle.Format = "C3";
            GVSaving.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");

            GVSaving.ReadOnly = true;
        }

        private void _CalculateBalance()
        {
            var dt = ModuleManager.GetInstance().Select(TMConstants.Table.SAVINGS, "\"UserId\"='" + UserId.Value + "'", "\"Debet\", \"Credit\"");

            decimal totalDebet = 0, totalKredit = 0;

            if (dt.Rows.Count > 0)
            {
                totalDebet = dt.AsEnumerable().Sum(x => x.IsNull("Debet") ? 0 : Convert.ToDecimal(x["Debet"]));
                totalKredit = dt.AsEnumerable().Sum(x => x.IsNull("Credit") ? 0 : Convert.ToDecimal(x["Credit"]));
            }

            var balance = totalDebet - totalKredit;

            LblTotal.Text = balance.ToString("c3", CultureInfo.GetCultureInfo("id-ID"));
        }

        public void ExportToCSv(string fileName)
        {
            var sb = new StringBuilder();
            var columnHeader = String.Empty;

            // headers
            foreach (DataGridViewColumn column in GVSaving.Columns)
            {
                if (column.Visible)
                {
                    columnHeader += column.Name + ",";
                }
            }

            sb.Append(columnHeader);
            if (sb.Length > 0)
            {
                sb.Length--;
            }
            sb.Append(Environment.NewLine);

            // data
            foreach (DataGridViewRow row in GVSaving.Rows)
            {
                if (row.Index < GVSaving.Rows.Count - 1)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible)
                        {
                            sb.Append(cell.Value + ",");
                        }
                    }

                    if (sb.Length > 0)
                    {
                        sb.Length--;
                    }
                    sb.Append(Environment.NewLine);
                }
            }

            sb.Append(Environment.NewLine);

            sb.Append("Balance, " + LblTotal.Text.Replace(".", "").Replace(",", "."));

            using (var sw = new StreamWriter(fileName))
            {
                sw.Write(sb.ToString());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rowsToDelete =
                (
                    from DataGridViewRow row in GVSaving.SelectedRows
                    select row.Cells[0].Value
                ).ToList();

            var message = String.Format(TMConstants.Dialog.DELETE, string.Join(",", rowsToDelete));
            var ans = MessageBox.Show(this, message, TMConstants.Dialog.Captions.WARNING, MessageBoxButtons.YesNo);

            if (ans != DialogResult.Yes) return;

            foreach (var id in rowsToDelete)
            {
                ModuleManager.GetInstance().Delete(TMConstants.Table.SAVINGS, "\"SavingsId\"='" + id + "'");
            }

            _LoadData();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (GVSaving.SelectedRows.Count != 1)
            {
                MessageBox.Show(this, TMConstants.Dialog.MANY_SELECTION, TMConstants.Dialog.Captions.WARNING,
                    MessageBoxButtons.OK);
            }
            else
            {
                SavingsId = GVSaving.SelectedRows[0].Cells[0].Value.ToString();
                var savForms = new SavingsEdit();
                savForms.Closed += propFormClosed;
                savForms.Show();
            }
        }

        private void _LoadComboBox()
        {
            ComboNames.Items.AddRange(Utility.GetEmployees().Cast<object>().ToArray());
            ComboNames.SelectedIndex = 0;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            _LoadData();
            _SetDataViewProperties();
        }

        private void _DisableButtons()
        {
            BtnCredit.Enabled = false;
            BtnDebet.Enabled = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            LblActiveUser.Text = "None";
        }

        private void _EnableButtons()
        {
            BtnCredit.Enabled = true;
            BtnDebet.Enabled = true;
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            LblActiveUser.Text = "Name: " + ((Business.DataModel.Employee) ComboNames.SelectedItem).Text;
        }
    }
}
