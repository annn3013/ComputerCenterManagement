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
    public  class nvBLL
    {
        nvAccess a = new nvAccess();
        public string themNV2(NhanVien nv)
        {
            if (nv.MaNhanVien == "")
            {
                return "vui lòng nhập mã giáo viên";
            }
            if (nv.HoTen == "")
            {
                return "vui lòng nhập họ tên";
            }
            if (nv.DiaChi == "")
            {
                return "vui lòng nhập địa chỉ";
            }


            int soDienThoaiInt; // Biến để lưu giá trị số nguyên sau khi chuyển đổi

            if (!int.TryParse(nv.SoDienThoai, out soDienThoaiInt))
            {

                return "vui lòng nhập đúng đố điện thoại";
            }
            if (nv.ChucVu == "")
            {
                return "vui lòng nhập chức vụ";
            }
            return a.themNV2(nv);
        }
        public string xoaNV2(string manv)
        {
            return a.xoaNV2(manv);
        }
        public string suaNV2(NhanVien nv)
        {
            if (nv.MaNhanVien == "")
            {
                return "vui lòng nhập mã giáo viên";
            }
            if (nv.HoTen == "")
            {
                return "vui lòng nhập họ tên";
            }
            if (nv.DiaChi == "")
            {
                return "vui lòng nhập địa chỉ";
            }


            int soDienThoaiInt; // Biến để lưu giá trị số nguyên sau khi chuyển đổi

            if (!int.TryParse(nv.SoDienThoai, out soDienThoaiInt))
            {

                return "vui lòng nhập đúng đố điện thoại";
            }
            if (nv.ChucVu == "")
            {
                return "vui lòng nhập chức vụ";
            }
            return a.suaNV2(nv);
        }
        public DataTable loadNV2()
        {
            return a.loadNV2();
        }
        public string checkNV2(string manv)
        {
            return a.checkNV2(manv);
        }
        public DataTable loadNVT2(string manv)
        {
            return a.loadNVT2(manv);
        }
        public DataTable loadTNV2(string manv)
        {
            return a.loadTNV2(manv);
        }
        public string autoNV2()
        {
            return a.autoNV2();
        }
        public string checkNVT2(string manv)
        {
            return a.checkNVT2(manv);
        }
    }
}
