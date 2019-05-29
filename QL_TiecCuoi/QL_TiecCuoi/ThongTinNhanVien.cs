using QL_TiecCuoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TiecCuoi
{
    public partial class ThongTinNhanVien : Form
    {
        public ThongTinNhanVien()
        {
            InitializeComponent();
            NhanVien_Load();
            Show_ComboboxMaNhanVien();
            Show_ComboboxChucVu();
            Show_ComboboxCa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }
        public void Show_ComboboxMaNhanVien()
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            comboBoxSanh.DataSource = provider.ExecuteQuery(query);
            comboBoxSanh.DisplayMember = "LoaiSanh";
            comboBoxSanh.ValueMember = "id";
        }
        public void Show_ComboboxChucVu()
        {
            string query = "select * from ChucVu";
            DataProvider provider = new DataProvider();
            comboBoxChucVu.DataSource = provider.ExecuteQuery(query);
            comboBoxChucVu.DisplayMember = "ChucVu";
            comboBoxChucVu.ValueMember = "ChucVu";
        }
        public void Show_ComboboxCa()
        {
            string query = "select * from Ca";
            DataProvider provider = new DataProvider();
            comboBoxCa.DataSource = provider.ExecuteQuery(query);
            comboBoxCa.DisplayMember = "TenCa";
            comboBoxCa.ValueMember = "TenCa";
        }
        private void NhanVien_Load()
        {
            string query = "select * from NhanVien";
            DataProvider provider = new DataProvider();
            dataGridViewDSNhanVien.DataSource = provider.ExecuteQuery(query);
            dataGridViewDSNhanVien.Columns[0].Visible = false;
            dataGridViewDSNhanVien.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridViewDSNhanVien.Columns[2].HeaderText = "Tên Nhân Viên";
            dataGridViewDSNhanVien.Columns[3].HeaderText = "Số Điện Thoại";
            dataGridViewDSNhanVien.Columns[4].HeaderText = "Địa Chỉ";
            dataGridViewDSNhanVien.Columns[5].HeaderText = "Loại Sảnh";
            dataGridViewDSNhanVien.Columns[6].HeaderText = "Chức Vụ";
            dataGridViewDSNhanVien.Columns[7].HeaderText = "Ca";
            dataGridViewDSNhanVien.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridViewDSNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxTenNhanVien.Text != "" && textBoxSoDienThoai.Text != "" && textBoxDiaChi.Text != "")
            {
                try
                {
                    DataProvider provider = new DataProvider();
                    string query = "Insert into NhanVien (TenNhanVien, SoDienThoai, DiaChi, LoaiSanh, ChucVu, Ca) Values(N'" + textBoxTenNhanVien.Text + "' , N'"
                    + textBoxSoDienThoai.Text + "' , N'" + textBoxDiaChi.Text + "',N'"
                    + comboBoxSanh.Text.Trim() + "',N'"
                     + comboBoxChucVu.Text.Trim() + "',N'"
                     + comboBoxCa.Text.Trim() + "')";
                    provider.ExecuteWrite(query);
                    Console.Write(query);
                    MessageBox.Show("Bạn đã thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    NhanVien_Load();
                }
                catch
                {
                    MessageBox.Show("Lỗi! Không thêm được, vui lòng điền đầy đủ thông tin");
                }
            }
            else
                MessageBox.Show("Lỗi! Không thêm được, vui lòng điền đầy đủ thông tin");
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDSNhanVien.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from NhanVien where id='" + a + "'";
                provider.ExecuteDelete(deletedStr);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                NhanVien_Load();
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDSNhanVien.CurrentCell.RowIndex;
                string maNhanVien = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[1].Value.ToString());
                string tenNhanVien;
                if (textBoxTenNhanVien.Text.Equals("")) {
                    tenNhanVien = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[2].Value.ToString());
                }
                else
                {
                    tenNhanVien = textBoxTenNhanVien.Text.ToString();
                }
                string soDienThoai;
                if (textBoxSoDienThoai.Text.Equals(""))
                {
                    soDienThoai = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[3].Value.ToString());
                }
                else
                {
                    soDienThoai = textBoxSoDienThoai.Text.ToString();
                }
                string diaChi;
                if (textBoxDiaChi.Text.Equals(""))
                {
                    diaChi = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[4].Value.ToString());
                }
                else
                {
                    diaChi = textBoxDiaChi.Text.ToString();
                }

                string loaiSanh = comboBoxSanh.Text; //Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[5].Value.ToString());
                string chucVu = comboBoxChucVu.Text;//Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[6].Value.ToString());
                string ca = comboBoxCa.Text;//Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[7].Value.ToString());

                string updateStr = "Update NhanVien set TenNhanVien=N'" + tenNhanVien + "',SoDienThoai=N'" + soDienThoai + "',DiaChi=N'" + diaChi + "',LoaiSanh = N'" + loaiSanh + "',ChucVu=N'" + chucVu + "',Ca=N'" + ca + "' where MaNhanVien = '" + maNhanVien + "'";
                Console.Write(updateStr);
                provider.ExecuteUpdate(updateStr);

                NhanVien_Load();
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }
        }

        private void textBoxTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void textBoxSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }


        private void DataGridViewDSNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("cell click");
            Console.WriteLine(e.RowIndex);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewDSNhanVien.Rows[e.RowIndex];
                textBoxTenNhanVien.Text = row.Cells[2].Value.ToString();
                textBoxSoDienThoai.Text = row.Cells[3].Value.ToString();
                textBoxDiaChi.Text = row.Cells[4].Value.ToString();       
                comboBoxSanh.Text = row.Cells[5].Value.ToString();
                comboBoxChucVu.SelectedValue = row.Cells[6].Value;
                comboBoxCa.SelectedValue = row.Cells[7].Value;

            }
        }

        private void DataGridViewDSNhanVien_CellContentClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine("cell click");
            Console.WriteLine(e.RowIndex);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewDSNhanVien.Rows[e.RowIndex];
                textBoxTenNhanVien.Text = row.Cells[2].Value.ToString();
                textBoxSoDienThoai.Text = row.Cells[3].Value.ToString();
                textBoxDiaChi.Text = row.Cells[4].Value.ToString();
                comboBoxSanh.Text = row.Cells[5].Value.ToString();
                comboBoxChucVu.SelectedValue = row.Cells[6].Value;
                comboBoxCa.SelectedValue = row.Cells[7].Value;

            }
        }


    }
}
