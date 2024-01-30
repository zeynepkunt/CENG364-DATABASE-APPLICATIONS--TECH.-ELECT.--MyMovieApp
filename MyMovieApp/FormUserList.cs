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
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOVIEDataSet9.TblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.mOVIEDataSet9.TblUser);

        }

        int choose;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            choose = dataGridView1.SelectedCells[0].RowIndex;
            FormUserEdit formUserEdit = new FormUserEdit();
            formUserEdit.userId = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            formUserEdit.username = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            formUserEdit.name = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            formUserEdit.surname = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            formUserEdit.email = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            formUserEdit.password = dataGridView1.Rows[choose].Cells[5].Value.ToString();

            formUserEdit.Show();
        }
    }
}
