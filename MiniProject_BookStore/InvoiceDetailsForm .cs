using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;

namespace MiniProject_BookStore
{
    partial class InvoiceDetailsForm : Form
    {
        public Invoice invoice;
        private readonly BookStoreContext db;
        private readonly int pageSize = 10;
        private readonly List<InvoiceDetail> temporaryInvoiceDetails = new List<InvoiceDetail>();
        int pageIndex = 0;


        public enum FormMode
        {
            Insert,
            Update
        }

        public FormMode Mode { get; set; }

        public InvoiceDetailsForm(Invoice invoice, FormMode formMode)
        {
            InitializeComponent();
            Mode = formMode;
            db = DbContextSingleton.Instance;


            if (Mode == FormMode.Update)
            {
                this.invoice = db.Invoices
                    .Include(x => x.InvoiceDetails)
                    .FirstOrDefault(x => x.Id == invoice.Id);
                temporaryInvoiceDetails = invoice.InvoiceDetails.ToList();
                PopulateInvoiceDetails();
            }



            LoadBooks();
        }

        private void PopulateInvoiceDetails()
        {
            if (Mode == FormMode.Update)
            {
                lblInvoiceID.Text = "Invoice ID: " + invoice.Id;
                txtCustomerName.Text = invoice.CustomerName;
                txtCustomerPhone.Text = invoice.CustomerPhone;
            }

            dgvInvoiceDetails.Columns.Add("BookID", "Book ID");
            dgvInvoiceDetails.Columns.Add("BookName", "Book Name");
            dgvInvoiceDetails.Columns.Add("Quantity", "Quantity");
            dgvInvoiceDetails.Columns.Add("UnitPrice", "Unit Price");
            dgvInvoiceDetails.Columns.Add("TotalPrice", "Total Price");

            foreach (var detail in temporaryInvoiceDetails)
            {
                var book = db.Books.FirstOrDefault(x => x.Id == detail.BookId);
                if (book != null)
                {
                    dgvInvoiceDetails.Rows.Add(detail.BookId, book.Name, detail.Quantity, book.Price, detail.Quantity * book.Price);
                }
            }
            //UpdateTotalPrice();
            CalculateTotalPriceFromTemporaryDetails();
        }

        private void LoadBooks()
        {
            var books = SearchBooks();
            var displayBooks = books
                .Where(b => b.IsActive == true)
                .Select(b => new
                {
                    ID = b.Id,
                    Name = b.Name,
                    BookType = b.BookType == null ? "None" : b.BookType.Name,
                    Author = b.Author,
                    Quantity = b.Quantity,
                    Price = b.Price
                }).ToList();
            dgvBook.DataSource = displayBooks;
        }

        private List<Book> SearchBooks()
        {
            var books = db.Books.Include(x => x.BookType) as IQueryable<Book>;
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                books = books.Where(b => b.Id.ToString().Contains(txtID.Text));
            }
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                books = books.Where(b => b.Name.Contains(txtName.Text));
            }
            int start = pageSize * pageIndex;
            books = books.Skip(start).Take(pageSize);
            return books.ToList();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetails.SelectedRows.Count > 0)
            {
                int rowIndex = dgvInvoiceDetails.SelectedRows[0].Index;
                var selectedBookId = Convert.ToInt32(dgvInvoiceDetails.Rows[rowIndex].Cells["BookID"].Value);

                // Xóa dữ liệu tạm thời tương ứng với sách đã chọn
                var invoiceDetailToRemove = temporaryInvoiceDetails.FirstOrDefault(d => d.BookId == selectedBookId);
                if (invoiceDetailToRemove != null)
                {
                    temporaryInvoiceDetails.Remove(invoiceDetailToRemove);
                }

                // Xóa dòng trên DataGridView
                dgvInvoiceDetails.Rows.RemoveAt(rowIndex);

                UpdateTotalPrice();
            }
        }

        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dgvInvoiceDetails.Rows)
            {
                totalPrice += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            }
            lblTotalPrice.Text = "Total Price: $" + totalPrice.ToString("0.00");
        }
void saveChange()
{
                if (Mode == FormMode.Update)
            {
                // refund
                foreach (var detail in invoice.InvoiceDetails)
                {
                    var book = db.Books.FirstOrDefault(x => x.Id == detail.BookId);
                    if (book != null)
                    {
                        book.Quantity += (int)detail.Quantity;
                    }
                }
                db.SaveChanges();

                // update
                    
                           var temp = db.Invoices.Where(x=>x.Id == invoice.Id).FirstOrDefault();
                temp.CustomerName =txtCustomerName.Text;
                temp.CustomerPhone = txtCustomerPhone.Text;

                db.InvoiceDetails.RemoveRange(db.InvoiceDetails.Where(detail => detail.Id == invoice.Id));
                db.SaveChanges();
                db.InvoiceDetails.AddRange(temporaryInvoiceDetails);
                db.SaveChanges();

                foreach (var detail in temporaryInvoiceDetails)
                {
                    var book = db.Books.FirstOrDefault(x => x.Id == detail.BookId);
                    if (book != null)
                    {
                        book.Quantity -= (int)detail.Quantity;
                    }
                }
                db.SaveChanges();
            }
            else
            {
                // Tru di so luong sach
                foreach (var detail in temporaryInvoiceDetails)
                {
                    var book = db.Books.FirstOrDefault(x => x.Id == detail.BookId);
                    if (book != null)
                    {
                        book.Quantity -= (int)detail.Quantity;
                    }
                }
                db.SaveChanges();

                // tao hoa don moi
                Invoice newInvoice = new Invoice
                {
                    CreatedDate = DateTime.Now,
                    CustomerName = txtCustomerName.Text,
                    CustomerPhone = txtCustomerPhone.Text,
                    InvoiceDetails = temporaryInvoiceDetails
                };
                db.Invoices.Add(newInvoice);
                db.SaveChanges();
            }
}

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            saveChange();
            MessageBox.Show("Changes saved successfully.");
            LoadBooks();
            this.Close();
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvBook.Rows[e.RowIndex];
            int bookId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            var book = db.Books.FirstOrDefault(x => x.Id == bookId);
            InvoiceDetail? invoiceDetail = null;
            if (Mode == FormMode.Update)
            {
                invoiceDetail= temporaryInvoiceDetails.FirstOrDefault(x => x.BookId == bookId && x.Id == invoice.Id);
            }else
            {
                invoiceDetail= temporaryInvoiceDetails.FirstOrDefault(x => x.BookId == bookId);
            }

            if (invoiceDetail == null)
            {
                if (book == null || book.Quantity == 0)
                {
                    MessageBox.Show("This book is out of stock");
                    return;
                }
                InvoiceDetail newInvoiceDetail = new InvoiceDetail
                {
                    BookId = bookId,
                    Quantity = 1,
                };
                if (Mode == FormMode.Update)
                {
                    newInvoiceDetail.Id = invoice.Id;
                }
                temporaryInvoiceDetails.Add(newInvoiceDetail);
            }
            else
            {
                if ((invoiceDetail.Quantity + 1) > book.Quantity)
                {
                    MessageBox.Show("Exceeded quantity");
                    return;
                }
                invoiceDetail.Quantity++;
            }
            Reload();
        }

        private void Reload()
        {
            dgvInvoiceDetails.Rows.Clear();
            dgvInvoiceDetails.Columns.Clear();
            PopulateInvoiceDetails();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            pageIndex = 0;
            LoadBooks();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            pageIndex = 0;
            LoadBooks();
        }

        private void numPageIndex_ValueChanged(object sender, EventArgs e)
        {
            pageIndex = (int)numPageIndex.Value;
            LoadBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numPageIndex.Value > 0) // Check to avoid negative page index
                numPageIndex.Value--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numPageIndex.Value++;
        }

        private void InvoiceDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.ChangeTracker.Clear();
        }
        private void CalculateTotalPriceFromTemporaryDetails()
        {
            decimal totalPrice = 0;
            foreach (var detail in temporaryInvoiceDetails)
            {
                var book = db.Books.FirstOrDefault(x => x.Id == detail.BookId);
                if (book != null)
                {
                    totalPrice += (detail.Quantity * book.Price) is decimal ? (decimal)(detail.Quantity * book.Price) : 0;
                }
            }
            txtTotal.Text = totalPrice.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Mode == FormMode.Insert)
            {
                Invoice newInvoice = new Invoice
                {
                    CreatedDate = DateTime.Now,
                    CustomerName = txtCustomerName.Text,
                    CustomerPhone = txtCustomerPhone.Text,
                    InvoiceDetails = temporaryInvoiceDetails
                };
                db.Invoices.Add(newInvoice);
                db.SaveChanges();
                invoice = newInvoice;
            }
            saveChange();
            PrintInvoice printInvoice = new PrintInvoice
            {
                invoice = invoice
            };
            printInvoice.ShowDialog();
            Close();
        }
    }
}
