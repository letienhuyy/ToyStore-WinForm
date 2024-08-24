using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopDoChoi.Class;
using System.Data.SqlClient;
using System.Collections;

namespace QuanLyShopDoChoi
{
    public partial class UC_Account : UserControl
    {
        DataTable datatbl;
        public UC_Account()
        {
            InitializeComponent();
        }
        private bool CheckID()
        {
            string query = "SELECT Username FROM Account WHERE Username = N'" + dgvAccount.SelectedCells[0].Value.ToString() + "'";

            if (Function.GetFieldValue(query) == txtUsername.Text)
            {
                return true;
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" ||  txtFullname.Text == "" || txtPhonenumber.Text == "" || CheckID() == true)
            {
                MessageBox.Show("Add failure");
            }
            else
            {
                string sql = "insert into Account(Username, Password,  Fullname, Phonenumber, Role) values (N'" + txtUsername.Text + "',N'" + txtUsername.Text + "', N'" + txtFullname.Text + "', N'" + txtPhonenumber.Text + "', N'" + cboRole.Text + "')";
                Function.RunSQL(sql);
                LoadDataToDgv();
            }
            ClearText();
        }
        private void UC_Account_Load(object sender, EventArgs e)
        {
            LoadDataToDgv();
        }
        private void LoadDataToDgv()
        {
            string sql;
            sql = "SELECT UserName, FullName, PhoneNumber, Role FROM Account";
            datatbl = Function.GetDataToTable(sql);
            dgvAccount.DataSource = datatbl;
            FillCbb();
            dgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAccount.AllowUserToAddRows = false;
            ClearText();
        }
        private void FillCbb()
        {
            List<string> comboSource = new List<string>();
            comboSource.Add("Staff");
            comboSource.Add("Admin");
            cboRole.DataSource = comboSource;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtFullname.Text == "" || txtPhonenumber.Text == "")
            {
                MessageBox.Show("Update failed");         
            }
            else
            {
                string sql = "update Account set Fullname= N'" + txtFullname.Text + "', Phonenumber= N'" + txtPhonenumber.Text + "', Role= N'" + cboRole.Text + "' where Username= N'" + txtUsername.Text + "'";
                Function.RunSQL(sql);

                MessageBox.Show("Update successful");
                LoadDataToDgv();
            }
            ClearText();
        }                   
        private void dgvAccount_Click(object sender, EventArgs e)
        {
            txtUsername.Text = dgvAccount.SelectedCells[0].Value.ToString();
            txtFullname.Text = dgvAccount.SelectedCells[1].Value.ToString();
            txtPhonenumber.Text = dgvAccount.SelectedCells[2].Value.ToString();
            cboRole.Text = dgvAccount.SelectedCells[3].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 0) return;

            string usname = dgvAccount.SelectedCells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE Account WHERE Username = '" + usname + "'";
                Function.RunSQL(query);
                dgvAccount.Rows.Remove(dgvAccount.SelectedRows[0]);
            }
            ClearText();
        }
        private void ClearText()
        {
            txtUsername.Text = "";
            txtFullname.Text = "";
            txtPhonenumber.Text = "";
            cboRole.SelectedIndex = -1;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            using (frmChangePass changePasswordForm = new frmChangePass())
            {
                changePasswordForm.UserName = dgvAccount.SelectedCells[0].Value.ToString();
                changePasswordForm.ShowDialog();
            }
        }
    }
}
