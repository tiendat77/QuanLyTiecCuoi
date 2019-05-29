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
    public partial class ThongTinDichVuMonAn : Form
    {
        public ThongTinDichVuMonAn()
        {
            InitializeComponent();
            ThongTinMonAn_Load();
            ThongTinDichVu_load();
        }

       private void ThongTinMonAn_Load()
       {
            string query = "SELECT MONAN.id, MaMonAn, TenMonAn, LOAIMONAN.TenLoaiMonAn, GiaMonAn FROM MONAN INNER JOIN LOAIMONAN ON LOAIMONAN.MaLoaiMonAn = MONAN.MaLoaiMonAn";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Mã Món Ăn";
            dataGridView1.Columns[2].HeaderText = "Tên Món Ăn";
            dataGridView1.Columns[3].HeaderText = "Loại Món Ăn";
            dataGridView1.Columns[4].HeaderText = "Giá";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ComboBoxLoaiMonAn_show();
        }

        private void ComboBoxLoaiMonAn_show()
        {
            string query = "select * from LOAIMONAN";
            DataProvider provider = new DataProvider();
            comboBox1.DataSource = provider.ExecuteQuery(query);
            comboBox1.DisplayMember = "TenLoaiMonAn";
            comboBox1.ValueMember = "MaLoaiMonAn";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[2].Value.ToString());
            comboBox1.Text = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[3].Value.ToString());
            textBox3.Text = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[4].Value.ToString());
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[2].Value.ToString());
            comboBox1.Text = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[3].Value.ToString());
            textBox3.Text = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[4].Value.ToString());
        }

        private void Button1_Click(object sender, EventArgs e) //Them mon an
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                try
                {
                    DataProvider provider = new DataProvider();
                    string TenMon = textBox1.Text;
                    string LoaiMon = comboBox1.SelectedValue.ToString();
                    string Gia = textBox3.Text;
                    string query = "Insert into MonAn Values(N'" + TenMon + "' , '" + LoaiMon + "' , '" + Gia + "')";
                    int idInsert = provider.ExecuteWrite(query);
                    Console.WriteLine("ID insert" + idInsert);

                    ThongTinMonAn_Load();
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

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)  //Sua mon an
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString());
                string TenMon = textBox1.Text;
                string Gia = textBox3.Text;
                string updateStr = "UPDATE MONAN SET TenMonAn = N'"+ TenMon +"', GiaMonAn = "+ Gia +" WHERE id = "+ id;
                Console.Write(updateStr);
                provider.ExecuteUpdate(updateStr);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                ThongTinMonAn_Load();
            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }
        }

        private void Button3_Click(object sender, EventArgs e)  //xoa mon an
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from MONAN where id=" + id;
                provider.ExecuteDelete(deletedStr);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                ThongTinMonAn_Load();

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void ThongTinDichVu_load()
        {
            string query = "SELECT DICHVU.id, MaDichVu, TenDichVu, LOAIDICHVU.TenLoaiDichVu, GiaDichVu FROM DICHVU INNER JOIN LOAIDICHVU ON LOAIDICHVU.MaLoaiDichVu = DICHVU.MaLoaiDichVu";
            DataProvider provider = new DataProvider();
            dataGridView2.DataSource = provider.ExecuteQuery(query);
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Mã Dịch Vụ";
            dataGridView2.Columns[2].HeaderText = "Tên Dịch Vụ";
            dataGridView2.Columns[3].HeaderText = "Loại Dịch Vụ";
            dataGridView2.Columns[4].HeaderText = "Giá";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ComboBoxLoaiDichVu_show();
        }

        private void ComboBoxLoaiDichVu_show()
        {
            string query = "select * from LOAIDICHVU";
            DataProvider provider = new DataProvider();
            comboBox2.DataSource = provider.ExecuteQuery(query);
            comboBox2.DisplayMember = "TenLoaiDichVu";
            comboBox2.ValueMember = "MaLoaiDichVu";
        }

        private void Button7_Click(object sender, EventArgs e) //Them dich vu
        {
            if (textBox4.Text != "" && textBox2.Text != "")
            {
                try
                {
                    DataProvider provider = new DataProvider();
                    string TenDV = textBox4.Text;
                    string LoaiDV = comboBox2.SelectedValue.ToString();
                    string Gia = textBox2.Text;
                    string query = "Insert into DICHVU Values(N'" + TenDV + "' , '" + LoaiDV + "' , '" + Gia + "')";
                    int idInsert = provider.ExecuteWrite(query);
                    Console.WriteLine("ID insert" + idInsert);

                    ThongTinDichVu_load();
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

        private void Button6_Click(object sender, EventArgs e) //Sua Dich Vu
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridView2.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[0].Value.ToString());
                string TenDV = textBox4.Text;
                string Gia = textBox2.Text;
                string updateStr = "UPDATE DICHVU SET TenDichVu = N'" + TenDV + "', GiaDichVu = " + Gia + " WHERE id = " + id;
                Console.Write(updateStr);
                provider.ExecuteUpdate(updateStr);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                ThongTinDichVu_load();
            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }
        }

        private void Button5_Click(object sender, EventArgs e) //Xoa dich vu
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridView2.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from DICHVU where id=" + id;
                provider.ExecuteDelete(deletedStr);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                ThongTinDichVu_load();

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex = dataGridView2.CurrentCell.RowIndex;
            textBox4.Text = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[2].Value.ToString());
            comboBox2.Text = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[3].Value.ToString());
            textBox2.Text = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[4].Value.ToString());
        }

        private void DataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentIndex = dataGridView2.CurrentCell.RowIndex;
            textBox4.Text = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[2].Value.ToString());
            comboBox2.Text = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[3].Value.ToString());
            textBox2.Text = Convert.ToString(dataGridView2.Rows[CurrentIndex].Cells[4].Value.ToString());
        }

        private void textBoxGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
