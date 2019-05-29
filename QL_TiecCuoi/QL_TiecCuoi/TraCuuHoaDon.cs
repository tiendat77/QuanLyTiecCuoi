using QL_TiecCuoi.DAO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_TiecCuoi
{
    public partial class TraCuuHoaDon : Form
    {
        public TraCuuHoaDon()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }


        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (textBoxTimHoaDon.Text.Equals(""))
            {
                MessageBox.Show("Lỗi, Vui lòng nhập thông tin tìm kiếm!");
            }
            else
            {
                string valueFilter = textBoxTimHoaDon.Text.ToString().Trim();
                string fieldFilter = "MaKhachHang";
                if (radioButtonMaHD.Checked)
                {
                    fieldFilter = "TenKhachHang";
                }

                string query1 = @"Select h.MaHoaDon, p.MaKhachHang, p.TenKhachHang, p.NgayLap, p.DienThoai, p.TenChuRe, p.TenCoDau, s.TenSanh, dv.MaChiTietDichVu, td.MaThucDon, h.TongTienHoaDon, h.TienPhat, h.TienCoc, h.TienConLai
                from HoaDon h
                left join ThongTinKhachHang p on p.id = h.MaThongTinKhachHang
                left join ThongTinDatTiec t on t.id = h.MaDatTiec
                left join ThongTinSanh s on s.id = h.MaLoaiSanh
                left join ChiTietDichVu dv on dv.id = h.MaChiTietDichVu
                left join ThucDon td on td.id = h.MaThucDon where " + fieldFilter + " like N'%" + valueFilter + "%'";
                Console.Write(query1);
                DataProvider provider = new DataProvider();
                dataGridViewTraCuuHoaDon.DataSource = provider.ExecuteQuery(query1);
                DatTen();
            }

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = @"Select h.MaHoaDon, p.MaKhachHang, p.TenKhachHang, p.NgayLap,  p.DienThoai, p.TenChuRe, p.TenCoDau, s.TenSanh, dv.MaChiTietDichVu, td.MaThucDon, h.TongTienHoaDon, h.TienPhat, h.TienCoc, h.TienConLai
            from HoaDon h
            left join ThongTinKhachHang p on p.id = h.MaThongTinKhachHang
            left join ThongTinDatTiec t on t.id = h.MaDatTiec
            left join ThongTinSanh s on s.id = h.MaLoaiSanh
            left join ChiTietDichVu dv on dv.id = h.MaChiTietDichVu
            left join ThucDon td on td.id = h.MaThucDon ";
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuHoaDon.DataSource = provider.ExecuteQuery(query);
            DatTen();

        }

        private void DatTen()
        {
            dataGridViewTraCuuHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dataGridViewTraCuuHoaDon.Columns[1].HeaderText = "Mã Khách Hàng";
            dataGridViewTraCuuHoaDon.Columns[2].HeaderText = "Tên Khách Hàng";
            dataGridViewTraCuuHoaDon.Columns[3].HeaderText = "Ngày Lập Hóa Đơn";
            dataGridViewTraCuuHoaDon.Columns[4].HeaderText = "Số ĐTKH";
            dataGridViewTraCuuHoaDon.Columns[5].HeaderText = "Tên Chú Rể";
            dataGridViewTraCuuHoaDon.Columns[6].HeaderText = "Tên Cô Dâu";
            dataGridViewTraCuuHoaDon.Columns[7].HeaderText = "Tên Sảnh";
            dataGridViewTraCuuHoaDon.Columns[8].HeaderText = "Mã Dịch Vụ";
            dataGridViewTraCuuHoaDon.Columns[9].HeaderText = "Mã Thực Đơn";
            dataGridViewTraCuuHoaDon.Columns[10].HeaderText = "Tổng Tiền HĐ";
            dataGridViewTraCuuHoaDon.Columns[11].HeaderText = "Tiền Phạt";
            dataGridViewTraCuuHoaDon.Columns[12].HeaderText = "Tiền Cọc";
            dataGridViewTraCuuHoaDon.Columns[13].HeaderText = "Tiền Còn Lại";
            dataGridViewTraCuuHoaDon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridViewTraCuuHoaDon.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
