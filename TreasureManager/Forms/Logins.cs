using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreasureManager.Business.Manager;
using TreasureManager.Business.Utils;

namespace TreasureManager.Forms
{
    public partial class Logins : Form
    {
        private DataTable dt;
        public Logins()
        {
            InitializeComponent();
        }

        private void Logins_Load(object sender, EventArgs e)
        {
            dt = ModuleManager.GetInstance().Select(TMConstants.Table.LOGINS, "", "\"Username\", \"pass\", \"id\"");
            TxtUsername.Text = dt.Rows[0][0].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var username = Utility.Escape(TxtUsername.Text);
            var pass1 = Utility.Escape(TxtPassword.Text);
            var pass2 = Utility.Escape(TxtRePassword.Text);

            if ((String.IsNullOrEmpty(pass1) && string.IsNullOrEmpty(pass2) || String.IsNullOrEmpty(username)))
            {
                _SetErrorMessage("Username/Password tidak boleh kosong");
            }
            else
            {
                if (!pass1.Equals(pass2))
                {
                    _SetErrorMessage("Password dan Re-Password tidak sama");
                }
                else
                {
                    var pass = Utility.ComputeHash(pass1, new SHA512Cng());

                    ModuleManager.GetInstance().Update(TMConstants.Table.LOGINS, "\"Username\" = '" + username + "', \"pass\" = '" + pass + "'", "\"id\"='" + dt.Rows[0][2] + "'");

                    _SetSuccessMessage("Login info berhasil di update");
                }
            }
        }

        private void _SetErrorMessage(string message)
        {
            LblMessage.Text = message;
            LblMessage.ForeColor = Color.Red;
            LblMessage.Visible = true;
        }

        private void _SetSuccessMessage(string message)
        {
            LblMessage.Text = message;
            LblMessage.ForeColor = Color.Green;
            LblMessage.Visible = true;
        }

        private void ChkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPass.Checked)
            {
                TxtPassword.PasswordChar = (char) 0;
                TxtRePassword.PasswordChar = (char) 0;
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                TxtRePassword.PasswordChar = '*';
            }
        }
    }
}
