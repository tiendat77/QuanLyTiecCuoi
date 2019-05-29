using System;
using System.Windows.Forms;
using QL_TiecCuoi.DAO;

namespace QL_TiecCuoi
{
    public partial class TraCuuTiecCuoi : Form
    {
        public TraCuuTiecCuoi()
        {
            InitializeComponent();

        }

        private void showTiecCuoi()
        {
            string query1 = "SELECT TenKhachHang, DienThoai, TenChuRe, TenCoDau,THONGTINSANH.LoaiSanh, NgayToChuc, THONGTINDATTIEC.Ca, THONGTINDATTIEC.SoLuongBan FROM THONGTINKHACHHANG INNER JOIN THONGTINDATTIEC ON THONGTINDATTIEC.MaThongTinKhachHang = THONGTINKHACHHANG.id INNER JOIN THONGTINSANH ON THONGTINDATTIEC.MaLoaiSanh = THONGTINSANH.id";
            Console.Write(query1);
            DataProvider provider = new DataProvider();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.DataSource = provider.ExecuteQuery(query1);
            dataGridView1.Columns[0].HeaderText = "Tên Khách Hàng";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].HeaderText = "Điện Thoại";
            dataGridView1.Columns[2].HeaderText = "Tên Chú Rể";
            dataGridView1.Columns[3].HeaderText = "Tên Cô Dâu";
            dataGridView1.Columns[4].HeaderText = "Loại Sảnh";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[5].HeaderText = "Ngày Tổ Chức";
            dataGridView1.Columns[6].HeaderText = "Ca";
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[7].HeaderText = "Số Lượng bàn";
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showTiecCuoi();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string valueFilter = textBoxTraCuu.Text.ToString();
            if (valueFilter.CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin tra cứu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                string fieldFilter = "TenChuRe";
                if (radioButtonSDT.Checked)
                {
                    fieldFilter = "DienThoai";
                }
                string query1 = "SELECT TenKhachHang, DienThoai, TenChuRe, TenCoDau,THONGTINSANH.LoaiSanh, NgayToChuc, THONGTINDATTIEC.Ca, THONGTINDATTIEC.SoLuongBan FROM THONGTINKHACHHANG INNER JOIN THONGTINDATTIEC ON THONGTINDATTIEC.MaThongTinKhachHang = THONGTINKHACHHANG.id INNER JOIN THONGTINSANH ON THONGTINDATTIEC.MaLoaiSanh = THONGTINSANH.id where THONGTINKHACHHANG."+fieldFilter+" =N'"+valueFilter+"'";
                //string query1 = "Select a.*, p.* from ThongTinDatTiec a inner join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang where " + fieldFilter + " like '%" + valueFilter + "%'";
                Console.Write(query1);
                DataProvider provider = new DataProvider();
                dataGridView1.DataSource = provider.ExecuteQuery(query1);
                dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }

        }
    }
}
