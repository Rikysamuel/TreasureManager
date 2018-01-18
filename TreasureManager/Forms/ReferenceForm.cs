using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreasureManager.Business.Manager;
using TreasureManager.Business.Utils;
using TreasureManager.Forms.Master;

namespace TreasureManager.Forms
{
    public partial class ReferenceForm : Form
    {
        public ReferenceForm()
        {
            InitializeComponent();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            rbProperty.Checked = true;
            LoadProperties();
        }

        private void rbProperty_CheckedChanged(object sender, EventArgs e)
        {
            LoadProperties();
        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {
            LoadSavings();
        }

        private void rbDeposito_CheckedChanged(object sender, EventArgs e)
        {
            GVReferences.DataSource = null;
        }

        private void LoadProperties()
        {
            var selection = "\"TransactionId\", \"PropertyName\", \"Description\", \"Remarks\", \"Year\", \"Value\", \"ReferenceId\", \"Status\", \"UserId\"";
            var where = "\"ReferenceId\" LIKE '%" + TxtRefId.Text + "%'";
            GVReferences.DataSource = ModuleManager.GetInstance().Select(TMConstants.Table.PROPERTY, where, selection);

            foreach (DataGridViewRow row in GVReferences.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    if (row.Cells[7].Value.ToString().Equals("False"))
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                }
            }

            GVReferences.Columns[0].HeaderText = "Id";
            GVReferences.Columns[1].HeaderText = "Nama Properti";
            GVReferences.Columns[2].HeaderText = "Deskripsi";
            GVReferences.Columns[3].HeaderText = "Keterangan";
            GVReferences.Columns[4].HeaderText = "Tahun Perolehan";
            GVReferences.Columns[5].HeaderText = "Harga Perolehan";
            GVReferences.Columns[6].HeaderText = "Reference Id";
            GVReferences.Columns[7].HeaderText = "Status";
            GVReferences.Columns[8].HeaderText = "User Id";

            GVReferences.Columns[5].DefaultCellStyle.Format = "c3";
            GVReferences.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            GVReferences.Columns[7].Visible = false;

            foreach (DataGridViewColumn gvSavingColumn in GVReferences.Columns)
            {
                gvSavingColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvSavingColumn.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15F, GraphicsUnit.Pixel);
            }
        }

        private void LoadSavings()
        {
            var selection = "\"SavingsId\", \"Remarks\", \"Debet\", \"Credit\", \"Tanggal\", \"ReferenceId\", \"UserId\"";
            var where = "\"ReferenceId\" LIKE '%" + TxtRefId.Text + "%'";

            GVReferences.DataSource = ModuleManager.GetInstance().Select(TMConstants.Table.SAVINGS, where, selection);

            GVReferences.Columns[0].HeaderText = "Id";
            GVReferences.Columns[0].HeaderText = "Id";
            GVReferences.Columns[1].HeaderText = "Keterangan";
            GVReferences.Columns[2].HeaderText = "Debet";
            GVReferences.Columns[3].HeaderText = "Kredit";
            GVReferences.Columns[4].HeaderText = "Tanggal";
            GVReferences.Columns[5].HeaderText = "Reference Id";

            GVReferences.Columns[2].DefaultCellStyle.Format = "c3";
            GVReferences.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");

            GVReferences.Columns[3].DefaultCellStyle.Format = "c3";
            GVReferences.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");

            foreach (DataGridViewColumn gvSavingColumn in GVReferences.Columns)
            {
                gvSavingColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvSavingColumn.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15F, GraphicsUnit.Pixel);
            }
        }
    }
}
