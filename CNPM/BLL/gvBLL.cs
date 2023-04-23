using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
     public class gvBLL
    {
        gvAccess a = new gvAccess();
        public string themGV2(GiaoVien gv)
        {
            if (gv.MaGiaoVien == "")
            {
                return "vui lòng nhập mã giáo viên";
            }
            if (gv.HoTen == "")
            {
                return "vui lòng nhập họ tên";
            }
            if (gv.DiaChi == "")
            {
                return "vui lòng nhập địa chỉ";
            }
            

            int soDienThoaiInt; // Biến để lưu giá trị số nguyên sau khi chuyển đổi

            if (!int.TryParse(gv.SoDienThoai, out soDienThoaiInt))
            {

                return "vui lòng nhập đúng đố điện thoại";
            }
            if (gv.ChucVu == "")
            {
                return "vui lòng nhập chức vụ";
            }

            return a.themGV2(gv);
        }
        public string suaGV2(GiaoVien gv)
        {
            if (gv.MaGiaoVien == "")
            {
                return "vui lòng nhập mã giáo viên";
            }
            if (gv.HoTen == "")
            {
                return "vui lòng nhập họ tên";
            }
            if (gv.DiaChi == "")
            {
                return "vui lòng nhập địa chỉ";
            }


            int soDienThoaiInt; // Biến để lưu giá trị số nguyên sau khi chuyển đổi

            if (!int.TryParse(gv.SoDienThoai, out soDienThoaiInt))
            {

                return "vui lòng nhập đúng đố điện thoại";
            }
            if (gv.ChucVu == "")
            {
                return "vui lòng nhập chức vụ";
            }
            return a.suaGV2(gv);
        }
        public string xoaGV2(string magv)
        {
            return a.xoaGV2(magv);
        }
        public string autoGV2()
        {
            return a.autoGV2();
        }
        public string checkGV2(string magv)
        {
            return a.checkGV2(magv);
        }
        public DataTable loadGV2()
        {
            return a.loadGV2();
        }
        public DataTable loadGVT2(string magv)
        {
            return a.loadGVT2(magv);
        }
        public DataTable loadGVC2(string maPhongHoc, int  caHoc, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return a.loadGVC2(maPhongHoc, caHoc, ngayBatDau, ngayKetThuc);
        }
        public DataTable loadTGV2(string hoten)
        {
            return a.loadTGV2(hoten);
        }
        public string checkGVT2(string hoten)
        {
            return a.checkGVT2(hoten);
        }
    }
}
