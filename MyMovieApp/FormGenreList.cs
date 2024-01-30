using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace MyMovieApp
{
    public partial class FormGenreList : Form
    {
        public FormGenreList()
        {
            InitializeComponent();
        }

        private void FormGenreList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet10.TblGenre' table. You can move, or remove it, as needed.
            this.tblGenreTableAdapter.Fill(this.mOVIEDataSet10.TblGenre);

        }

        int choose;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choose = dataGridView1.SelectedCells[0].RowIndex;
            FormGenreEdit formGenreEdit = new FormGenreEdit();
            formGenreEdit.genreId = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            formGenreEdit.genreName = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            formGenreEdit.Show();
        }
    }
}
