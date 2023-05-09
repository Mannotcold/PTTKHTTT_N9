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
        string str = "Data Source=.;Initial Catalog=PTTKHTTT;Integrated Security=True";
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
        }

        private void SPDV_Click(object sender, EventArgs e)
        {
            Form BanSPDVtaicho = new BanSPDVtaicho();
            //this.Hide();
            BanSPDVtaicho.ShowDialog();
            this.Close();
        }

        private void Tour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BanSanPhamDichVu_Load(object sender, EventArgs e)
        {
            XemDS_PHIEUDATPHONG();
        }

        // this.Hide();

    }
}
