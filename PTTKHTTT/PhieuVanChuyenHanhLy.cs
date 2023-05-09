using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        string str = "Data Source=DESKTOP-GJA4FCO;Initial Catalog=PTTKHTTT;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        //DataTable table = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            string TenKHDaiDien = textBox1.Text;
            command = connection.CreateCommand();
            command.CommandText = "SELECT PDP.MAPHIEUDP AS MAPHIEU, P.MAPHONG " +
                "                   FROM PHIEUDATPHONG PDP, PHONG P " +
                "                   WHERE TenKHDaiDien = '" + TenKHDaiDien + "' AND PDP.MAPHIEUDP = P.MAPHONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PhieuVanChuyenHanhLy_Load(object sender, EventArgs e)
        {

        }
    }
}
