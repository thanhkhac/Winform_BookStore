namespace MiniProject_BookStore
{
    partial class BookDetails
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
            picBook = new PictureBox();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            numPrice = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnAddImage = new Button();
            cbBookType = new ComboBox();
            numQuantity = new NumericUpDown();
            txtAuthor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // picBook
            // 
            picBook.BackColor = Color.Transparent;
            picBook.Location = new Point(627, 24);
            picBook.Name = "picBook";
            picBook.Size = new Size(309, 414);
            picBook.TabIndex = 0;
            picBook.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(373, 27);
            txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnAddImage);
            groupBox1.Controls.Add(cbBookType);
            groupBox1.Controls.Add(numQuantity);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book details";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 3;
            numPrice.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numPrice.Location = new Point(121, 262);
            numPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(132, 27);
            numPrice.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 71);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 114);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 165);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 217);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 262);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(248, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 46);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Submit";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(121, 304);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(94, 29);
            btnAddImage.TabIndex = 6;
            btnAddImage.Text = "Add image";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // cbBookType
            // 
            cbBookType.FormattingEnabled = true;
            cbBookType.Location = new Point(121, 157);
            cbBookType.Name = "cbBookType";
            cbBookType.Size = new Size(221, 28);
            cbBookType.TabIndex = 5;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(121, 210);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(132, 27);
            numQuantity.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(121, 107);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(373, 27);
            txtAuthor.TabIndex = 2;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 450);
            Controls.Add(groupBox1);
            Controls.Add(picBook);
            Name = "BookDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details of book";
            Load += BookDetails_Load;
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBook;
        private TextBox txtName;
        private GroupBox groupBox1;
        private Button btnAddImage;
        private ComboBox cbBookType;
        private NumericUpDown numQuantity;
        private TextBox txtAuthor;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numPrice;
    }
}