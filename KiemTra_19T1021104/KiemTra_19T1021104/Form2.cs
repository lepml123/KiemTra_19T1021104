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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void ShowForm1()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nhom = new Nhom
            {
                TenNhom = textTen.Text,
            };
            NhomViewModel.ThemNhom(nhom);
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }
    }
}
