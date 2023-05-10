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
    public partial class DanhSachPhong : Form
    {
        public DanhSachPhong()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-O8J01RU8;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void LayKM()
        {
            connection = new SqlConnection(str);
            connection.Open();

            //Tạo ma phieu dat phong
            string sql = "select TenKhuyenMai  from DanhSachKhuyenMai KM join DanhSachPhong DSP on KM.MAPHONG = DSP.MAPHONG WHERE DSP.MaPhong = '" + text1.Text + "'";

            SqlCommand com = new SqlCommand(sql, connection);
            //Lấy dữ liệu về từ kết quả câu lệnh trên
            //ExecuteReader() dùng với select
            //ExecuteNonquery(); với inserrt update delete
            SqlDataReader dta = com.ExecuteReader();
            while (dta.Read())
            {
                //MessageBox.Show(dta.GetString(0));
                text8.Text = dta.GetString(0);
                //MaPhieuDP = "PH00" + madp.ToString();

            }
        }

        void XemDanhSachPhong()
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from DanhSachPhong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DSP.DataSource = table;
            //hhhh
        }
        private void DanhSachPhong_Load(object sender, EventArgs e)
        {
            XemDanhSachPhong();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DSP.CurrentRow.Index;
            text1.Text = DSP.Rows[i].Cells[0].Value.ToString();
            text2.Text = DSP.Rows[i].Cells[1].Value.ToString();
            text4.Text = DSP.Rows[i].Cells[3].Value.ToString();
            text3.Text = DSP.Rows[i].Cells[2].Value.ToString();
            text5.Text = DSP.Rows[i].Cells[4].Value.ToString();
            text6.Text = DSP.Rows[i].Cells[5].Value.ToString();
            text7.Text = DSP.Rows[i].Cells[7].Value.ToString();
            text9.Text = DSP.Rows[i].Cells[6].Value.ToString();
            LayKM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ textbox
            string TinhTrangTrong = text3.Text;
            string TinhTrangVeSinh = text5.Text;
            string TinhTrangHuHong = text6.Text;
            string MoTa = text7.Text;
            string MaPhieuThuePhong = text9.Text;


            // Cập nhật dữ liệu vào cơ sở dữ liệu (nếu cần)

            // Cập nhật dữ liệu lên trên gridview
            int rowIndex = DSP.CurrentCell.RowIndex;
            DSP.Rows[rowIndex].Cells[3].Value = TinhTrangTrong;
            DSP.Rows[rowIndex].Cells[4].Value = TinhTrangVeSinh;
            DSP.Rows[rowIndex].Cells[5].Value = TinhTrangHuHong;
            DSP.Rows[rowIndex].Cells[6].Value = MoTa;
            DSP.Rows[rowIndex].Cells[7].Value = MaPhieuThuePhong;
            XemDanhSachPhong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form DanhSachPhong = new LeTan();
            this.Hide();
            DanhSachPhong.ShowDialog();
            this.Close();
        }
    }
}
