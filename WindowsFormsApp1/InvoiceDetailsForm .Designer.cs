namespace MiniProject_BookStore
{
    partial class InvoiceDetailsForm
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
            lblInvoiceID = new Label();
            dgvInvoiceDetails = new DataGridView();
            lblTotalPrice = new Label();
            btnSaveChanges = new Button();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            btnDeleteBook = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtID = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            numPageIndex = new NumericUpDown();
            dgvBook = new DataGridView();
            txtTotal = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPageIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceID
            // 
            lblInvoiceID.AutoSize = true;
            lblInvoiceID.Location = new Point(20, 20);
            lblInvoiceID.Name = "lblInvoiceID";
            lblInvoiceID.Size = new Size(0, 20);
            lblInvoiceID.TabIndex = 0;
            // 
            // dgvInvoiceDetails
            // 
            dgvInvoiceDetails.AllowUserToAddRows = false;
            dgvInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceDetails.ColumnHeadersHeight = 29;
            dgvInvoiceDetails.Location = new Point(20, 144);
            dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            dgvInvoiceDetails.RowHeadersWidth = 51;
            dgvInvoiceDetails.Size = new Size(510, 300);
            dgvInvoiceDetails.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(20, 420);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 20);
            lblTotalPrice.TabIndex = 2;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(374, 450);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(75, 43);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(131, 76);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(200, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(131, 109);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(200, 27);
            txtCustomerPhone.TabIndex = 5;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(455, 450);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(75, 43);
            btnDeleteBook.TabIndex = 8;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 79);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 9;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 112);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 10;
            label2.Text = "Phone number";
            // 
            // button2
            // 
            button2.Location = new Point(1125, 509);
            button2.Name = "button2";
            button2.Size = new Size(63, 29);
            button2.TabIndex = 28;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(968, 509);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 27;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(630, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(105, 27);
            txtID.TabIndex = 26;
            txtID.ValidatingType = typeof(int);
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(779, 70);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 23;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(597, 70);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 22;
            label6.Text = "ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(837, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 27);
            txtName.TabIndex = 19;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // numPageIndex
            // 
            numPageIndex.Location = new Point(1052, 509);
            numPageIndex.Name = "numPageIndex";
            numPageIndex.Size = new Size(67, 27);
            numPageIndex.TabIndex = 18;
            numPageIndex.ValueChanged += numPageIndex_ValueChanged;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(588, 100);
            dgvBook.MultiSelect = false;
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.Size = new Size(600, 403);
            dgvBook.TabIndex = 17;
            dgvBook.CellDoubleClick += dgvBook_CellDoubleClick;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(81, 458);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 461);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 30;
            label3.Text = "Total";
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 553);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(numPageIndex);
            Controls.Add(dgvBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblInvoiceID);
            Controls.Add(dgvInvoiceDetails);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerPhone);
            Controls.Add(btnDeleteBook);
            Name = "InvoiceDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceDetails";
            FormClosing += InvoiceDetailsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPageIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceID;
        private Label lblCreatedDate;
        private Label lblCustomerName;
        private Label lblCustomerPhone;
        private DataGridView dgvInvoiceDetails;
        private Label lblTotalPrice;
        private Button btnSaveChanges;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhone;
        private Button btnDeleteBook;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;
        private MaskedTextBox txtID;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private NumericUpDown numPageIndex;
        private DataGridView dgvBook;
        private TextBox txtTotal;
        private Label label3;
    }
}