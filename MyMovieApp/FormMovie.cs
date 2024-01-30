using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyMovieApp
{
    public partial class FormMovie : Form
    {
        public FormMovie()
        {
            InitializeComponent();
        }

        MySqlConnection conn=new MySqlConnection();
        private void FormMovie_Load(object sender, EventArgs e)
        {
            this.tblGenreTableAdapter.Fill(this.mOVIEDataSet6.TblGenre);
            dataGridView1.DataSource = MovieDatabase.GetAllMoviesForAdmin();
            
            SqlCommand cmd2 = new SqlCommand("select Name from TblGenre", conn.connection());
            conn.connection().Close();


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TblMovie (Name, MovieContent, Director, Writers, Rating, GenreId) VALUES (@PName, @PMovieContent, @PDirector, @PWriters, @PRating, @PGenreId)", conn.connection());

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(TxtMovieName.Text) ||
                    string.IsNullOrWhiteSpace(TxtContent.Text) ||
                    string.IsNullOrWhiteSpace(TxtDirector.Text) ||
                    string.IsNullOrWhiteSpace(TxtWriter.Text) ||
                    string.IsNullOrWhiteSpace(TxtRating.Text) ||
                    CmbGenre.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return; // Exit the method if any field is empty
                }

                // Convert TxtRating.Text to decimal
                decimal rating;
                if (decimal.TryParse(TxtRating.Text, out rating))
                {
                    cmd.Parameters.AddWithValue("@PName", TxtMovieName.Text);
                    cmd.Parameters.AddWithValue("@PMovieContent", TxtContent.Text);
                    cmd.Parameters.AddWithValue("@PDirector", TxtDirector.Text);
                    cmd.Parameters.AddWithValue("@PWriters", TxtWriter.Text);
                    cmd.Parameters.Add("@PRating", SqlDbType.Decimal).Value = rating;
                    cmd.Parameters.AddWithValue("@PGenreId", CmbGenre.SelectedValue);
                    cmd.Parameters.AddWithValue("@PId", TxtId.Text);
                    cmd.ExecuteNonQuery(); // Executes statement against the connection and returns the number of rows affected
                }
                else
                {
                    // Handle the case where TxtRating.Text is not a valid decimal
                    // You can show an error message or take appropriate action.
                }

                conn.connection().Close();
                MessageBox.Show("Successful");
                dataGridView1.DataSource = MovieDatabase.GetAllMoviesForAdmin();
                TxtMovieName.Clear();
                TxtContent.Clear();
                TxtDirector.Clear();
                TxtWriter.Clear();
                TxtRating.Clear();
                CmbGenre.SelectedIndex = -1;
                TxtId.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Try again.");
                throw;
            }

        // rating değerini baştan sıfır vermeliyim dokunulmamalı diye düşündüm!!!
        //try
        //{
        //    SqlCommand cmd = new SqlCommand("insert into TblMovie ( Name, MovieContent, Director, Writers, Rating, GenreId) values (@PName, @PMovieContent, @PDirector, @PWriters,@PRating,@PGenreId )", conn.connection());


        //    cmd.Parameters.AddWithValue("@PName", TxtMovieName.Text);
        //    cmd.Parameters.AddWithValue("@PMovieContent", TxtContent.Text);
        //    cmd.Parameters.AddWithValue("@PDirector", TxtDirector.Text);
        //    cmd.Parameters.AddWithValue("@PWriters", TxtWriter.Text);
        //    cmd.Parameters.AddWithValue("@PRating", 0);
        //    cmd.Parameters.AddWithValue("@PGenreId", CmbGenre.SelectedValue);
        //    cmd.Parameters.AddWithValue("@PId", TxtId.Text);
        //    cmd.ExecuteNonQuery(); // Executes statement against the connection and returns the number of rows affected

        //    conn.connection().Close();
        //    MessageBox.Show("Successful");
        //    this.tblMovieTableAdapter.Fill(this.mOVIEDataSet1.TblMovie);
        //    TxtMovieName.Clear();
        //    TxtContent.Clear();
        //    TxtDirector.Clear();
        //    TxtWriter.Clear();
        //    TxtRating.Clear();
        //    CmbGenre.SelectedIndex = -1;
        //    TxtId.Clear();
        //}
        //catch (Exception)
        //{
        //    MessageBox.Show("Error.Try again.");
        //    throw;
        //}
    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtId.Text))
                {
                    MessageBox.Show("Please select a movie to delete.");
                    return; // Exit the method if Id is empty
                }
                SqlCommand cmd = new SqlCommand("delete from TblMovie where Id=@p1", conn.connection());
                cmd.Parameters.AddWithValue("@p1",TxtId.Text);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
                dataGridView1.DataSource = MovieDatabase.GetAllMoviesForAdmin();
                TxtMovieName.Clear();
                TxtContent.Clear();
                TxtDirector.Clear();
                TxtWriter.Clear();
                TxtRating.Clear();
                CmbGenre.SelectedIndex = -1;
                TxtId.Clear();
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
            string id, name, movieContent, director, writers, rating, genreId;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            name = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            movieContent = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            director = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            writers = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            rating = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            genreId = dataGridView1.Rows[choose].Cells[6].Value.ToString();

            TxtId.Text = id;
            TxtMovieName.Text = name;
            TxtContent.Text = movieContent;
            TxtDirector.Text = director;
            TxtWriter.Text = writers;
            TxtRating.Text = rating;
            CmbGenre.Text = genreId;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TblMovie Set Name=@PName, MovieContent=@PMovieContent, Director=@PDirector, Writers=@PWriters, Rating=@PRating, GenreId=@PGenreId where Id=@PId", conn.connection());
                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(TxtMovieName.Text) ||
                    string.IsNullOrWhiteSpace(TxtContent.Text) ||
                    string.IsNullOrWhiteSpace(TxtDirector.Text) ||
                    string.IsNullOrWhiteSpace(TxtWriter.Text) ||
                    string.IsNullOrWhiteSpace(TxtRating.Text) ||
                    CmbGenre.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select movie from table.");
                    return; // Exit the method if any field is empty
                }

                decimal rating;

                if (decimal.TryParse(TxtRating.Text, out rating))
                {
                    cmd.Parameters.AddWithValue("@PName", TxtMovieName.Text);
                    cmd.Parameters.AddWithValue("@PMovieContent", TxtContent.Text);
                    cmd.Parameters.AddWithValue("@PDirector", TxtDirector.Text);
                    cmd.Parameters.AddWithValue("@PWriters", TxtWriter.Text);
                    cmd.Parameters.AddWithValue("@PRating", SqlDbType.Decimal).Value = rating;
                    cmd.Parameters.AddWithValue("@PGenreId", CmbGenre.SelectedValue);
                    cmd.Parameters.AddWithValue("@PId",TxtId.Text);
                    cmd.ExecuteNonQuery(); // Executes statement against the connection and returns the number of rows affected
                    conn.connection().Close();
                    MessageBox.Show("Successful");
                    dataGridView1.DataSource = MovieDatabase.GetAllMoviesForAdmin();
                    TxtMovieName.Clear();
                    TxtContent.Clear();
                    TxtDirector.Clear();
                    TxtWriter.Clear();
                    TxtRating.Clear();
                    CmbGenre.SelectedIndex = -1;
                    TxtId.Clear();
                }
                else
                {
                    // Handle the case where TxtRating.Text is not a valid decimal
                    // You can show an error message or take appropriate action.
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error.Try again.");
                throw;
            }
        }

        // Show tooltip on hover
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Add Movie");

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Delete Movie");

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Update Movie");

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
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
