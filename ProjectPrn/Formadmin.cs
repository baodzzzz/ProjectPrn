using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPrn
{
    public partial class Formadmin : Form
    {
        ProjectPrnContext db = new ProjectPrnContext();

        public Formadmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmain f = new frmain();
                f.Show();
                this.Hide();
            }
        }

        private void Formadmin_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btRefresh.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = db.Users.ToList();
        }
        private void ResetValues()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtCcCd.Text = "";
            mtbMobi.Text = "";
            mtbDob.Text = "";
            rbFmale.Checked = false;
            rbMale.Checked = false;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dgvUser.CurrentRow.Cells["id"].Value.ToString();
            txtName.Text = dgvUser.CurrentRow.Cells["fullname"].Value.ToString();
            txtEmail.Text = dgvUser.CurrentRow.Cells["email"].Value.ToString();
            mtbMobi.Text = dgvUser.CurrentRow.Cells["mobile"].Value.ToString();
            txtCcCd.Text = dgvUser.CurrentRow.Cells["cccd"].Value.ToString();
            txtAddress.Text = dgvUser.CurrentRow.Cells["address"].Value.ToString();
            mtbDob.Text = dgvUser.CurrentRow.Cells["dob"].Value.ToString();
            if (Convert.ToInt32(dgvUser.CurrentRow.Cells["gender"].Value.ToString()) == 1)
            {
                rbMale.Checked = true;
            }
            else rbFmale.Checked = true;
            btEdit.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var result = db.Users.Single(u => u.Id == Convert.ToInt32(txtId.Text));
                db.Users.Remove(result);
                db.SaveChanges();
                LoadDataGridView();
                ResetValues();
            }
        }
        public bool CheckCCCD(string cd)
        {
            return Regex.IsMatch(cd, "^([0-9]){12}$");
        }

        public bool CheckEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool CheckMobile(String mobile)
        {
            return Regex.IsMatch(mobile, @"^\(\d{3}\)\s\d{3}-\d{4}");
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            if (!CheckMobile(mtbMobi.Text))
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbMobi.Focus();
                return;
            }
            if (mtbDob.Text == "   /   /    ")
            {
                MessageBox.Show("Bạn phải đầy đủ họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDob.Focus();
                return;
            }
            if (!CheckEmail(txtEmail.Text))
            {
                MessageBox.Show("Bạn phải đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDob.Focus();
                return;
            }

            User user = db.Users.FirstOrDefault(u => u.Email == txtEmail.Text);
            if (user != null && user.Id != Convert.ToInt32(txtId.Text)) { MessageBox.Show("Email đã tồn tại!"); return; }

            if (!CheckCCCD(txtCcCd.Text))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng CCCD dài từ 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCcCd.Focus();
                return;
            }
            User u1 = db.Users.Single(u => u.Id == Convert.ToInt32(txtId.Text));
            u1.Id = Convert.ToInt32(txtId.Text);
            u1.Mobile = mtbMobi.Text;
            u1.Fullname = txtName.Text;
            u1.Email = txtEmail.Text;
            u1.Dob = mtbDob.Text;
            u1.Cccd = txtCcCd.Text;
            u1.Address = txtAddress.Text;
            u1.Gender = rbMale.Checked ? 1 : 0;
            db.SaveChanges();
            LoadDataGridView();
            ResetValues();
            btRefresh.Enabled = false;
            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btRefresh.Enabled = false;
                return;
            }
            ResetValues();

        }


    }
}
