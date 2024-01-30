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
    public partial class FormViewComment : Form
    {
        public FormViewComment()
        {
            InitializeComponent();
        }

        private void FormViewComment_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =MovieDatabase.GetSelectedUserComments();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            try
            {
                if (commentId == -1)
                {
                    MessageBox.Show("Please select movie");
                    return; 
                }
                SqlCommand cmd = new SqlCommand("DELETE from TblComments where Id=@p1 ", conn.connection());
                cmd.Parameters.AddWithValue("@p1", commentId);
                cmd.ExecuteNonQuery();
                conn.connection().Close();
                MessageBox.Show("Successful");
                dataGridView1.DataSource = MovieDatabase.GetSelectedUserComments();

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

        int commentId = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string comment;
            int choose;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            comment = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            commentId =Convert.ToInt32(comment);
        }
    }
}
