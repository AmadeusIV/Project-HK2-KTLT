using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HK2_KTLT
{
    public partial class ChucVu: Form
    {
        public static string ConnetionString = @"Data Source=DESKTOP-FO6MTI0\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public static string Loai_TaiKhoan = "-1";

        public ChucVu()
        {
            InitializeComponent();
            SetControls("Reset");
        }


        public void SetControls(string state)
        {
            switch (state) { 
            case "Reset":
                    btnGhiCV.Enabled = false;
                    btnHuyCV.Enabled = false;
                    btnSuaCV.Enabled = true;
                    btnThemCV.Enabled = false;
                    btnXoaCV.Enabled = false;

                    lblErrorCV.Text = "";
                    lblThanhCong.Text = "";
                    break;
            }
        }

        public void GetData()
        {
            try
            {
                //Kiểm tra thông tin tài khoản, so sánh với dữ liệu trong CSDL
                SqlConnection conn = new SqlConnection(ConnetionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "SELECT * FROM tblChucVu ORDER BY Ten_ChucVu";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dtgChucVu.DataSource = ds.Tables[0];
                    lblTongSo.Text = "Tổng số: " + (dtgChucVu.Rows.Count -1) + " bản ghi";
                }
                else
                {
                    lblTongSo.Text = "Tổng số: 0 bản ghi";
                }
            }
            catch (Exception ex)
            {
                lblErrorCV.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }
        private void ChucVu_Load(object sender, EventArgs e)
        {
            dtgChucVu.AutoGenerateColumns = true;
            GetData();
        }

        private void dtgChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dtgChucVu.Rows[rowIndex];

            txtMaCV.Text = selectedRow.Cells["Ma_ChucVu"].Value.ToString();
            txtTenCV.Text = selectedRow.Cells["Ten_ChucVu"].Value.ToString();
            txtGhiChu.Text = selectedRow.Cells["Ghi_Chu"].Value.ToString();
            txtID.Text = selectedRow.Cells["ID_ChucVu"].Value.ToString();
        }
    }
}
