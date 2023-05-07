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
        private void Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.Text.ToString());
            string TinhTrang = comboBox2.Text.ToString();
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand com = new SqlCommand();
            //Lấy dữ liệu về từ kết quả câu lệnh trên
            //ExecuteReader() dùng với select
            //ExecuteNonquery(); với inserrt update delete
            //com.ExecuteNonQuery();
            MaPhieuDP = "30";
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
}
