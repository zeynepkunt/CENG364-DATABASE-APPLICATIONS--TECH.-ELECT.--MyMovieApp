using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMovieApp
{
    public partial class FormMainPage : Form
    {
        public FormMainPage()
        {
            InitializeComponent();
        }

        private void LblAdminLogIn_Click(object sender, EventArgs e)
        {
            bool signControl = false;
            signControl = MovieDatabase.AdminSign(TxtAdminUserName.Text, TxtAdminPassword.Text);

            if (signControl == true)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide();
            }
            else
            {
                TxtAdminUserName.Clear();
                TxtAdminPassword.Clear();
            }
        }

        private void LblUserLogIn_Click(object sender, EventArgs e)
        {
            bool signControl = false;
            signControl = MovieDatabase.UserSign(TxtUserName.Text, TxtUserPassword.Text);

            if (signControl == true)
            {
                FormUserMainPage formUserMainPage = new FormUserMainPage();
                formUserMainPage.Show();
                this.Hide();
            }
            else
            {
                TxtUserName.Clear();
                TxtUserPassword.Clear();
            }
        }

        private void LblSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserRegister formUserRegister = new FormUserRegister();
            formUserRegister.Show();
            this.Hide();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
