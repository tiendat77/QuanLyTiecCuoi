using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace QL_TiecCuoi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void TrangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://oscarpalace.vn/");
        }

        private void LapHopDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new LapHopDong();
            frm.ShowDialog();
        }

        private void LapHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new LapHoaDon();
            frm.ShowDialog();
        }

        private void ThoatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void BaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new BaoCaoDoanhThu();
            frm.ShowDialog();
        }

        private void ThôngTinNhanVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ThongTinNhanVien();
            frm.ShowDialog();
        }

        private void ThongTinDVMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ThongTinDichVuMonAn();
            frm.ShowDialog();
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuHoaDon();
            frm.ShowDialog();
        }

        private void TiecCuoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuTiecCuoi();
            frm.ShowDialog();
        }

        private void DiaChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new DiaChiNhaHang();
            frm.ShowDialog();
        }

        private void ThongTinSanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ThongTinSanh();
            frm.ShowDialog();
        }
    }
}
