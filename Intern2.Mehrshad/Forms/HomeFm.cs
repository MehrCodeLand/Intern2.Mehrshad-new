using System;
using System.Windows.Forms;
using System.Threading;
using ServiceLeyer.Services;

namespace Intern2.Mehrshad.Forms
{
    public partial class HomeFm : Form
    {
        private readonly IKalaRepository _repo;
        public HomeFm( IKalaRepository repo )
        {
            InitializeComponent();
            _repo = repo;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var message = "bye";
            MessageBox.Show(message);
            Thread.Sleep(500);

            Application.Exit();
        }

        private void SeeAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void AllKalaBtn_Click(object sender, EventArgs e)
        {
            var allKala = new AllKalaFm(_repo);
            allKala.ShowDialog();
        }
    }
}
