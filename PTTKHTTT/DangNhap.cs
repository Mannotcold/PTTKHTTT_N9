using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTTKHTTT
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        //Ket noi server sql
        SqlConnection connection;
        string str = "Data Source=.;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        //Nut dăng nhap
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Thuc hien ket noi server
            connection = new SqlConnection(str);
            try
            {
                //gan u,p la bang tb1 và tb2 tang tinh bao mat;
                string username = textBox1.Text;
                string password = textBox2.Text;

                //Mo ket noi server
                connection.Open();
                //viet sql
                string sql = "select * from NHANVIEN JOIN TAIKHOAN on MANV = Ten_TK Where MANV = '" + username + "' AND MATKHAU = '" + password + "' ";

                SqlCommand com = new SqlCommand(sql, connection);
                //Lấy dữ liệu về từ kết quả câu lệnh trên
                //ExecuteReader() dùng với select
                //ExecuteNonquery(); với inserrt update delete

                //doc du lieu tu duoi len
                SqlDataReader dta = com.ExecuteReader();

                if (dta.Read() == true)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                    //gan account_type băng voi vai tro
                    string account_type = dta.GetString(4);
                    if (account_type == "NVLETAN")
                    {
                        Form formLeTan = new LeTan(username);
                        this.Hide();
                        formLeTan.ShowDialog();
                        this.Close();
                    }
                    else if (account_type == "NVBELLMAN")
                    {
                        Form formbellman = new PhieuVanChuyenHanhLy();
                        this.Hide();
                        formbellman.ShowDialog();
                        this.Close();
                    }
                    else if (account_type == "NVBUONGPHONG")
                    {
                        MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (account_type == "NVKETOAN")
                    {
                        MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập không thành công");
                }
            }
            catch (Exception ex)
            {
                //Khong ket noi duoc voi server thi hien thong bao
                MessageBox.Show("lỗi kết nối");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {

                this.Close();

            }
            else
            {

            }
        }
    }
}
