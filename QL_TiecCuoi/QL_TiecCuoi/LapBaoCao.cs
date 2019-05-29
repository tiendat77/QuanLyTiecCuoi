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
    public partial class LapBaoCao : Form
    {
        public LapBaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                DateTime dtLap = dateTimePickerNgayLap.Value;
                string datelap = dtLap.Date.ToString("dd-MMM-yy"); 
                DateTime dtBaoCao = dateTimePickerNgayBaoCao.Value;
                string datebc = dtBaoCao.Date.ToString("dd-MMM-yy");
                Console.WriteLine(datebc + datelap);
                string query1 = "Insert into LapBaoCao ( NgayLap,NgayBaoCao,SoLuongTiec, DoanhThu) Values('"
                    + datelap + "' , '"
                    + datebc + "' , '"
                    + textBoxSoLuongTiec.Text + "' , '"
                    + textBoxDoanhThu.Text + "' )";
                Console.WriteLine(query1);
                provider.ExecuteWrite(query1);

                MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi, không thực hiện được");
            }

        }


        private void textBoxSoLuongTiec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxDoanhThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }


        private void updateBaoCao()
        {
            //
            String query2 = 
                "declare @nammin INT; " +
                "declare @nammax INT ; " +
                "declare @cnt INT =1; " +
                "declare @idmin INT;" +
                "declare @idmax INT ;" +
                "SET @nammin = (select min(YEAR(NgayBaoCao)) from LapBaoCao);" +
                "SET @nammax = (select max(YEAR(NgayBaoCao)) from LapBaoCao); " +
                "WHILE @nammin <= @nammax " +
                "BEGIN " +
                    "SET @cnt = 1; " +
                    "WHILE @cnt <= 12 " +
                    "BEGIN " +
                        "IF EXISTS(SELECT * from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin) " +
                        "BEGIN " +
                            "IF EXISTS(SELECT * from BaoCaoDoanhThu where Thang=@cnt AND Nam=@nammin) " +
                            "BEGIN " +
                                "UPDATE BaoCaoDoanhThu SET TongDoanhThu=(select sum(DoanhThu) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin)," +
                                "TongTiec = (select sum(SoLuongTiec) from LapBaoCao where MONTH(NgayBaoCao) = @cnt AND YEAR(NgayBaoCao)= @nammin) " +
                                "where Thang=@cnt AND Nam=@nammin ; " +
                            "END; " +
                            "ELSE " +
                            "BEGIN " +
                                "insert into BaoCaoDoanhThu values( @nammin,@cnt,(select sum(SoLuongTiec) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin),(select sum(DoanhThu) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin) ); " +
                            "END; " +
                            
                            "SET @idmin = (select min(id) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin); " +
                            "SET @idmax = (select max(id) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin); " +
                            "WHILE @idmin <= @idmax " +
                            "BEGIN " +
                                "declare @tongdoanhthuthang FLOAT = (select sum(DoanhThu) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin); " +
                                "UPDATE LapBaoCao SET Tile = ((select DoanhThu from LapBaoCao where id = @idmin AND MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin)/@tongdoanhthuthang) " +
                                "where  id = @idmin AND MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao) = @nammin; " +
                                "SET @idmin=@idmin+1; " +
                            "END ; " +
                        "END; " +
                    "SET @cnt = @cnt + 1; " +
                    "END; " +
                "SET @nammin = @nammin + 1; " +
                "END; ";
            DataProvider provider = new DataProvider();
            provider.ExecuteQuery(query2);

        }

    }
}

