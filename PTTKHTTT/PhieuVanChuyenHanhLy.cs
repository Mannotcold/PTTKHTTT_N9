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
using static System.Net.Mime.MediaTypeNames;

namespace PTTKHTTT
{
    public partial class PhieuVanChuyenHanhLy : Form
    {
        public PhieuVanChuyenHanhLy()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM PHIEUVANCHUYENHANHLY";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Không được tìm kiếm khi chưa nhập tên khách hàng.");
            }
            else
            {
                connection = new SqlConnection(str);
                connection.Open();
                string TenKHDaiDien = textBox1.Text;
                command = connection.CreateCommand();
                command.CommandText = "SELECT PDP.MAPHIEUDP AS MAPHIEU, P.MAPHONG AS MAPHONG" +
                    "               FROM PHIEUDATPHONG PDP JOIN DANHSACHPHONG P ON PDP.MAPHIEUDP = P.MAPHIEUTHUEPHONG" +
                    "               WHERE PDP.TenKHDaiDien = '" + TenKHDaiDien + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void PhieuVanChuyenHanhLy_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Không được tạo phiếu khi chưa có đủ thông tin.");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thêm hay không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //MessageBox.Show(comboBox2.Text.ToString());
                    //string TinhTrang = comboBox2.Text.ToString();
                    connection = new SqlConnection(str);
                    connection.Open();
                    SqlCommand com = new SqlCommand();
                    //Lấy dữ liệu về từ kết quả câu lệnh trên
                    //ExecuteReader() dùng với select
                    //ExecuteNonquery(); với insert update delete
                    //com.ExecuteNonQuery();
                    //MAPHIEUDP();
                    com.CommandType = CommandType.Text;
                    com.CommandText = "insert into PHIEUVANCHUYENHANHLY(MAPHIEUVANCHUYENHANHLY, MAPHONG, SLHANHLY) VALUES ('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
                    com.Connection = connection;
                    //loaddata();
                    int kq = com.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm phiếu đặt phòng thành công. ");
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu đặt phòng thất bại! .");
                    }
                    loaddata();
                    connection.Close();
                }
            }
                
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form PhieuVanChuyenHanhLy = new LeTan();
            this.Hide();
            PhieuVanChuyenHanhLy.ShowDialog();
            this.Close();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa hay không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                connection = new SqlConnection(str);
                connection.Open();
                SqlCommand com = new SqlCommand();
                //Lấy dữ liệu về từ kết quả câu lệnh trên
                //ExecuteReader() dùng với select
                //ExecuteNonquery(); với inserrt update delete
                //com.ExecuteNonQuery();

                com.CommandType = CommandType.Text;
                com.CommandText = "delete from PHIEUVANCHUYENHANHLY where MAPHIEUVANCHUYENHANHLY = '" + textBox2.Text + "'";
                com.Connection = connection;
                //loaddata();
                int kq = com.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công! ");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! .");
                }
                loaddata();
            }
            else
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button5.Visible = false;
        }
    }
}
