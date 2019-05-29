using System;
using QL_TiecCuoi.DAO;
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
    public partial class ThucDonDichVu : Form
    {
        private LapHopDong form;
        private int SLban;
        public ThucDonDichVu(LapHopDong form,int SLban)
        {
            this.form = form;
            this.SLban = SLban;
            InitializeComponent();
            setComponent_Thucdon();
            setComponent_DichVu();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void setComponent_Thucdon()
        {
            string query = "select * from monan where MaLoaiMonAn ='KV'";
            DataProvider provider = new DataProvider();
            comboBoxKhaiVi.DataSource = provider.ExecuteQuery(query);
            comboBoxKhaiVi.DisplayMember = "TenMonAn";
            comboBoxKhaiVi.ValueMember = "MaMonAn";


            query = "select * from monan where MaLoaiMonAn ='MC'";
            comboBoxMC1.DataSource = provider.ExecuteQuery(query);
            comboBoxMC1.DisplayMember = "TenMonAn";
            comboBoxMC1.ValueMember = "MaMonAn";


            comboBoxMC2.DataSource = provider.ExecuteQuery(query);
            comboBoxMC2.DisplayMember = "TenMonAn";
            comboBoxMC2.ValueMember = "MaMonAn";

            comboBoxMC3.DataSource = provider.ExecuteQuery(query);
            comboBoxMC3.DisplayMember = "TenMonAn";
            comboBoxMC3.ValueMember = "MaMonAn";

            query = "select * from monan where MaLoaiMonAn ='ML'";
            comboBoxLau.DataSource = provider.ExecuteQuery(query);
            comboBoxLau.DisplayMember = "TenMonAn";
            comboBoxLau.ValueMember = "MaMonAn";

            query = "select * from monan where MaLoaiMonAn ='TM'";
            comboBoxTM.DataSource = provider.ExecuteQuery(query);
            comboBoxTM.DisplayMember = "TenMonAn";
            comboBoxTM.ValueMember = "MaMonAn";
        }

        private void setComponent_DichVu()
        {
            
            string query = "select * from dichvu where MaLoaiDichVu ='DU'";
            DataProvider provider = new DataProvider();
            comboBoxDU1.DataSource = provider.ExecuteQuery(query);
            comboBoxDU1.DisplayMember = "TenDichVu";
            comboBoxDU1.ValueMember = "MaDichVu";

            comboBoxDU2.DataSource = provider.ExecuteQuery(query);
            comboBoxDU2.DisplayMember = "TenDichVu";
            comboBoxDU2.ValueMember = "MaDichVu";


            query = "select * from dichvu where MaLoaiDichVu ='BK'";
            comboBoxBK.DataSource = provider.ExecuteQuery(query);
            comboBoxBK.DisplayMember = "TenDichVu";
            comboBoxBK.ValueMember = "MaDichVu";

            query = "select * from dichvu where MaLoaiDichVu ='MC'";
            comboBoxMC.DataSource = provider.ExecuteQuery(query);
            comboBoxMC.DisplayMember = "TenDichVu";
            comboBoxMC.ValueMember = "MaDichVu";

            query = "select * from dichvu where MaLoaiDichVu ='BN'";
            comboBoxBN.DataSource = provider.ExecuteQuery(query);
            comboBoxBN.DisplayMember = "TenDichVu";
            comboBoxBN.ValueMember = "MaDichVu";

            query = "select * from dichvu where MaLoaiDichVu ='CS'";
            comboBoxCS.DataSource = provider.ExecuteQuery(query);
            comboBoxCS.DisplayMember = "TenDichVu";
            comboBoxCS.ValueMember = "MaDichVu";
        }

        private void buttonDongY_Click(object sender, EventArgs e)
        {
            if(textBoxSL2.Text.Trim().CompareTo("")==0 || textBoxSL2.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng đồ uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DongY_handle();
            }
        }

        private void DongY_handle()
        {
            double GiaThucDon = 0;
            double GiaDichVu = 0;

            GiaThucDon += TinhGiaThucDon(comboBoxKhaiVi);
            GiaThucDon += TinhGiaThucDon(comboBoxMC1);
            GiaThucDon += TinhGiaThucDon(comboBoxMC2);
            GiaThucDon += TinhGiaThucDon(comboBoxMC3);
            GiaThucDon += TinhGiaThucDon(comboBoxLau);
            GiaThucDon += TinhGiaThucDon(comboBoxTM);

            //Console.WriteLine(GiaThucDon);

            GiaDichVu += TinhGiaDichVu(comboBoxDU1) * Convert.ToDouble(textBoxSL1.Text);
            GiaDichVu += TinhGiaDichVu(comboBoxDU2) * Convert.ToDouble(textBoxSL2.Text);
            GiaDichVu += TinhGiaDichVu(comboBoxBK);
            GiaDichVu += TinhGiaDichVu(comboBoxBN);
            GiaDichVu += TinhGiaDichVu(comboBoxMC);
            GiaDichVu += TinhGiaDichVu(comboBoxCS);

            //Console.WriteLine(GiaDichVu);

            DataProvider provider = new DataProvider();
            String query = "insert into THUCDON values (N'"+comboBoxKhaiVi.Text.ToString()+"', N'"+comboBoxMC1.Text.ToString()+"',N'"+comboBoxMC2.Text.ToString()+"',N'"+comboBoxMC3.Text.ToString()+"', N'"+comboBoxLau.Text.ToString()+"', N'"+comboBoxTM.Text.ToString()+"',"+GiaThucDon+")";
            provider.ExecuteQuery(query);
            query = "insert into CHITIETDICHVU values (N'" + comboBoxDU1.Text.ToString() + "',"+textBoxSL1.Text+", N'" + comboBoxDU2.Text.ToString() + "',"+textBoxSL2.Text+",N'" + comboBoxBK.Text.ToString() + "',N'" + comboBoxMC.Text.ToString() + "', N'" + comboBoxBN.Text.ToString() + "', N'" + comboBoxCS.Text.ToString() + "'," + GiaDichVu + ")";
            provider.ExecuteQuery(query);

            DataTable data1  = provider.ExecuteQuery("SELECT TOP 1 id FROM THUCDON ORDER BY id DESC");
            DataTable data2 = provider.ExecuteQuery("SELECT TOP 1 id FROM CHITIETDICHVU ORDER BY id DESC");
            this.form.setMaThucDonDichVu(data1.Rows[0]["id"].ToString(), data2.Rows[0]["id"].ToString());

            data1 = provider.ExecuteQuery("SELECT TOP 1 GiaThucDon FROM THUCDON ORDER BY id DESC"); 
            data2 = provider.ExecuteQuery("SELECT TOP 1 GiaCTDichVu FROM CHITIETDICHVU ORDER BY id DESC");
            double thanhtien = Convert.ToDouble(data2.Rows[0]["GiaCTDichVu"] )/SLban + Convert.ToDouble(data1.Rows[0]["GiaThucDon"]);

            this.form.setGiaThucDonDichVu(data1.Rows[0]["GiaThucDon"].ToString(), data2.Rows[0]["GiaCTDichVu"].ToString(),Convert.ToInt32(thanhtien).ToString());

            this.Hide();

        }
        
        private double TinhGiaThucDon(ComboBox cbx)
        {
            String temp = "select * from MONAN where MaMonAn ='" + cbx.SelectedValue + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(temp);
            return Convert.ToDouble(data.Rows[0]["GiaMonAn"]);
        }

        private double TinhGiaDichVu(ComboBox cbx)
        {
            String temp = "select * from DICHVU where MaDichVu ='" + cbx.SelectedValue + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(temp);
            return Convert.ToDouble(data.Rows[0]["GiaDichVu"]);
        }
        private void textBoxSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))

            {
                e.Handled = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new LapHopDong();
            frm.ShowDialog();
        }
    }
}
