using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace MyMovieApp
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet11.TblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.mOVIEDataSet11.TblUser);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            // Check if any of the text fields is empty
            if (string.IsNullOrWhiteSpace(TxtUsername.Text) ||
                string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtSurname.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return; // Exit the method if any field is empty
            }
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TblUser (UserName, Name, Surname, Email, Password) values (@P1,@P2,@P3,@P4,@P5)", conn.connection());

                cmd.Parameters.AddWithValue("@P1", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@P2", TxtName.Text);
                cmd.Parameters.AddWithValue("@P3", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@P4", TxtEmail.Text);
                cmd.Parameters.AddWithValue("@P5", TxtPassword.Text);

                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
                this.tblUserTableAdapter.Fill(this.mOVIEDataSet11.TblUser);

            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            if (Convert.ToInt32(TxtId.Text) < 0)
            {
                MessageBox.Show("Please select valid user.");
                return; 
            }
            try
            {
                SqlCommand cmd = new SqlCommand("delete from TblUser where Id=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtId.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
                this.tblUserTableAdapter.Fill(this.mOVIEDataSet11.TblUser);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            // Check if any of the text fields is empty
            if (string.IsNullOrWhiteSpace(TxtUsername.Text) ||
                string.IsNullOrWhiteSpace(TxtName.Text) ||
                string.IsNullOrWhiteSpace(TxtSurname.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return; // Exit the method if any field is empty
            }
            try
            {
                SqlCommand cmd = new SqlCommand("update TblUser Set UserName=@P1, Name=@P2, Surname=@P3, Email=@P4, Password=@P5   where Id=@P6", conn.connection());
                cmd.Parameters.AddWithValue("@P1", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@P2", TxtName.Text);
                cmd.Parameters.AddWithValue("@P3", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@P4", TxtEmail.Text);
                cmd.Parameters.AddWithValue("@P5", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@P6", TxtId.Text);
                cmd.ExecuteNonQuery(); 
                conn.connection().Close();
                MessageBox.Show("Successful");
                this.tblUserTableAdapter.Fill(this.mOVIEDataSet11.TblUser);

            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }

        int choose;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string userId, username, name, surname, email, password;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            userId = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            username = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            name = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            surname = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            email = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            password = dataGridView1.Rows[choose].Cells[5].Value.ToString();

            TxtId.Text = userId;
            TxtUsername.Text = username;
            TxtName.Text = name;
            TxtSurname.Text = surname;
            TxtEmail.Text = email;
            TxtPassword.Text = password;
        }

        private void userListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserList userList = new FormUserList();
            userList.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormMovieList movieList = new FormMovieList();
            movieList.Show();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovie formMovie = new FormMovie();
            formMovie.Show();
            this.Hide();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovie formMovie = new FormMovie();
            formMovie.Show();
            this.Hide();
        }

        private void editMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovie formMovie = new FormMovie();
            formMovie.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGenreList formGenreList = new FormGenreList();
            formGenreList.Show();
        }

        private void addGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenre formGenre = new FormGenre();
            formGenre.Show();
            this.Hide();
        }

        private void deleteGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenre formGenre = new FormGenre();
            formGenre.Show();
            this.Hide();
        }

        private void editGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenre formGenre = new FormGenre();
            formGenre.Show();
            this.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        
    }
}
