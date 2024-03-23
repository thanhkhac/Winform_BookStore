using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MiniProject_BookStore
{
    public partial class Login : Form
    {
        BookStoreContext db = DbContextSingleton.Instance;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Tìm kiếm tài khoản trong cơ sở dữ liệu
            Account account = db.Accounts.FirstOrDefault(acc => acc.Username == username && acc.Password == password);

            if (account != null && account.IsActive == true)
            {
                MessageBox.Show("Logged in successfully");
                this.Hide();
                Main mainForm = new Main();
                mainForm.account = account;
                var value =  mainForm.ShowDialog();
                if (value == DialogResult.OK)
                {
                    this.Show();
                }else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password again");
            }
        }
    }
}