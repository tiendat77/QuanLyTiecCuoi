using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_TiecCuoi.DAO;

namespace QL_TiecCuoi
{
    public partial class LapHoaDon : Form
    {
        private DataRow dataHoaDonCurrent;

        public LapHoaDon()
        {
            InitializeComponent();
            ComboBoxMaDT_Load();
        }

        private void ComboBoxMaDT_Load()
        {
            string query = "select top 10 * from ThongTinDatTiec order by id desc";
            DataProvider provide = new DataProvider();
            comboBoxMaHopDong.DataSource = provide.ExecuteQuery(query);
            comboBoxMaHopDong.DisplayMember = "MaDatTiec";
            comboBoxMaHopDong.ValueMember = "MaDatTiec";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = @"Select a.*, p.*, c.*,d.*, e.DonGiaToiThieu
            from ThongTinDatTiec a
            left join ThongTinKhachHang p on p.id = a.MaThongTinKhachHang
            left join ChiTietDichVu c on c.id = a.MaDichVu
            left join ThucDon d on d.id = a.MaThucDon
            left join ThongTinSanh e on e.id = a.MaLoaiSanh
             where a.MaDatTiec ='" + comboBoxMaHopDong.Text + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            int i = 0;
            foreach (DataRow r in data.Rows)
            {
                i++;
            }

            if (i == 0)
            {
                MessageBox.Show("Mã hợp đồng không tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                DataRow dataRow = data.Rows[0];
                this.dataHoaDonCurrent = dataRow;
                textBoxNgayLap.Text = System.Convert.ToDateTime(dataRow["NgayLap"]).ToString("dd/MM/yyyy");
                textBoxNgayToChuc.Text = System.Convert.ToDateTime(dataRow["NgayToChuc"]).ToString("dd/MM/yyyy");
                textBoxTenKH.Text = dataRow["TenKhachHang"].ToString();
                textBoxDicChiKH.Text = dataRow["DiaChi"].ToString();
                textBoxDienThoai.Text = dataRow["DienThoai"].ToString();
                textBoxEmail.Text = dataRow["Email"].ToString();
                textBoxSoBan.Text = dataRow["SoLuongBan"].ToString();

                string query1 = "select d.* from ThongTinDatTiec a left join ThucDon d on d.id = a.MaThucDon where MaDatTiec = '" + comboBoxMaHopDong.Text + "'";
                dataGridViewThucDon.DataSource = provider.ExecuteQuery(query1);
                dataGridViewThucDon.Columns[0].Visible = false;
                dataGridViewThucDon.Columns[1].HeaderText = "Mã Thực Đơn";
                dataGridViewThucDon.Columns[2].HeaderText = "Món Khai Vị";
                dataGridViewThucDon.Columns[3].HeaderText = "Món Chính 1";
                dataGridViewThucDon.Columns[4].HeaderText = "Món Chính 2";
                dataGridViewThucDon.Columns[5].HeaderText = "Món Chính 3";
                dataGridViewThucDon.Columns[6].HeaderText = "Lẩu";
                dataGridViewThucDon.Columns[7].HeaderText = "Tráng Miệng";
                dataGridViewThucDon.Columns[8].HeaderText = "Giá Thực Đơn";
                dataGridViewThucDon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                string query2 = "select c.* from ThongTinDatTiec a left join ChiTietDichVu c on c.id = a.MaDichVu where MaDatTiec = '" + comboBoxMaHopDong.Text + "'";
                dataGridViewDichVu.DataSource = provider.ExecuteQuery(query2);
                dataGridViewDichVu.Columns[0].Visible = false;
                dataGridViewDichVu.Columns[1].HeaderText = "Mã Dịch Vụ";
                dataGridViewDichVu.Columns[2].HeaderText = "Đồ Uống 1";
                dataGridViewDichVu.Columns[3].HeaderText = "Số Lượng";
                dataGridViewDichVu.Columns[4].HeaderText = "Đồ Uống 2";
                dataGridViewDichVu.Columns[5].HeaderText = "Số Lượng";
                dataGridViewDichVu.Columns[6].HeaderText = "Bánh Kem";
                dataGridViewDichVu.Columns[7].HeaderText = "MC";
                dataGridViewDichVu.Columns[8].HeaderText = "Ban Nhạc";
                dataGridViewDichVu.Columns[9].HeaderText = "Ca Sĩ";
                dataGridViewDichVu.Columns[10].HeaderText = "Giá Dịch Vụ";
                dataGridViewDichVu.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                textBoxTienThucDon.Text = (System.Convert.ToDouble(dataRow["GiaThucDon"]) * System.Convert.ToDouble(dataRow["SoLuongBan"])).ToString();
                textBoxTienDichVu.Text = dataRow["GiaCTDichVu"].ToString();
                //textBoxTienSanh.Text = dataRow["DonGiaToiThieu"].ToString();
                //textBoxPhat.Text = dataRow["TiSoPhat"].ToString();
                textBoxTienCoc.Text = dataRow["TienCoc"].ToString();


                //tinh tien tre
                DateTime NgayLap = dateTimePickerLapHD.Value;
                DateTime NgayDai = System.Convert.ToDateTime(dataRow["NgayToChuc"]);

                TimeSpan time = NgayLap - NgayDai;
                int SoNgayTre = time.Days;
                Console.WriteLine(SoNgayTre);
                if (SoNgayTre >= 0)
                {
                    textBoxPhat.Text = (SoNgayTre * 0.01).ToString();
                }
                else
                {
                    textBoxPhat.Text = "0";
                }

                ///
                if (radioButtonKhong.Checked)
                {
                    tinhTienKhongPhat();
                }
                else
                {
                    tinhTienCoPhat();
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            String query = @"select a.*,t.*
            from HoaDon a
            left join ThongTinDatTiec t on a.MaDatTiec   = t.id
            where  t.MaDatTiec =N'" + comboBoxMaHopDong.Text + "'";
            DataProvider provider = new DataProvider();
            DataTable tb = provider.ExecuteQuery(query);
            int i = 0;
            foreach (DataRow r in tb.Rows)
            {
                i++;
            }

            if (i > 0)
            {
                MessageBox.Show("Lỗi, Hợp đồng này đã được thanh toán!");
            }
            else
            {
                try
                {


                    Console.WriteLine(this.dataHoaDonCurrent["id"].ToString());
                    string query1 = "Insert into HoaDon(NgayLap, MaDatTiec, MaThongTinKhachHang , MaLoaiSanh, MaChiTietDichVu, MaThucDon, TienPhat,TongTienHoaDon,TienCoc ,TienConLai) Values(N'"
                        + dateTimePickerLapHD.Value.Date.ToString("dd-MMM-yy") + " ', "
                        + this.dataHoaDonCurrent["id"] + " , "
                        + this.dataHoaDonCurrent["MaThongTinKhachHang"] + " , "
                        + this.dataHoaDonCurrent["MaLoaiSanh"] + " , "
                        + this.dataHoaDonCurrent["MaDichVu"] + " , "
                        + this.dataHoaDonCurrent["MaThucDon"] + " , N'"
                        + textBoxTienPhat.Text + "' , N'"
                        + textBoxTongHoaDon.Text + "' , N'"
                        + textBoxTienCoc.Text + "' , N'"
                        + textBoxConLai.Text + "')";

                    Console.WriteLine(query1);
                    provider.ExecuteWrite(query1);

                    MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                    MessageBox.Show("Lỗi, không lưu được");
                }
            }
        }

        private void RadioButtonKhong_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKhong.Checked)
            {
                tinhTienKhongPhat();
            }
        }

        private void RadioButtonCo_CheckedChanged(object sender, EventArgs e)
        {
            tinhTienCoPhat();
        }

        private void DateTimePickerLapHD_ValueChanged(object sender, EventArgs e)
        {
            if (!textBoxNgayToChuc.Text.Equals(""))
            {
                string query = @"Select a.*,p.*
                from ThongTinDatTiec a
                left join ThongTinKhachHang p on p.id = a.MaThongTinKhachHang
                where a.MaDatTiec = N'" + comboBoxMaHopDong.Text + "'";

                DataProvider provider = new DataProvider();
                DataTable tb = provider.ExecuteQuery(query);
                DataRow row = tb.Rows[0];
                DateTime NgayLap = dateTimePickerLapHD.Value;
                DateTime NgayDai = System.Convert.ToDateTime(row["NgayToChuc"]);
                TimeSpan time = NgayLap - NgayDai;
                int SoNgayTre = time.Days;
                Console.WriteLine(SoNgayTre);
                if (SoNgayTre >= 0)
                {
                    textBoxPhat.Text = (SoNgayTre * 0.01).ToString();
                }
                else
                {
                    textBoxPhat.Text = "0";
                }

                /// cap nhat lai tien phat
                if (radioButtonCo.Checked)
                {
                    tinhTienCoPhat();
                }
                else
                {
                    tinhTienKhongPhat();
                }

            }

         
        }

        private void ComboBoxMaHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = @"Select a.*, p.*, c.*,d.*, e.DonGiaToiThieu
            from ThongTinDatTiec a
            left join ThongTinKhachHang p on p.id = a.MaThongTinKhachHang
            left join ChiTietDichVu c on c.id = a.MaDichVu
            left join ThucDon d on d.id = a.MaThucDon
            left join ThongTinSanh e on e.id = a.MaLoaiSanh
             where a.MaDatTiec ='" + comboBoxMaHopDong.Text + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            int i = 0;
            foreach (DataRow r in data.Rows)
            {
                i++;
            }

            if (i == 0)
            {
            }
            else
            {
                DataRow dataRow = data.Rows[0];
                this.dataHoaDonCurrent = dataRow;
                textBoxNgayLap.Text = System.Convert.ToDateTime(dataRow["NgayLap"]).ToString("dd/MM/yyyy");
                textBoxNgayToChuc.Text = System.Convert.ToDateTime(dataRow["NgayToChuc"]).ToString("dd/MM/yyyy");
                textBoxTenKH.Text = dataRow["TenKhachHang"].ToString();
                textBoxDicChiKH.Text = dataRow["DiaChi"].ToString();
                textBoxDienThoai.Text = dataRow["DienThoai"].ToString();
                textBoxEmail.Text = dataRow["Email"].ToString();
                textBoxSoBan.Text = dataRow["SoLuongBan"].ToString();

                string query1 = "select d.* from ThongTinDatTiec a left join ThucDon d on d.id = a.MaThucDon where MaDatTiec = '" + comboBoxMaHopDong.Text + "'";
                dataGridViewThucDon.DataSource = provider.ExecuteQuery(query1);
                dataGridViewThucDon.Columns[0].Visible = false;
                dataGridViewThucDon.Columns[1].HeaderText = "Mã Thực Đơn";
                dataGridViewThucDon.Columns[2].HeaderText = "Món Khai Vị";
                dataGridViewThucDon.Columns[3].HeaderText = "Món Chính 1";
                dataGridViewThucDon.Columns[4].HeaderText = "Món Chính 2";
                dataGridViewThucDon.Columns[5].HeaderText = "Món Chính 3";
                dataGridViewThucDon.Columns[6].HeaderText = "Lẩu";
                dataGridViewThucDon.Columns[7].HeaderText = "Tráng Miệng";
                dataGridViewThucDon.Columns[8].HeaderText = "Giá Thực Đơn";
                dataGridViewThucDon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                string query2 = "select c.* from ThongTinDatTiec a left join ChiTietDichVu c on c.id = a.MaDichVu where MaDatTiec = '" + comboBoxMaHopDong.Text + "'";
                dataGridViewDichVu.DataSource = provider.ExecuteQuery(query2);
                dataGridViewDichVu.Columns[0].Visible = false;
                dataGridViewDichVu.Columns[1].HeaderText = "Mã Dịch Vụ";
                dataGridViewDichVu.Columns[2].HeaderText = "Đồ Uống 1";
                dataGridViewDichVu.Columns[3].HeaderText = "Số Lượng";
                dataGridViewDichVu.Columns[4].HeaderText = "Đồ Uống 2";
                dataGridViewDichVu.Columns[5].HeaderText = "Số Lượng";
                dataGridViewDichVu.Columns[6].HeaderText = "Bánh Kem";
                dataGridViewDichVu.Columns[7].HeaderText = "MC";
                dataGridViewDichVu.Columns[8].HeaderText = "Ban Nhạc";
                dataGridViewDichVu.Columns[9].HeaderText = "Ca Sĩ";
                dataGridViewDichVu.Columns[10].HeaderText = "Giá Dịch Vụ";
                dataGridViewDichVu.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                textBoxTienThucDon.Text = (System.Convert.ToDouble(dataRow["GiaThucDon"]) * System.Convert.ToDouble(dataRow["SoLuongBan"])).ToString();
                textBoxTienDichVu.Text = dataRow["GiaCTDichVu"].ToString();
                //textBoxTienSanh.Text = dataRow["DonGiaToiThieu"].ToString();
                //textBoxPhat.Text = dataRow["TiSoPhat"].ToString();
                textBoxTienCoc.Text = dataRow["TienCoc"].ToString();


                //tinh tien tre
                DateTime NgayLap = dateTimePickerLapHD.Value;
                DateTime NgayDai = System.Convert.ToDateTime(dataRow["NgayToChuc"]);

                TimeSpan time = NgayLap - NgayDai;
                int SoNgayTre = time.Days;
                Console.WriteLine(SoNgayTre);
                if (SoNgayTre >= 0)
                {
                    textBoxPhat.Text = (SoNgayTre * 0.01).ToString();
                }
                else
                {
                    textBoxPhat.Text = "0";
                }

                ///
                if (radioButtonKhong.Checked)
                {
                    tinhTienKhongPhat();
                }

            }
        }

        private void ComboBoxMaHopDong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string query = @"Select a.*, p.*, c.*,d.*, e.DonGiaToiThieu
            from ThongTinDatTiec a
            left join ThongTinKhachHang p on p.id = a.MaThongTinKhachHang
            left join ChiTietDichVu c on c.id = a.MaDichVu
            left join ThucDon d on d.id = a.MaThucDon
            left join ThongTinSanh e on e.id = a.MaLoaiSanh
             where a.MaDatTiec ='" + comboBoxMaHopDong.Text + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            int i = 0;
            foreach (DataRow r in data.Rows)
            {
                i++;
            }

            if (i == 0)
            {
               
            }
            else
            {
                DataRow dataRow = data.Rows[0];
                this.dataHoaDonCurrent = dataRow;
                textBoxNgayLap.Text = System.Convert.ToDateTime(dataRow["NgayLap"]).ToString("dd/MM/yyyy");
                textBoxNgayToChuc.Text = System.Convert.ToDateTime(dataRow["NgayToChuc"]).ToString("dd/MM/yyyy");
                textBoxTenKH.Text = dataRow["TenKhachHang"].ToString();
                textBoxDicChiKH.Text = dataRow["DiaChi"].ToString();
                textBoxDienThoai.Text = dataRow["DienThoai"].ToString();
                textBoxEmail.Text = dataRow["Email"].ToString();
                textBoxSoBan.Text = dataRow["SoLuongBan"].ToString();

                string query1 = "select d.* from ThongTinDatTiec a left join ThucDon d on d.id = a.MaThucDon where MaDatTiec = '" + comboBoxMaHopDong.Text + "'";
                dataGridViewThucDon.DataSource = provider.ExecuteQuery(query1);
                dataGridViewThucDon.Columns[0].Visible = false;
                dataGridViewThucDon.Columns[1].HeaderText = "Mã Thực Đơn";
                dataGridViewThucDon.Columns[2].HeaderText = "Món Khai Vị";
                dataGridViewThucDon.Columns[3].HeaderText = "Món Chính 1";
                dataGridViewThucDon.Columns[4].HeaderText = "Món Chính 2";
                dataGridViewThucDon.Columns[5].HeaderText = "Món Chính 3";
                dataGridViewThucDon.Columns[6].HeaderText = "Lẩu";
                dataGridViewThucDon.Columns[7].HeaderText = "Tráng Miệng";
                dataGridViewThucDon.Columns[8].HeaderText = "Giá Thực Đơn";
                dataGridViewThucDon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                string query2 = "select c.* from ThongTinDatTiec a left join ChiTietDichVu c on c.id = a.MaDichVu where MaDatTiec = '" + comboBoxMaHopDong.Text + "'";
                dataGridViewDichVu.DataSource = provider.ExecuteQuery(query2);
                dataGridViewDichVu.Columns[0].Visible = false;
                dataGridViewDichVu.Columns[1].HeaderText = "Mã Dịch Vụ";
                dataGridViewDichVu.Columns[2].HeaderText = "Đồ Uống 1";
                dataGridViewDichVu.Columns[3].HeaderText = "Số Lượng";
                dataGridViewDichVu.Columns[4].HeaderText = "Đồ Uống 2";
                dataGridViewDichVu.Columns[5].HeaderText = "Số Lượng";
                dataGridViewDichVu.Columns[6].HeaderText = "Bánh Kem";
                dataGridViewDichVu.Columns[7].HeaderText = "MC";
                dataGridViewDichVu.Columns[8].HeaderText = "Ban Nhạc";
                dataGridViewDichVu.Columns[9].HeaderText = "Ca Sĩ";
                dataGridViewDichVu.Columns[10].HeaderText = "Giá Dịch Vụ";
                dataGridViewDichVu.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                textBoxTienThucDon.Text = (System.Convert.ToDouble(dataRow["GiaThucDon"]) * System.Convert.ToDouble(dataRow["SoLuongBan"])).ToString();
                textBoxTienDichVu.Text = dataRow["GiaCTDichVu"].ToString();
                //textBoxTienSanh.Text = dataRow["DonGiaToiThieu"].ToString();
                //textBoxPhat.Text = dataRow["TiSoPhat"].ToString();
                textBoxTienCoc.Text = dataRow["TienCoc"].ToString();


                //tinh tien tre
                DateTime NgayLap = dateTimePickerLapHD.Value;
                DateTime NgayDai = System.Convert.ToDateTime(dataRow["NgayToChuc"]);

                TimeSpan time = NgayLap - NgayDai;
                int SoNgayTre = time.Days;
                Console.WriteLine(SoNgayTre);
                if (SoNgayTre >= 0)
                {
                    textBoxPhat.Text = (SoNgayTre * 0.01).ToString();
                }
                else
                {
                    textBoxPhat.Text = "0";
                }

                ///
                if (radioButtonKhong.Checked)
                {
                    tinhTienKhongPhat();
                }
                else
                {
                    tinhTienCoPhat();
                }

            }
        }

        private void tinhTienKhongPhat()
        {
            double i2 = 0;
            textBoxTienPhat.Text = i2.ToString();
            double a1, b1, c1, d1;
            //bool isAValid = double.TryParse(textBoxTienSanh.Text.Trim(), out a1);
            bool isBValid = double.TryParse(textBoxTienPhat.Text.Trim(), out b1);
            bool isCValid = double.TryParse(textBoxTienThucDon.Text.Trim(), out c1);
            bool isDValid = double.TryParse(textBoxTienDichVu.Text.Trim(), out d1);
            if (isBValid && isCValid && isDValid)
                textBoxTongHoaDon.Text = (b1 + c1 + d1).ToString();

            else
                textBoxTongHoaDon.Text = "Invalid input";
            double e1, f1;
            bool isEValid = double.TryParse(textBoxTongHoaDon.Text.Trim(), out e1);
            bool isFValid = double.TryParse(textBoxTienCoc.Text.Trim(), out f1);
            if (isEValid && isFValid)
                textBoxConLai.Text = (e1 - f1).ToString();
            else
                textBoxConLai.Text = "Invalid input";
        }

        private void tinhTienCoPhat()
        {
            double a, b;
            double a2, c2, d2;
            //tinh tong hoa don
            //bool isA2Valid = double.TryParse(textBoxTienSanh.Text.Trim(), out a2);
            bool isC2Valid = double.TryParse(textBoxTienThucDon.Text.Trim(), out c2);
            bool isD2Valid = double.TryParse(textBoxTienDichVu.Text.Trim(), out d2);
            if (isC2Valid && isD2Valid)
                textBoxTongHoaDon.Text = (c2 + d2).ToString();
            else
                textBoxTongHoaDon.Text = "Invalid input";
            //tinh tien phat
            bool isAValid = double.TryParse(textBoxTongHoaDon.Text.Trim(), out a);
            bool isBValid = double.TryParse(textBoxPhat.Text.Trim(), out b);
            if (isAValid && isBValid)
            {
                textBoxTienPhat.Text = (a * b).ToString();
            }
            else
                textBoxTienPhat.Text = "Invalid input";

            double e2, f2, g2;
            bool isEValid = double.TryParse(textBoxTongHoaDon.Text.Trim(), out e2);
            bool isFValid = double.TryParse(textBoxTienCoc.Text.Trim(), out f2);
            bool isGValid = double.TryParse(textBoxTienPhat.Text.Trim(), out g2);
            if (isEValid && isFValid && isGValid)
                textBoxConLai.Text = (e2 - f2 + g2).ToString();
            else
                textBoxConLai.Text = "Invalid input";
        }
    }



}
