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
    public partial class PhieuDatPhong : Form
    {
        public PhieuDatPhong()
        {
            InitializeComponent();
        }


        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-O8J01RU8;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUDATPHONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //hhhh
            connection.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void LamMoi_Click(object sender, EventArgs e)
        {
            text2.Text = null;
            text4.Text = null;
            text6.Text = null;
            text8.Text = null;
            text3.Text = null;
            textBox6.Text = null;
            text7.Text = null;
            text5.Text = null;
            text1.Text = null;
            richTextBox1.Text = null;
        }
        string MaPhieuDP;


        private void MAPHIEUDP()
        {
            connection = new SqlConnection(str);
            connection.Open();

            //Tạo ma phieu dat phong
            string sql = "select COUNT(*) from PHIEUDATPHONG";

            SqlCommand com = new SqlCommand(sql, connection);
            //Lấy dữ liệu về từ kết quả câu lệnh trên
            //ExecuteReader() dùng với select
            //ExecuteNonquery(); với inserrt update delete
            SqlDataReader dta = com.ExecuteReader();
            while (dta.Read())
            {
                int madp = dta.GetInt32(0) + 2;
                MaPhieuDP = "PH00" + madp.ToString();
                
            }
        }


        private void Them_Click(object sender, EventArgs e)
        {
            MAPHIEUDP();
            DialogResult rs = MessageBox.Show("Bạn có muốn thêm hay không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                connection = new SqlConnection(str);
                connection.Open();
                SqlCommand com = new SqlCommand();
                //Lấy dữ liệu về từ kết quả câu lệnh trên
                //ExecuteReader() dùng với select
                //ExecuteNonquery(); với inserrt update delete
                //com.ExecuteNonQuery();
                //MAPHIEUDP();
                com.CommandType = CommandType.Text;
                com.CommandText = "insert into  PHIEUDATPHONG (MaPhieuDP, TinhTrangDuyet,NgayLap,NgayDen,NgayDi,SoDemLuuTru, CacYeuCauDacBiet, LoaiKH) VALUES ('" + MaPhieuDP + "','" + comboBox2.Text.ToString() + "','" + dateTimePicker3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + text8.Text + "','" + richTextBox1.Text + "','" + comboBox2.Text + "')";
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

            }
            else
            {

            }

        }


        private void PhieuDatPhong_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dataGridView1.CurrentRow.Index;
            text1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            text2.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            text3.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            text4.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            text5.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            text8.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dateTimePicker3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                loaddata();
            }
            else
            {
                connection = new SqlConnection(str);
                connection.Open();
                string TenKHDaiDien = textBox6.Text;
                command = connection.CreateCommand();
                command.CommandText = "select * from PHIEUDATPHONG WHERE TenKHDaiDien = '" + TenKHDaiDien + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật hay không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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

                com.CommandText = "Update PHIEUDATPHONG set TinhTrangDuyet = '" + comboBox2.Text.ToString() + "',NgayLap = '" + dateTimePicker3.Text + "',NgayDen = '" + dateTimePicker1.Text + "', NgayDi = '" + dateTimePicker2.Text + "' ,SoDemLuuTru = '" + text8.Text + "', CacYeuCauDacBiet = '" + richTextBox1.Text + "', LoaiKH = '" + comboBox1.Text + "' where MAPHIEUDP = '" + text1.Text + "'";
                com.Connection = connection;
                //loaddata();
                int kq = com.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật phiếu đặt phòng thành công. ");
                }
                else
                {
                    MessageBox.Show("Cập nhật phiếu đặt phòng thất bại! .");
                }
                loaddata();

            }
            else
            {

            }

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa hay không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                connection = new SqlConnection(str);
                connection.Open();
                SqlCommand com = new SqlCommand();
                string now = DateTime.Now.ToString();
                //Lấy dữ liệu về từ kết quả câu lệnh trên
                //ExecuteReader() dùng với select
                //ExecuteNonquery(); với inserrt update delete
                //com.ExecuteNonQuery();

                com.CommandType = CommandType.Text;
                com.CommandText = "delete from PHIEUDATPHONG where MAPHIEUDP = '" + text1.Text + "'";
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

        private void button9_Click(object sender, EventArgs e)
        {
            Form formLeTan = new LeTan();
            this.Hide();
            formLeTan.ShowDialog();
            this.Close();
        }
    }
}
