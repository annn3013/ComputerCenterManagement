using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
     public class mhBLL
    {
        mhAccess a = new mhAccess();
        public string themMH2(MonHoc mh)
        {
            if (mh.TenMonHoc == "")
            {
                return "Vui lòng nhập tên môn học";
            }
            if (mh.MaMonHoc == "") {
                return "Vui lòng nhập mã môn học ";
            }
            if (mh.SoBuoi == 0)
            {
                return "Vui lòng nhập đúng số buổi học";
            }
            if (mh.HocPhi == 0)
            {
                return "vui lòng nhập đúng học phí";
            }
            if (mh.MaKhoaHoc == "")
            {
                return "Vui lòng nhập mã khóa học";
            }
            return a.themMH2(mh);
        }
        public string xoaMH2(string mamon)
        {
            return a.xoaMH2(mamon);
        }
        public string suaMH2(string mamon, MonHoc mh)
        {
            if (mh.TenMonHoc == "")
            {
                return "Vui lòng nhập tên môn học";
            }
            if (mh.MaMonHoc == "")
            {
                return "Vui lòng nhập mã môn học ";
            }
            if (mh.SoBuoi == 0)
            {
                return "Vui lòng nhập đúng số buổi học";
            }
            if (mh.HocPhi == 0)
            {
                return "vui lòng nhập đúng học phí";
            }
            if (mh.MaKhoaHoc == "")
            {
                return "Vui lòng nhập mã khóa học";
            }
            return a.suaMH2(mamon, mh);
        }
        public DataTable loadMH2()
        {
            return a.loadMH2();
        }
        public DataTable loadMHT2(string mamon)
        {
            return a.loadMHT2(mamon);
        }
        public string autoMH2()
        {
            return a.autoMH2();
        }
        public string checkMH2(string mamh)
        {
            if (mamh == "")
            {
                return "Vui lòng nhập mã môn học";
            }
            return a.checkMH2(mamh);
        }

    }
}
