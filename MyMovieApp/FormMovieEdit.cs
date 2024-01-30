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
    public partial class FormMovieEdit : Form
    {
        public FormMovieEdit()
        {
            InitializeComponent();
        }

        public string id,movieName,content,director,writer,rating,genreId;
        MySqlConnection conn=new MySqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update TblMovie Set Name=@PName, MovieContent=@PMovieContent, Director=@PDirector, Writers=@PWriters, Rating=@PRating, GenreId=@PGenreId where Id=@PId", conn.connection());

                if (float.TryParse(TxtRating.Text, out float rating))
                {
                    cmd.Parameters.AddWithValue("@PName", TxtMovieName.Text);
                    cmd.Parameters.AddWithValue("@PMovieContent", TxtContent.Text);
                    cmd.Parameters.AddWithValue("@PDirector", TxtDirector.Text);
                    cmd.Parameters.AddWithValue("@PWriters", TxtWriter.Text);
                    cmd.Parameters.AddWithValue("@PRating", rating); // Use the converted value
                    cmd.Parameters.AddWithValue("@PGenreId", CmbGenre.SelectedValue);
                    cmd.Parameters.AddWithValue("@PId", TxtId.Text);
                    cmd.ExecuteNonQuery(); // Executes statement against the connection and returns the number of rows affected
                    conn.connection().Close();
                    MessageBox.Show("Successful");

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

        private void FormMovieEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet7.TblGenre' table. You can move, or remove it, as needed.
            this.tblGenreTableAdapter.Fill(this.mOVIEDataSet7.TblGenre);
            TxtId.Text = id;
            TxtMovieName.Text = movieName;
            TxtContent.Text = content;
            TxtDirector.Text = director;
            TxtWriter.Text = writer;
            TxtRating.Text = rating;
            CmbGenre.Text = genreId;
        }
    }
}
