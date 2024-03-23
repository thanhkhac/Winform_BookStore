using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;

namespace MiniProject_BookStore
{
    public partial class BookDetails : Form
    {
        public enum FormMode
        {
            Insert,
            Update
        }

        public FormMode Mode { get; set; }

        BookStoreContext db = DbContextSingleton.Instance;
        public Book xBook { get; set; }

        void setUp()
        {
            picBook.SizeMode = PictureBoxSizeMode.Zoom;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public BookDetails()
        {
            InitializeComponent();

        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            setUp();
            loadBookType();
            loadBook();
        }

        public void loadBook()
        {
            if (xBook != null)
            {
                txtName.Text = xBook.Name;
                txtAuthor.Text = xBook.Author;
                cbBookType.SelectedItem = xBook.BookType;
                numPrice.Value = xBook.Price;
                numQuantity.Value = xBook.Quantity;
                if (xBook.BookImg != null)
                {
                    Image img = (Bitmap)((new ImageConverter()).ConvertFrom(xBook.BookImg.Img));
                    picBook.Image = img;
                }
            }
        }

        void loadBookType()
        {
            var bookTypes = db.BookTypes;
            cbBookType.DataSource = bookTypes.ToList();
            cbBookType.DisplayMember = "Name";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files (*.jpg)|*.jpg|PNG files(*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picBook.ImageLocation = ofd.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string author = txtAuthor.Text;
            BookType bookType = (BookType)cbBookType.SelectedItem;
            int quantity = (int)numQuantity.Value;
            decimal price = numPrice.Value;
            BookImg bookImg = uploadImage();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(author) || quantity < 0 || price < 0)
            {
                MessageBox.Show("The information of the book is invalid. Please enter again", "Invalid", MessageBoxButtons.OK);
                return;
            }

            if (Mode == FormMode.Insert)
            {
                Book book = new Book
                {
                    Name = name,
                    Author = author,
                    Quantity = quantity,
                    Price = price,
                    IsActive = true,
                    BookImg = bookImg,
                    BookType = bookType
                };
                db.Books.Add(book);
            }
            if (Mode == FormMode.Update)
            {
                Book updateBook = db.Books.Include(x=> x.BookImg).FirstOrDefault(b => b.Id == xBook.Id);
                updateBook.Name = name;
                updateBook.Author = author;
                updateBook.Quantity = quantity;
                updateBook.Price = price;
                updateBook.Quantity = quantity;
                updateBook.BookType = bookType;
                if (bookImg != null)
                {
                    if (updateBook.BookImg != null)
                    {
                        db.BookImgs.Remove(updateBook.BookImg);
                    }
                    updateBook.BookImg = bookImg;
                }
            }

            try
            {
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                this.DialogResult = DialogResult.Retry;
            }
                }

        BookImg uploadImage()
        {
            string imgPath = picBook.ImageLocation;
            if (imgPath != null)
            {
                byte[] pic = File.ReadAllBytes(imgPath);
                BookImg bookImg = new BookImg
                {
                    Img = pic
                };
                return bookImg;
            }
            return null;
        }


    }
}
