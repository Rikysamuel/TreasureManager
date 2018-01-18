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
using TreasureManager.Forms.CRUD;

namespace TreasureManager.Forms
{
    public partial class Employee : Form
    {
        public static string EmployeeId { get; set; }
        public Employee()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var userForms = new EmployeeEdit();
            userForms.Closed += propFormClosed;
            userForms.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            _LoadData();
            _SetDataViewProperties();
        }

        private void propFormClosed(object sender, EventArgs e)
        {
            EmployeeId = String.Empty;
            _LoadData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var rowsToDelete =
                (
                    from DataGridViewRow row in GVEmployee.SelectedRows
                    select row.Cells[0].Value
                ).ToList();

            var message = String.Format(TMConstants.Dialog.DELETE, string.Join(",", rowsToDelete));
            var ans = MessageBox.Show(this, message, TMConstants.Dialog.Captions.WARNING, MessageBoxButtons.YesNo);

            if (ans != DialogResult.Yes) return;

            foreach (var id in rowsToDelete)
            {
                ModuleManager.GetInstance().Delete(TMConstants.Table.EMPLOYEE, "\"UserId\"='" + id + "'");
            }

            _LoadData();
        }

        private void _LoadData()
        {
            string selection = "\"UserId\", \"Name\", \"BirthPlace\", \"BirthDate\", \"Address\", \"Phone\"";
            GVEmployee.DataSource = ModuleManager.GetInstance().Select(TMConstants.Table.EMPLOYEE, "", selection);
        }

        private void _SetDataViewProperties()
        {
            GVEmployee.Columns[0].HeaderText = "User Id";
            GVEmployee.Columns[1].HeaderText = "Nama";
            GVEmployee.Columns[2].HeaderText = "Tempat Lahir";
            GVEmployee.Columns[3].HeaderText = "Tanggal Lahir";
            GVEmployee.Columns[4].HeaderText = "Alamat";
            GVEmployee.Columns[5].HeaderText = "Telepon";

            foreach (DataGridViewColumn gvSavingColumn in GVEmployee.Columns)
            {
                gvSavingColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvSavingColumn.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15F, GraphicsUnit.Pixel);
            }

            GVEmployee.ReadOnly = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (GVEmployee.SelectedRows.Count != 1)
            {
                MessageBox.Show(this, TMConstants.Dialog.MANY_SELECTION, TMConstants.Dialog.Captions.WARNING,
                    MessageBoxButtons.OK);
            }
            else
            {
                EmployeeId = GVEmployee.SelectedRows[0].Cells[0].Value.ToString();
                var empForm = new EmployeeEdit();
                empForm.Closed += propFormClosed;
                empForm.Show();
            }
        }
    }
}
