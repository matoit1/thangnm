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
            this.nhomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moiQuanHeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiTacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuocHenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhomToolStripMenuItem,
            this.nguoiDungToolStripMenuItem,
            this.moiQuanHeToolStripMenuItem,
            this.doiTacToolStripMenuItem,
            this.cuocHenToolStripMenuItem,
            this.thongTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhomToolStripMenuItem
            // 
            this.nhomToolStripMenuItem.Name = "nhomToolStripMenuItem";
            this.nhomToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.nhomToolStripMenuItem.Text = "Nhom";
            this.nhomToolStripMenuItem.Click += new System.EventHandler(this.nhomToolStripMenuItem_Click);
            // 
            // nguoiDungToolStripMenuItem
            // 
            this.nguoiDungToolStripMenuItem.Name = "nguoiDungToolStripMenuItem";
            this.nguoiDungToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.nguoiDungToolStripMenuItem.Text = "NguoiDung";
            // 
            // moiQuanHeToolStripMenuItem
            // 
            this.moiQuanHeToolStripMenuItem.Name = "moiQuanHeToolStripMenuItem";
            this.moiQuanHeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.moiQuanHeToolStripMenuItem.Text = "MoiQuanHe";
            // 
            // doiTacToolStripMenuItem
            // 
            this.doiTacToolStripMenuItem.Name = "doiTacToolStripMenuItem";
            this.doiTacToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.doiTacToolStripMenuItem.Text = "DoiTac";
            // 
            // cuocHenToolStripMenuItem
            // 
            this.cuocHenToolStripMenuItem.Name = "cuocHenToolStripMenuItem";
            this.cuocHenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cuocHenToolStripMenuItem.Text = "CuocHen";
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thongTinToolStripMenuItem.Text = "ThongTin";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moiQuanHeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiTacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuocHenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
    }
}