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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyMovieApp
{
    public partial class FormShowWatchlist : Form
    {
        public FormShowWatchlist()
        {
            InitializeComponent();
        }
        public string friendId;
        private void FormShowWatchlist_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            DataTable dt = new DataTable();
            try
            {
                string _sql = "SELECT ROW_NUMBER()  OVER (ORDER BY Mv.Name ) AS Number, Mv.Name " +
                              "FROM TblMovie Mv " +
                              "INNER JOIN TblWatchList Wa " +
                              "ON Wa.MovieId = Mv.Id " +
                              "WHERE Wa.UserId = '" + friendId + "' " +
                              "ORDER BY Mv.Name";


                SqlCommand cmd = new SqlCommand(_sql, conn.connection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
            }
            finally
            {
                if (conn != null)
                {
                    conn.connection().Close();
                }
            }
            dataGridView1.DataSource= dt;
        }
    }
}
