using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BLL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class INDIEM : Form
    {
        private string mahv;
        public INDIEM()
        {
            InitializeComponent();
        }
        public INDIEM(string a)
        {
            InitializeComponent();
            this.mahv = a;
        }

        private void INDIEM_Load(object sender, EventArgs e)
        {
            diemBLL diemBLL = new diemBLL();
            // Tạo đối tượng DataSet


            // Tạo đối tượng DataTable từ nguồn dữ liệu (chẳng hạn từ một phương thức hoặc đối tượng BLL)
            SqlDataAdapter adapter = diemBLL.hienDiemTA2(this.mahv);
            DataSet ds = new DataSet("DataSet1");
            adapter.Fill(ds, "DIEMHV");

            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.REPORT.DIEMRP.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["DIEMHV"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
