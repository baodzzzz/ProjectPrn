namespace ProjectPrn
{
    partial class formcustomer
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
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.mtxtMobi = new System.Windows.Forms.MaskedTextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(194, 78);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(193, 27);
            this.txtCusID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(564, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 27);
            this.txtAddress.TabIndex = 7;
            // 
            // dgvCus
            // 
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Location = new System.Drawing.Point(67, 186);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.RowHeadersWidth = 51;
            this.dgvCus.RowTemplate.Height = 29;
            this.dgvCus.Size = new System.Drawing.Size(690, 188);
            this.dgvCus.TabIndex = 9;
            this.dgvCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCus_CellClick);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(67, 400);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 29);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(194, 400);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(310, 400);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(94, 29);
            this.btEdit.TabIndex = 12;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(433, 400);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 29);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(663, 400);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 29);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // mtxtMobi
            // 
            this.mtxtMobi.Location = new System.Drawing.Point(564, 129);
            this.mtxtMobi.Mask = "(999) 000-0000";
            this.mtxtMobi.Name = "mtxtMobi";
            this.mtxtMobi.Size = new System.Drawing.Size(193, 27);
            this.mtxtMobi.TabIndex = 15;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(550, 400);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(94, 29);
            this.btRefresh.TabIndex = 16;
            this.btRefresh.Text = "Tải lại";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // formcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.mtxtMobi);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvCus);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formcustomer";
            this.Text = "formcustomer";
            this.Load += new System.EventHandler(this.formcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.MaskedTextBox mtxtMobi;
        private System.Windows.Forms.Button btRefresh;
    }
}