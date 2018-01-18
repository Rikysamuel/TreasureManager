using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TreasureManager.Business.Manager;
using TreasureManager.Business.Manager.Form;
using TreasureManager.Business.Utils;
using TreasureManager.Forms.CRUD;

namespace TreasureManager.Forms
{
    public partial class PropertyForm : Form, IFormBehavior
    {
        public static string PropertyId { get; set; }
        public static Business.DataModel.Employee UserId { get; set; }

        public static bool ShowAll;

        public PropertyForm()
        {
            InitializeComponent();
            _LoadComboBox();
        }

        private void PropertyForm_Load(object sender, EventArgs e)
        {
            _LoadData(ShowAll);
            _SetDataViewProperties();
        }

        private void _SetDataViewProperties()
        {
            GVProperty.Columns[0].HeaderText = "No";
            GVProperty.Columns[1].HeaderText = "Id";
            GVProperty.Columns[2].HeaderText = "Nama Properti";
            GVProperty.Columns[3].HeaderText = "Deskripsi";
            GVProperty.Columns[4].HeaderText = "Keterangan";
            GVProperty.Columns[5].HeaderText = "Tahun Perolehan";
            GVProperty.Columns[6].HeaderText = "Harga Perolehan";
            GVProperty.Columns[7].HeaderText = "Reference Id";

            foreach (DataGridViewColumn gvSavingColumn in GVProperty.Columns)
            {
                gvSavingColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvSavingColumn.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15F, GraphicsUnit.Pixel);
            }

            GVProperty.Columns[0].Visible = false;

            GVProperty.Columns[6].DefaultCellStyle.Format = "c3";
            GVProperty.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");

            GVProperty.ReadOnly = true;
        }

        private void _LoadData(bool showAll)
        {
            string selection = "\"Id\", \"TransactionId\", \"PropertyName\", \"Description\", \"Remarks\", \"Year\", \"Value\", \"ReferenceId\"";

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
                if (showAll)
                {
                    selection = "\"Id\", \"TransactionId\", \"PropertyName\", \"Description\", \"Remarks\", \"Year\", \"Value\", \"ReferenceId\", \"Status\"";
                    GVProperty.DataSource = ModuleManager.GetInstance().Select("Property", "\"UserId\"='" + UserId.Value + "'", selection);
                }
                else
                {
                    GVProperty.DataSource = ModuleManager.GetInstance().Select("Property", "\"Status\"=true AND \"UserId\"='" + UserId.Value + "'", selection);
                }
            }

            if (GVProperty.ColumnCount > 8)
            {
                GVProperty.Columns[8].Visible = false;

                foreach (DataGridViewRow row in GVProperty.Rows)
                {
                    if (row.Cells[8].Value != null && row.Cells[8].Value.ToString().Equals("False"))
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var propForm = new PropertyEdit();
            propForm.Closed += propFormClosed;
            propForm.Show();
        }

        private void propFormClosed(object sender, EventArgs e)
        {
            PropertyId = String.Empty;
            _LoadData(ShowAll);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rowsToDelete =
                (
                    from DataGridViewRow row in GVProperty.SelectedRows
                    select row.Cells[1].Value
                ).ToList();

            var message = String.Format(TMConstants.Dialog.DELETE, string.Join(",", rowsToDelete));
            var ans = MessageBox.Show(this, message, TMConstants.Dialog.Captions.WARNING, MessageBoxButtons.YesNo);

            if (ans != DialogResult.Yes) return;

            foreach (var id in rowsToDelete)
            {
                ModuleManager.GetInstance().Delete(TMConstants.Table.PROPERTY, "\"TransactionId\"='" + id + "'");
            }

            _LoadData(ShowAll);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (GVProperty.SelectedRows.Count != 1)
            {
                MessageBox.Show(this, TMConstants.Dialog.MANY_SELECTION, TMConstants.Dialog.Captions.WARNING,
                    MessageBoxButtons.OK);
            }
            else
            {
                PropertyId = GVProperty.SelectedRows[0].Cells[0].Value.ToString();
                var propForm = new PropertyEdit();
                propForm.Closed += propFormClosed;
                propForm.Show();
            }
        }

        public void ExportToCSv(string fileName)
        {
            var sb = new StringBuilder();
            var columnHeader = String.Empty;

            // headers
            foreach (DataGridViewColumn column in GVProperty.Columns)
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
            foreach (DataGridViewRow row in GVProperty.Rows)
            {
                if (row.Index < GVProperty.Rows.Count - 1)
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

            using (var sw = new StreamWriter(fileName))
            {
                sw.Write(sb.ToString());
            }
        }

        private void _LoadComboBox()
        {
            ComboNames.Items.AddRange(Utility.GetEmployees().Cast<object>().ToArray());
            ComboNames.SelectedIndex = 0;
        }

        private void _DisableButtons()
        {
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            LblActiveUser.Text = "None";
        }

        private void _EnableButtons()
        {
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = true;
            BtnEdit.Enabled = true;
            LblActiveUser.Text = "Name: " + ((Business.DataModel.Employee)ComboNames.SelectedItem).Text;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            _LoadData(ShowAll);
            _SetDataViewProperties();
        }

        private void ChckSold_CheckedChanged(object sender, EventArgs e)
        {
            ShowAll = ChckSold.Checked;

            _LoadData(ShowAll);
        }
    }
}
