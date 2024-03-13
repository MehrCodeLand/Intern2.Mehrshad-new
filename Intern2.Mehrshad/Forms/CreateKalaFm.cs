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
    public partial class CreateKalaFm : Form
    {
        public CreateKalaFm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateKalaFm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intern3DataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.intern3DataSet1.Category);

        }
    }
}
