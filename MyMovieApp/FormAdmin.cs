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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet3.TblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.mOVIEDataSet3.TblUser);
            // TODO: This line of code loads data into the 'mOVIEDataSet2.TblMovie' table. You can move, or remove it, as needed.
            this.tblMovieTableAdapter.Fill(this.mOVIEDataSet2.TblMovie);
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToLongTimeString();
            label2.Text=DateTime.Now.ToLongDateString();
        }

        private void userListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserList formUserList = new FormUserList();
            formUserList.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormMovieList formMovieList = new FormMovieList();
            formMovieList.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGenreList formGenreList = new FormGenreList();
            formGenreList.Show();
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
