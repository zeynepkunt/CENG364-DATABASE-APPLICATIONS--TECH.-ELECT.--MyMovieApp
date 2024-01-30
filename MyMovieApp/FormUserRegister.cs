using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyMovieApp
{
    public partial class FormUserRegister : Form
    {
        public FormUserRegister()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection();


        private void FormUserRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainPage formMainPage = new FormMainPage();
            formMainPage.Show();
            this.Hide();
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {

            int control = MovieDatabase.UserRegister(TxtUserName.Text, TxtName.Text, TxtSurname.Text, TxtEmail.Text, TxtPassword.Text);
            if (control == 1)
            {
                FormMainPage formMainPage = new FormMainPage();
                formMainPage.Show();
                this.Hide();
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
                }
            }
        }
    }
}
// Data Source = DESKTOP - 3P5FBUI;Initial Catalog = MOVIE; Integrated Security = True
