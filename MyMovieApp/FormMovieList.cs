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
    public partial class FormMovieList : Form
    {
        public FormMovieList()
        {
            InitializeComponent();
        }

        private void FormMovieList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet5.TblMovie' table. You can move, or remove it, as needed.
            this.tblMovieTableAdapter.Fill(this.mOVIEDataSet5.TblMovie);

        }

        int choose;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choose = dataGridView1.SelectedCells[0].RowIndex;
            FormMovieEdit formMovieEdit = new FormMovieEdit();
            formMovieEdit.id = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            formMovieEdit.movieName= dataGridView1.Rows[choose].Cells[1].Value.ToString();
            formMovieEdit.content = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            formMovieEdit.director = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            formMovieEdit.writer = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            formMovieEdit.rating = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            formMovieEdit.genreId = dataGridView1.Rows[choose].Cells[6].Value.ToString();

            formMovieEdit.Show();
        }
    }
}
