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
    public partial class FormFollower : Form
    {
        public FormFollower()
        {
            InitializeComponent();
        }

        private void FormFollower_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MovieDatabase.GetFollower();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection();
            string id;
            int choose;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            if (choose < 0 || choose >= dataGridView1.Rows.Count || (id == ""))
            {
                MessageBox.Show("Invalid selection. Please try again.");
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand("delete from TblFollow where Id=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1", id);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
                dataGridView1.DataSource = MovieDatabase.GetFollower();
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }


        int selectedId = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose;
            string friendsUserName;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            friendsUserName = dataGridView1.Rows[choose].Cells[1].Value.ToString();

            MySqlConnection conn = new MySqlConnection();
            string _sql = "SELECT Id FROM TblUser WHERE Username = '" + friendsUserName + "'";

            using (SqlCommand cmd = new SqlCommand(_sql, conn.connection()))
            {
                cmd.Parameters.AddWithValue("@Username", friendsUserName);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    selectedId = Convert.ToInt32(result);
                }
            }
        }
        private void LblShowWatchlist_Click(object sender, EventArgs e)
        {
            FormShowWatchlist formShowWatchlist = new FormShowWatchlist();
            formShowWatchlist.friendId = Convert.ToString(selectedId);
            formShowWatchlist.Show();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserMainPage formUserMainPage = new FormUserMainPage();
            formUserMainPage.Show();
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

        private void gENREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenre_User formGenre_User = new FormGenre_User();
            formGenre_User.Show();
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

        private void LblShowWatched_Click(object sender, EventArgs e)
        {
            FormShowWatchedMovies formShowWatchedMovies = new FormShowWatchedMovies();
            formShowWatchedMovies.friendId = Convert.ToString(selectedId);
            formShowWatchedMovies.Show();
        }
    }
}
