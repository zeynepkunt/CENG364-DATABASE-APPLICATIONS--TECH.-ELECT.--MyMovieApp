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
    public partial class FormWatchlist : Form
    {
        public FormWatchlist()
        {
            InitializeComponent();
        }

        private void FormWatchlist_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MovieDatabase.GetWatchlist();
            dataGridView2.DataSource = MovieDatabase.GetAllMoviesNotInWatchlistAndWatched();
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

        private void wATCHLISTToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        // it is unique key
        int movieId = -1; // Default value indicating no movie found
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string movieName;
            int choose;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            movieName = dataGridView1.Rows[choose].Cells[1].Value.ToString();

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
                    dataGridViewComment.DataSource = MovieDatabase.GetMovieComments(movieId);
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

        int movieId2 = -1;


        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int choose;
            choose = dataGridView2.SelectedCells[0].RowIndex;
            String movieIdSting = dataGridView2.Rows[choose].Cells[0].Value.ToString();
            movieId2 = Convert.ToInt32(movieIdSting);
            dataGridViewComment.DataSource = MovieDatabase.GetMovieComments(movieId2);
        }
        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            MovieDatabase.DeleteFromWatchlist(movieId);
            dataGridView1.DataSource = MovieDatabase.GetWatchlist();
            dataGridView2.DataSource = MovieDatabase.GetAllMoviesNotInWatchlistAndWatched();
            movieId = -1;
            movieId2= -1;
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            MovieDatabase.AddtoWatchlist(movieId2);
            dataGridView1.DataSource = MovieDatabase.GetWatchlist();
            dataGridView2.DataSource = MovieDatabase.GetAllMoviesNotInWatchlistAndWatched();
            movieId = -1;
            movieId2 = -1;
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
    }
}
