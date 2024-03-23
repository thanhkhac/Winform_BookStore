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
            tabControl1 = new TabControl();
            tabBook = new TabPage();
            button2 = new Button();
            button1 = new Button();
            txtID = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAuthor = new TextBox();
            cboBookType = new ComboBox();
            txtName = new TextBox();
            numPageIndex = new NumericUpDown();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvBook = new DataGridView();
            tabPage2 = new TabPage();
            label6 = new Label();
            invoicePageNumber = new NumericUpDown();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            dgvInvoice = new DataGridView();
            tabControl1.SuspendLayout();
            tabBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPageIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invoicePageNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBook);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1066, 677);
            tabControl1.TabIndex = 0;
            // 
            // tabBook
            // 
            tabBook.Controls.Add(button2);
            tabBook.Controls.Add(button1);
            tabBook.Controls.Add(txtID);
            tabBook.Controls.Add(label5);
            tabBook.Controls.Add(label4);
            tabBook.Controls.Add(label3);
            tabBook.Controls.Add(label2);
            tabBook.Controls.Add(label1);
            tabBook.Controls.Add(txtAuthor);
            tabBook.Controls.Add(cboBookType);
            tabBook.Controls.Add(txtName);
            tabBook.Controls.Add(numPageIndex);
            tabBook.Controls.Add(btnDelete);
            tabBook.Controls.Add(btnAdd);
            tabBook.Controls.Add(dgvBook);
            tabBook.Location = new Point(4, 29);
            tabBook.Name = "tabBook";
            tabBook.Padding = new Padding(3);
            tabBook.Size = new Size(1058, 644);
            tabBook.TabIndex = 0;
            tabBook.Text = "Book management";
            tabBook.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(972, 509);
            button2.Name = "button2";
            button2.Size = new Size(63, 29);
            button2.TabIndex = 16;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(815, 511);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 15;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(359, 18);
            label5.Name = "label5";
            label5.Size = new Size(285, 41);
            label5.TabIndex = 13;
            label5.Text = "Book Management";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 92);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 11;
            label3.Text = "BookType:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 92);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(823, 89);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 8;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
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
            // numPageIndex
            // 
            numPageIndex.Location = new Point(899, 511);
            numPageIndex.Name = "numPageIndex";
            numPageIndex.Size = new Size(67, 27);
            numPageIndex.TabIndex = 4;
            numPageIndex.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(57, 568);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 51);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(167, 568);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 51);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(9, 133);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.Size = new Size(1046, 372);
            dgvBook.TabIndex = 0;
            dgvBook.CellDoubleClick += dgvBook_CellDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(invoicePageNumber);
            tabPage2.Controls.Add(btnNextPage);
            tabPage2.Controls.Add(btnPreviousPage);
            tabPage2.Controls.Add(dgvInvoice);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1058, 644);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Invoice management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(341, 38);
            label6.Name = "label6";
            label6.Size = new Size(312, 41);
            label6.TabIndex = 4;
            label6.Text = "Invoice management";
            // 
            // invoicePageNumber
            // 
            invoicePageNumber.Location = new Point(870, 403);
            invoicePageNumber.Name = "invoicePageNumber";
            invoicePageNumber.Size = new Size(61, 27);
            invoicePageNumber.TabIndex = 3;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(937, 401);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(770, 403);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 1;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // dgvInvoice
            // 
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(6, 112);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.RowTemplate.Height = 29;
            dgvInvoice.Size = new Size(1046, 269);
            dgvInvoice.TabIndex = 0;
            dgvInvoice.CellDoubleClick += dgvInvoice_CellDoubleClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 701);
            Controls.Add(tabControl1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabBook.ResumeLayout(false);
            tabBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPageIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)invoicePageNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                txtID.Select(0, 0);
            });         
        }
        private TabControl tabControl1;
        private TabPage tabBook;
        private TabPage tabPage2;
        private DataGridView dgvBook;
        private Button btnDelete;
        private Button btnAdd;
        private NumericUpDown numPageIndex;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAuthor;
        private ComboBox cboBookType;
        private TextBox txtName;
        private Label label5;
        private MaskedTextBox txtID;
        private Button button2;
        private Button button1;
        private DataGridView dgvInvoice;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private NumericUpDown invoicePageNumber;
        private Label label6;
    }
}
