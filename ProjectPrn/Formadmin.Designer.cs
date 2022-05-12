namespace ProjectPrn
{
    partial class Formadmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCcCd = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFmale = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mtbMobi = new System.Windows.Forms.MaskedTextBox();
            this.mtbDob = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(350, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "CCCD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "SDT";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(428, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 27);
            this.txtEmail.TabIndex = 12;
            // 
            // txtCcCd
            // 
            this.txtCcCd.Location = new System.Drawing.Point(428, 120);
            this.txtCcCd.Name = "txtCcCd";
            this.txtCcCd.Size = new System.Drawing.Size(199, 27);
            this.txtCcCd.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(715, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 27);
            this.txtAddress.TabIndex = 14;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(117, 173);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 24);
            this.rbMale.TabIndex = 17;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFmale
            // 
            this.rbFmale.AutoSize = true;
            this.rbFmale.Location = new System.Drawing.Point(205, 173);
            this.rbFmale.Name = "rbFmale";
            this.rbFmale.Size = new System.Drawing.Size(50, 24);
            this.rbFmale.TabIndex = 18;
            this.rbFmale.TabStop = true;
            this.rbFmale.Text = "Nữ";
            this.rbFmale.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(199, 27);
            this.txtId.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 27);
            this.txtName.TabIndex = 20;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.email,
            this.mobile,
            this.cccd,
            this.address,
            this.gender,
            this.dob});
            this.dgvUser.Location = new System.Drawing.Point(12, 222);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.Size = new System.Drawing.Size(1051, 258);
            this.dgvUser.TabIndex = 21;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Họ và Tên";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "SDT";
            this.mobile.MinimumWidth = 6;
            this.mobile.Name = "mobile";
            this.mobile.Width = 125;
            // 
            // cccd
            // 
            this.cccd.DataPropertyName = "cccd";
            this.cccd.HeaderText = "CCCD";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            this.cccd.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa Chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.FalseValue = "Nữ";
            this.gender.HeaderText = "Giới Tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.TrueValue = "Nam";
            this.gender.Width = 125;
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Ngày Sinh";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.Width = 125;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(85, 517);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(284, 517);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(94, 29);
            this.btEdit.TabIndex = 23;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(820, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 25;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mtbMobi
            // 
            this.mtbMobi.Location = new System.Drawing.Point(715, 66);
            this.mtbMobi.Mask = "(999) 000-0000";
            this.mtbMobi.Name = "mtbMobi";
            this.mtbMobi.Size = new System.Drawing.Size(199, 27);
            this.mtbMobi.TabIndex = 26;
            // 
            // mtbDob
            // 
            this.mtbDob.Location = new System.Drawing.Point(428, 172);
            this.mtbDob.Mask = "00/00/0000";
            this.mtbDob.Name = "mtbDob";
            this.mtbDob.Size = new System.Drawing.Size(199, 27);
            this.mtbDob.TabIndex = 27;
            this.mtbDob.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ngày sinh";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(580, 517);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(94, 29);
            this.btRefresh.TabIndex = 30;
            this.btRefresh.Text = "Tải lại";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Formadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 568);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtbDob);
            this.Controls.Add(this.mtbMobi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.rbFmale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCcCd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formadmin";
            this.Text = "Formadmin";
            this.Load += new System.EventHandler(this.Formadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCcCd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFmale;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox mtbMobi;
        private System.Windows.Forms.MaskedTextBox mtbDob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
    }
}