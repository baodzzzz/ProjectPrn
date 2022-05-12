namespace ProjectPrn
{
    partial class forgotpass
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email đăng ký";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(172, 41);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 27);
            this.tbEmail.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lấy lại mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(172, 143);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(203, 27);
            this.tbCode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // forgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Name = "forgotpass";
            this.Text = "forgotpass";
            this.Load += new System.EventHandler(this.forgotpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label3;
    }
}