using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMovieApp
{
    public partial class FormUserEdit : Form
    {
        public FormUserEdit()
        {
            InitializeComponent();
        }

        public string userId, username, name, surname, email, password;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TblUser Set UserName=@P1, Name=@P2, Surname=@P3, Email=@P4, Password=@P5   where Id=@P6", conn.connection());
                cmd.Parameters.AddWithValue("@P1", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@P2", TxtName.Text);
                cmd.Parameters.AddWithValue("@P3", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@P4", TxtEmail.Text);
                cmd.Parameters.AddWithValue("@P5", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@P6", TxtId.Text);
                cmd.ExecuteNonQuery(); // Executes statement against the connection and returns the number of rows affected
                conn.connection().Close();
                MessageBox.Show("Successful");

            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }

        MySqlConnection conn = new MySqlConnection();
        private void FormUserEdit_Load(object sender, EventArgs e)
        {
            TxtId.Text = userId;
            TxtUsername.Text = username;
            TxtName.Text = name;
            TxtSurname.Text = surname;
            TxtEmail.Text = email;
            TxtPassword.Text = password;
        }
    }
}
