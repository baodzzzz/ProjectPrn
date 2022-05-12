using ProjectPrn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPrn
{
    public partial class formcustomer : Form
    {

        ProjectPrnContext db = new ProjectPrnContext();
        public formcustomer()
        {
            InitializeComponent();
        }

        private void formcustomer_Load(object sender, EventArgs e)
        {
            txtCusID.Enabled = false;
            btRefresh.Enabled = false;
            btSave.Enabled = false;
            LoaDataGridView();
        }
        private void LoaDataGridView()
        {
            dgvCus.DataSource = db.Customers.ToList();
            dgvCus.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvCus.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvCus.Columns[2].HeaderText = "Địa Chỉ";
            dgvCus.Columns[3].HeaderText = "Số Điện Thoại";
        }

        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btAdd.Enabled == false)
            {
                MessageBox.Show("Thêm Khách Hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCusID.Focus();
                return;
            }
            txtCusID.Text = dgvCus.CurrentRow.Cells["cid"].Value.ToString();
            txtAddress.Text = dgvCus.CurrentRow.Cells["caddress"].Value.ToString();
            txtName.Text = dgvCus.CurrentRow.Cells["cname"].Value.ToString();
            mtxtMobi.Text = dgvCus.CurrentRow.Cells["cmobile"].Value.ToString();

            btEdit.Enabled = true;
            btDelete.Enabled = true;
            btRefresh.Enabled = true;
        }
        private void ResetValues()
        {
            txtCusID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            mtxtMobi.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            btEdit.Enabled = false;
            btDelete.Enabled = false;
            btRefresh.Enabled = true;
            btSave.Enabled = true;
            btAdd.Enabled = false;
            ResetValues();
            txtCusID.Enabled = true;
            txtCusID.Focus();
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCusID.Focus();
                return;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            if (mtxtMobi.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtMobi.Focus();
                return;
            }
            //check mã khách hàng tồn tại?
            var result = db.Customers.FirstOrDefault(x => x.Cid == txtCusID.Text);
            if (result != null)
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCusID.Focus();
                return;
            }
            else
            {
                Customer customer = new Customer();
                customer.Cid = txtCusID.Text;
                customer.Cname = txtName.Text;
                customer.Caddress = txtAddress.Text;
                customer.Cmobile = mtxtMobi.Text;
                db.Customers.Add(customer);
                db.SaveChanges();
                LoaDataGridView();
                ResetValues();
                btDelete.Enabled = true;
                btAdd.Enabled = true;
                btEdit.Enabled = true;
                btRefresh.Enabled = false;
                btSave.Enabled = false;
                txtCusID.Enabled = false;
                MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            if (mtxtMobi.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtMobi.Focus();
                return;
            }


            Customer customer1 = db.Customers.Single(c => c.Cid == txtCusID.Text);
            customer1.Cid = txtCusID.Text;
            customer1.Cname = txtName.Text;
            customer1.Caddress = txtAddress.Text;
            customer1.Cmobile = mtxtMobi.Text;
            db.SaveChanges();
            LoaDataGridView();
            ResetValues();
            btRefresh.Enabled = false;


        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var result = db.Customers.Single(c => c.Cid == txtCusID.Text);
                db.Customers.Remove(result);
                db.SaveChanges();
                LoaDataGridView();
                ResetValues();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (btAdd.Enabled == false && MessageBox.Show("Bạn có muốn thoát thêm mới không?", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btAdd.Enabled = true;
            }
            else if (MessageBox.Show("Bạn có muốn thoát không?", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmain f = new frmain();
                f.Show();
                this.Hide();
            }
        }
    }
}
