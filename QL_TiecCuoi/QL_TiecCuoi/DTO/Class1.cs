using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TiecCuoi.DTO
{
    public class TaiKhoanDTO
    {
        private string tenDangNhap;

        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }

            set
            {
                tenDangNhap = value;
            }
        }
        private string matKhau;
        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }
        public TaiKhoanDTO(string pTenTaiKhoan, string pMatKhau)
        {
            this.tenDangNhap = pTenTaiKhoan;
            this.matKhau = pMatKhau;
        }


    }
    public class ThongTinSanhDTO
    {
      
        // dinh nghia loai sanh
        public string LoaiSanh
        {
            get
            {
                return loaiSanh;
            }

            set
            {
                loaiSanh = value;
            }
        }
        private string loaiSanh;
        // dinh nghia ten sanh
        public string TenSanh
        {
            get
            {
                return tenSanh;
            }

            set
            {
                tenSanh = value;
            }
        }
        private string tenSanh;
        //dinh nghia so luong ban toi da
        public string SoLuongBanToiDa
        {
            get
            {
                return soLuongBanToiDa;
            }

            set
            {
                soLuongBanToiDa = value;
            }
        }
        private string soLuongBanToiDa;
        //dinh nghia don gia toi thieu
        public string DonGiaToiThieu
        {
            get
            {
                return donGiaToiThieu;
            }

            set
            {
                donGiaToiThieu = value;
            }
        }
        private string donGiaToiThieu;
        // dinh nghia ghi chu
        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        
        private string ghiChu;
        // 
        public ThongTinSanhDTO(string pLoaiSanh, string pTenSanh, string pSoLuongBanToiDa, string pDonGiaToiThieu, string pGhiChu)
        {
            this.loaiSanh = pLoaiSanh;
            this.tenSanh = pTenSanh;
            this.soLuongBanToiDa = pSoLuongBanToiDa;
            this.donGiaToiThieu = pDonGiaToiThieu;
            this.ghiChu = pGhiChu;
        }
    }
    public class ThucDonDTO
    {
        private string maThucDon;
        public string MaThucDon
        {
            get
            {
                return maThucDon;
            }

            set
            {
                maThucDon = value;
            }
        }

        private string monKhaiVi;
        public string MonKhaiVi
        {
            get
            {
                return monKhaiVi;
            }

            set
            {
                monKhaiVi = value;
            }
        }

        private string monChinh1;
        public string MonChinh1
        {
            get
            {
                return monChinh1;
            }

            set
            {
                monChinh1 = value;
            }
        }

        private string monChinh2;
        public string MonChinh2
        {
            get
            {
                return monChinh2;
            }

            set
            {
                monChinh2 = value;
            }
        }

        private string monChinh3;
        public string MonChinh3
        {
            get
            {
                return monChinh3;
            }

            set
            {
                monChinh3 = value;
            }
        }

        private string lau;
        public string Lau
        {
            get
            {
                return lau;
            }

            set
            {
                lau = value;
            }
        }

        private string trangMieng;
        public string TrangMieng
        {
            get
            {
                return trangMieng;
            }

            set
            {
                trangMieng = value;
            }
        }

        private string bia;
        public string Bia
        {
            get
            {
                return bia;
            }

            set
            {
                bia = value;
            }
        }

        private string nuocNgot;
        public string NuocNgot
        {
            get
            {
                return nuocNgot;
            }

            set
            {
                nuocNgot = value;
            }
        }

        public string GiaThucDon
        {
            get
            {
                return giaThucDon;
            }

            set
            {
                giaThucDon = value;
            }
        }
        private string giaThucDon;

        public ThucDonDTO(string pMaThucDon, string pMonKhaiVi, string pMonChinh1, string pMonChinh2, string pMonChinh3, string pLau, string pTrangMieng, string pBia, string pNuocNgot, string pGiaThucDon)
        {
            this.maThucDon = pMaThucDon;
            this.monKhaiVi = pMonKhaiVi;
            this.monChinh1 = pMonChinh1;
            this.monChinh2 = pMonChinh2;
            this.monChinh3 = pMonChinh3;
            this.lau = pLau;
            this.trangMieng = pTrangMieng;
            this.bia = pBia;
            this.nuocNgot = pNuocNgot;
            this.giaThucDon = pGiaThucDon;
        }




    }
    public class DichVuDTO
    {
        private string maDichVu;
        public string MaDichVu
        {
            get
            {
                return maDichVu;
            }

            set
            {
                maDichVu = value;
            }
        }

        private string ruou;
        public string Ruou
        {
            get
            {
                return ruou;
            }

            set
            {
                ruou = value;
            }
        }

        private string banhKem;
        public string BanhKem
        {
            get
            {
                return banhKem;
            }

            set
            {
                banhKem = value;
            }
        }

        private string mc;
        public string Mc
        {
            get
            {
                return mc;
            }

            set
            {
                mc = value;
            }
        }

        private string banNhac;
        public string BanNhac
        {
            get
            {
                return banNhac;
            }

            set
            {
                banNhac = value;
            }
        }

        private string caSi;
        public string CaSi
        {
            get
            {
                return caSi;
            }

            set
            {
                caSi = value;
            }
        }

        private string dJ;
        public string DJ
        {
            get
            {
                return dJ;
            }

            set
            {
                dJ = value;
            }
        }

        private string giaDichVu;
        public string GiaDichVu
        {
            get
            {
                return giaDichVu;
            }

            set
            {
                giaDichVu = value;
            }
        }





    }
    public class ThongTinDatTiecDTO
    {
        private string maDatTiec;
        private string maKhachHang;
        private string loaiSanh;
        private string maThucDon;
        private string maDichVu;
        private int soLuongNhanVien;
        private string trangThai;
        private string ca;

        public string MaDatTiec
        {
            get
            {
                return maDatTiec;
            }

            set
            {
                maDatTiec = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string LoaiSanh
        {
            get
            {
                return loaiSanh;
            }

            set
            {
                loaiSanh = value;
            }
        }

        public string MaThucDon
        {
            get
            {
                return maThucDon;
            }

            set
            {
                maThucDon = value;
            }
        }

        public string MaDichVu
        {
            get
            {
                return maDichVu;
            }

            set
            {
                maDichVu = value;
            }
        }



        public string TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public string Ca
        {
            get
            {
                return ca;
            }

            set
            {
                ca = value;
            }
        }

        public int SoLuongNhanVien
        {
            get
            {
                return soLuongNhanVien;
            }

            set
            {
                soLuongNhanVien = value;
            }
        }

        public ThongTinDatTiecDTO(string pMaDatTiec, string pMaKhachHang, string pLoaiSanh, string pMaThucDon, string pMaDichVu, int pSoLuongNhanVien, string pTrangThai, string pCa)
        {
            this.maDatTiec = pMaDatTiec;
            this.maKhachHang = pMaKhachHang;
            this.loaiSanh = pLoaiSanh;
            this.maThucDon = pMaThucDon;
            this.maDichVu = pMaDichVu;
            this.SoLuongNhanVien = pSoLuongNhanVien;
            this.trangThai = pTrangThai;
            this.ca = pCa;
        }
    }
    public class ThongTinKhachHangDTO
    {
        private string maKhachHang;
        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        private DateTime ngayLap;
        public DateTime NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
            }
        }

        private string tenKhachHang;
        public string TenKhachHang
        {
            get
            {
                return tenKhachHang;
            }

            set
            {
                tenKhachHang = value;
            }
        }

        private string tenChuRe;
        public string TenChuRe
        {
            get
            {
                return tenChuRe;
            }

            set
            {
                tenChuRe = value;
            }
        }

        private string tenCoDau;
        public string TenCoDau
        {
            get
            {
                return tenCoDau;
            }

            set
            {
                tenCoDau = value;
            }
        }

        private string diaChi;
        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        private string dienThoai;
        public string DienThoai
        {
            get
            {
                return dienThoai;
            }

            set
            {
                dienThoai = value;
            }
        }

        private string eMail;
        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                eMail = value;
            }
        }

        private DateTime ngayToChuc;
        public DateTime NgayToChuc
        {
            get
            {
                return ngayToChuc;
            }

            set
            {
                ngayToChuc = value;
            }
        }
        public ThongTinKhachHangDTO(string pMaKhachHang, DateTime pNgayLap, string pTenKhachHang, string pTenChuRe, string pTenCoDau, string pDiaChi, string pDienThoai, string pEMail, DateTime pNgayToChuc)
        {
            this.maKhachHang = pMaKhachHang;
            this.ngayLap = pNgayLap;
            this.tenKhachHang = pTenKhachHang;
            this.tenChuRe = pTenChuRe;
            this.tenCoDau = pTenCoDau;
            this.diaChi = pDiaChi;
            this.eMail = pDiaChi;
            this.ngayToChuc = pNgayToChuc;
        }

    }
    public class NhanVienDTO
    {
        private string maNhanVien;
        private string tienNhanVien;
        private string soDienThoai;
        private string diaChi;
        private string loaiSanh;
        private string chucVu;
        private string ca;

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public string TienNhanVien
        {
            get
            {
                return tienNhanVien;
            }

            set
            {
                tienNhanVien = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string LoaiSanh
        {
            get
            {
                return loaiSanh;
            }

            set
            {
                loaiSanh = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public string Ca
        {
            get
            {
                return ca;
            }

            set
            {
                ca = value;
            }
        }
        public NhanVienDTO(string pMaNhanVien, string pTienNhanVien, string pSoDienThoai, string pDiaChi, string pLoaiSanh, string pChucVu, string pCa)
        {
            this.maNhanVien = pMaNhanVien;
            this.tienNhanVien = pTienNhanVien;
            this.soDienThoai = pSoDienThoai;
            this.diaChi = pDiaChi;
            this.loaiSanh = LoaiSanh;
            this.chucVu = pChucVu;
            this.ca = Ca;
        }
    }
    public class HoaDonDTO
    {
        private string maHoaDon;
        private string maKhachHang;
        private string maDatTiec;
        private string thucDon;
        private string dichVu;
        private float tienThucDon;
        private float tienDichVu;
        private float tienPhat;
        private float tongTienHoaDon;
        private float tienCoc;
        private float tienConLai;

        public string MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string MaDatTiec
        {
            get
            {
                return maDatTiec;
            }

            set
            {
                maDatTiec = value;
            }
        }

        public string ThucDon
        {
            get
            {
                return thucDon;
            }

            set
            {
                thucDon = value;
            }
        }

        public string DichVu
        {
            get
            {
                return dichVu;
            }

            set
            {
                dichVu = value;
            }
        }

        public float TienThucDon
        {
            get
            {
                return tienThucDon;
            }

            set
            {
                tienThucDon = value;
            }
        }

        public float TienDichVu
        {
            get
            {
                return tienDichVu;
            }

            set
            {
                tienDichVu = value;
            }
        }

        public float TienPhat
        {
            get
            {
                return tienPhat;
            }

            set
            {
                tienPhat = value;
            }
        }

        public float TongTienHoaDon
        {
            get
            {
                return tongTienHoaDon;
            }

            set
            {
                tongTienHoaDon = value;
            }
        }

        public float TienCoc
        {
            get
            {
                return tienCoc;
            }

            set
            {
                tienCoc = value;
            }
        }

        public float TienConLai
        {
            get
            {
                return tienConLai;
            }

            set
            {
                tienConLai = value;
            }
        }
        public HoaDonDTO(string pMaHoaDon, string pMaKhachHang, string pMaDatTiec, string pThucDon, string pDichVu, float pTienThucDon, float pTienDichVu, float pTienPhat, float pTongTienHoaDon, float pTienCoc, float pTienConLai)
        {
            this.maHoaDon = pMaHoaDon;
            this.maKhachHang = pMaKhachHang;
            this.maDatTiec = pMaDatTiec;
            this.thucDon = pThucDon;
            this.dichVu = pDichVu;
            this.tienThucDon = pTienThucDon;
            this.tienDichVu = pTienDichVu;
            this.tienPhat = pTienPhat;
            this.tongTienHoaDon = pTongTienHoaDon;
            this.tienCoc = pTienCoc;
            this.tienConLai = pTienConLai;
        }


    }
    public class DoanhThuDTO
    {
        private string maBaoCao;
        private string maNhanVien;
        private string thangBaoCao;
        private string namBaoCao;
        private string ngayLap;
        private string soLuongTiec;

        public string MaBaoCao
        {
            get
            {
                return maBaoCao;
            }

            set
            {
                maBaoCao = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public string ThangBaoCao
        {
            get
            {
                return thangBaoCao;
            }

            set
            {
                thangBaoCao = value;
            }
        }

        public string NamBaoCao
        {
            get
            {
                return namBaoCao;
            }

            set
            {
                namBaoCao = value;
            }
        }

        public string NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
            }
        }

        public string SoLuongTiec
        {
            get
            {
                return soLuongTiec;
            }

            set
            {
                soLuongTiec = value;
            }
        }
        public DoanhThuDTO(string pMaBaoCao, string pMaNhanVien, string pThangBaoCao,
        string pNamBaoCao, string pNgayLap, string pSoLuongTiec)
        {
            this.maBaoCao = pMaBaoCao;
            this.maNhanVien = pMaNhanVien;
            this.thangBaoCao = pThangBaoCao;
            this.namBaoCao = pNamBaoCao;
            this.ngayLap = pNgayLap;
            this.soLuongTiec = pSoLuongTiec;
        }

    }
}
