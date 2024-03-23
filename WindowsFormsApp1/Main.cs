using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;

namespace MiniProject_BookStore
{
    public partial class Main : Form
    {
        BookStoreContext db = DbContextSingleton.Instance;
        int pageIndex = 0;
        int pageSize = 10;
        public void setUp()
        {
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBook.RowTemplate.Height = 40;
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            var books = db.Books.Include(x => x.BookType) as IQueryable<Book>;

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
                    Price = b.Price
                };

            dgvBook.DataSource = displayBooks.ToList();
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

            var invoices = db.Invoices.Include(x => x.InvoiceDetails).OrderBy(x=> x.CreatedDate).ToList();

            var displayInvoice = from invoice in db.Invoices
                                 join invoiceDetail in db.InvoiceDetails on invoice.Id equals invoiceDetail.Id
                                 join book in db.Books on invoiceDetail.Id equals book.Id
                                 group new { book, invoiceDetail } by new { invoice.Id, invoice.CreatedDate, invoice.CustomerName, invoice.CustomerPhone } into grouped
                                 select new
                                 {
                                     InvoiceID = grouped.Key.Id,
                                     CreatedDate = grouped.Key.CreatedDate,
                                     CustomerName = grouped.Key.CustomerName,
                                     CustomerPhone = grouped.Key.CustomerPhone,
                                     TotalPrice = grouped.Sum(x => x.book.Price * x.invoiceDetail.Quantity)
                                 };

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
                    invoiceDetailsForm.Mode = InvoiceDetailsForm.FormMode.Update;
                    invoiceDetailsForm.ShowDialog();
                    loadInvoice();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }



}
