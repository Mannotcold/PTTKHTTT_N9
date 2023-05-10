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
    public partial class BanSanPhamDichVu : Form
    {
        public BanSanPhamDichVu()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-O8J01RU8;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        

        void XemDS_PHIEUDATPHONG()
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUDATPHONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            TK_PhieuDB.DataSource = table;
        }
        void TK_PhieuDatPhong()
        {

            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUDATPHONG where MaPhieuDP = '" + MaPhieu.Text.ToUpper() + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            TK_PhieuDB.DataSource = table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string valuestr = TK_PhieuDB.Rows[e.RowIndex].Cells["LoaiKH"].Value.ToString();

            // So sánh giá trị float với một giá trị nào đó
            if (valuestr.ToUpper() == "DOAN")
            {
                Tour.Enabled = false;

                // Ẩn button
                Tour.Visible = false;
            }
            else
            {
                // Cho phép click vào button
                Tour.Enabled = true;

                // Hiển thị button
                Tour.Visible = true;
                //MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void TK_PDP_Click(object sender, EventArgs e)
        {
            TK_PhieuDatPhong();
            if(MaPhieu.Text=="")
            {
               // MessageBox.Show("Mã phiếu không hợp lệ hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XemDS_PHIEUDATPHONG();
            }


            // Lấy chuỗi text nhập vào từ TextBox
            // string searchText = MaPhieu.Text;

            //// Duyệt qua từng dòng của DataGridView
            //for (int i = 0; i < TK_PhieuDB.Rows.Count; i++)
            //{
            //    // Lấy giá trị của cột "Tên sản phẩm" tại dòng đang xử lý
            //    string maphieu = TK_PhieuDB.Rows[i].Cells["MaPhieuDP"].ToString().ToUpper();

            //    // So sánh chuỗi text nhập vào với giá trị của cột "Tên sản phẩm"
            //    if (MaPhieu.Text.ToUpper() == maphieu)
            //    {
            //        TK_PhieuDatPhong();
            //        return;
            //    }
            //}

            //// Hiển thị thông báo nếu không tìm thấy dữ liệu trùng khớp
            //MessageBox.Show("Mã phiếu không hợp lệ hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //XemDS_PHIEUDATPHONG();
        }



        private void SPDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Tour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BanSanPhamDichVu_Load(object sender, EventArgs e)
        {
            XemDS_PHIEUDATPHONG();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // this.Hide();

    }
}
