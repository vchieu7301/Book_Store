using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhaSach.Model;
using System.Data.SqlClient;

namespace QuanLyNhaSach.Controls
{
    class control
    {

        Database db;
        public control()
        {
            db = new Database();
        }
        public void Disconnect()
        {
            db.Disconnect();
        }

        public bool Login(string username, string pass)
        {
            return db.Login(username, pass);
        }
        public void dangky(string username, string pass, string manv, string tennv, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh,string chucvu, string LOAI)
        {
             db.dangky(username, pass, manv, tennv, diachi, gioitinh, sdt, email, ngaysinh,chucvu, LOAI);
        }
        public void sach( string masach, string tensach, string macd, string manxb, string matg, int soluong, int dongia, string LOAI)
        {
            db.sach(masach, tensach, macd, manxb, matg, soluong, dongia, LOAI);
        }
        public DataTable dataCBO(string data)
        {
            return db.dataCBO( data);
        }
        public string ChucVu(string username)
        {
            return db.ChucVu(username);
        }
        public string LayTenNV(string username)
        {
            return db.LayTenNV(username);
        }
        public DataTable LayDataTable(string tenbang)
        {
            return db.LayDataTable( tenbang);
        }
        public void DoiMK(string username, string pass, string passnew)
        {
            db.DoiMK( username, pass, passnew);
        }
        public void themnv(string manv, string tennv, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh, string chucvu, string username, string pass, string LOAI)
        {
            db.themnv( manv, tennv, diachi, gioitinh, sdt, email, ngaysinh, chucvu, username, pass, LOAI);
        }
        public void themkh(string makh, string tenkh, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh,int tienno, string LOAI)
        {
            db.themkh( makh, tenkh, diachi, gioitinh, sdt, email, ngaysinh, tienno, LOAI);
        }
        public DataTable Search(string ten, string key)
        {
            return db.Search(ten, key);
        }
        public void Delete(string ma, int index)
        {
            db.Delete( ma, index);
        }
        public void phieunhap(string sopn, DateTime ngaynhap, int gianhap, int tongtien, string LOAI)
        {
            db.phieunhap(sopn, ngaynhap, gianhap, tongtien, LOAI);
        }
        public void ct_phieunhap(string sopn, int soluong, string masach, string manv, string LOAI)
        {
            db.ct_phieunhap( sopn, soluong, masach, manv, LOAI);
        }
        public void hoadon(string sohd, DateTime ngaylap, int dongia, int tongtien, string LOAI)
        {
            db.hoadon( sohd, ngaylap, dongia, tongtien, LOAI);
        }
        public void ct_hoadon( string sohd, string masach, string manv, string makh, int soluong, string LOAI)
        {
            db.ct_hoadon( sohd, masach, manv, makh, soluong, LOAI);
        }
        public void updateSL( string masach, int sl)
        {
            db.updateSL(masach, sl);
        }
        public int baocao()
        {
            return db.baocao();
        }
        public void phieumuon(string sopm, DateTime ngaymuon, DateTime ngaytra, string LOAI)
        {
            db.phieumuon( sopm, ngaymuon, ngaytra, LOAI);
        }
        public void ct_phieumuon(string sopm, int soluong, string masach, string makh, string manv, string LOAI)
        {
            db.ct_phieumuon( sopm, soluong, masach, makh, manv, LOAI);
        }
        public void phieuthu(string sopt, DateTime ngaythu,  string LOAI)
        {
            db.phieuthu( sopt, ngaythu, LOAI);
        }
        public void ct_phieuthu(string sopt, string makh, int tienthu, string LOAI)
        {
            db.ct_phieuthu( sopt, makh, tienthu, LOAI);
        }
        public SqlDataReader LoadThongTin(string ma)
        {
            return db.LoadThongTin( ma);
        }
        //public SqlDataReader LoadThongTinNo(string ma)
        //{
        //    return db.LoadThongTinNo( ma);
        //}
        public void chude(string macd, string tencd, string ghichu, string LOAI)
        {
            db.chude(macd, tencd, ghichu, LOAI);
        }
        public void tacgia(string matg, string tentg, string diachi, string LOAI)
        {
            db.tacgia(matg, tentg, diachi, LOAI);
        }
        public void nxb(string manxb, string tennxb, string diachi, string LOAI)
        {
            db.nxb(manxb, tennxb, diachi, LOAI);
        }
    }
}
