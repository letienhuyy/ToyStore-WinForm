namespace QuanLyShopDoChoi
{
    partial class frmChangePass
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
            this.components = new System.ComponentModel.Container();
            this.oldpass = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.confirmpass = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldpass
            // 
            this.oldpass.AutoSize = true;
            this.oldpass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.oldpass.Location = new System.Drawing.Point(134, 35);
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(145, 23);
            this.oldpass.TabIndex = 0;
            this.oldpass.Text = "Old Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtOldPassword.Location = new System.Drawing.Point(357, 32);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(281, 32);
            this.txtOldPassword.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNewPassword.Location = new System.Drawing.Point(357, 106);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(281, 32);
            this.txtNewPassword.TabIndex = 4;
            // 
            // newpass
            // 
            this.newpass.AutoSize = true;
            this.newpass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.newpass.Location = new System.Drawing.Point(134, 109);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(155, 23);
            this.newpass.TabIndex = 3;
            this.newpass.Text = "New Password";
            this.newpass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(357, 187);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(281, 32);
            this.txtConfirmPassword.TabIndex = 6;
            // 
            // confirmpass
            // 
            this.confirmpass.AutoSize = true;
            this.confirmpass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.confirmpass.Location = new System.Drawing.Point(134, 190);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(184, 23);
            this.confirmpass.TabIndex = 5;
            this.confirmpass.Text = "Confirm Password";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(357, 255);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(108, 33);
            this.btnChange.TabIndex = 59;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.oldpass);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldpass;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label newpass;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label confirmpass;
        private System.Windows.Forms.Button btnChange;
    }
}