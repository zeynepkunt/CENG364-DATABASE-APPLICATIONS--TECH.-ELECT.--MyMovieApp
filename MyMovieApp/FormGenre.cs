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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace MyMovieApp
{
    public partial class FormGenre : Form
    {
        public FormGenre()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection();

        private void FormGenre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet4.TblGenre' table. You can move, or remove it, as needed.
            this.tblGenreTableAdapter.Fill(this.mOVIEDataSet4.TblGenre);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(TxtGenreName.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return; // Exit the method if any field is empty
                }

                SqlCommand cmd = new SqlCommand("insert into TblGenre ( Name) values (@PName)", conn.connection());

                cmd.Parameters.AddWithValue("@PName", TxtGenreName.Text); 
                cmd.ExecuteNonQuery(); 
              

                conn.connection().Close();
                MessageBox.Show("Successful");
                this.tblGenreTableAdapter.Fill(this.mOVIEDataSet4.TblGenre);
                TxtGenreId.Clear();
                TxtGenreName.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtGenreId.Text))
                {
                    MessageBox.Show("Please select a genre to delete.");
                    return; // Exit the method if Id is empty
                }
                SqlCommand cmd = new SqlCommand("delete from TblGenre where Id=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", TxtGenreId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful");
                this.tblGenreTableAdapter.Fill(this.mOVIEDataSet4.TblGenre);
                TxtGenreId.Clear();
                TxtGenreName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.connection().Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtGenreName.Text))
                {
                    MessageBox.Show("Please select Genre from table.");
                    return; // Exit the method if any field is empty
                }

                SqlCommand cmd = new SqlCommand("update TblGenre Set Name=@PName where Id=@PId", conn.connection());

                cmd.Parameters.AddWithValue("@PName", TxtGenreName.Text);
                cmd.Parameters.AddWithValue("@PId", TxtGenreId.Text);

                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
                this.tblGenreTableAdapter.Fill(this.mOVIEDataSet4.TblGenre);
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
            string id, name;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            name = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            

            TxtGenreId.Text = id;
            TxtGenreName.Text = name;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Add Genre");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Delete Genre");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Update Genre");
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Close();
        }

        private void userListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserList formUserList = new FormUserList();
            formUserList.Show();
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
            FormMovieList formMovieList = new FormMovieList();
            formMovieList.Show();
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
    }
}
