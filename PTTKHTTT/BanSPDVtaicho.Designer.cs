namespace PTTKHTTT
{
    partial class BanSPDVtaicho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DSSPDV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Xoa = new System.Windows.Forms.Button();
            this.DSSPDVduocchon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LapPhieu = new System.Windows.Forms.Button();
            this.PDichVuTamThoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MaPhieu = new System.Windows.Forms.TextBox();
            this.TenKH = new System.Windows.Forms.TextBox();
            this.MaKH = new System.Windows.Forms.TextBox();
            this.CacYeuCauDacBiet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhiDichVuTamThoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DSSPDV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSSPDVduocchon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁN SẢN PHẨM VÀ DỊCH VỤ TẠI CHỖ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách sản phẩm và dịch vụ";
            // 
            // DSSPDV
            // 
            this.DSSPDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSSPDV.Location = new System.Drawing.Point(16, 17);
            this.DSSPDV.Name = "DSSPDV";
            this.DSSPDV.RowHeadersWidth = 51;
            this.DSSPDV.RowTemplate.Height = 24;
            this.DSSPDV.Size = new System.Drawing.Size(702, 164);
            this.DSSPDV.TabIndex = 2;
            this.DSSPDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSSPDV_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DSSPDV);
            this.panel1.Location = new System.Drawing.Point(32, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 230);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.PhiDichVuTamThoi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CacYeuCauDacBiet);
            this.panel2.Controls.Add(this.MaKH);
            this.panel2.Controls.Add(this.TenKH);
            this.panel2.Controls.Add(this.MaPhieu);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PDichVuTamThoi);
            this.panel2.Controls.Add(this.LapPhieu);
            this.panel2.Controls.Add(this.Xoa);
            this.panel2.Controls.Add(this.DSSPDVduocchon);
            this.panel2.Location = new System.Drawing.Point(32, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 450);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(524, 224);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 34);
            this.Xoa.TabIndex = 1;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // DSSPDVduocchon
            // 
            this.DSSPDVduocchon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSSPDVduocchon.Location = new System.Drawing.Point(38, 138);
            this.DSSPDVduocchon.Name = "DSSPDVduocchon";
            this.DSSPDVduocchon.RowHeadersWidth = 51;
            this.DSSPDVduocchon.RowTemplate.Height = 24;
            this.DSSPDVduocchon.Size = new System.Drawing.Size(461, 183);
            this.DSSPDVduocchon.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Liên phiếu đăng kí sản phẩm và dịch vụ";
            // 
            // LapPhieu
            // 
            this.LapPhieu.Location = new System.Drawing.Point(524, 276);
            this.LapPhieu.Name = "LapPhieu";
            this.LapPhieu.Size = new System.Drawing.Size(95, 36);
            this.LapPhieu.TabIndex = 2;
            this.LapPhieu.Text = "Lập phiếu";
            this.LapPhieu.UseVisualStyleBackColor = true;
            this.LapPhieu.Click += new System.EventHandler(this.LapPhieu_Click);
            // 
            // PDichVuTamThoi
            // 
            this.PDichVuTamThoi.AutoSize = true;
            this.PDichVuTamThoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDichVuTamThoi.Location = new System.Drawing.Point(520, 138);
            this.PDichVuTamThoi.Name = "PDichVuTamThoi";
            this.PDichVuTamThoi.Size = new System.Drawing.Size(156, 20);
            this.PDichVuTamThoi.TabIndex = 3;
            this.PDichVuTamThoi.Text = "Phí dịch vụ tạm thời";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã phiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Các yêu cầu đặc biệt";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Trở Lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaPhieu
            // 
            this.MaPhieu.Location = new System.Drawing.Point(163, 19);
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Size = new System.Drawing.Size(100, 22);
            this.MaPhieu.TabIndex = 8;
            // 
            // TenKH
            // 
            this.TenKH.Location = new System.Drawing.Point(436, 22);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(100, 22);
            this.TenKH.TabIndex = 9;
            // 
            // MaKH
            // 
            this.MaKH.Location = new System.Drawing.Point(163, 56);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(100, 22);
            this.MaKH.TabIndex = 10;
            // 
            // CacYeuCauDacBiet
            // 
            this.CacYeuCauDacBiet.Location = new System.Drawing.Point(436, 59);
            this.CacYeuCauDacBiet.Name = "CacYeuCauDacBiet";
            this.CacYeuCauDacBiet.Size = new System.Drawing.Size(100, 22);
            this.CacYeuCauDacBiet.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Danh sách sản phẩm dịch vụ được chọn";
            // 
            // PhiDichVuTamThoi
            // 
            this.PhiDichVuTamThoi.Location = new System.Drawing.Point(524, 176);
            this.PhiDichVuTamThoi.Name = "PhiDichVuTamThoi";
            this.PhiDichVuTamThoi.Size = new System.Drawing.Size(100, 22);
            this.PhiDichVuTamThoi.TabIndex = 13;
            // 
            // BanSPDVtaicho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BanSPDVtaicho";
            this.Text = "BanSPDVtaicho";
            this.Load += new System.EventHandler(this.BanSPDVtaicho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSSPDV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSSPDVduocchon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DSSPDV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DSSPDVduocchon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label PDichVuTamThoi;
        private System.Windows.Forms.Button LapPhieu;
        private System.Windows.Forms.TextBox PhiDichVuTamThoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CacYeuCauDacBiet;
        private System.Windows.Forms.TextBox MaKH;
        private System.Windows.Forms.TextBox TenKH;
        private System.Windows.Forms.TextBox MaPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}