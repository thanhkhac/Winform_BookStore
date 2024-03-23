namespace MiniProject_BookStore
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            addNewAccountToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            dgvInvoice = new DataGridView();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            invoicePageNumber = new NumericUpDown();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            tabBook = new TabPage();
            dgvBook = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            numPageIndex = new NumericUpDown();
            cboBookType = new ComboBox();
            txtName = new TextBox();
            txtAuthor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoicePageNumber).BeginInit();
            tabBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPageIndex).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1090, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, addNewAccountToolStripMenuItem, logOutToolStripMenuItem1 });
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(77, 24);
            logoutToolStripMenuItem.Text = "Account";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(238, 26);
            changePasswordToolStripMenuItem.Text = "Change password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // addNewAccountToolStripMenuItem
            // 
            addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            addNewAccountToolStripMenuItem.Size = new Size(238, 26);
            addNewAccountToolStripMenuItem.Text = "Account management";
            addNewAccountToolStripMenuItem.Click += addNewAccountToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(238, 26);
            logOutToolStripMenuItem1.Text = "Log out";
            logOutToolStripMenuItem1.Click += logOutToolStripMenuItem1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(invoicePageNumber);
            tabPage2.Controls.Add(btnNextPage);
            tabPage2.Controls.Add(btnPreviousPage);
            tabPage2.Controls.Add(dgvInvoice);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1058, 613);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Invoice management";
            // 
            // dgvInvoice
            // 
            dgvInvoice.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(6, 112);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.RowTemplate.Height = 29;
            dgvInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoice.Size = new Size(1046, 378);
            dgvInvoice.TabIndex = 0;
            dgvInvoice.CellDoubleClick += dgvInvoice_CellDoubleClick;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = Color.Gold;
            btnPreviousPage.Location = new Point(773, 496);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 1;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.Gold;
            btnNextPage.Location = new Point(940, 496);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // invoicePageNumber
            // 
            invoicePageNumber.Location = new Point(873, 496);
            invoicePageNumber.Name = "invoicePageNumber";
            invoicePageNumber.Size = new Size(61, 27);
            invoicePageNumber.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(404, 36);
            label6.Name = "label6";
            label6.Size = new Size(312, 41);
            label6.TabIndex = 4;
            label6.Text = "Invoice management";
            // 
            // button4
            // 
            button4.BackColor = Color.OliveDrab;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(106, 546);
            button4.Name = "button4";
            button4.Size = new Size(94, 51);
            button4.TabIndex = 6;
            button4.Text = "Add new";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(6, 546);
            button3.Name = "button3";
            button3.Size = new Size(94, 51);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tabBook
            // 
            tabBook.BackColor = SystemColors.GradientActiveCaption;
            tabBook.Controls.Add(button5);
            tabBook.Controls.Add(button2);
            tabBook.Controls.Add(button1);
            tabBook.Controls.Add(txtID);
            tabBook.Controls.Add(label5);
            tabBook.Controls.Add(label4);
            tabBook.Controls.Add(label3);
            tabBook.Controls.Add(label2);
            tabBook.Controls.Add(label1);
            tabBook.Controls.Add(txtAuthor);
            tabBook.Controls.Add(txtName);
            tabBook.Controls.Add(cboBookType);
            tabBook.Controls.Add(numPageIndex);
            tabBook.Controls.Add(btnDelete);
            tabBook.Controls.Add(btnAdd);
            tabBook.Controls.Add(dgvBook);
            tabBook.Location = new Point(4, 29);
            tabBook.Name = "tabBook";
            tabBook.Padding = new Padding(3);
            tabBook.Size = new Size(1058, 613);
            tabBook.TabIndex = 0;
            tabBook.Text = "Book management";
            // 
            // dgvBook
            // 
            dgvBook.BackgroundColor = SystemColors.ActiveCaption;
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(9, 133);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBook.Size = new Size(1046, 372);
            dgvBook.TabIndex = 0;
            dgvBook.CellDoubleClick += dgvBook_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.OliveDrab;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(109, 547);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 51);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(9, 547);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 51);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // numPageIndex
            // 
            numPageIndex.Location = new Point(899, 511);
            numPageIndex.Name = "numPageIndex";
            numPageIndex.Size = new Size(67, 27);
            numPageIndex.TabIndex = 4;
            numPageIndex.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cboBookType
            // 
            cboBookType.FormattingEnabled = true;
            cboBookType.Location = new Point(565, 89);
            cboBookType.Name = "cboBookType";
            cboBookType.Size = new Size(151, 28);
            cboBookType.TabIndex = 7;
            cboBookType.SelectedIndexChanged += cboBookType_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(303, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(823, 89);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 8;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 92);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 92);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 10;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 92);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 11;
            label3.Text = "BookType:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(760, 92);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 12;
            label4.Text = "Author:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(403, 17);
            label5.Name = "label5";
            label5.Size = new Size(285, 41);
            label5.TabIndex = 13;
            label5.Text = "Book Management";
            // 
            // txtID
            // 
            txtID.Location = new Point(134, 85);
            txtID.Mask = "0000000000000";
            txtID.Name = "txtID";
            txtID.Size = new Size(105, 27);
            txtID.TabIndex = 14;
            txtID.ValidatingType = typeof(int);
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += maskedTextBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(815, 511);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 15;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(974, 511);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 16;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBook);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1066, 646);
            tabControl1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.OliveDrab;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(209, 547);
            button5.Name = "button5";
            button5.Size = new Size(118, 51);
            button5.TabIndex = 17;
            button5.Text = "Book types";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1090, 701);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoicePageNumber).EndInit();
            tabBook.ResumeLayout(false);
            tabBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPageIndex).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtID.Select(0, 0);
            });         
        }
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private ToolStripMenuItem addNewAccountToolStripMenuItem;
        private TabPage tabPage2;
        private Button button3;
        private Button button4;
        private Label label6;
        private NumericUpDown invoicePageNumber;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private DataGridView dgvInvoice;
        private TabPage tabBook;
        private Button button5;
        private Button button2;
        private Button button1;
        private MaskedTextBox txtID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAuthor;
        private TextBox txtName;
        private ComboBox cboBookType;
        private NumericUpDown numPageIndex;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvBook;
        private TabControl tabControl1;
    }
}
