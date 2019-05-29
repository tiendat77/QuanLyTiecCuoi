using QL_TiecCuoi.DAO;
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

namespace QL_TiecCuoi
{
    public partial class LapHopDong : Form
    {
        public LapHopDong()
        {
            InitializeComponent();
            Show_ComboboxLoaiSanh();
            Show_ComboboxCa();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form frm = new LapHopDong();
            frm.ShowDialog();

        }

        public void setMaThucDonDichVu(String TD, String DV)
        {
            this.textBoxMaThucDon.Text = TD;
            this.textBoxMaDichVu.Text = DV;
        }

        public void setGiaThucDonDichVu(String GTD, String GDV, String ThanhTien)
        {
            this.textBoxGiaThucDon.Text = GTD;
            this.textBoxGiaDichVu.Text = GDV;
            this.textBoxThanhTien.Text = ThanhTien;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            if (textBoxTenKhachHang.Text != "" && textBoxTenChuRe.Text != "" && textBoxTenCoDau.Text != "" && textBoxDienThoai.Text != "" && textBoxDiaChi.Text != "" && textBoxEmail.Text != "" && textBoxTienCoc.Text != "" && textBoxSoLuongBan.Text != "" && textBoxSLNhanVien.Text != "")
            {
                int b;
                bool isAValid_1 = int.TryParse(textBoxSoLuongBan.Text.Trim(), out b);
                string sCombobox = this.comboBoxLoaiSanh.Text.Normalize();
                Console.WriteLine(sCombobox);
                String query = "select * from THONGTINSANH where LoaiSanh ='" + comboBoxLoaiSanh.Text + "'";
                DataTable data = dataProvider.ExecuteQuery(query);

                if (b > Convert.ToInt32(data.Rows[0]["SoLuongBanToiDa"]))
                {
                    MessageBox.Show("Số lượng bàn tối đa là " + Convert.ToInt32(data.Rows[0]["SoLuongBanToiDa"]) + " bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Convert.ToInt32(textBoxThanhTien.Text) < Convert.ToInt32(data.Rows[0]["DonGiaToiThieu"]))
                {
                    MessageBox.Show("Thành tiền thấp hơn đơn giá tối thiểu, Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    int c;
                    bool isAValid_2 = int.TryParse(textBoxSLNhanVien.Text.Trim(), out c);
                    if (b != c)
                    {
                        MessageBox.Show("Số lượng nhân viên phải bằng số lượng bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (KtraToChuc())
                        {
                            string formatDate = "yyyy-MM-dd";
                            int IdThongTinKhachHang;
                            query = "Insert into ThongTinKhachHang Values('"
                                    + dateTimePickerNgayLap.Value.ToString(formatDate) + "', N'"
                                    + textBoxTenKhachHang.Text + "' , N'"
                                    + textBoxTenChuRe.Text + "' , N'"
                                    + textBoxTenCoDau.Text + "' , N'"
                                    + textBoxDiaChi.Text + "' , '"
                                    + textBoxDienThoai.Text + "', '"
                                    + textBoxEmail.Text + "', '"
                                    + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "' , '"
                                    + textBoxTienCoc.Text + "')";
                            IdThongTinKhachHang = dataProvider.ExecuteWrite(query);

                            query = "Insert into ThongTinDatTiec  Values('"
                                    + dateTimePickerNgayLap.Value.ToString(formatDate) + "', "
                                    + IdThongTinKhachHang + ","
                                    + comboBoxLoaiSanh.SelectedValue.ToString() + ","
                                    + textBoxMaDichVu.Text.ToString() + ","
                                    + textBoxMaThucDon.Text.ToString() + ","
                                    + textBoxSLNhanVien.Text + ", "
                                    + textBoxSoLuongBan.Text + ", N'"
                                    + comboBoxCa.Text.ToString().Trim() + "' )";
                            dataProvider.ExecuteQuery(query);
                            MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        }
                    }
                }
            }


            //else
            //{
            //    if (textBoxTenKhachHang.Text.Trim().CompareTo("") == 0)
            //    {
            //        MessageBox.Show("Họ tên không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (textBoxTenChuRe.Text.Trim().CompareTo("") == 0)
            //    {
            //        MessageBox.Show("Tên chú rể không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (textBoxTenCoDau.Text.Trim().CompareTo("") == 0)
            //    {
            //        MessageBox.Show("Tên cô dâu không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (textBoxDiaChi.Text.Trim().CompareTo("") == 0)
            //    {
            //        MessageBox.Show("Địa chỉ không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (textBoxEmail.Text.Trim().CompareTo("") == 0)
            //    {
            //        MessageBox.Show("Email không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (textBoxDienThoai.Text.Trim().CompareTo("") == 0)
            //    {
            //        MessageBox.Show("Số điện thoại không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    if (textBoxSoLuongBan.Text.Trim().CompareTo("") == 0)
            //    {
            //        MessageBox.Show("Số lượng bàn không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
        }

        public void Show_ComboboxLoaiSanh()
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            comboBoxLoaiSanh.DataSource = provider.ExecuteQuery(query);
            comboBoxLoaiSanh.DisplayMember = "LoaiSanh";
            comboBoxLoaiSanh.ValueMember = "id";
        }

        public void Show_ComboboxCa()
        {
            string query = "select * from CA";
            DataProvider provider = new DataProvider();
            comboBoxCa.DataSource = provider.ExecuteQuery(query);
            comboBoxCa.DisplayMember = "TenCa";
            comboBoxCa.ValueMember = "TenCa";
        }

        private void textBoxTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }



        private void textBoxDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSLNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool KtraToChuc()
        {
            string formatDate = "yyyy-MM-dd ";
            string ngayToChuc = dateTimePickerNgayToChuc.Value.ToString(formatDate);
            string loaiSanh = comboBoxLoaiSanh.SelectedValue.ToString();
            string ca = comboBoxCa.Text.ToString();
            string query0 = "select count(*) as count from ThongTinDatTiec left join ThongTinKhachHang on ThongTinKhachHang.id = ThongTinDatTiec.MaThongTinKhachHang where ThongTinKhachHang.NgayToChuc = '" + ngayToChuc + "' and ThongTinDatTiec.Ca = N'" + ca + "' and ThongTinDatTiec.MaLoaiSanh = " + loaiSanh;
            DataProvider provider = new DataProvider();
            DataTable t = provider.ExecuteQuery(query0);
            int a;
            int.TryParse(t.Rows[0]["count"].ToString(), out a);
            // Console.WriteLine("----------------------------");
            Console.WriteLine(a);
            if (a > 0)
            {
                MessageBox.Show("Đã có khách đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if(textBoxSoLuongBan.Text != "")
            {
                Form frm = new ThucDonDichVu(this, Convert.ToInt32(textBoxSoLuongBan.Text));
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSoLuongBan_TextChanged(object sender, EventArgs e)
        {
            textBoxSLNhanVien.Text = textBoxSoLuongBan.Text;
        }
    }
}
