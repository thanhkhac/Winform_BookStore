namespace MiniProject_BookStore
{
    partial class AccountManagement
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
            dgv = new DataGridView();
            label5 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            checkAdmin = new CheckBox();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = SystemColors.GradientActiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(38, 81);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(421, 347);
            dgv.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(232, 27);
            label5.Name = "label5";
            label5.Size = new Size(326, 41);
            label5.TabIndex = 16;
            label5.Text = "Account management";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(135, 58);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(160, 27);
            txtUsername.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(133, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(162, 27);
            txtPassword.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.Location = new Point(25, 192);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.Location = new Point(186, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 29);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 65);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 21;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 22;
            label2.Text = "Password";
            // 
            // checkAdmin
            // 
            checkAdmin.AutoSize = true;
            checkAdmin.Location = new Point(135, 150);
            checkAdmin.Name = "checkAdmin";
            checkAdmin.Size = new Size(75, 24);
            checkAdmin.TabIndex = 23;
            checkAdmin.Text = "Admin";
            checkAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkAdmin);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(465, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 357);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(25, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 29);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(dgv);
            Name = "AccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManagement";
            Load += AccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private CheckBox checkAdmin;
        private GroupBox groupBox1;
        private Button btnDelete;
    }
}