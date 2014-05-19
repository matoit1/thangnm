namespace HaMy
{
    partial class HomeSI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiNhom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoiQuanHe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoiTac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCuocHen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhom,
            this.tsmiNguoiDung,
            this.tsmiMoiQuanHe,
            this.tsmiDoiTac,
            this.tsmiCuocHen,
            this.tsmiThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiNhom
            // 
            this.tsmiNhom.Name = "tsmiNhom";
            this.tsmiNhom.Size = new System.Drawing.Size(53, 20);
            this.tsmiNhom.Text = "Nhóm";
            this.tsmiNhom.Click += new System.EventHandler(this.tsmiNhom_Click);
            // 
            // tsmiNguoiDung
            // 
            this.tsmiNguoiDung.Name = "tsmiNguoiDung";
            this.tsmiNguoiDung.Size = new System.Drawing.Size(83, 20);
            this.tsmiNguoiDung.Text = "Người dùng";
            this.tsmiNguoiDung.Click += new System.EventHandler(this.tsmiNguoiDung_Click);
            // 
            // tsmiMoiQuanHe
            // 
            this.tsmiMoiQuanHe.Name = "tsmiMoiQuanHe";
            this.tsmiMoiQuanHe.Size = new System.Drawing.Size(86, 20);
            this.tsmiMoiQuanHe.Text = "Mối quan hệ";
            this.tsmiMoiQuanHe.Click += new System.EventHandler(this.tsmiMoiQuanHe_Click);
            // 
            // tsmiDoiTac
            // 
            this.tsmiDoiTac.Name = "tsmiDoiTac";
            this.tsmiDoiTac.Size = new System.Drawing.Size(56, 20);
            this.tsmiDoiTac.Text = "Đối tác";
            this.tsmiDoiTac.Click += new System.EventHandler(this.tsmiDoiTac_Click);
            // 
            // tsmiCuocHen
            // 
            this.tsmiCuocHen.Name = "tsmiCuocHen";
            this.tsmiCuocHen.Size = new System.Drawing.Size(70, 20);
            this.tsmiCuocHen.Text = "Cuộc hẹn";
            this.tsmiCuocHen.Click += new System.EventHandler(this.tsmiCuocHen_Click);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(50, 20);
            this.tsmiThoat.Text = "Thoát";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // HomeSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 459);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeSI";
            this.Text = "Phần mềm quản lý lịch hẹn - Nguyễn Thị Hà My";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhom;
        private System.Windows.Forms.ToolStripMenuItem tsmiNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoiQuanHe;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoiTac;
        private System.Windows.Forms.ToolStripMenuItem tsmiCuocHen;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
    }
}