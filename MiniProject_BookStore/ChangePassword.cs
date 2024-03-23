using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;

namespace MiniProject_BookStore
{
    public partial class ChangePassword : Form
    {
        BookStoreContext db = DbContextSingleton.Instance;
        public Account account { get; set; }

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(account.Password == txtOldPass.Text))
            {
MessageBox.Show("Wrong password");
return;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password requires a minimum of 8 characters");
                return;
            }

            if (!(txtConfirm.Text ==txtPassword.Text ))
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

account.Password = txtPassword.Text;
                db.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }
    }
}
