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
       

        private void DSSPDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BanSPDVtaicho_Load(object sender, EventArgs e)
        {
            XemDS_SPDV();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }
    }
}
