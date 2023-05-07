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
    }
}
