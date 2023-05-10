using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTT
{
    public partial class BanSPDVtaicho : Form
    {
        public BanSPDVtaicho()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        
        void XemDS_SPDV()
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from DanhSachSanPhamVaDichVu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DSSPDV.DataSource = table;
        }

        /*SqlConnection connection2;
        SqlCommand command2;
        string str2 = "Data Source=.;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table2 = new DataTable();
        
        void XemDS_SPDVduocchon()
        {
            connection2 = new SqlConnection(str2);
            connection2.Open();
            command2 = connection2.CreateCommand();
            command2.CommandText = "select * from SPDVduocchon";
            adapter2.SelectCommand = command2;
            table2.Clear();
            adapter2.Fill(table2);
            DSSPDVduocchon.DataSource = table2;
        }
  
        */
        private void DSSPDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BanSPDVtaicho_Load(object sender, EventArgs e)
        {
            XemDS_SPDV();
           // XemDS_SPDVduocchon();
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LapPhieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa được phát triển ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form BanSanPhamDichVu = new BanSanPhamDichVu();
            this.Hide();
            BanSanPhamDichVu.ShowDialog();
            this.Close();
        }
    }
}
