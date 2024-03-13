using ServiceLeyer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern2.Mehrshad.Forms
{
    public partial class AllKalaFm : Form
    {
        private readonly IKalaRepository _kalaRepo;
        public AllKalaFm( IKalaRepository kalaRepository )
        {
            InitializeComponent();
            _kalaRepo = kalaRepository;

            // Attach event handler to DataGridView's CellDoubleClick event
            DataGridKala.CellDoubleClick += DataGridView_CellDoubleClick;
        }

        private void AllKalaFm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intern3DataSet2.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.intern3DataSet2.Category);
            // TODO: This line of code loads data into the 'intern3DataSet.Kala' table. You can move, or remove it, as needed.
            this.kalaTableAdapter.Fill(this.intern3DataSet.Kala);

        }

        private void RefreshPage()
        {
            // TODO: This line of code loads data into the 'intern3DataSet2.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.intern3DataSet2.Category);
            // TODO: This line of code loads data into the 'intern3DataSet.Kala' table. You can move, or remove it, as needed.
            this.kalaTableAdapter.Fill(this.intern3DataSet.Kala);
        }
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if double-clicked cell is in a row (not header or empty space)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = DataGridKala.Rows[e.RowIndex];

                // Example: Display a message box with the content of the selected row
                MessageBox.Show($"Double-clicked row: {selectedRow.Cells[0].Value}, {selectedRow.Cells[2].Value}");

                var kalaID = selectedRow.Cells[0].Value;

                var editKala = new EditKalaFm( _kalaRepo , Convert.ToInt32(kalaID));
                editKala.ShowDialog();


                // refresh 
                RefreshPage();
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var createFm = new CreateKalaFm();
            createFm.ShowDialog();

            // select
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
