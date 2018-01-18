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

namespace TreasureManager.Forms.Secure
{
    public partial class Password : Form
    {
        public static bool success { get; set; }
        public Password()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = Utility.Escape(TxtUsername.Text);
            var password = Utility.Escape(TxtPassword.Text);

            var dt = ModuleManager.GetInstance().Select(TMConstants.Table.LOGINS, "", "\"Username\", \"pass\"");

            foreach (DataRow dtRow in dt.Rows)
            {
                if (username.Equals(dtRow[0]))
                {
                    var hashedPass = Utility.ComputeHash(password, new SHA512Cng());
                    success = hashedPass.Equals(dtRow[1]);
                    break;
                }
            }

            if (success)
            {
                this.Close();
            }
            else
            {
                LblLoginValidation.Visible = true;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            success = false;
            this.Close();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.BringToFront();
        }
    }
}
