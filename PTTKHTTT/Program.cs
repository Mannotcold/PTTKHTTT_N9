﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHTTT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Application.Run(new DangNhap());

            //Application.Run(new DangNhap());
            //Application.Run(new BanSanPhamDichVu());
            //Application.Run(new BanSPDVtaicho());

            Application.Run(new DangNhap());
            //Application.Run(new DanhSachPhong());
            //Application.Run(new BanSanPhamDichVu());
            //Application.Run(new BanSPDVtaicho());

            //Application.Run(new DangNhap());
            //Application.Run(new BanSanPhamDichVu());
            //Application.Run(new BanSPDVtaicho());
            //Application.Run(new LeTan());

            //Application.Run(new PhieuVanChuyenHanhLy());



        }
        //trach vua sua
    }
}
