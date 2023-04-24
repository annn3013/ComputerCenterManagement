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
    public  class mhAccess :DbAccess 
    {
        public string themMH2(MonHoc mh)
        {
            if (mh.TenMonHoc == "")
            {
                return "vui long nhập tên môn học";
            }
            if (mh.MaMonHoc == "")
            {
                return "vui lòng nhập mã môn học";
            }
            if (mh.SoBuoi == 0)
            {
                return "vui lòng nhập đúng số buổi";
            }
            if (mh.HocPhi ==0)
            {
                return "vui lòng nhập đúng học phí";
            }
            if(mh.MaKhoaHoc == "")
            {
                return "vui lòng nhập mã khóa học";
            }
            return themMH(mh);
        }
        public string xoaMH2(string mamon)
        {
            return xoaMH(mamon);
        }
        public string suaMH2(string mamon,MonHoc mh)
        {
            return suaMH(mamon,mh);
        }
        public DataTable loadMH2() {
            return loadMH();
        }
        public  DataTable loadMHT2(string mamon)
        {
            return loadMHT(mamon);
        }
        public string autoMH2()
        {
            return autoMH();
        }
        public string checkMH2(string mamh)
        {
            return checkMH(mamh);
        }
    }
}
