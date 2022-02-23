using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace QuanLyNhaSach.Model
{
    class DataProvider
    {
        public DataProvider()
        {

        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        string connectionString = ConfigurationManager.ConnectionStrings["MKN"].ConnectionString.ToString();

        public void Connect()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
            }
            catch (Exception sqlex)
            {
                throw sqlex;
            }
        }
        public void Disconnect()
        {
            con.Close();
        }
        //đăng nhập
        public bool Login(string strStore, string username, string pass) //strStore = tên store Procedu truyền vào
        {

            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("pass", pass);
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            return dt.Rows.Count > 0;
        }
        //đăng ký nhân viên
        public void dangky(string strStore,string username,string pass, string manv, string tennv, string diachi, Boolean gioitinh, string sdt, string email,DateTime ngaysinh,string chucvu, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("PassWords", pass);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    cmd.Parameters.AddWithValue("TenNV",tennv);
                    cmd.Parameters.AddWithValue("DiaChi",  diachi);
                    cmd.Parameters.AddWithValue("GioiTinh", gioitinh);
                    cmd.Parameters.AddWithValue("SDT", sdt);
                    cmd.Parameters.AddWithValue("NgaySinh", ngaysinh);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("ChucVu", chucvu);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("PassWords", pass);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    cmd.Parameters.AddWithValue("TenNV", tennv);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    cmd.Parameters.AddWithValue("GioiTinh", gioitinh);
                    cmd.Parameters.AddWithValue("SDT", sdt);
                    cmd.Parameters.AddWithValue("NgaySinh", ngaysinh);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("ChucVu", chucvu);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //tìm kiếm
        public DataTable Search(string strStore, string ten, string key)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (key)
            {
                case "TENSACH":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "TENSACH";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "CHUDE":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "CHUDE";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TACGIA":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "TACGIA";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "NXB":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "NXB";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TENNV":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "TENNV";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "SDT":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "SDT";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "DIACHI":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "DIACHI";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "EMAIL":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "EMAIL";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "TENKH":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "TENKH";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "SDTKH":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "SDTKH";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "DIACHIKH":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "DIACHIKH";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
                case "EMAILKH":
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "EMAILKH";
                    cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
                    break;
            }
            dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        // xóa dữ liệu
        public void Delete(string strStore, string ma, int index)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (index)
            {
                case 0:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "SACH";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 1:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "NHANVIEN";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 2:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "KHACHHANG";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 3:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "HOADON";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 4:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "PHIEUNHAP";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 5:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "PHIEUMUON";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 6:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "PHIEUTHU";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 7:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "CHUDE";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 8:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "TACGIA";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;
                case 9:
                    cmd.Parameters.Add("tenbang", SqlDbType.NVarChar).Value = "NXB";
                    cmd.Parameters.Add("ma", SqlDbType.NVarChar).Value = ma;
                    break;

            }
            cmd.ExecuteNonQuery();
        }
        //thêm sách mới
        public void sach(string strStore,string masach, string tensach,string macd,string manxb, string matg, int soluong, int dongia,string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
                {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("TenSach", tensach);       
                    cmd.Parameters.AddWithValue("MaCD", macd);
                    cmd.Parameters.AddWithValue("MaNXB",  manxb);
                    cmd.Parameters.AddWithValue("MaTG", matg);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    cmd.Parameters.AddWithValue("DonGia", dongia);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("TenSach", tensach);
                    cmd.Parameters.AddWithValue("MaCD", macd);
                    cmd.Parameters.AddWithValue("MaNXB", manxb);
                    cmd.Parameters.AddWithValue("MaTG", matg);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    cmd.Parameters.AddWithValue("DonGia", dongia);
                    break;
             }
            cmd.ExecuteNonQuery();
        }
        //Load dữ liệu cho combobox
        public DataTable dataCBO(string strStore, string data)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch(data)           
            {
                case "CHUDE":
                    cmd.Parameters.AddWithValue("Store", "chude");
                    break;
                case "NXB":
                    cmd.Parameters.AddWithValue("Store", "nxb");
                    break;
                case "TACGIA":
                    cmd.Parameters.AddWithValue("Store", "tacgia");
                    break;
                case "NHANVIEN":
                    cmd.Parameters.AddWithValue("Store", "nhanvien");
                    break;
                case "SACH":
                    cmd.Parameters.AddWithValue("Store", "sach");
                    break;
                case "KHACHHANG":
                    cmd.Parameters.AddWithValue("Store", "khachhang");
                    break;
                case "TAIKHOAN":
                    cmd.Parameters.AddWithValue("Store", "taikhoan");
                    break;

            }
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            return dt;
        }
        //lấy chức vụ
        public string chucvu(string strStore, string username)
        {
            string chucvu;
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Username", username);
            SqlDataReader dar = cmd.ExecuteReader();
            if(dar.Read())
            {
                chucvu = (string)dar["ChucVu"];
                return chucvu; 
            }
            Disconnect();
            return "";

        }
        //lấy họ tên
        public string LayTenNV(string strStore, string username)
        {
            string hoten;
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Username", username);
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
            {
                hoten = (string)dar["TenNV"];
                return hoten;
            }
            Disconnect();
            return "";

        }
        //Load datagridview
        public DataTable LayDataTable(string strStore,string tenbang)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (tenbang)
            {
                case "SACH":
                    cmd.Parameters.AddWithValue("tenbang", "SACH");
                    break;
                case "NHANVIEN":
                    cmd.Parameters.AddWithValue("tenbang", "NHANVIEN");
                    break;
                case "KHACHHANG":
                    cmd.Parameters.AddWithValue("tenbang", "KHACHHANG");
                    break;
                case "PHIEUNHAP":
                    cmd.Parameters.AddWithValue("tenbang", "PHIEUNHAP");
                    break;
                case "PHIEUMUON":
                    cmd.Parameters.AddWithValue("tenbang", "PHIEUMUON");
                    break;
                case "HOADON":
                    cmd.Parameters.AddWithValue("tenbang", "HOADON");
                    break;
                case "BAOCAO":
                    cmd.Parameters.AddWithValue("tenbang", "BAOCAO");
                    break;
                case "PHIEUTHU":
                    cmd.Parameters.AddWithValue("tenbang", "PHIEUTHU");
                    break;
                case "BAOCAOCONGNO":
                    cmd.Parameters.AddWithValue("tenbang", "BAOCAOCONGNO");
                    break;
                case "CHUDE":
                    cmd.Parameters.AddWithValue("tenbang", "CHUDE");
                    break;
                case "TACGIA":
                    cmd.Parameters.AddWithValue("tenbang", "TACGIA");
                    break;
                case "NXB":
                    cmd.Parameters.AddWithValue("tenbang", "NXB");
                    break;
            }
            DataTable dt = new DataTable();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            return dt;
        }
        //Đổi mật khẩu người dùng
        public void DoiMK(string strStore, string username, string pass, string passnew) 
        {

            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("pass", pass);
            cmd.Parameters.AddWithValue("passnew", passnew);
            cmd.ExecuteNonQuery();
        }
        //thêm nhân viên
        public void themnv(string strStore, string manv, string tennv, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh, string chucvu, string username, string pass, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");                   
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    cmd.Parameters.AddWithValue("TenNV", tennv);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    cmd.Parameters.AddWithValue("GioiTinh", gioitinh);
                    cmd.Parameters.AddWithValue("SDT", sdt);
                    cmd.Parameters.AddWithValue("NgaySinh", ngaysinh);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("ChucVu", chucvu);
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("PassWords", pass);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");                  
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    cmd.Parameters.AddWithValue("TenNV", tennv);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    cmd.Parameters.AddWithValue("GioiTinh", gioitinh);
                    cmd.Parameters.AddWithValue("SDT", sdt);
                    cmd.Parameters.AddWithValue("NgaySinh", ngaysinh);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("ChucVu", chucvu);
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("PassWords", pass);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm khách hàng
        public void themkh(string strStore, string makh, string tenkh, string diachi, Boolean gioitinh, string sdt, string email, DateTime ngaysinh,int tienno, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("TenKH", tenkh);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    cmd.Parameters.AddWithValue("GioiTinh", gioitinh);
                    cmd.Parameters.AddWithValue("SDT", sdt);
                    cmd.Parameters.AddWithValue("NgaySinh", ngaysinh);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("TienNo", tienno);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("TenKH", tenkh);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    cmd.Parameters.AddWithValue("GioiTinh", gioitinh);
                    cmd.Parameters.AddWithValue("SDT", sdt);
                    cmd.Parameters.AddWithValue("NgaySinh", ngaysinh);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("TienNo", tienno);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        // thêm phiếu nhập
        public void phieunhap(string strStore, string sopn, DateTime ngaynhap, int gianhap, int tongtien, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoPN", sopn);
                    cmd.Parameters.AddWithValue("NgayNhap", ngaynhap);
                    cmd.Parameters.AddWithValue("GiaNhap", gianhap);
                    cmd.Parameters.AddWithValue("TongTien", tongtien);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoPN", sopn);
                    cmd.Parameters.AddWithValue("NgayNhap", ngaynhap);
                    cmd.Parameters.AddWithValue("GiaNhap", gianhap);
                    cmd.Parameters.AddWithValue("TongTien", tongtien);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm chi tiết phiếu nhập
        public void ct_phieunhap(string strStore, string sopn, int soluong, string masach, string manv, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoPN", sopn);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoPN", sopn);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm hóa đơn
        public void hoadon(string strStore, string sohd, DateTime ngaylap, int dongia, int tongtien, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoHD", sohd);
                    cmd.Parameters.AddWithValue("NgayLap", ngaylap);                                       
                    cmd.Parameters.AddWithValue("DonGia", dongia);
                    cmd.Parameters.AddWithValue("TongTien", tongtien);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoHD", sohd);
                    cmd.Parameters.AddWithValue("NgayLap", ngaylap);                   
                    cmd.Parameters.AddWithValue("DonGia", dongia);
                    cmd.Parameters.AddWithValue("TongTien", tongtien);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm chi tiết hóa đơn
        public void ct_hoadon(string strStore, string sohd, string masach, string manv, string makh, int soluong, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoHD", sohd);
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoHD", sohd);
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //Update số lượng 
        public void updateSL (string strStore, string masach, int sl)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaSach", masach);
            cmd.Parameters.AddWithValue("SoLuong", sl);
        }
        //Báo cáo 
        public int baocao(string strStore)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            int m = (int)cmd.ExecuteScalar();
            Disconnect();
            return m;
        }
        // thêm phiếu mượn
        public void phieumuon(string strStore, string sopm, DateTime ngaymuon, DateTime ngaytra, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoPM", sopm);
                    cmd.Parameters.AddWithValue("NgayMuon", ngaymuon);
                    cmd.Parameters.AddWithValue("NgayTra", ngaytra);                    
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoPM", sopm);
                    cmd.Parameters.AddWithValue("NgayMuon", ngaymuon);
                    cmd.Parameters.AddWithValue("NgayTra", ngaytra);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm chi tiết phiếu mượn
        public void ct_phieumuon(string strStore, string sopm, int soluong, string masach,string makh, string manv, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoPM", sopm);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoPM", sopm);
                    cmd.Parameters.AddWithValue("SoLuong", soluong);
                    cmd.Parameters.AddWithValue("MaSach", masach);
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("MaNV", manv);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //Thêm phiếu thu
        public void phieuthu(string strStore, string sopt, DateTime ngaythu, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoPT", sopt);
                    cmd.Parameters.AddWithValue("NgayThu", ngaythu);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoPT", sopt);
                    cmd.Parameters.AddWithValue("NgayThu", ngaythu);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm chi tiết phiếu thu
        public void ct_phieuthu(string strStore, string sopt, string makh, int tienthu, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("SoPT", sopt);
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("TienThu", tienthu);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("SoPT", sopt);
                    cmd.Parameters.AddWithValue("MaKH", makh);
                    cmd.Parameters.AddWithValue("TienThu", tienthu);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //Load thông tin
       public SqlDataReader LoadThongTin (string strStore, string ma)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaSach", ma);
            SqlDataReader loadtt = cmd.ExecuteReader();
            return loadtt;
        }
        //Load thông tin nợ
        //public SqlDataReader LoadThongTinNo(string strStore, string ma)
        //{
        //    cmd = new SqlCommand(strStore, con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("SoPT", ma);
        //    SqlDataReader loadttno = cmd.ExecuteReader();
        //    return loadttno;
        //}
        //thêm chủ đề
        public void chude(string strStore, string macd, string tencd, string ghichu, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("MaCD", macd);
                    cmd.Parameters.AddWithValue("TenCD", tencd);
                    cmd.Parameters.AddWithValue("GhiChu", ghichu);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("MaCD", macd);
                    cmd.Parameters.AddWithValue("TenCD", tencd);
                    cmd.Parameters.AddWithValue("GhiChu", ghichu);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm tác giả
        public void tacgia(string strStore, string matg, string tentg, string diachi, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("MaTG", matg);
                    cmd.Parameters.AddWithValue("TenTG", tentg);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("MaTG", matg);
                    cmd.Parameters.AddWithValue("TenTG", tentg);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    break;
            }
            cmd.ExecuteNonQuery();
        }
        //thêm nxb
        public void nxb(string strStore, string manxb, string tennxb, string diachi, string LOAI)
        {
            cmd = new SqlCommand(strStore, con);
            cmd.CommandType = CommandType.StoredProcedure;
            switch (LOAI)
            {
                case "INSERT":
                    cmd.Parameters.AddWithValue("Store", "INSERT");
                    cmd.Parameters.AddWithValue("MaNXB", manxb);
                    cmd.Parameters.AddWithValue("TenNXB", tennxb);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    break;
                case "UPDATE":
                    cmd.Parameters.AddWithValue("Store", "UPDATE");
                    cmd.Parameters.AddWithValue("MaNXB", manxb);
                    cmd.Parameters.AddWithValue("TenNXB", tennxb);
                    cmd.Parameters.AddWithValue("DiaChi", diachi);
                    break;
            }
            cmd.ExecuteNonQuery();
        }

    }
}
