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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-O8J01RU8;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                connection.Open();
                string sql = "select * from NHANVIEN JOIN TAIKHOAN on MANV = Ten_TK Where MANV = '" + username + "' AND MATKHAU = '" + password + "' ";

                SqlCommand com = new SqlCommand(sql, connection);
                //Lấy dữ liệu về từ kết quả câu lệnh trên
                //ExecuteReader() dùng với select
                //ExecuteNonquery(); với inserrt update delete
                SqlDataReader dta = com.ExecuteReader();

                if (dta.Read() == true)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                    string account_type = dta.GetString(2);
                    if (account_type == "Le Tan")
                    {
                        Form formLeTan = new LeTan(username);
                        this.Hide();
                        formLeTan.ShowDialog();
                        this.Close();
                    }
                    else if (account_type == "Bellman")
                    {
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
            }


        }
    }
}
