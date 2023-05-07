namespace PTTKHTTT
{
    partial class BanSanPhamDichVu
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
            this.SOPHONG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TK_PDP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MaPhieu = new System.Windows.Forms.TextBox();
            this.TK_PhieuDB = new System.Windows.Forms.DataGridView();
            this.TENKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SPDV = new System.Windows.Forms.Button();
            this.Tour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TK_PhieuDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHIẾU ĐẶT PHÒNG";
            // 
            // SOPHONG
            // 
            this.SOPHONG.Location = new System.Drawing.Point(356, 189);
            this.SOPHONG.Name = "SOPHONG";
            this.SOPHONG.Size = new System.Drawing.Size(100, 22);
            this.SOPHONG.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số phòng";
            // 
            // TK_PDP
            // 
            this.TK_PDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK_PDP.Location = new System.Drawing.Point(508, 221);
            this.TK_PDP.Name = "TK_PDP";
            this.TK_PDP.Size = new System.Drawing.Size(127, 29);
            this.TK_PDP.TabIndex = 5;
            this.TK_PDP.Text = "Tìm kiếm";
            this.TK_PDP.UseVisualStyleBackColor = true;
            this.TK_PDP.Click += new System.EventHandler(this.TK_PDP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã phiếu";
            // 
            // MaPhieu
            // 
            this.MaPhieu.Location = new System.Drawing.Point(356, 228);
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Size = new System.Drawing.Size(100, 22);
            this.MaPhieu.TabIndex = 7;
            // 
            // TK_PhieuDB
            // 
            this.TK_PhieuDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TK_PhieuDB.Location = new System.Drawing.Point(49, 332);
            this.TK_PhieuDB.Name = "TK_PhieuDB";
            this.TK_PhieuDB.RowHeadersWidth = 51;
            this.TK_PhieuDB.RowTemplate.Height = 24;
            this.TK_PhieuDB.Size = new System.Drawing.Size(698, 176);
            this.TK_PhieuDB.TabIndex = 8;
            this.TK_PhieuDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TENKH
            // 
            this.TENKH.Location = new System.Drawing.Point(356, 150);
            this.TENKH.Name = "TENKH";
            this.TENKH.Size = new System.Drawing.Size(100, 22);
            this.TENKH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "do chỗ phiếu đặt phong ko có số phòng nên chắc tìm kiếm bằng mã phiếu";
            // 
            // SPDV
            // 
            this.SPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPDV.Location = new System.Drawing.Point(49, 514);
            this.SPDV.Name = "SPDV";
            this.SPDV.Size = new System.Drawing.Size(336, 49);
            this.SPDV.TabIndex = 10;
            this.SPDV.Text = "Bán sản phẩm và dịch vụ tại chỗ";
            this.SPDV.UseVisualStyleBackColor = true;
            // 
            // Tour
            // 
            this.Tour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tour.Location = new System.Drawing.Point(415, 517);
            this.Tour.Name = "Tour";
            this.Tour.Size = new System.Drawing.Size(332, 46);
            this.Tour.TabIndex = 11;
            this.Tour.Text = "Bán Tour du lịch tại chỗ";
            this.Tour.UseVisualStyleBackColor = true;
            // 
            // BanSanPhamDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.Tour);
            this.Controls.Add(this.SPDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TK_PhieuDB);
            this.Controls.Add(this.MaPhieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TK_PDP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SOPHONG);
            this.Controls.Add(this.TENKH);
            this.Controls.Add(this.label1);
            this.Name = "BanSanPhamDichVu";
            this.Text = "BanSanPhamDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.TK_PhieuDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SOPHONG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TK_PDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaPhieu;
        private System.Windows.Forms.DataGridView TK_PhieuDB;
        private System.Windows.Forms.TextBox TENKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SPDV;
        private System.Windows.Forms.Button Tour;
    }
}