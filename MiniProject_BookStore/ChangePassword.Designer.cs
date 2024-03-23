namespace MiniProject_BookStore
{
    partial class ChangePassword
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
            label5 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtOldPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtConfirm = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(241, 43);
            label5.Name = "label5";
            label5.Size = new Size(266, 41);
            label5.TabIndex = 15;
            label5.Text = "Change password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(316, 341);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(191, 40);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "Change password";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(294, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(303, 34);
            txtPassword.TabIndex = 23;
            // 
            // txtOldPass
            // 
            txtOldPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPass.Location = new Point(294, 133);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(303, 34);
            txtOldPass.TabIndex = 22;
            txtOldPass.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(177, 217);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 133);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 20;
            label1.Text = "Old password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(149, 204);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 25;
            label3.Text = "New password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(149, 276);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 28;
            label4.Text = "Confirm";
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirm.Location = new Point(294, 270);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(303, 34);
            txtConfirm.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(177, 289);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 26;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtConfirm);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtOldPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtOldPass;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtConfirm;
        private Label label6;
    }
}