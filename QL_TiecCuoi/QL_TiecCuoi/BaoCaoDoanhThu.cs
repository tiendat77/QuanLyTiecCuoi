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
    public partial class BaoCaoDoanhThu : Form
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
           
            string query = "Select NgayBaoCao, SoLuongTiec, DoanhThu, TiLe from LapBaoCao where MONTH(NgayBaoCao)=" + dateTimePicker1.Value.Month + " and YEAR(NgayBaoCao)=" +dateTimePicker1.Value.Year;
            DataProvider provider = new DataProvider();
            dataGridViewDSBaoCao.DataSource = provider.ExecuteQuery(query);

            updateDoanhThuThang();
            updateDoanhThuNgay();
            string queryDoanhThu = "Select TongTiec, TongDoanhThu from BaoCaoDoanhThu where Thang=" + dateTimePicker1.Value.Month + " and Nam=" + dateTimePicker1.Value.Year; ;
            dataGridViewTongDoanhThu.DataSource = provider.ExecuteQuery(queryDoanhThu);

            dataGridView_Header();
        }

        private void updateDoanhThuThang() {
            String query2 =
"declare @nammin INT; " +
"declare @nammax INT; " +
"declare @ngaymin INT; " +
"declare @ngaymax INT; " +
"declare @cnt INT =1;" +
"SET @nammin = (select min(YEAR(NgayLap)) from HoaDon);" +
"SET @nammax = (select max(YEAR(NgayLap)) from HoaDon);" +
"WHILE @nammin <= @nammax " +
"BEGIN " +
"	SET @cnt = 1;" +
"	WHILE @cnt <= 12 " +
"	BEGIN " +
"		IF  EXISTS(SELECT * from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin) " +
"		BEGIN " +
"			IF  EXISTS(SELECT * from BaoCaoDoanhThu where  Thang=@cnt AND Nam=@nammin) " +
"			BEGIN " +
"				UPDATE BaoCaoDoanhThu SET TongTiec=(select count(id) from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin), " +
"				TongDoanhThu=(select sum(TongTienHoaDon) from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin) " +
"				where Thang=@cnt AND Nam=@nammin " +
"			END; " +
"			ELSE " +
"			BEGIN  " +
"				insert into BaoCaoDoanhThu values( @nammin,@cnt,(select sum(id) from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin), " +
"				(select sum(TongTienHoaDon) from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin) ); " +
"			END; " +
"		END;" +
"	SET @cnt = @cnt + 1;" +
"	END;" +
"SET @nammin = @nammin + 1;" +
"END;";

            DataProvider provider = new DataProvider();
            dataGridViewTongDoanhThu.DataSource = provider.ExecuteQuery(query2);

        }
        private void updateDoanhThuNgay()
        {
            String query2 =
"declare @nammin INT; " +
"declare @nammax INT; " +
"declare @cnt INT =1; " +
"declare @ngaymin INT; " +
"declare @ngaymax INT; " +
"declare @idmax INT; " +
"SET @nammin = (select min(YEAR(NgayLap)) from HoaDon); " +
"SET @nammax = (select max(YEAR(NgayLap)) from HoaDon); " +
"WHILE @nammin <= @nammax " +
"BEGIN " +
"	SET @cnt = 1; " +
"	WHILE @cnt <= 12 " +
"	BEGIN " +
"		IF  EXISTS(SELECT * from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin) " +
"		BEGIN " +
"			SET @ngaymin = (select min(DAY(NgayLap)) from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin); " +
"            SET @ngaymax = (select max(DAY(NgayLap)) from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin); " +
"			declare @tongdoanhthungay INT; " +
"			declare @tongdoanhthuthang FLOAT = (select sum(TongTienHoaDon) from HoaDon where MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin); " +
"			declare @tile FLOAT; " +
"			WHILE @ngaymin<=@ngaymax " +
"			BEGIN " +
"				IF  EXISTS(SELECT * from LapBaoCao where DAY(NgayBaoCao)=@ngaymin AND MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin ) " +
"				BEGIN " +
"					SET @tongdoanhthungay =(select sum(TongTienHoaDon) from HoaDon where DAY(NgayLap)=@ngaymin AND MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin); " +
"					SET @tile =(@tongdoanhthungay/@tongdoanhthuthang)*10000; " +
"					SET @tile = CONVERT(INT, @tile); " +
"					SET @tile = CONVERT(FLOAT, @tile)/100; " +
"					UPDATE LapBaoCao SET SoLuongTiec=(select count(id) from HoaDon where DAY(NgayLap)=@ngaymin AND MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin), " +
"					DoanhThu=(select sum(TongTienHoaDon) from HoaDon where DAY(NgayLap)=@ngaymin AND MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin), " +
"					Tile = @tile " +
"					where DAY(NgayBaoCao)=@ngaymin AND MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin " +
"				END; " +
"				ELSE " +
"				IF  EXISTS(SELECT * from HoaDon where DAY(NgayLap)=@ngaymin AND MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin ) " +
"				BEGIN " +
"					SET @tile =(@tongdoanhthungay/@tongdoanhthuthang)*10000; " +
"					SET @tile = CONVERT(INT, @tile); " +
"					SET @tile = CONVERT(FLOAT, @tile)/100; " +
"					SET @tongdoanhthungay =(select sum(TongTienHoaDon) from HoaDon where DAY(NgayLap)=@ngaymin AND MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin);   " +
"					declare @ngayyy date = (SELECT TOP (1) NgayLap FROM HoaDon WHERE DAY(NgayLap)=@ngaymin AND MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin); " +
"					insert into LapBaoCao (NgayBaoCao, SoLuongTiec, DoanhThu, Tile ) values( @ngayyy,(select count(id) from HoaDon where DAY(NgayLap)=@ngaymin AND MONTH(NgayLap)=@cnt AND YEAR(NgayLap)=@nammin), " +
"					@tongdoanhthungay, @tile ); " +
"				END; " +
"				SET @ngaymin=@ngaymin+1; " +
"			END ;		" +
"		END; " +
"		SET @idmax = (select max(id) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin); " +
"		IF((select Tile from LapBaoCao where id=@idmax) !=1 ) " +
"		BEGIN " +
"			SET @tile =100 - ( select sum(Tile) from (select TOP ( (select count(Tile) from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin) -1) Tile  from LapBaoCao where MONTH(NgayBaoCao)=@cnt AND YEAR(NgayBaoCao)=@nammin ) AS LAMTRON ) " +
"           SET @tile = @tile*100; " +
"			SET @tile = CONVERT(INT, @tile); " +
"           SET @tile = CONVERT(FLOAT, @tile) / 100; " +
"			UPDATE LapBaoCao SET  Tile = @tile where id=@idmax " +
"		END; 	" +
"	SET @cnt = @cnt + 1; " +
"	END; " +
"SET @nammin = @nammin + 1; " +
"END; ";

            DataProvider provider = new DataProvider();
            dataGridViewTongDoanhThu.DataSource = provider.ExecuteQuery(query2);

        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateDoanhThuThang();
            updateDoanhThuNgay();
            string query = "Select TongTiec, TongDoanhThu from BaoCaoDoanhThu where Thang=" + dateTimePicker1.Value.Month + " and Nam=" + dateTimePicker1.Value.Year;
            String queryBaocao = "Select NgayBaoCao, SoLuongTiec, DoanhThu,TiLe from LapBaoCao where MONTH(NgayBaoCao)=" + dateTimePicker1.Value.Month + " and YEAR(NgayBaoCao)=" + dateTimePicker1.Value.Year;
            DataProvider provider = new DataProvider();
            dataGridViewDSBaoCao.DataSource = provider.ExecuteQuery(queryBaocao);
            dataGridViewTongDoanhThu.DataSource = provider.ExecuteQuery(query);
            dataGridView_Header();
        }


        private void ButtonTatca_Click(object sender, EventArgs e)
        {
            updateDoanhThuThang();
            updateDoanhThuNgay();

            string query = "select Thang, Nam,TongTiec, TongDoanhThu from BaoCaoDoanhThu";
            DataProvider provider = new DataProvider();

            dataGridViewTongDoanhThu.DataSource = provider.ExecuteQuery(query);
            dataGridView_Header();
        }

        private void dataGridView_Header()
        {
            dataGridViewTongDoanhThu.Columns[0].HeaderText = "Tổng Tiệc";
            dataGridViewTongDoanhThu.Columns[1].HeaderText = "Tổng Doanh Thu";
            dataGridViewTongDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTongDoanhThu.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            dataGridViewDSBaoCao.Columns[0].HeaderText = "Ngày";
            dataGridViewDSBaoCao.Columns[1].HeaderText = "Số Lượng Tiệc";
            dataGridViewDSBaoCao.Columns[2].HeaderText = "Doanh Thu";
            dataGridViewDSBaoCao.Columns[3].HeaderText = "Tỉ Lệ";
            dataGridViewDSBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDSBaoCao.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }
    }
}