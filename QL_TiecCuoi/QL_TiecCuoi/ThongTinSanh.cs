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
    public partial class ThongTinSanh : Form
    {
        public ThongTinSanh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)  //them
        {
            if (textBoxLoai.Text != "" && textBoxTen.Text != "" && textBoxBan.Text != "" && textBoxGia.Text != "")
            {
                try
                {
                    DataProvider provider = new DataProvider();
                    string Ten = textBoxTen.Text;
                    string Loai = textBoxLoai.Text;
                    string SLBan = textBoxBan.Text;
                    string Gia = textBoxGia.Text;
                    string GhiChu = "Không";
                    if (textBoxGhiChu.Text != "")
                    {
                        GhiChu = textBoxGhiChu.Text;
                    }
                    string query = "Insert into ThongTinSanh(LoaiSanh, TenSanh, SoLuongBanToiDa, DonGiaToiThieu, GhiChu) Values('" + Loai + "', '" + Ten + "', '" + SLBan + "', '" + Gia + "', '" + GhiChu + "')";
                    int idInsert = provider.ExecuteWrite(query);
                    Console.WriteLine("ID insert" + idInsert);

                    dataGridView_load();
                    MessageBox.Show("Bạn đã thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

                }
                catch
                {
                    MessageBox.Show("Lỗi, không thêm được");
                }
            }
            else
            {
                MessageBox.Show("Lỗi, không thêm được");
            }
        }
      
        private void ThongTin_Load(object sender, EventArgs e)
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            dataGridViewDS_Sanh.DataSource = provider.ExecuteQuery(query);
            dataGridViewDS_Sanh.Columns[0].Visible = false;
            dataGridViewDS_Sanh.Columns[1].HeaderText = "Loại sảnh";
            dataGridViewDS_Sanh.Columns[2].HeaderText = "Tên sảnh";
            dataGridViewDS_Sanh.Columns[3].HeaderText = "Số lượng bàn tối đa";
            dataGridViewDS_Sanh.Columns[4].HeaderText = "Đơn giá tối thiểu";
            dataGridViewDS_Sanh.Columns[5].HeaderText = "Ghi chú";
            dataGridViewDS_Sanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDS_Sanh.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void dataGridView_load()
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            dataGridViewDS_Sanh.DataSource = provider.ExecuteQuery(query);
            dataGridViewDS_Sanh.Columns[0].Visible = false;
            dataGridViewDS_Sanh.Columns[1].HeaderText = "Loại sảnh";
            dataGridViewDS_Sanh.Columns[2].HeaderText = "Tên sảnh";
            dataGridViewDS_Sanh.Columns[3].HeaderText = "Số lượng bàn tối đa";
            dataGridViewDS_Sanh.Columns[4].HeaderText = "Đơn giá tối thiểu";
            dataGridViewDS_Sanh.Columns[5].HeaderText = "Ghi chú";
            dataGridViewDS_Sanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDS_Sanh.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void button3_Click(object sender, EventArgs e)  //xoa
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from ThongTinSanh where id='" + a + "'";
                provider.ExecuteDelete(deletedStr);
                dataGridView_load();
                Console.Write(deletedStr);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void button4_Click(object sender, EventArgs e)  //sua
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
                string ID = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[0].Value.ToString());
                string loaisanh = textBoxLoai.Text;
                string tensanh = textBoxTen.Text;
                string soluongbantoida = textBoxBan.Text;
                string dongiatoithieu = textBoxGia.Text;
                string ghichu = textBoxGhiChu.Text;

                string updateStr = "Update ThongTinSanh set TenSanh=N'" + tensanh + "',SoLuongBanToiDa=" + soluongbantoida + ",DonGiaToiThieu=" + dongiatoithieu + ",GhiChu=N'" + ghichu + "' where id = " + ID;
                Console.Write(updateStr);
                provider.ExecuteUpdate(updateStr);

                dataGridView_load();
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void DataGridViewDS_Sanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
            textBoxLoai.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[1].Value.ToString()); //loai
            textBoxTen.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[2].Value.ToString()); //ten
            textBoxBan.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[3].Value.ToString()); //soluong ban
            textBoxGia.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[4].Value.ToString()); //dongia
            textBoxGhiChu.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[5].Value.ToString()); //ghichu
        }

        private void DataGridViewDS_Sanh_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
            textBoxLoai.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[1].Value.ToString()); //loai
            textBoxTen.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[2].Value.ToString()); //ten
            textBoxBan.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[3].Value.ToString()); //soluong ban
            textBoxGia.Text = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[4].Value.ToString()); //dongia
            textBoxGhiChu.Text= Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[5].Value.ToString()); //ghichu
        }

        private void textBoxSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
