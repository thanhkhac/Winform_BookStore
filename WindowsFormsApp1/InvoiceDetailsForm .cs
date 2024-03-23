using System;
using System.Collections.Generic;
using System.Linq;
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
            this.invoice = db.Invoices
                .Include(x => x.InvoiceDetails)
                .FirstOrDefault(x => x.Id == invoice.Id);
            if (this.invoice == null)
            {
                MessageBox.Show("Invoice not found.");
                Close();
                return;
            }

            if (Mode == FormMode.Update )
            {
                temporaryInvoiceDetails = invoice.InvoiceDetails.ToList();
            }
            

            PopulateInvoiceDetails();
            LoadBooks();
        }

        private void PopulateInvoiceDetails()
        {
            lblInvoiceID.Text = "Invoice ID: " + invoice.Id;
            txtCustomerName.Text = invoice.CustomerName;
            txtCustomerPhone.Text = invoice.CustomerPhone;

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
                .Where(b => b.IsActive ==true)
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
    db.InvoiceDetails.RemoveRange(db.InvoiceDetails.Where(detail => detail.Id == invoice.Id));
    db.SaveChanges();
    db.InvoiceDetails.AddRange(temporaryInvoiceDetails);
    db.SaveChanges();
    MessageBox.Show("Changes saved successfully.");
    this.Close();
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvBook.Rows[e.RowIndex];
            int bookId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            var book = db.Books.FirstOrDefault(x => x.Id == bookId);
            var invoiceDetail = temporaryInvoiceDetails.FirstOrDefault(x => x.BookId == bookId && x.Id == invoice.Id);

            if (invoiceDetail == null)
            {
                if (book == null || book.Quantity == 0)
                {
                    MessageBox.Show("This book is out of stock");
                    return;
                }
                InvoiceDetail newInvoiceDetail = new InvoiceDetail
                {
                    Id = invoice.Id,
                    BookId = bookId,
                    Quantity = 1,
                };
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
                    totalPrice += ( detail.Quantity * book.Price) is decimal ? (decimal)( detail.Quantity * book.Price) : 0;
                }
            }
            txtTotal.Text = totalPrice.ToString("0.00");
        }
    }
}
