using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMovieApp
{
    public partial class FormWatchedMovies : Form
    {
        public FormWatchedMovies()
        {
            InitializeComponent();
        }

        private void FormWatchedMovies_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MovieDatabase.GetWatchedMovies();
            dataGridView2.DataSource = MovieDatabase.GetWatchlist();

        }

        int movieId = -1; // movie id of the watched movie table
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string movieName;
            int choose;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            movieName = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            if (!string.IsNullOrEmpty(movieName))
            {
                MySqlConnection conn = new MySqlConnection();
                // conn.ConnectionString = Veritabani.ConStr;

                try
                {
                    // Use parameterized query to avoid SQL injection
                    SqlCommand cmd = new SqlCommand("Select Id FROM TblMovie WHERE Name = @movieName", conn.connection());
                    cmd.Parameters.AddWithValue("@MovieName", movieName);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        // Convert the result to int
                        movieId = Convert.ToInt32(result);
                    }
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
            else
            {
                MessageBox.Show("Please Select Movie");
            }
        }

        int movieId2 = -1; // movie id of the watchlist table
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string movieName;
            int choose;
            choose = dataGridView2.SelectedCells[0].RowIndex;
            movieName = dataGridView2.Rows[choose].Cells[1].Value.ToString();
            if (!string.IsNullOrEmpty(movieName))
            {
                MySqlConnection conn = new MySqlConnection();
                // conn.ConnectionString = Veritabani.ConStr;

                try
                {
                    // Use parameterized query to avoid SQL injection
                    SqlCommand cmd = new SqlCommand("Select Id FROM TblMovie WHERE Name = @movieName", conn.connection());
                    cmd.Parameters.AddWithValue("@MovieName", movieName);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        // Convert the result to int
                        movieId2 = Convert.ToInt32(result);
                    }
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
            else
            {
                MessageBox.Show("Please Select Movie");
            }
        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            MovieDatabase.DeleteFromWatchedMovies(movieId);
            dataGridView1.DataSource = MovieDatabase.GetWatchedMovies();
            dataGridView2.DataSource = MovieDatabase.GetWatchlist();
            movieId = -1;
            movieId2 = -1;
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            MovieDatabase.AddtoWatched(movieId2);
            MovieDatabase.DeleteFromWatchlist(movieId2);
            dataGridView1.DataSource = MovieDatabase.GetWatchedMovies();
            dataGridView2.DataSource = MovieDatabase.GetWatchlist();
            movieId = -1;
            movieId2 = -1;
        }

        private void pictureBoxAddComment_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            if (movieId == -1)
            {
                MessageBox.Show("Please, select a movie you watched from the 'watched list' table");
                return;
            }
            try
            {
                if (string.IsNullOrWhiteSpace(TxtComment.Text))
                {
                    MessageBox.Show("Please write a comment.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("insert into TblComments ( UserId, MovieId,Comment) values (@p1,@p2,@p3)", conn.connection());

                cmd.Parameters.AddWithValue("@p1", MovieDatabase.UserId);
                cmd.Parameters.AddWithValue("@p2", movieId);
                cmd.Parameters.AddWithValue("@p3", TxtComment.Text);

                cmd.ExecuteNonQuery();


                conn.connection().Close();
                MessageBox.Show("Successful");
                TxtComment.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }


        private void gENREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenre_User formGenre_User = new FormGenre_User();
            formGenre_User.Show();
            this.Hide();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserMainPage userMainPage = new FormUserMainPage();
            userMainPage.Show();
            this.Hide();
        }

        private void tOP10MOVIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTop10Movies formTop10Movies = new FormTop10Movies();
            formTop10Movies.Show();
            this.Hide();
        }

        private void tOP25MOVIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTop25Movies formTop25Movies = new FormTop25Movies();
            formTop25Movies.Show();
            this.Hide();
        }

        private void aLLMOVIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllMovies formAllMovies = new FormAllMovies();
            formAllMovies.Show();
            this.Hide();
        }

        private void wATCHLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWatchlist formWatchlist = new FormWatchlist();
            formWatchlist.Show();
            this.Hide();
        }

        private void wATCHEDMOVIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWatchedMovies formWatchedMovies = new FormWatchedMovies();
            formWatchedMovies.Show();
            this.Hide();
        }


        private void fOLLOWINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFollowing formFollowing = new FormFollowing();
            formFollowing.Show();
            this.Hide();
        }

        private void fOLLOWERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFollower formFollower = new FormFollower();
            formFollower.Show();
            this.Hide();
        }

        private void LblViewComment_Click(object sender, EventArgs e)
        {
            FormViewComment formViewComment = new FormViewComment();
            formViewComment.Show();

        }

        
    }
}
