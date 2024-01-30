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
    public partial class FormTop25Movies : Form
    {
        public FormTop25Movies()
        {
            InitializeComponent();
        }

        private void FormTop25Movies_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource=MovieDatabase.Get25Movies();
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
    }
}
