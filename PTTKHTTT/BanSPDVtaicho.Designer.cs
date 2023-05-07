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
            this.btnXem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DSSPDVduocchon = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.Button();
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
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(0, 0);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Xoa);
            this.panel2.Controls.Add(this.DSSPDVduocchon);
            this.panel2.Location = new System.Drawing.Point(32, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 277);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phiếu đăng kí sản phẩm và dịch vụ";
            // 
            // DSSPDVduocchon
            // 
            this.DSSPDVduocchon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSSPDVduocchon.Location = new System.Drawing.Point(16, 20);
            this.DSSPDVduocchon.Name = "DSSPDVduocchon";
            this.DSSPDVduocchon.RowHeadersWidth = 51;
            this.DSSPDVduocchon.RowTemplate.Height = 24;
            this.DSSPDVduocchon.Size = new System.Drawing.Size(702, 183);
            this.DSSPDVduocchon.TabIndex = 0;
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(337, 209);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 34);
            this.Xoa.TabIndex = 1;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // BanSPDVtaicho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 712);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BanSPDVtaicho";
            this.Text = "BanSPDVtaicho";
            this.Load += new System.EventHandler(this.BanSPDVtaicho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSSPDV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DSSPDVduocchon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Xoa;
    }
}