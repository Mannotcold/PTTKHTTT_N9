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
    public partial class LeTan : Form
    {
        public LeTan()
        {
            InitializeComponent();
        }
        private string TaiKhoan;
        
        public LeTan(string TK)
        {
            InitializeComponent();
            this.TaiKhoan = TK;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form formDatPhong = new PhieuDatPhong();
            this.Hide();
            formDatPhong.ShowDialog();
            this.Close();
        }

        private void BanSPDVgui_Click(object sender, EventArgs e)
        {
            Form BanSanPhamDichVu = new BanSanPhamDichVu();
            this.Hide();
            BanSanPhamDichVu.ShowDialog();
            this.Close();
            
        }

        private void LeTan_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {

                this.Close();

            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formDSP = new DanhSachPhong();
            this.Hide();
            formDSP.ShowDialog();
            this.Close();
        }
    }
}
