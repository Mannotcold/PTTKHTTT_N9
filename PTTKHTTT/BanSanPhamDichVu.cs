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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


        }
        void check_btnTour()
        {
            string loaiKH;

            loaiKH = TK_PhieuDB.Rows[0].Cells["LOAIKH"].Value.ToString();

            if (loaiKH.ToUpper() == "DOAN")
            {

                Tour.Visible = false; // ẩn button Tour
            }
            else
            {
                Tour.Visible = true; // hiển thị button Tour

            }
        }

        private void TK_PDP_Click(object sender, EventArgs e)
        {

            if (MaPhieu.Text == "")
            {
                // MessageBox.Show("Mã phiếu không hợp lệ hoặc không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XemDS_PHIEUDATPHONG();
                Tour.Visible = true;
            }
            else
            {

                TK_PhieuDatPhong();
                check_btnTour();
            }


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void TroLai_LeTan_Click_1(object sender, EventArgs e)
        {
            Form LeTan = new LeTan();
            this.Hide();
            LeTan.ShowDialog();
            this.Close();
        }
    }
}
