namespace MiniProject_BookStore
{
    partial class BookTypeManagement
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label8 = new Label();
            txtBookTypeName = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(428, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(200, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(131, 357);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 18;
            label8.Text = "Name:";
            // 
            // txtBookTypeName
            // 
            txtBookTypeName.Location = new Point(200, 350);
            txtBookTypeName.Name = "txtBookTypeName";
            txtBookTypeName.Size = new Size(322, 27);
            txtBookTypeName.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(200, 9);
            label7.Name = "label7";
            label7.Size = new Size(354, 41);
            label7.TabIndex = 16;
            label7.Text = "Book type management";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(693, 257);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BookTypeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label8);
            Controls.Add(txtBookTypeName);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Name = "BookTypeManagement";
            Text = "BookTypeManagement";
            Load += BookTypeManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label8;
        private TextBox txtBookTypeName;
        private Label label7;
        private DataGridView dataGridView1;
    }
}