using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_BookStore
{
    public partial class AccountManagement : Form
    {
        BookStoreContext db = DbContextSingleton.Instance;
        public Account currentAccount { get; set; }
        public AccountManagement()
        {
            InitializeComponent();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {

            List<Account> accounts = db.Accounts.ToList();

            var arrayList = from acc in accounts 
                select new
                {
                    Username = acc.Username,
                    Password = acc.Password,
                    IsActive = acc.IsActive,
                    IsAdmin = acc.IsAdmin
                };
            // Gán BindingSource vào DataGridView
            dgv.DataSource = arrayList.ToList();

            // Gán BindingSource vào các control
            txtUsername.DataBindings.Add("Text", dgv.DataSource, "Username");
            txtPassword.DataBindings.Add("Text", dgv.DataSource, "Password");
            checkAdmin.DataBindings.Add("Checked", dgv.DataSource, "IsAdmin", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            var existingAccount = db.Accounts.FirstOrDefault(x => x.Username == txtUsername.Text);
            if (existingAccount != null)
            {
                MessageBox.Show("This account already exists.");
                return;
            }

            Account newAccount = new Account
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                IsActive = true,
                IsAdmin = checkAdmin.Checked
            };
            db.Accounts.Add(newAccount);

                db.SaveChanges();
                MessageBox.Show("Account added successfully.");
                RefreshData();

        }


        private void RefreshData()
        {
            List<Account> accounts = db.Accounts.ToList();

    var arrayList = from acc in accounts 
                    select new
                    {
                        Username = acc.Username,
                        Password = acc.Password,
                        IsActive = acc.IsActive,
                        IsAdmin = acc.IsAdmin
                    };

            dgv.DataSource = arrayList.ToList();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            checkAdmin.DataBindings.Clear();

            txtUsername.DataBindings.Add("Text", dgv.DataSource, "Username");
            txtPassword.DataBindings.Add("Text", dgv.DataSource, "Password");
            checkAdmin.DataBindings.Add("Checked", dgv.DataSource, "IsAdmin", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
var Account = db.Accounts.FirstOrDefault(x=> x.Username == txtUsername.Text);
            if (Account == null)
            {
                MessageBox.Show("This account does not exist, please create a new one");
                return;
            }

            if (txtUsername.Text == currentAccount.Username)
            {
                MessageBox.Show("Please use the change password function");
                return;
            }

            Account.Password = txtPassword.Text;
            Account.IsAdmin = checkAdmin.Checked;
            db.SaveChanges();
            MessageBox.Show("Update successfully.");
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Account = db.Accounts.FirstOrDefault(x=> x.Username == txtUsername.Text);
            if (Account == null)
            {
                MessageBox.Show("This account does not exist, please create a new one");
                return;
            }

            if (txtUsername.Text == currentAccount.Username)
            {
                MessageBox.Show("You cannot delete your own account");
                return;
            }

    db.Accounts.Remove(Account);
            db.SaveChanges();
            MessageBox.Show("Update successfully.");
            RefreshData();
        }
    }
}
