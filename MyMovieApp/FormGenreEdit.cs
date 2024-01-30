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
using System.Xml.Linq;

namespace MyMovieApp
{
    public partial class FormGenreEdit : Form
    {
        public FormGenreEdit()
        {
            InitializeComponent();
        }

        public string genreId, genreName;

        MySqlConnection conn =new MySqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("update TblGenre Set Name=@P1 where Id=@P2", conn.connection());
                cmd.Parameters.AddWithValue("@P1", TxtGenreName.Text);
                cmd.Parameters.AddWithValue("@P2", TxtId.Text);
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

        private void FormGenreEdit_Load(object sender, EventArgs e)
        {
            TxtId.Text = genreId;
            TxtGenreName.Text = genreName;
        }
    }
}
