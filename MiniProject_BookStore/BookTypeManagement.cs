using Microsoft.EntityFrameworkCore;
using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiniProject_BookStore
{
    public partial class BookTypeManagement : Form
    {
        BookStoreContext db = DbContextSingleton.Instance;

        public BookTypeManagement()
        {
            InitializeComponent();
        }

        private void BookTypeManagement_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = db.BookTypes.ToList();
            dataGridView1.Columns["Books"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string typeName = txtBookTypeName.Text.Trim();
            if (!string.IsNullOrEmpty(typeName))
            {
                var newBookType = new BookType { Name = typeName };
                db.BookTypes.Add(newBookType);
                db.SaveChanges();
                RefreshGrid();
                MessageBox.Show("Book type added successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid book type name!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int typeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var bookType = db.BookTypes.Find(typeId);
                if (bookType != null)
                {
                    string newTypeName = txtBookTypeName.Text.Trim();
                    if (!string.IsNullOrEmpty(newTypeName))
                    {
                        bookType.Name = newTypeName;
                        db.Entry(bookType).State = EntityState.Modified;
                        db.SaveChanges();
                        RefreshGrid();
                        MessageBox.Show("Book type updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid book type name!");
                    }
                }
                else
                {
                    MessageBox.Show("Selected book type not found!");
                }
            }
            else
            {
                MessageBox.Show("Please select a book type to update!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this book type?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int typeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                    var bookType = db.BookTypes.Find(typeId);
                    if (bookType != null)
                    {
                        db.BookTypes.Remove(bookType);
                        db.SaveChanges();
                        RefreshGrid();
                        MessageBox.Show("Book type deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Selected book type not found!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book type to delete!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtBookTypeName.Text = row.Cells["Name"].Value.ToString();
            }
        }
    }
}
