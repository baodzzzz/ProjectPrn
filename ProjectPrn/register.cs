﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using ProjectPrn.Models;

namespace ProjectPrn
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        
        public bool CheckAccount(String ac) //check tk va mk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
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
            return Regex.IsMatch(mobile, @"^\d{9,11}$");
        }
        public bool CheckCCCD(string cd)
        {
            return Regex.IsMatch(cd, "^([ 0-9]){12}$");
        }
        public static string RandomChar(int numberRD)
        {
            string randomStr = "";
            try
            {
                string[] myIntArray = new string[numberRD];
                int x;
                //that is to create the random # and add it to uour string
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = Convert.ToChar(Convert.ToInt32(autoRand.Next(65, 87))).ToString();
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception ex)
            {
                randomStr = "error";
            }
            return randomStr;
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        private void btDky_Click(object sender, EventArgs e)
        {
            ProjectPrnContext context = new ProjectPrnContext();
            string fullname = tbFullName.Text;
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            string repass = tbRePassword.Text;
            if (!CheckAccount(username))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự!");
                return;
            }
            if (!CheckAccount(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự!");
                return;
            }
            if (repass != password) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            string email = tbEmail.Text;
            if (!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email (abc@gmail.com)!");
                return;
            }
            //check email da ton tai chua
            User user = context.Users.FirstOrDefault(c => c.Email == tbEmail.Text);
            // var result = from c in context.Users select new { c.Email, email };
            if (user != null) { MessageBox.Show("Email đã tồn tại!"); return; }

            string mobile = tbMobile.Text;
            if (!CheckMobile(mobile))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại dài từ 9-11 số!");
                return;
            }
            string cd = tbCd.Text;
            if (!CheckCCCD(cd))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng CCCD dài từ 12 số!");
                return;
            }
            string adress = tbAdress.Text;
            string dob = dtPDOb.Text;
            bool gender = male.Checked ? true : false;

            User u = new User();
            u.Fullname = fullname;
            u.Username = username;
            u.Password = password;
            u.Email = email;
            u.RoleId = 1;
            u.Mobile = mobile;
            u.Cccd = cd;
            u.Address = adress;
            u.Dob = dob;
            u.Gender = gender ? 1 : 0;
            u.Verify = 0;
            SetValueForText1 = email;

            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential("baodz686868@gmail.com", "Bao12345678");

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("baodz686868@gmail.com");
                mailDetails.To.Add(tbEmail.Text.Trim());

                mailDetails.Subject = "Code của bạn";
                mailDetails.Body = RandomChar(6);
                SetValueForText2 = mailDetails.Body;
                clientDetails.Send(mailDetails);
                context.Users.Add(u);
                context.SaveChanges();
                if (MessageBox.Show("Đăng ký thành công? Bạn cần xác minh tài khoản để được đăng nhập!!!", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fVerify fverify = new fVerify();
                    fverify.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "xác nhận", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {

                login login = new login();
                login.Show();
                this.Hide();

            }
        }
    }
}
