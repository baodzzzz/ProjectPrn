namespace ProjectPrn
{
    partial class Fchangepass
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
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbRePass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCurrentPass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xác Nhận Mật Khẩu Mới";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(243, 134);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(182, 27);
            this.tbNewPass.TabIndex = 2;
            // 
            // tbRePass
            // 
            this.tbRePass.Location = new System.Drawing.Point(243, 217);
            this.tbRePass.Name = "tbRePass";
            this.tbRePass.PasswordChar = '*';
            this.tbRePass.Size = new System.Drawing.Size(182, 27);
            this.tbRePass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu Hiện Tại";
            // 
            // tbCurrentPass
            // 
            this.tbCurrentPass.Location = new System.Drawing.Point(243, 60);
            this.tbCurrentPass.Name = "tbCurrentPass";
            this.tbCurrentPass.PasswordChar = '*';
            this.tbCurrentPass.Size = new System.Drawing.Size(182, 27);
            this.tbCurrentPass.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fchangepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbCurrentPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbRePass);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fchangepass";
            this.Text = "Fchangepass";
            this.Load += new System.EventHandler(this.Fchangepass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbRePass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCurrentPass;
        private System.Windows.Forms.Button button2;
    }
}