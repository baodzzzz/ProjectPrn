using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using ProjectPrn.Models;

namespace ProjectPrn
{
    public partial class Fchangepass : Form
    {
        public Fchangepass()
        {

            InitializeComponent();
        }
        private User u;
        private ProjectPrnContext context;
        private void Fchangepass_Load(object sender, EventArgs e)
        {
            context = new ProjectPrnContext();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại");
                tbCurrentPass.Select();
                return;
            }
            if (string.IsNullOrEmpty(tbNewPass.Text) || string.IsNullOrEmpty(tbRePass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
                tbNewPass.Select();
                return;
            }
            if (!tbNewPass.Text.Equals(tbRePass.Text))
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                tbNewPass.Select();
                return;
            }
            var rs = context.Users.SingleOrDefault(x => x.Username == login.SetValueForText3 && x.Password == tbCurrentPass.Text);
            if (rs == null)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng");
                tbCurrentPass.Select();
                return;
            }
            rs.Password = tbNewPass.Text;
            context.SaveChanges();
            MessageBox.Show("Đổi mật khẩu thành công");
            this.Dispose();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(); //dong form
        }
    }
}
