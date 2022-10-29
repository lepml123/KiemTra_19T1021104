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
    public partial class Form1 : Form
    {
        int manhom = 0;
        int masinhvien = 0;
        public Form1()
        {
            InitializeComponent();
            NapDanhSachNhom();
        }
        void NapDanhSachNhom()
        {
            var list = NhomViewModel.GetList();
            gridnhom.DataSource = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void NapDanhSachNguoi(int id)
        {

            var list = NguoiViewModel.GetListByID(id);
            gridnguoi.DataSource = list;
        }
        private void ShowForm2()
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
        private void ClickThemNhom(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm2));
            thread.Start();
            this.Close();
        }

        private void ClickXoaNhom(object sender, EventArgs e)
        {
            if (manhom != 0)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomViewModel.XoaNhom(manhom);
                    NapDanhSachNhom();
                }
            }
        }
        private void ShowForm3()
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void ClickThemLienLac(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm3));
            thread.Start();
            this.Close();
        }
        

        private void ClickXoaLienLac(object sender, EventArgs e)
        {
            if (masinhvien != 0)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ?", "Chú ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NguoiViewModel.XoaNguoi(masinhvien);
                    NapDanhSachNhom();
                    NapDanhSachNguoi(manhom);
                }
            }
        }

        private void gridnhom_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridnhom.Rows[e.RowIndex];
            string tennhom = Convert.ToString(row.Cells["TenNhom"].Value);
            var list = NhomViewModel.GetList();
            int id = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].TenNhom.Equals(tennhom))
                {
                    id = list[i].ID;
                    manhom = id;
                }
            }
            NapDanhSachNguoi(manhom);
        }

        private void gridNguoi_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridnguoi.Rows[e.RowIndex];
            txttengoi.Text = Convert.ToString(row.Cells["TenGoi"].Value);
            txtemail.Text = Convert.ToString(row.Cells["Email"].Value);
            txtsdt.Text = Convert.ToString(row.Cells["SDT"].Value);
            string email = Convert.ToString(row.Cells["Email"].Value);

            var list = NguoiViewModel.GetListAll();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Email.Equals(email))
                {
                    txtdiachi.Text = list[i].DiaChi;
                    masinhvien = list[i].ID;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
