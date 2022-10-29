using KiemTra_19T1021104.Model;
using KiemTra_19T1021104.ViewModel;
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

namespace KiemTra_19T1021104
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            NapDSNhom();
        }
        private void ShowForm1()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = NhomViewModel.GetList();
            var id = 0;
            var chimuc = cbxNhom.SelectedIndex;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == chimuc)
                {
                    id = list[i].ID;
                }
            }
            var nguoi = new Nguoi
            {
                TenGoi = textTen.Text,
                Email = textEmail.Text,
                DiaChi = textDiachi.Text,
                SDT = textSDT.Text,
                IDNhom = id,

            };
            NguoiViewModel.ThemNguoi(nguoi);
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }
        void NapDSNhom()
        {
            var list = NhomViewModel.GetList();
            for (int i = 0; i < list.Count; i++)
            {
                cbxNhom.Items.Add(list[i].TenNhom);
            }

        }
    }
}
