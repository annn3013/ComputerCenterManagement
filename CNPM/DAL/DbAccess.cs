using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
 

namespace DAL
{
    public class SqlconnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=cnpm5;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }

    public class DbAccess
    {
        public static string CheckLoginData(TaiKhoan tk)
        {
            string user = null;
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "select * from TaiKhoan Where TenTaiKhoan=@tentk and MatKhau=@mk";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@tentk", tk.TenTaiKhoan);
            command.Parameters.AddWithValue("@mk", tk.MatKhau);
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "tài khoản hoặc mật khẩu không chính xác";
            }
            return user;
        }

        public static int CheckLoginData2(TaiKhoan tk)
        {
            int user = 0;
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "select * from TaiKhoan Where TenTaiKhoan=@tentk and MatKhau=@mk";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@tentk", tk.TenTaiKhoan);
            command.Parameters.AddWithValue("@mk", tk.MatKhau);
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetInt32(3);
                }
                reader.Close();
                conn.Close();
            }
            return user;
        }

        public static string CheckQuyenData(int maquyen)
        {
            string quyen = null;
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "select TenQuyen from Quyen Where MaQuyen=@maquyen";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maquyen", maquyen);
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quyen = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "không tồn tại quyền này";
            }
            return quyen;
        }
        public static string doiMK(string tentk, string matKhauMoi)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "UPDATE TaiKhoan SET MatKhau = @matKhauMoi WHERE TenTaiKhoan = @tentk";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@matKhauMoi", matKhauMoi);
            command.Parameters.AddWithValue("@tentk", tentk);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Cập nhật mật khẩu thành công";
            }
            else
            {
                return "Cập nhật mật không thành công"; ;
            }
        }

        public static string themTK(TaiKhoan tk)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, MaQuyen) VALUES (@maTK, @tenTK, @matKhau, @maQuyen)";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maTK", tk.MaTaiKhoan);
            command.Parameters.AddWithValue("@tenTK", tk.TenTaiKhoan);
            command.Parameters.AddWithValue("@matKhau", tk.MatKhau);
            command.Parameters.AddWithValue("@maQuyen", tk.MaQuyen);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Thêm tài khoản thành công";
            }
            else
            {
                return "Thêm tài khoản không thành công";
            }
        }
        public static int demTK()
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "SELECT COUNT(*) FROM TaiKhoan";
            SqlCommand command = new SqlCommand(querry, conn);
            int count = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return count;
        }
        public static string LoadMTK()
        {

            string maTaiKhoan = "";

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT TOP 1 MaTaiKhoan FROM TaiKhoan ORDER BY MaTaiKhoan DESC";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    maTaiKhoan = reader["MaTaiKhoan"].ToString();
                }

                reader.Close();
            }

            return maTaiKhoan;
        }

        public static DataTable loadTK()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM TaiKhoan";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadHV()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HocVien";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static string checkTKT(string matk)
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin tài khoản với MaTaiKhoan được cung cấp
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE MaTaiKhoan = @matk";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@matk", matk);

            // Thực hiện truy vấn và kiểm tra số lượng tài khoản tương ứng
            int count = (int)command.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                return "ok";
            }
            else
            {
                return "Tài khoản có mã " + matk + " không tồn tại trong CSDL.";
            }
        }
        public static DataTable loadTKT(string matk)
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM TaiKhoan WHERE MaTaiKhoan=@matk";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@matk", matk);

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadHVT(string mahv)
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HocVien WHERE MaHocVien=@mahv";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@mahv", mahv);

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadTHV(string hoten)
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HocVien WHERE HoTen=@hoten";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@hoten", hoten);

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static string TimHocVien(string maHocVien)
        {
            string result = "Không tồn tại học viên này trong cơ sở dữ liệu";

            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin học viên
            string query = "SELECT COUNT(*) FROM HocVien WHERE MaHocVien=@maHocVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maHocVien", maHocVien);

            // Thực hiện truy vấn và lấy giá trị đầu tiên
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                result = "Học viên có mã " + maHocVien + " tồn tại trong cơ sở dữ liệu";
            }

            // Đóng kết nối và trả về kết quả
            conn.Close();
            return result;
        }
        public static string TimHocVienT(string tenhv)
        {
            string result = "Không tồn tại học viên này trong cơ sở dữ liệu";

            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin học viên
            string query = "SELECT COUNT(*) FROM HocVien WHERE HoTen=@tenhv";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tenhv", tenhv);

            // Thực hiện truy vấn và lấy giá trị đầu tiên
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                result = "Học viên có tên " + tenhv + " tồn tại trong cơ sở dữ liệu";
            }

            // Đóng kết nối và trả về kết quả
            conn.Close();
            return result;
        }

        public static string suaTK(TaiKhoan tk)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "UPDATE TaiKhoan SET TenTaiKhoan = @tenTK, MatKhau = @matKhau, MaQuyen = @maQuyen WHERE MaTaiKhoan = @maTK";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maTK", tk.MaTaiKhoan);
            command.Parameters.AddWithValue("@tenTK", tk.TenTaiKhoan);
            command.Parameters.AddWithValue("@matKhau", tk.MatKhau);
            command.Parameters.AddWithValue("@maQuyen", tk.MaQuyen);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Cập nhật thông tin tài khoản thành công";
            }
            else
            {
                return "Cập nhật thông tin tài khoản không thành công";
            }
        }
        public static string xoaTK(string matk)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "DELETE FROM TaiKhoan WHERE MaTaiKhoan=@matk";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maTK", matk);

            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "xóa tài khoản thành công";
            }
            else
            {
                return "xóa tài khoản không thành công";
            }
        }
        //truy vấn học viên

        public static string themHV(HocVien hv)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "INSERT INTO HocVien (MaHocVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, NgheNghiep) " +
                               "VALUES (@MaHocVien, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @NgheNghiep)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", hv.MaHV);
                cmd.Parameters.AddWithValue("@HoTen", hv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", hv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", hv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", hv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", hv.Sdt);
                cmd.Parameters.AddWithValue("@NgheNghiep", hv.NgheNghiep);

                cmd.ExecuteNonQuery();

                result = "Thêm học viên thành công";
            }
            catch (Exception ex)
            {
                result = "Thêm học viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string capNhatHV(HocVien hv)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "UPDATE HocVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, " +
                    "SoDienThoai = @SoDienThoai, NgheNghiep = @NgheNghiep WHERE MaHocVien = @MaHocVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", hv.MaHV);
                cmd.Parameters.AddWithValue("@HoTen", hv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", hv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", hv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", hv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", hv.Sdt);
                cmd.Parameters.AddWithValue("@NgheNghiep", hv.NgheNghiep);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = "Cập nhật thông tin học viên thành công";
                }
                else
                {
                    result = "Không tìm thấy học viên cần cập nhật";
                }
            }
            catch (Exception ex)
            {
                result = "Cập nhật thông tin học viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string xoaHV(string maHV)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "EXEC XoaHocVien @MaHocVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", maHV);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = "Xóa học viên thành công";
                }
                else
                {
                    result = "Không tìm thấy học viên cần xóa";
                }
            }
            catch (Exception ex)
            {
                result = "Xóa học viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static string LayMaCuoi()
        {
            string result = "Chưa có";

            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT TOP 1 MaHocVien FROM HocVien ORDER BY MaHocVien DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    result = reader["MaHocVien"].ToString();
                }
            }
            catch (Exception ex)
            {
                result = "Lỗi truy vấn cơ sở dữ liệu: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        // truy vấn khóa học :
        public static string themKH(KhoaHoc kh)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc) " +
                               "VALUES (@MaKhoaHoc, @TenKhoaHoc)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhoaHoc", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKhoaHoc", kh.TenKH);

                cmd.ExecuteNonQuery();
                result = "Thêm khóa học thành công";
            }
            catch (Exception ex)
            {
                result = "Thêm khóa học thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public static string getMaKH()
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT TOP 1 MaKhoaHoc FROM KhoaHoc ORDER BY MaKhoaHoc DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("MaKhoaHoc")))
                    {
                        result = reader["MaKhoaHoc"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                result = "Lỗi truy vấn: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static DataTable LoadKH()
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string query = "SELECT * FROM KhoaHoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable LoadKHT(string maKhoaHoc)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * FROM KhoaHoc WHERE MaKhoaHoc = @MaKhoaHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhoaHoc", maKhoaHoc);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt.Columns.Add("Error");
                dt.Rows.Add("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static string CheckKHT(string maKhoaHoc)
        {
            string result = "Không tồn tại khóa học này trong cơ sở dữ liệu";

            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin khóa học
            string query = "SELECT COUNT(*) FROM KhoaHoc WHERE MaKhoaHoc=@maKhoaHoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maKhoaHoc", maKhoaHoc);

            // Thực hiện truy vấn và lấy giá trị đầu tiên
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                result = "Khóa học có mã " + maKhoaHoc + " tồn tại trong cơ sở dữ liệu";
            }

            // Đóng kết nối và trả về kết quả
            conn.Close();
            return result;
        }
        public static string suaKH(KhoaHoc kh)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "UPDATE KhoaHoc SET TenKhoaHoc=@TenKhoaHoc WHERE MaKhoaHoc=@MaKhoaHoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhoaHoc", kh.MaKH);
                cmd.Parameters.AddWithValue("@TenKhoaHoc", kh.TenKH);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = "Sửa thông tin khóa học thành công";
                }
                else
                {
                    result = "Không tìm thấy khóa học có mã " + kh.MaKH;
                }
            }
            catch (Exception ex)
            {
                result = "Sửa thông tin khóa học thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static string xoaKH(string maKH)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "DELETE FROM KhoaHoc WHERE MaKhoaHoc=@MaKhoaHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhoaHoc", maKH);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = "Xóa khóa học thành công";
                }
                else
                {
                    result = "Không tìm thấy khóa học có mã " + maKH;
                }
            }
            catch (Exception ex)
            {
                result = "Xóa khóa học thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        // truy vấn lớp học
        // Hàm kiểm tra sự tồn tại của giá trị trong cơ sở dữ liệu
        private static bool KiemTraTonTai(string tableName, string columnName, string value)
        {
            bool result = false;
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @Value";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Value", value);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string themLH(LopHoc lh)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                // Kiểm tra xem đã tồn tại lớp học nào khác trong cùng phòng học và cùng ca học trong khoảng thời gian của lớp học mới
                string checkQuery = "SELECT COUNT(*) FROM LopHoc " +
                                    "WHERE MaPhongHoc = @MaPhongHoc AND CaHoc = @CaHoc " +
                                    "AND ((NgayBatDau <= @NgayBatDau AND NgayKetThuc >= @NgayBatDau) " +
                                    "OR (NgayBatDau <= @NgayKetThuc AND NgayKetThuc >= @NgayKetThuc))";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaPhongHoc", lh.MaPhongHoc);
                checkCmd.Parameters.AddWithValue("@CaHoc", lh.CaHoc);
                checkCmd.Parameters.AddWithValue("@NgayBatDau", lh.NgayBatDau);
                checkCmd.Parameters.AddWithValue("@NgayKetThuc", lh.NgayKetThuc);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                {
                    return "Thêm lớp học thất bại: Phòng học và ca học đã được sử dụng cho lớp học khác trong khoảng thời gian này";
                }
                // Lấy số buổi học của môn học
                string getSoBuoiQuery = "SELECT SoBuoi FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                SqlCommand getSoBuoiCmd = new SqlCommand(getSoBuoiQuery, conn);
                getSoBuoiCmd.Parameters.AddWithValue("@MaMonHoc", lh.MaMonHoc);
                int soBuoi = Convert.ToInt32(getSoBuoiCmd.ExecuteScalar());
                // Kiểm tra xem khoảng cách giữa ngày bắt đầu và ngày kết thúc có lớn hơn số buổi học của môn học hay không
                TimeSpan duration = lh.NgayKetThuc - lh.NgayBatDau;
                int soNgayHoc = duration.Days + 1; // Số ngày học là số ngày giữa ngày bắt đầu và ngày kết thúc + 1
                if (soNgayHoc < soBuoi)
                {
                    return "Thêm lớp học thất bại: Khoảng cách giữa ngày bắt đầu và ngày kết thúc phải lớn hơn số buổi học của môn học";
                }
                string checkMonHocQuery = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                SqlCommand checkMonHocCmd = new SqlCommand(checkMonHocQuery, conn);
                checkMonHocCmd.Parameters.AddWithValue("@MaMonHoc", lh.MaMonHoc);
                int countMonHoc = Convert.ToInt32(checkMonHocCmd.ExecuteScalar());
                if (countMonHoc == 0)
                {
                    return "Thêm lớp học thất bại: Mã môn học không tồn tại trong bảng MonHoc";
                }
                string checkPhongHocQuery = "SELECT COUNT(*) FROM PhongHoc WHERE MaPhongHoc = @MaPhongHoc";
                SqlCommand checkPhongHocCmd = new SqlCommand(checkPhongHocQuery, conn);
                checkPhongHocCmd.Parameters.AddWithValue("@MaPhongHoc", lh.MaPhongHoc);
                int countPhongHoc = Convert.ToInt32(checkPhongHocCmd.ExecuteScalar());
                if (countPhongHoc == 0)
                {
                    return "Thêm lớp học thất bại: Mã phòng học không tồn tại trong bảng PhongHoc";
                }

                // Nếu không có lớp học nào trùng lặp, thực hiện thêm lớp học mới
                string query = "INSERT INTO LopHoc (MaLopHoc, TenLopHoc, SiSo, NgayBatDau, NgayKetThuc, CaHoc, MaMonHoc, MaPhongHoc) " +
                "VALUES (@MaLopHoc, @TenLopHoc, @SiSo, @NgayBatDau, @NgayKetThuc, @CaHoc, @MaMonHoc, @MaPhongHoc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLopHoc", lh.MaLopHoc);
                cmd.Parameters.AddWithValue("@TenLopHoc", lh.TenLopHoc);
                cmd.Parameters.AddWithValue("@SiSo", lh.SiSo);
                cmd.Parameters.AddWithValue("@NgayBatDau", lh.NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", lh.NgayKetThuc);
                cmd.Parameters.AddWithValue("@CaHoc", lh.CaHoc);
                cmd.Parameters.AddWithValue("@MaMonHoc", lh.MaMonHoc);
                cmd.Parameters.AddWithValue("@MaPhongHoc", lh.MaPhongHoc);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = "Thêm lớp học thành công";
                }
                else
                {
                    result = "Thêm lớp học thất bại";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                result = "Thêm lớp học thất bại: " + ex.Message;
            }

            return result;
        }

        public static string xoaLH(string maLopHoc)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "EXEC XoaLopHoc  @MaLopHoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLopHoc", maLopHoc);

                int rowsAffected = cmd.ExecuteNonQuery();


                    result = "Xóa lớp học thành công";
                

            }
            catch (Exception ex)
            {
                result = "Xóa lớp học thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public static string checkLH(string maLopHoc)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT COUNT(*) FROM LopHoc WHERE MaLopHoc = @MaLopHoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLopHoc", maLopHoc);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    result = "có";
                }
                else
                {
                    result = "Mã lớp học " + maLopHoc + " không tồn tại trong bảng LopHoc.";
                }
            }
            catch (Exception ex)
            {
                result = "Lỗi xảy ra khi kiểm tra mã lớp học: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static string suaLH(LopHoc lh)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                // Kiểm tra xem lớp học cần sửa có tồn tại hay không
                string checkExistQuery = "SELECT COUNT(*) FROM LopHoc WHERE MaLopHoc = @MaLopHoc";
                SqlCommand checkExistCmd = new SqlCommand(checkExistQuery, conn);
                checkExistCmd.Parameters.AddWithValue("@MaLopHoc", lh.MaLopHoc);
                int count = Convert.ToInt32(checkExistCmd.ExecuteScalar());
                if (count == 0)
                {
                    return "Sửa lớp học thất bại: Mã lớp học không tồn tại";
                }

                // Kiểm tra xem đã tồn tại lớp học nào khác trong cùng phòng học và cùng ca học trong khoảng thời gian của lớp học mới
                string checkQuery = "SELECT COUNT(*) FROM LopHoc " +
                                    "WHERE MaPhongHoc = @MaPhongHoc AND CaHoc = @CaHoc " +
                                    "AND ((NgayBatDau <= @NgayBatDau AND NgayKetThuc >= @NgayBatDau) " +
                                    "OR (NgayBatDau <= @NgayKetThuc AND NgayKetThuc >= @NgayKetThuc)) " +
                                    "AND MaLopHoc != @MaLopHoc"; // Loại trừ lớp học đang sửa
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaPhongHoc", lh.MaPhongHoc);
                checkCmd.Parameters.AddWithValue("@CaHoc", lh.CaHoc);
                checkCmd.Parameters.AddWithValue("@NgayBatDau", lh.NgayBatDau);
                checkCmd.Parameters.AddWithValue("@NgayKetThuc", lh.NgayKetThuc);
                checkCmd.Parameters.AddWithValue("@MaLopHoc", lh.MaLopHoc);
                int countDup = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (countDup > 0)
                {
                    return "Sửa lớp học thất bại: Phòng học và ca học đã được sử dụng cho lớp học khác trong khoảng thời gian này";
                }

                // Lấy số buổi học của môn học
                string getSoBuoiQuery = "SELECT SoBuoi FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                SqlCommand getSoBuoiCmd = new SqlCommand(getSoBuoiQuery, conn);
                getSoBuoiCmd.Parameters.AddWithValue("@MaMonHoc", lh.MaMonHoc);
                int soBuoi = Convert.ToInt32(getSoBuoiCmd.ExecuteScalar());

                // Kiểm tra xem khoảng cách giữa ngày bắt đầu và ngày kết thúc có lớn hơn số buổi học của môn học hay không
                TimeSpan duration = lh.NgayKetThuc - lh.NgayBatDau;
                int soNgayHoc = duration.Days + 1; // Số ngày học là tổng số ngày trong khoảng thời gian + 1
                if (soNgayHoc < soBuoi)
                {
                    return "Sửa lớp học thất bại: Số buổi học của môn học lớn hơn khoảng thời gian đã chọn";
                }
                string checkMonHocQuery = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                SqlCommand checkMonHocCmd = new SqlCommand(checkMonHocQuery, conn);
                checkMonHocCmd.Parameters.AddWithValue("@MaMonHoc", lh.MaMonHoc);
                int countMonHoc = Convert.ToInt32(checkMonHocCmd.ExecuteScalar());
                if (countMonHoc == 0)
                {
                    return " Mã môn học không tồn tại trong bảng MonHoc";
                }
                string checkPhongHocQuery = "SELECT COUNT(*) FROM PhongHoc WHERE MaPhongHoc = @MaPhongHoc";
                SqlCommand checkPhongHocCmd = new SqlCommand(checkPhongHocQuery, conn);
                checkPhongHocCmd.Parameters.AddWithValue("@MaPhongHoc", lh.MaPhongHoc);
                int countPhongHoc = Convert.ToInt32(checkPhongHocCmd.ExecuteScalar());
                if (countPhongHoc == 0)
                {
                    return " Mã phòng học không tồn tại trong bảng PhongHoc";
                }

                // Thực hiện cập nhật thông tin của lớp học vào cơ sở dữ liệu
                string updateQuery = "UPDATE LopHoc SET TenLopHoc =@TenLopHoc, MaMonHoc = @MaMonHoc, MaPhongHoc = @MaPhongHoc,SiSo=@siso, " +
                                    "CaHoc = @CaHoc, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc " +
                                    "WHERE MaLopHoc = @MaLopHoc";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@MaMonHoc", lh.MaMonHoc);
                updateCmd.Parameters.AddWithValue("@MaPhongHoc", lh.MaPhongHoc);
                updateCmd.Parameters.AddWithValue("@CaHoc", lh.CaHoc);
                updateCmd.Parameters.AddWithValue("@NgayBatDau", lh.NgayBatDau);
                updateCmd.Parameters.AddWithValue("@NgayKetThuc", lh.NgayKetThuc);
                updateCmd.Parameters.AddWithValue("@MaLopHoc", lh.MaLopHoc);
                updateCmd.Parameters.AddWithValue("@TenLopHoc", lh.TenLopHoc);
                updateCmd.Parameters.AddWithValue("@siso", lh.SiSo);
                updateCmd.ExecuteNonQuery();

                result = "Sửa lớp học thành công";
            }
            catch (Exception ex)
            {
                result = "Sửa lớp học thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static DataTable LoadLH()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * FROM LopHoc"; // Thay đổi query để select tất cả các cột trong bảng LopHoc
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable LoadLHC()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * FROM LopHoc WHERE NOT EXISTS (SELECT 1 FROM GiangDay WHERE GiangDay.MaLopHoc = LopHoc.MaLopHoc)"; // Thêm mệnh đề NOT EXISTS để chỉ lấy những bản ghi có MaLopHoc chưa tồn tại trong bảng GiangDay
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable loadLHDK(string maHocVien)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = @"SELECT lh.MaLopHoc, lh.TenLopHoc
                                            FROM LopHoc lh
                                            WHERE NOT EXISTS (
                                                SELECT 1
                                                FROM LopHoc lh5
                                                WHERE lh5.MaMonHoc = lh.MaMonHoc
                                                    AND lh5.MaLopHoc <> lh.MaLopHoc
                                                    AND EXISTS (
                                                        SELECT 1
                                                        FROM ghidanh gh3
                                                        INNER JOIN LopHoc lh6 ON gh3.MaLopHoc = lh6.MaLopHoc
                                                        WHERE gh3.MaHocVien = @MaHocVien
                                                        AND lh6.MaMonHoc = lh5.MaMonHoc)
                                            )
                                            AND NOT EXISTS(
                                            SELECT 1
                                             FROM ghidanh gh
                                            WHERE gh.MaHocVien = @MaHocVien
                                            AND gh.MaLopHoc = lh.MaLopHoc)
										    AND lh.ChoTrong > 0
										    AND NOT EXISTS (
											    SELECT 1
											    FROM LopHoc lh2
											    WHERE lh2.CaHoc = lh.CaHoc
												    AND lh2.NgayBatDau <= lh.NgayKetThuc
												    AND lh2.NgayKetThuc >= lh.NgayBatDau
												    AND EXISTS (
													    SELECT 1
													    FROM ghidanh gh2
													    WHERE gh2.MaHocVien = @MaHocVien
														    AND gh2.MaLopHoc = lh2.MaLopHoc
												    ))";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", maHocVien);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable LoadLHT(string maLopHoc)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * " + // Thay đổi query để select tất cả các cột trong bảng LopHoc
                               "FROM LopHoc " +
                               "WHERE MaLopHoc = @MaLopHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLopHoc", maLopHoc);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static string LayMaLopHocCuoiCung()
        {
            string maLopHoc = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT TOP 1 MaLopHoc " +
                               "FROM LopHoc " +
                               "ORDER BY MaLopHoc DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    maLopHoc = reader["MaLopHoc"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return maLopHoc;
        }
        public static string autoLH()
        {
            string maLopHoc = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT TOP 1 MaLopHoc " +
                               "FROM LopHoc " +
                               "ORDER BY MaLopHoc DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string lastMaLopHoc = reader["MaLopHoc"].ToString();
                    int lastNumber = Convert.ToInt32(lastMaLopHoc.Substring(2));
                    int newNumber = lastNumber + 1;
                    maLopHoc = "LH" + newNumber.ToString("D3");
                }
                else
                {
                    maLopHoc = "LH001";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return maLopHoc;
        }
        // truy vấn và thao tác Môn Học
        public static string themMH(MonHoc mh)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                // Kiểm tra xem MaKhoaHoc đã tồn tại trong bảng KhoaHoc chưa
                string checkKhoaHocQuery = "SELECT COUNT(*) FROM KhoaHoc WHERE MaKhoaHoc = @MaKhoaHoc";
                SqlCommand checkKhoaHocCmd = new SqlCommand(checkKhoaHocQuery, conn);
                checkKhoaHocCmd.Parameters.AddWithValue("@MaKhoaHoc", mh.MaKhoaHoc);
                int count = (int)checkKhoaHocCmd.ExecuteScalar();

                if (count == 0)
                {
                    result = "Thêm môn học thất bại: Mã khoa học không tồn tại trong bảng KhoaHoc";
                }
                else
                {
                    string query = "INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoBuoi, HocPhi, MaKhoaHoc) " +
                                   "VALUES (@MaMonHoc, @TenMonHoc, @SoBuoi, @HocPhi, @MaKhoaHoc)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaMonHoc", mh.MaMonHoc);
                    cmd.Parameters.AddWithValue("@TenMonHoc", mh.TenMonHoc);
                    cmd.Parameters.AddWithValue("@SoBuoi", mh.SoBuoi);
                    cmd.Parameters.AddWithValue("@HocPhi", mh.HocPhi);
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", mh.MaKhoaHoc);

                    cmd.ExecuteNonQuery();
                    result = "Thêm môn học thành công";
                }
            }
            catch (Exception ex)
            {
                result = "Thêm môn học thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static string xoaMH(string maMonHoc)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                // Kiểm tra xem MaMonHoc đã tồn tại trong bảng MonHoc chưa
                string checkMonHocQuery = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                SqlCommand checkMonHocCmd = new SqlCommand(checkMonHocQuery, conn);
                checkMonHocCmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                int count = (int)checkMonHocCmd.ExecuteScalar();

                if (count == 0)
                {
                    result = "Xóa môn học thất bại: Mã môn học không tồn tại trong bảng MonHoc";
                }
                else
                {
                    string query = "EXEC XoaMonHoc @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                    cmd.ExecuteNonQuery();
                    result = "Xóa môn học thành công";
                }
            }
            catch (Exception ex)
            {
                result = "Xóa môn học thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static string suaMH(string maMonHoc, MonHoc mh)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                // Kiểm tra xem MaKhoaHoc đã tồn tại trong bảng KhoaHoc chưa
                string checkKhoaHocQuery = "SELECT COUNT(*) FROM KhoaHoc WHERE MaKhoaHoc = @MaKhoaHoc";
                SqlCommand checkKhoaHocCmd = new SqlCommand(checkKhoaHocQuery, conn);
                checkKhoaHocCmd.Parameters.AddWithValue("@MaKhoaHoc", mh.MaKhoaHoc);
                int count = (int)checkKhoaHocCmd.ExecuteScalar();

                if (count == 0)
                {
                    result = "Cập nhật môn học thất bại: Mã khoa học không tồn tại trong bảng KhoaHoc";
                }
                else
                {
                    // Cập nhật thông tin môn học
                    string query = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc, SoBuoi = @SoBuoi, HocPhi = @HocPhi, MaKhoaHoc = @MaKhoaHoc WHERE MaMonHoc = @MaMonHoc";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenMonHoc", mh.TenMonHoc);
                    cmd.Parameters.AddWithValue("@SoBuoi", mh.SoBuoi);
                    cmd.Parameters.AddWithValue("@HocPhi", mh.HocPhi);
                    cmd.Parameters.AddWithValue("@MaKhoaHoc", mh.MaKhoaHoc);
                    cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        result = "Cập nhật thông tin môn học thành công";
                    }
                    else
                    {
                        result = "Cập nhật môn học thất bại";
                    }
                }
            }
            catch (Exception ex)
            {
                result = "Có lỗi xảy ra: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static DataTable loadMH()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * FROM MonHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable loadMHT(string maMonHoc)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * " +
                               "FROM MonHoc " +
                               "WHERE MaMonHoc = @MaMonHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static string autoMH()
        {
            string maMonHoc = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT TOP 1 MaMonHoc " +
                               "FROM MonHoc " +
                               "ORDER BY MaMonHoc DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string lastMaMonHoc = reader["MaMonHoc"].ToString();
                    int lastNumber = Convert.ToInt32(lastMaMonHoc.Substring(2));
                    int newNumber = lastNumber + 1;
                    maMonHoc = "MH" + newNumber.ToString("D3");
                }
                else
                {
                    maMonHoc = "MH001";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return maMonHoc;
        }
        public static string checkMH(string maMonHoc)
        {
            string result = "Mã môn học  không tồn tại trong cơ sở dữ liệu";

            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin môn học
            string query = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc=@maMonHoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maMonHoc", maMonHoc);

            // Thực hiện truy vấn và lấy giá trị đầu tiên
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                result = "Mã môn học " + maMonHoc + " tồn tại trong cơ sở dữ liệu";
            }

            // Đóng kết nối và trả về kết quả
            conn.Close();
            return result;
        }

        // truy vấn giáo viên 
        public static string themGV(GiaoVien gv)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "INSERT INTO GiaoVien (MaGiaoVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu) " +
                               "VALUES (@MaGiaoVien, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @ChucVu)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", gv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", gv.SoDienThoai);
                cmd.Parameters.AddWithValue("@ChucVu", gv.ChucVu);

                cmd.ExecuteNonQuery();

                result = "Thêm giáo viên thành công";
            }
            catch (Exception ex)
            {
                result = "Thêm giáo viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string suaGV(GiaoVien gv)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "UPDATE GiaoVien " +
                               "SET HoTen = @HoTen, " +
                               "GioiTinh = @GioiTinh, " +
                               "NgaySinh = @NgaySinh, " +
                               "DiaChi = @DiaChi, " +
                               "SoDienThoai = @SoDienThoai, " +
                               "ChucVu = @ChucVu " +
                               "WHERE MaGiaoVien = @MaGiaoVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", gv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", gv.SoDienThoai);
                cmd.Parameters.AddWithValue("@ChucVu", gv.ChucVu);
                cmd.Parameters.AddWithValue("@MaGiaoVien", gv.MaGiaoVien);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = "Cập nhật thông tin giáo viên thành công";
                }
                else
                {
                    result = "Không tìm thấy giáo viên để cập nhật";
                }
            }
            catch (Exception ex)
            {
                result = "Cập nhật thông tin giáo viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string xoaGV(string maGiaoVien)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "EXEC XoaGiaoVien @MaGiaoVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = "Xóa thông tin giáo viên thành công";
                }
                else
                {
                    result = "Không tìm thấy giáo viên để xóa";
                }
            }
            catch (Exception ex)
            {
                result = "Xóa thông tin giáo viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static string checkGV(string maGiaoVien)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT COUNT(*) FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    result = "Mã giáo viên đã tồn tại trong cơ sở dữ liệu.";
                }
                else
                {
                    result = "Mã giáo viên không tồn tại trong cơ sở dữ liệu.";
                }
            }
            catch (Exception ex)
            {
                result = "Lỗi kiểm tra mã giáo viên: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string checkGVT(string tengv)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT COUNT(*) FROM GiaoVien WHERE HoTen = @tengv";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tengv", tengv);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    result = "giáo viên đã tồn tại trong cơ sở dữ liệu.";
                }
                else
                {
                    result = " giáo viên không tồn tại trong cơ sở dữ liệu.";
                }
            }
            catch (Exception ex)
            {
                result = "Lỗi kiểm tra mã giáo viên: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static DataTable loadGV()
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM GiaoVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi load giáo viên từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        public static DataTable loadGVT(string maGiaoVien)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi load thông tin giáo viên từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable loadTGV(string hoten)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM GiaoVien WHERE HoTen = @hoten";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@hoten", hoten);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi load thông tin giáo viên từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable LoadGVC(string maPhongHoc, int caHoc, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                string query = @"SELECT gv.MaGiaoVien, gv.HoTen
                         FROM GiaoVien gv
                         WHERE gv.MaGiaoVien NOT IN (SELECT gd.MaGiaoVien 
                                                    FROM GiangDay gd 
                                                    INNER JOIN LopHoc lh ON gd.MaLopHoc = lh.MaLopHoc
                                                    WHERE lh.CaHoc = @CaHoc
                                                    AND ((lh.NgayBatDau BETWEEN @NgayBatDau AND @NgayKetThuc)
                                                    OR (lh.NgayKetThuc BETWEEN @NgayBatDau AND @NgayKetThuc)))
                                                    OR gv.MaGiaoVien NOT IN (SELECT MaGiaoVien FROM GiangDay)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);
                cmd.Parameters.AddWithValue("@CaHoc", caHoc);
                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi load thông tin giáo viên chưa giảng dạy từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static string autoGV()
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string maGiaoVien = "";

            try
            {
                string query = "SELECT MAX(MaGiaoVien) FROM GiaoVien";
                SqlCommand cmd = new SqlCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int maxMaGiaoVien = Convert.ToInt32(result.ToString().Substring(2));
                    maGiaoVien = "GV" + (maxMaGiaoVien + 1).ToString("D3");
                }
                else
                {
                    maGiaoVien = "GV001";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi sinh mã giáo viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return maGiaoVien;
        }

        // truy vấn điểm
        public static string themDiem(Diem diem)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                // Kiểm tra tồn tại của MaHocVien trong bảng HocVien
                string checkHocVienQuery = "SELECT COUNT(*) FROM HocVien WHERE MaHocVien = @MaHocVien";
                SqlCommand checkHocVienCmd = new SqlCommand(checkHocVienQuery, conn);
                checkHocVienCmd.Parameters.AddWithValue("@MaHocVien", diem.MaHV);
                int hocVienCount = Convert.ToInt32(checkHocVienCmd.ExecuteScalar());
                if (hocVienCount == 0)
                {
                    return "Thêm điểm thất bại: MaHocVien không tồn tại trong bảng HocVien";
                }

                // Kiểm tra tồn tại của MaMonHoc trong bảng MonHoc
                string checkMonHocQuery = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                SqlCommand checkMonHocCmd = new SqlCommand(checkMonHocQuery, conn);
                checkMonHocCmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMH);
                int monHocCount = Convert.ToInt32(checkMonHocCmd.ExecuteScalar());
                if (monHocCount == 0)
                {
                    return "Thêm điểm thất bại: MaMonHoc không tồn tại trong bảng MonHoc";
                }
                // Kiểm tra xem học viên đã đăng kí môn học này chưa
                string checkGhiDanhQuery = "SELECT COUNT(*) FROM ghidanh2 WHERE  MaHocVien=@MaHocVien AND MaMonHoc = @MaMonHoc";
                SqlCommand checkGhiDanhCmd = new SqlCommand(checkGhiDanhQuery, conn);
                checkGhiDanhCmd.Parameters.AddWithValue("@MaHocVien", diem.MaHV);
                checkGhiDanhCmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMH);
                int ghidanhCount = Convert.ToInt32(checkGhiDanhCmd.ExecuteScalar());
                if (ghidanhCount == 0)
                {
                    return "Thêm điểm thất bại: Học Viên Chưa ghi danh môn học này";
                }

                // Kiểm tra tồn tại của bản ghi với MaMonHoc và MaHocVien trùng trong bảng DiemTongHop
                string checkDiemTongHopQuery = "SELECT COUNT(*) FROM DiemTongHop WHERE MaMonHoc = @MaMonHoc AND MaHocVien = @MaHocVien";
                SqlCommand checkDiemTongHopCmd = new SqlCommand(checkDiemTongHopQuery, conn);
                checkDiemTongHopCmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMH);
                checkDiemTongHopCmd.Parameters.AddWithValue("@MaHocVien", diem.MaHV);
                int diemTongHopCount = Convert.ToInt32(checkDiemTongHopCmd.ExecuteScalar());
                if (diemTongHopCount > 0)
                {
                    return "Thêm điểm thất bại: Bản ghi đã tồn tại trong bảng DiemTongHop";
                }

                // Thêm dữ liệu vào bảng DiemTongHop
                string insertQuery = "INSERT INTO DiemTongHop (MaHocVien, MaMonHoc, DiemKiemTra1, DiemKiemTra2, DiemThi) " +
                                    "VALUES (@MaHocVien, @MaMonHoc, @DiemKiemTra1, @DiemKiemTra2, @DiemThi)";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", diem.MaHV);
                cmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMH);
                cmd.Parameters.AddWithValue("@DiemKiemTra1", diem.KT1);
                cmd.Parameters.AddWithValue("@DiemKiemTra2", diem.KT2);
                cmd.Parameters.AddWithValue("@DiemThi", diem.DiemThi);

                cmd.ExecuteNonQuery();

                result = "Thêm điểm thành công";
            }
            catch (Exception ex)
            {
                result = "Thêm điểm thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string suaDiem(Diem diem)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                // Kiểm tra sự tồn tại của MaHocVien trong bảng HocVien
                string checkMaHocVienQuery = "SELECT COUNT(*) FROM HocVien WHERE MaHocVien = @MaHocVien";
                SqlCommand checkMaHocVienCmd = new SqlCommand(checkMaHocVienQuery, conn);
                checkMaHocVienCmd.Parameters.AddWithValue("@MaHocVien", diem.MaHV);
                int maHocVienExist = (int)checkMaHocVienCmd.ExecuteScalar();

                if (maHocVienExist == 0)
                {
                    return "Mã học viên không tồn tại trong bảng HocVien";
                }

                // Kiểm tra sự tồn tại của MaMonHoc trong bảng MonHoc
                string checkMaMonHocQuery = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                SqlCommand checkMaMonHocCmd = new SqlCommand(checkMaMonHocQuery, conn);
                checkMaMonHocCmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMH);
                int maMonHocExist = (int)checkMaMonHocCmd.ExecuteScalar();

                if (maMonHocExist == 0)
                {
                    return "Mã môn học không tồn tại trong bảng MonHoc";
                }

                // Kiểm tra sự tồn tại của bản ghi trong bảng DiemTongHop
                string checkDiemTongHopQuery = "SELECT COUNT(*) FROM DiemTongHop WHERE MaHocVien = @MaHocVien AND MaMonHoc = @MaMonHoc";
                SqlCommand checkDiemTongHopCmd = new SqlCommand(checkDiemTongHopQuery, conn);
                checkDiemTongHopCmd.Parameters.AddWithValue("@MaHocVien", diem.MaHV);
                checkDiemTongHopCmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMH);
                int diemTongHopExist = (int)checkDiemTongHopCmd.ExecuteScalar();

                if (diemTongHopExist == 0)
                {
                    return "Bản ghi không tồn tại trong bảng DiemTongHop";
                }

                // Cập nhật giá trị trong bảng DiemTongHop
                string updateQuery = "UPDATE DiemTongHop SET DiemKiemTra1 = @DiemKiemTra1, DiemKiemTra2 = @DiemKiemTra2, DiemThi = @DiemThi " +
                                     "WHERE MaHocVien = @MaHocVien AND MaMonHoc = @MaMonHoc";

                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@DiemKiemTra1", diem.KT1);
                updateCmd.Parameters.AddWithValue("@DiemKiemTra2", diem.KT2);
                updateCmd.Parameters.AddWithValue("@DiemThi", diem.DiemThi);
                updateCmd.Parameters.AddWithValue("@MaHocVien", diem.MaHV);
                updateCmd.Parameters.AddWithValue("@MaMonHoc", diem.MaMH);
                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = "Cập nhật điểm thành công";
                }
                else
                {
                    result = "Không thể cập nhật điểm";
                }
            }
            catch (Exception ex)
            {
                result = "Lỗi: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static string xoaDiem(string maHocVien, string maMonHoc)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                // Kiểm tra sự tồn tại của mã học viên và mã môn học trong bảng HocVien và MonHoc
                string checkQuery = "SELECT COUNT(*) FROM HocVien WHERE MaHocVien = @MaHocVien";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaHocVien", maHocVien);
                int hocVienCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                checkQuery = "SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
                checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                int monHocCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (hocVienCount > 0 && monHocCount > 0)
                {
                    // Kiểm tra xem tồn tại bản ghi nào trong bảng DiemTongHop có mã học viên và mã môn học trùng với dữ liệu chuẩn bị xóa không
                    string deleteQuery = "DELETE FROM DiemTongHop WHERE MaHocVien = @MaHocVien AND MaMonHoc = @MaMonHoc";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@MaHocVien", maHocVien);
                    deleteCmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        result = "Xóa điểm thành công";
                    }
                    else
                    {
                        result = "Không tìm thấy dữ liệu để xóa";
                    }
                }
                else
                {
                    result = "Mã học viên hoặc mã môn học không tồn tại";
                }
            }
            catch (Exception ex)
            {
                result = "Lỗi: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static DataTable loadDiem()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                string query = "SELECT * FROM DiemTongHop";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static DataTable loadDiemT(string mahv)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                string query = "SELECT * FROM DiemTongHop WHERE MaHocVien = @MaHocVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", mahv);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static string checkDiem(string mahv)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                string query = "SELECT COUNT(*) FROM DiemTongHop WHERE MaHocVien = @MaHocVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", mahv);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    return "có";
                }
                else
                {
                    return "học viên này chưa được thêm điểm";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            

        }
        public static DataTable hienDiemT(string mahv)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                string query = "SELECT * FROM DiemTongHop WHERE MaHocVien=@mahv";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mahv", mahv);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static SqlDataAdapter hienDiemTA(string mahv)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                string query = "SELECT * FROM DiemTongHop WHERE MaHocVien=@mahv";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mahv", mahv);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                return adapter;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public static string checkDiemM(string mamh)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                string query = "SELECT COUNT(*) FROM DiemTongHop WHERE MaMonHoc = @MaMonHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMonHoc", mamh);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    return "có";
                }
                else
                {
                    return "mã môn học này chưa tồn tại trong bảng DiemTongHop";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable hienDiemM(string mamh)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            try
            {
                string query = "SELECT * FROM DiemTongHop WHERE MaMonHoc=@mamonhoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mamonhoc", mamh);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        // truy vấn giảng dạy
        public DataTable loadGD()
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = @"SELECT * FROM GiangDay";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi load thông tin GiangDay: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string themGD(string maGiaoVien, string maLopHoc)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = @"INSERT INTO GiangDay (MaGiaoVien, MaLopHoc) VALUES (@MaGiaoVien, @MaLopHoc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                cmd.Parameters.AddWithValue("@MaLopHoc", maLopHoc);

                cmd.ExecuteNonQuery();
                result = "Thêm dữ liệu vào bảng GiangDay thành công";
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm dữ liệu vào bảng GiangDay: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string xoaGD(string maGiaoVien, string maLopHoc)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = @"DELETE FROM GiangDay WHERE MaGiaoVien = @MaGiaoVien AND MaLopHoc = @MaLopHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);
                cmd.Parameters.AddWithValue("@MaLopHoc", maLopHoc);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = "Xóa dữ liệu từ bảng GiangDay thành công";
                }
                else
                {
                    result = "Không tìm thấy dữ liệu trong bảng GiangDay để xóa";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa dữ liệu từ bảng GiangDay: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public DataTable timGD(string maGiaoVien)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = @"SELECT * FROM GiangDay
                        WHERE MaGiaoVien = @MaGiaoVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGiaoVien", maGiaoVien);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tìm thông tin GiangDay: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        //truy vấn nhân viên'
        public static string themNV(NhanVien nv)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu) " +
                               "VALUES (@MaNhanVien, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @ChucVu)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);

                cmd.ExecuteNonQuery();

                result = "Thêm nhân viên thành công";
            }
            catch (Exception ex)
            {
                result = "Thêm nhân viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static string xoaNV(string maNhanVien)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = "Xóa nhân viên thành công";
                }
                else
                {
                    result = "Không tìm thấy nhân viên có mã: " + maNhanVien;
                }
            }
            catch (Exception ex)
            {
                result = "Xóa nhân viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string suaNV(NhanVien nv)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, ChucVu = @ChucVu " +
                               "WHERE MaNhanVien = @MaNhanVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = "Sửa thông tin nhân viên thành công";
                }
                else
                {
                    result = "Không tìm thấy nhân viên cần sửa";
                }
            }
            catch (Exception ex)
            {
                result = "Sửa thông tin nhân viên thất bại: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static DataTable loadNV()
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM NhanVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine("Lỗi load thông tin nhân viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable loadNVT(string maNhanVien)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine("Lỗi load thông tin nhân viên theo mã nhân viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable loadTNV(string hoten)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM NhanVien WHERE HoTen = @hoten";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@hoten", hoten);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine("Lỗi load thông tin nhân viên theo mã nhân viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static string checkNV(string maNhanVien)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            string result = "";

            try
            {
                string query = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    result = "oke";
                }
                else
                {
                    result = "Nhân viên này không tồn tại";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine("Lỗi kiểm tra tồn tại mã nhân viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string checkNVT(string tennv)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            string result = "";

            try
            {
                string query = "SELECT COUNT(*) FROM NhanVien WHERE HoTen = @hoten";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@hoten", tennv);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    result = "oke";
                }
                else
                {
                    result = "Nhân viên này không tồn tại";
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine("Lỗi kiểm tra tồn tại mã nhân viên: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public static string autoNV()
        {
            string maNhanVien = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT TOP 1 MaNhanVien " +
                               "FROM NhanVien " +
                               "ORDER BY MaNhanVien DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string lastMaNhanVien = reader["MaNhanVien"].ToString();
                    int lastNumber = Convert.ToInt32(lastMaNhanVien.Substring(2));
                    int newNumber = lastNumber + 1;
                    maNhanVien = "NV" + newNumber.ToString("D3");
                }
                else
                {
                    maNhanVien = "NV001";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }
            return maNhanVien;
        }

        // truy vấn ghi danh
        public static  DataTable loadGhD()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = SqlconnectionData.Connect())
            {
                connection.Open();
                try
                {
                    string query = "SELECT gh.MaHocVien, hv.HoTen, gh.MaLopHoc, lh.TenLopHoc, mh.MaMonHoc, mh.TenMonHoc " +
                                   "FROM ghidanh gh " +
                                   "JOIN hocvien hv ON gh.MaHocVien = hv.MaHocVien " +
                                   "JOIN LopHoc lh ON gh.MaLopHoc = lh.MaLopHoc " +
                                   "JOIN MonHoc mh ON lh.MaMonHoc = mh.MaMonHoc";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi tại đây (nếu cần)
                }
                finally
                {
                    connection.Close();
                }
            }

            return dt;
        }
        public static string themGhD(string maHocVien, string maLopHoc)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "INSERT INTO ghidanh (MaHocVien, MaLopHoc) VALUES (@maHocVien, @maLopHoc)";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maHocVien", maHocVien);
            command.Parameters.AddWithValue("@maLopHoc", maLopHoc);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Thêm dữ liệu vào bảng ghidanh thành công";
            }
            else
            {
                return "Thêm dữ liệu vào bảng ghidanh không thành công";
            }
        }
        public static string xoaGhD(string maHocVien, string maLopHoc)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "DELETE FROM ghidanh WHERE MaHocVien = @maHocVien AND MaLopHoc = @maLopHoc";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maHocVien", maHocVien);
            command.Parameters.AddWithValue("@maLopHoc", maLopHoc);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Xóa dữ liệu từ bảng ghidanh thành công";
            }
            else
            {
                return "Xóa dữ liệu từ bảng ghidanh không thành công";
            }
        }

        //truy vấn Biên Lai
        public static string ThemBL(BienLai bl)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Kiểm tra xem giá trị của trường MaHocVien đã tồn tại trong bảng HocVien hay chưa
            string hocVienQuery = "SELECT COUNT(*) FROM HocVien WHERE MaHocVien = @maHocVien";
            SqlCommand hocVienCommand = new SqlCommand(hocVienQuery, conn);
            hocVienCommand.Parameters.AddWithValue("@maHocVien", bl.MaHocVien);
            int hocVienResult = (int)hocVienCommand.ExecuteScalar();
            if (hocVienResult == 0)
            {
                conn.Close();
                return "Mã học viên không tồn tại trong bảng HocVien. Không thể thêm dữ liệu vào bảng BienLai.";
            }

            string query = "INSERT INTO BienLai (ID, TenNguoiDong, MaHocVien, SoTien, NgayDong) " +
                           "VALUES (@id, @tenNguoiDong, @maHocVien, @soTien, @ngayDong)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", bl.ID);
            command.Parameters.AddWithValue("@tenNguoiDong", bl.TenNguoiDong);
            command.Parameters.AddWithValue("@maHocVien", bl.MaHocVien);
            command.Parameters.AddWithValue("@soTien", bl.SoTien);
            command.Parameters.AddWithValue("@ngayDong", bl.NgayDong);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Thêm dữ liệu vào bảng BienLai thành công";
            }
            else
            {
                return "Thêm dữ liệu vào bảng BienLai không thành công";
            }
        }


        public static string xoaBL(string id)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "DELETE FROM BienLai WHERE ID=@ID";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@ID", id);

            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "xóa biên lai thành công";
            }
            else
            {
                return "xóa biên lai không thành công";
            }
        }

        public static string suaBL(BienLai bl)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            // Kiểm tra xem giá trị của trường MaHocVien đã tồn tại trong bảng HocVien hay chưa
            string hocVienQuery = "SELECT COUNT(*) FROM HocVien WHERE MaHocVien = @maHocVien";
            SqlCommand hocVienCommand = new SqlCommand(hocVienQuery, conn);
            hocVienCommand.Parameters.AddWithValue("@maHocVien", bl.MaHocVien);
            int hocVienResult = (int)hocVienCommand.ExecuteScalar();
            if (hocVienResult == 0)
            {
                conn.Close();
                return "Mã học viên không tồn tại trong bảng HocVien. Không thể thêm dữ liệu vào bảng BienLai.";
            }
            string querry = "UPDATE BienLai SET  TenNguoiDong = @TenNguoiDong, MaHocVien=@MaHocVien,SoTien=@SoTien,NgayDong=@NgayDong  WHERE ID = @ID";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@TenNguoiDong", bl.TenNguoiDong);
            command.Parameters.AddWithValue("@MaHocVien", bl.MaHocVien);
            command.Parameters.AddWithValue("@SoTien", bl.SoTien);
            command.Parameters.AddWithValue("@NgayDong", bl.NgayDong);
            command.Parameters.AddWithValue("@ID", bl.ID);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Cập nhật thông tin Biên Lai thành công";
            }
            else
            {
                return "Cập nhật thông tin Biên Lai không thành công";
            }
        }
        public static DataTable loadBL()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM BienLai";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadBLT(string id)
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM BienLai WHERE MaHocVien=@ID";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@ID", id);

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadBLID(string id)
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM BienLai WHERE ID=@ID";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@ID", id);

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }

        public static string autoBL()
        {
            string maBienLai = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT TOP 1 ID " +
                               "FROM BienLai " +
                               "ORDER BY ID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string lastMaBienLai = reader["ID"].ToString();
                    int lastNumber = Convert.ToInt32(lastMaBienLai.Substring(2));
                    int newNumber = lastNumber + 1;
                    maBienLai = "BL" + newNumber.ToString("D4");
                }
                else
                {
                    maBienLai = "BL0001";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return maBienLai;
        }
        public static string checkBL(string maHocVien)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * " +
                               "FROM BienLai " +
                               "WHERE MaHocVien = @MaHocVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHocVien", maHocVien);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = "Mã học viên đã tồn tại trong bảng BiênLai";
                }
                else
                {
                    result = "Mã học viên không tồn tại trong bảng BiênLai";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static string checkMBL(string id)
        {
            string result = "";
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            try
            {
                string query = "SELECT * " +
                               "FROM BienLai " +
                               "WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = "ID đã tồn tại trong bảng BiênLai";
                }
                else
                {
                    result = "ID không tồn tại trong bảng BiênLai";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi tại đây (nếu cần)
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        // truy vấn học phí
        public static DataTable loadHP()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HP INNER JOIN TinhTrangHocPhi ON HP.MaHocVien = TinhTrangHocPhi.MaHocVien;";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadHPTK(string mahv)
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HP INNER JOIN TinhTrangHocPhi ON HP.MaHocVien = TinhTrangHocPhi.MaHocVien WHERE   HoTen=@mahv";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@mahv",mahv);

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadHPC()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HP INNER JOIN TinhTrangHocPhi ON HP.MaHocVien = TinhTrangHocPhi.MaHocVien WHERE TinhTrang=N'Chưa Đóng';";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadHPT()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HP INNER JOIN TinhTrangHocPhi ON HP.MaHocVien = TinhTrangHocPhi.MaHocVien WHERE TinhTrang=N'Đóng Thiếu';";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadHPD()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HP INNER JOIN TinhTrangHocPhi ON HP.MaHocVien = TinhTrangHocPhi.MaHocVien WHERE TinhTrang=N'Đóng Đủ';";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        public static DataTable loadHPDu()
        {
            // Mở kết nối tới database
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();

            // Tạo câu truy vấn để lấy thông tin các tài khoản
            string querry = "SELECT * FROM HP INNER JOIN TinhTrangHocPhi ON HP.MaHocVien = TinhTrangHocPhi.MaHocVien WHERE TinhTrang=N'Đóng Dư';";

            // Tạo đối tượng SqlDataAdapter để thực hiện truy vấn và lấy dữ liệu vào DataTable
            SqlDataAdapter da = new SqlDataAdapter(querry, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Đóng kết nối và trả về DataTable chứa thông tin các tài khoản
            conn.Close();
            return dt;
        }
        // truy vấn phòng học
        public static string themPH(Phong ph)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "INSERT INTO PhongHoc (MaPhongHoc, TenPhongHoc) VALUES (@maPhongHoc, @tenPhongHoc)";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maPhongHoc", ph.MaPhongHoc);
            command.Parameters.AddWithValue("@tenPhongHoc", ph.TenPhongHoc);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Thêm phòng học thành công";
            }
            else
            {
                return "Thêm phòng học không thành công";
            }
        }

        public static string suaPH(Phong ph)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "UPDATE PhongHoc SET TenPhongHoc = @tenPhongHoc WHERE MaPhongHoc = @maPhongHoc";
            SqlCommand command = new SqlCommand(querry, conn);
            command.Parameters.AddWithValue("@maPhongHoc", ph.MaPhongHoc);
            command.Parameters.AddWithValue("@tenPhongHoc", ph.TenPhongHoc);
            int result = command.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return "Sửa thông tin phòng học thành công";
            }
            else
            {
                return "Sửa thông tin phòng học không thành công";
            }
        }

        public static DataTable loadPH()
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            string querry = "SELECT * FROM PhongHoc";
            SqlCommand command = new SqlCommand(querry, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }


    }
}







