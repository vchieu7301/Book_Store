using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    class Database
    {
        DataProvider pr = new DataProvider();

        public Database()
        {
            pr.Connect();

        }
        public void Disconnect()
        {
            pr.Disconnect();
        }
        //đăng nhập
        public bool Login(string username, string pass)
        {
            return pr.Login("sp_login", username, pass); //sp_login = tên trong store produce
        }
        //đăng ký nhân viên ở đăng nhập
        public void dangky(string username, string pass, string manv, string tennv, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh, string chucvu, string LOAI)
        {
            pr.dangky("sp_dangky", username, pass, manv, tennv, diachi, gioitinh, sdt, email, ngaysinh, chucvu, LOAI);
        }
        //thêm sách
        public void sach(string masach, string tensach, string macd, string manxb, string matg, int soluong, int dongia, string LOAI)
        {
            pr.sach("sp_sach", masach, tensach, macd, manxb, matg, soluong, dongia, LOAI);
        }
        //load dữ liệu combobox
        public DataTable dataCBO(string data)
        {
            return pr.dataCBO("sp_data", data);
        }
        //lấy chức vụ 
        public string ChucVu(string username)
        {
            return pr.chucvu("sp_chucvu", username);
        }
        //lấy tên nhân viên
        public string LayTenNV(string username)
        {
            return pr.LayTenNV("sp_chucvu", username);
        }
        //Load datagridview
        public DataTable LayDataTable(string tenbang)
        {
            return pr.LayDataTable("sp_load", tenbang);
        }
        //đổi mật khẩu
        public void DoiMK(string username, string pass, string passnew)
        {
            pr.DoiMK("sp_doimk", username, pass, passnew);
        }
        //Thêm nhân viên
        public void themnv(string manv, string tennv, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh, string chucvu, string username, string pass, string LOAI)
        {
            pr.themnv("sp_nhanvien", manv, tennv, diachi, gioitinh, sdt, email, ngaysinh, chucvu, username, pass, LOAI);
        }
        //thêm khách hàng
        public void themkh(string makh, string tenkh, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh, int tienno, string LOAI)
        {
            pr.themkh("sp_khachhang", makh, tenkh, diachi, gioitinh, sdt, email, ngaysinh, tienno, LOAI);
        }
        //tìm sách
        public DataTable Search(string ten, string key)
        {
            return pr.Search("sp_search", ten, key);
        }
        //xóa dữ liệu
        public void Delete(string ma, int index)
        {
            pr.Delete("sp_delete", ma, index);
        }
        //thêm phiếu nhập
        public void phieunhap(string sopn, DateTime ngaynhap, int gianhap, int tongtien, string LOAI)
        {
            pr.phieunhap("sp_phieunhap", sopn, ngaynhap, gianhap, tongtien, LOAI);
        }
        //thêm chi tiết phiếu nhập
        public void ct_phieunhap(string sopn, int soluong, string masach, string manv, string LOAI)
        {
            pr.ct_phieunhap("sp_ct_phieunhap", sopn, soluong, masach, manv, LOAI);
        }
        //thêm hóa đơn
        public void hoadon(string sohd, DateTime ngaylap, int dongia, int tongtien, string LOAI)
        {
            pr.hoadon("sp_hoadon", sohd, ngaylap, dongia, tongtien, LOAI);
        }
        //thêm chi tiết hóa đơn
        public void ct_hoadon(string sohd, string masach, string manv, string makh, int soluong, string LOAI)
        {
            pr.ct_hoadon("sp_ct_hoadon", sohd, masach, manv, makh, soluong, LOAI);
        }
        //Update số lượng
        public void updateSL(string masach, int sl)
        {
            pr.updateSL("sp_updateSL", masach, sl);
        }
        //Báo cáo 
        public int baocao()
        {
            return pr.baocao("sp_baocao");
        }
        //thêm phiếu mượn
        public void phieumuon(string sopm, DateTime ngaymuon, DateTime ngaytra, string LOAI)
        {
            pr.phieumuon("sp_phieumuon", sopm, ngaymuon, ngaytra, LOAI);
        }
        //thêm chi tiết phiếu mượn
        public void ct_phieumuon(string sopm, int soluong, string masach, string makh, string manv, string LOAI)
        {
            pr.ct_phieumuon("sp_ct_phieumuon", sopm, soluong, masach, makh, manv, LOAI);
        }
        //Thêm phiếu thu
        public void phieuthu(string sopt, DateTime ngaythu,  string LOAI)
        {
            pr.phieuthu("sp_phieuthu", sopt, ngaythu,  LOAI);
        }
        //thêm chi tiết phiếu thu
        public void ct_phieuthu( string sopt, string makh, int tienthu, string LOAI)
        {
            pr.ct_phieuthu("sp_ct_phieuthu", sopt, makh, tienthu, LOAI);
        }
        //Load thông tin
        public SqlDataReader LoadThongTin( string ma)
        {
            return pr.LoadThongTin("sp_loadthongtin", ma);
        }
        //Load thông tin nợ
        //public SqlDataReader LoadThongTinNo(string ma)
        //{
        //    return pr.LoadThongTinNo("sp_loadthongtinno", ma);
        //}
        //thêm chủ đề
        public void chude(string macd, string tencd, string ghichu, string LOAI)
        {
            pr.chude("sp_chude", macd, tencd, ghichu, LOAI);
        }
        //thêm tác giả
        public void tacgia(string matg, string tentg, string diachi, string LOAI)
        {
            pr.tacgia("sp_tacgia", matg, tentg, diachi, LOAI);
        }
        //thêm nxb
        public void nxb(string manxb, string tennxb, string diachi, string LOAI)
        {
            pr.nxb("sp_nxb", manxb, tennxb, diachi, LOAI);
        }
    }
}