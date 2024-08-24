using QuanLyShopDoChoi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopDoChoi
{
    public partial class frmChangePass : Form
    {
        public string UserName { get; set; }

        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill all info");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password are not the same");
                return;
            }
            string sql;
            sql = $"SELECT * FROM Account where Username = '{UserName}'";
            var datatbl = Function.GetDataToTable(sql);
            if(datatbl.Rows.Count == 0)
            {
                MessageBox.Show("Password is incorrect, please try again!");
                return;
            }

            string sqlChangePass = $"update Account set Password= N'{newPassword}' Where Username = '{UserName}'";
            Function.RunSQL(sqlChangePass);

            MessageBox.Show("Update successful");

            this.Close();
        }
    }
}
