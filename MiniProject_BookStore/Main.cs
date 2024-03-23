using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;

namespace MiniProject_BookStore
{
    public partial class Main : Form
    {
        BookStoreContext db = DbContextSingleton.Instance;
        public Account account { get; set; }
        int pageIndex = 0;
        int pageSize = 10;
        public void setUp()
        {

            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBook.RowTemplate.Height = 40;
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoice.RowTemplate.Height = 40;
            Text = "Thanh Khac Book Store";
            tabBook.Text = "Book Management";
        }

        public Main()
        {
            InitializeComponent();
            setUp();
            loadBookType();
            loadBook();

            loadInvoice();
        }

        void loadBookType()
        {
            cboBookType.Items.Add("Tất cả");
            cboBookType.Items.AddRange(db.BookTypes.ToList().ToArray());
            cboBookType.DisplayMember = "name";
            cboBookType.SelectedIndex = 0;
        }


        List<Book> searchBooks()
        {

            var books = db.Books.Include(x => x.BookType).Include(x => x.BookImg) as IQueryable<Book>;

            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                books = from b in books
                        where b.Id.ToString().Contains(txtID.Text)
                        select b;
            }

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                books = from b in books
                        where b.Name.Contains(txtName.Text)
                        select b;
            }

            if (cboBookType.SelectedIndex != 0)
            {
                books = from b in books
                        where b.BookType == cboBookType.SelectedItem
                        select b;
            }

            if (!string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                books = from b in books
                        where b.Author.Contains(txtAuthor.Text)
                        select b;
            }

            int start = pageSize * pageIndex;

            books = (from b in books
                     select b).Skip(start)
                .Take(pageSize);

            return books.ToList();
        }


        void loadBook()
        {
            var books = searchBooks();

            var displayBooks =
                from b in books
                where
                b.IsActive == true
                select new
                {
                    ID = b.Id,
                    Name = b.Name,
                    BookType = b.BookType == null ? "None" : b.BookType.Name,
                    Author = b.Author,
                    Quantity = b.Quantity,
                    Price = b.Price,
                    Image = b.BookImg == null ? null : ByteArrayToImage(b.BookImg.Img)
                };

            dgvBook.DataSource = displayBooks.ToList();
            dgvBook.Columns["Image"].DefaultCellStyle.NullValue = null; // Đặt giá trị null để tránh hiển thị hình ảnh mặc định cho ô trống
            dgvBook.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa hình ảnh trong ô
            dgvBook.Columns["Image"].Resizable = DataGridViewTriState.True; // Cho phép thay đổi kích thước cột hình ảnh
            dgvBook.RowTemplate.Height = 100; // Đặt chiều cao của mỗi hàng để hình ảnh được hiển thị đầy đủ
            dgvBook.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ((DataGridViewImageColumn)dgvBook.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvBook.SelectedCells[0].RowIndex;
            int id = (int)dgvBook.Rows[index].Cells["ID"].Value;
            var book = db.Books.Where(x => x.Id == id).Include(x => x.BookImg).SingleOrDefault();
            BookDetails bookDetails = new BookDetails
            {
                xBook = book,
                Mode = BookDetails.FormMode.Update
            };
            var result = bookDetails.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Success");
            }
            else if (result == DialogResult.Retry)
            {
                MessageBox.Show("An error occured");
            }
            loadBook();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookDetails bookDetails = new BookDetails
            {
                Mode = BookDetails.FormMode.Insert
            };

            var result = bookDetails.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Success");
            }
            else if (result == DialogResult.Retry)
            {
                MessageBox.Show("An error occured");
            }
            loadBook();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pageIndex = (int)numPageIndex.Value;
            loadBook();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            pageIndex = 0;
            loadBook();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            pageIndex = 0;
            loadBook();
        }

        private void cboBookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageIndex = 0;
            loadBook();
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            pageIndex = 0;
            loadBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numPageIndex.Value > 0) // Kiểm tra tránh trang âm
                numPageIndex.Value--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numPageIndex.Value++;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please choose books to delete");
                return;
            }

            if (MessageBox.Show("Do you want to delete these books", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvBook.SelectedRows)
                {
                    int bookID = Convert.ToInt32(row.Cells["ID"].Value);
                    var bookToRemove = db.Books.FirstOrDefault(b => b.Id == bookID);
                    var invoice = db.InvoiceDetails.Where(x=> x.BookId == bookID);
                    if (invoice.Count()> 0)
                    {
                        MessageBox.Show("Không thể xóa.Cuốn sách này đã có trong hóa đơn.");
                        return;
                    }
                    if (bookToRemove != null)
                    {
                        bookToRemove.IsActive = false;
                    }

                }
                db.SaveChanges();
                loadBook();
            }
        }

        int InvoiceIndex = 0;

        void loadInvoice()
        {
            var invoices = db.Invoices.ToList();
            var displayInvoice = from invoice in db.Invoices
                                 join invoiceDetail in db.InvoiceDetails on invoice.Id equals invoiceDetail.Id
                                 join book in db.Books on invoiceDetail.BookId equals book.Id

                                 group new { book, invoiceDetail } by new { invoice.Id, invoice.CreatedDate, invoice.CustomerName, invoice.CustomerPhone } into grouped
                                 orderby grouped.Key.CreatedDate descending
                                 select new
                                 {
                                     InvoiceID = grouped.Key.Id,
                                     CreatedDate = grouped.Key.CreatedDate,
                                     CustomerName = grouped.Key.CustomerName,
                                     CustomerPhone = grouped.Key.CustomerPhone,
                                     TotalPrice = grouped.Sum(x => x.book.Price * x.invoiceDetail.Quantity)
                                 };
            //MessageBox.Show(displayInvoice.Count().ToString());
            // Phân trang
            var pagedInvoices = displayInvoice.Skip(InvoiceIndex * pageSize).Take(pageSize).ToList();
            dgvInvoice.DataSource = pagedInvoices;
            invoicePageNumber.Value = InvoiceIndex;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (InvoiceIndex > 0)
            {
                InvoiceIndex--;
                loadInvoice();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int totalInvoices = db.Invoices.Count();
            int totalPages = (int)Math.Ceiling((double)totalInvoices / pageSize);
            if (InvoiceIndex < totalPages - 1)
            {
                InvoiceIndex++;
                loadInvoice();
            }
        }

        private void dgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ thực hiện khi bấm vào một dòng hợp lệ
            {
                // Lấy ID của hóa đơn từ dòng được chọn
                int invoiceID = (int)dgvInvoice.Rows[e.RowIndex].Cells["InvoiceID"].Value;

                // Lấy hóa đơn từ cơ sở dữ liệu
                var invoice = db.Invoices
                    .Include(i => i.InvoiceDetails)
                    .SingleOrDefault(i => i.Id == invoiceID);

                // Kiểm tra xem hóa đơn có tồn tại không
                if (invoice != null)
                {
                    // Mở form InvoiceDetailsForm và truyền hóa đơn vào constructor
                    InvoiceDetailsForm invoiceDetailsForm = new InvoiceDetailsForm(invoice, InvoiceDetailsForm.FormMode.Update);
                    invoiceDetailsForm.ShowDialog();
                    loadInvoice();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (account.IsAdmin == false)
            {
                addNewAccountToolStripMenuItem.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InvoiceDetailsForm invoiceDetailsForm = new InvoiceDetailsForm(null, InvoiceDetailsForm.FormMode.Insert);
            invoiceDetailsForm.ShowDialog();
            loadInvoice();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.account = account;
            var value = changePassword.ShowDialog();
            if (value == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement accountManagement = new AccountManagement();
            accountManagement.currentAccount = account;
            accountManagement.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dgvInvoice.SelectedCells[0].RowIndex;
            int id = (int)dgvInvoice.Rows[index].Cells["InvoiceID"].Value;
            var invoice = db.Invoices.Where(x => x.Id == id).SingleOrDefault();
            var invoiceDetails = db.InvoiceDetails.Where(x => x.Id == invoice.Id);

            var result = MessageBox.Show("Do you want to delete this invoice", "Alert", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                db.InvoiceDetails.RemoveRange(invoiceDetails);
                db.Invoices.Remove(invoice);
                db.SaveChanges();
                MessageBox.Show("Delete successfully");
            }

            loadInvoice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
BookTypeManagement bookType = new BookTypeManagement();
        bookType.ShowDialog();
            loadBook();
        }
    }



}
