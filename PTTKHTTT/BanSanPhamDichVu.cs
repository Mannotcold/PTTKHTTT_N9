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

        private void TK_PDP_Click(object sender, EventArgs e)
        {
            TK_PhieuDatPhong();
        }
    }
}
