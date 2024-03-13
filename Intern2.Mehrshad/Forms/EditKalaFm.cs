using DataLeyer.MyDbContext;
using DataLeyer.ViewModels;
using ServiceLeyer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern2.Mehrshad.Forms
{
    public partial class EditKalaFm : Form
    {
        private readonly IKalaRepository _kala;
        private int _kalaID;
        private KalaEditVm kalaEditVm ;
        public EditKalaFm( IKalaRepository kalaRepo , int kalaID )
        {
            InitializeComponent();
            _kalaID = kalaID;
            _kala = kalaRepo;
            FillKala();
        }

        private void ClearTextBox()
        {
            NameBox.Text = string.Empty;
            SerialNumberBox.Text = string.Empty;
        }
        private void FillKala()
        {
            kalaEditVm = _kala.FindKala(_kalaID);

            if(kalaEditVm == null)
            {
                var message = "kala is not founded";
                MessageBox.Show(message);

                Thread.Sleep(200);
                this.Close();
            }

            NameBox.Text = kalaEditVm.Name;
            SerialNumberBox.Text = kalaEditVm.SerialNumber;
            CategoryCat.SelectedValue = kalaEditVm.CategoryID;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            kalaEditVm.Name = NameBox.Text.Replace(" " , "");
            kalaEditVm.SerialNumber = SerialNumberBox.Text.Replace(" ", "");
            kalaEditVm.CategoryID = (int)CategoryCat.SelectedValue;

            var result = _kala.EditKala(kalaEditVm);
            if(result == 100)
            {
                var messge = "done";
                MessageBox.Show(messge);
                Thread.Sleep(200);
                this.Close();
            }
            else
            {
                var message = "somthing wrong";
                MessageBox.Show(message);
                Thread.Sleep(200);

                ClearTextBox();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditKalaFm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intern3DataSet3.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.intern3DataSet3.Category);
        }
    }
}
