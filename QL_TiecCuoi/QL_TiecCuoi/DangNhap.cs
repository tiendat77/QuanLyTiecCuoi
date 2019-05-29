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


namespace QL_TiecCuoi
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            textBoxTenDangNhap.ForeColor = Color.LightGray;
            textBoxTenDangNhap.Text = "Tên Đăng Nhập";
            this.textBoxTenDangNhap.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBoxTenDangNhap.Enter += new System.EventHandler(this.textBox1_Enter);

            textBoxMatKhau.ForeColor = Color.LightGray;
            textBoxMatKhau.Text = "Mật Khẩu";
            this.textBoxMatKhau.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBoxMatKhau.Enter += new System.EventHandler(this.textBox2_Enter);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "")
            {
                textBoxTenDangNhap.Text = "Tên Đăng Nhập";
                textBoxTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "Tên Đăng Nhập")
            {
                textBoxTenDangNhap.Text = "";
                textBoxTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text == "Mật Khẩu")
            {
                textBoxMatKhau.Text = "";
                textBoxMatKhau.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text == "")
            {
                textBoxMatKhau.Text = "Mật Khẩu";
                textBoxMatKhau.ForeColor = Color.Gray;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
            string TenDangNhap = textBoxTenDangNhap.Text;
            string MatKhau = textBoxMatKhau.Text;
            ///if (_DangNhap(TenDangNhap, MatKhau))
            if (true)
            {
                this.Hide();
                Form frm = new Menu();
                frm.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    this.Hide();
                    Form frm = new DangNhap();
                    frm.ShowDialog();
                }
            }
        }
        bool _DangNhap(string TenDangNhap, string MatKhau)
        {
            return DangNhapDAO.Instance.DangNhap(TenDangNhap, MatKhau);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

       
    }
}
