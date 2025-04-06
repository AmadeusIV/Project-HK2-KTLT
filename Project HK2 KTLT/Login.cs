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
    public partial class Login: Form
    {
        public static string ConnetionString = @"Data Source=DESKTOP-FO6MTI0\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        public static string Loai_TaiKhoan = "-1";
        public Login()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                //Kiểm tra tài khoản đã nhập hay chưa
                if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                    return;
                }
                //Kiểm tra mật khẩu đã nhập hay chưa
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                    return;
                }

                //Kiểm tra thông tin tài khoản, so sánh với dữ liệu trong CSDL
                SqlConnection conn = new SqlConnection(ConnetionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string Ten_TaiKhoan = txtTaiKhoan.Text.Trim();
                string Mat_Khau = txtMatKhau.Text.Trim();
                string sql = "SELECT * FROM tblTaiKhoan WHERE Ten_TKhoan='" + Ten_TaiKhoan + "' AND Mat_Khau='" + Mat_Khau + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    //Đăng nhập thành công
                    Loai_TaiKhoan = ds.Tables[0].Rows[0]["Loai_TKhoan"].ToString();
                    Main1 main1 = new Main1(Loai_TaiKhoan);
                    main1.Show();
                    this.Hide();
                }
                else
                {
                    //Đăng nhập thất bại
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblError.Text = "Tên tài khoản hoặc mật khẩu không đúng";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Lỗi" + ex.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult o = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (o == DialogResult.Yes)
                this.Close();
        }
    }
}
