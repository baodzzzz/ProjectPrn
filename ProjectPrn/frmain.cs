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
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Close();
            }

        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formadmin fa = new Formadmin();
            fa.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formcustomer fcus = new formcustomer();
            fcus.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        private void frmain_Load(object sender, EventArgs e)
        {
            toolStripSplitButton2.Text = login.SetValueForText3;

            if (login.SetValueForText8.Equals("0"))
            {
                nhanVienToolStripMenuItem.Visible = true;
                khachHangToolStripMenuItem.Visible = true;
            }
            else
            {
                nhanVienToolStripMenuItem.Visible = false;
            }


        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fchangepass fchangepass = new Fchangepass();
            fchangepass.ShowDialog();

        }
    }
}
