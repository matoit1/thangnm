namespace HaMy.Report
{
    partial class frmBaoCao_CuocHen
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dpktNgayGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dpktNgayGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crvCuocHen = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(555, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dpktNgayGioBatDau
            // 
            this.dpktNgayGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpktNgayGioBatDau.Location = new System.Drawing.Point(264, 34);
            this.dpktNgayGioBatDau.Name = "dpktNgayGioBatDau";
            this.dpktNgayGioBatDau.Size = new System.Drawing.Size(97, 20);
            this.dpktNgayGioBatDau.TabIndex = 1;
            // 
            // dpktNgayGioKetThuc
            // 
            this.dpktNgayGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpktNgayGioKetThuc.Location = new System.Drawing.Point(425, 32);
            this.dpktNgayGioKetThuc.Name = "dpktNgayGioKetThuc";
            this.dpktNgayGioKetThuc.Size = new System.Drawing.Size(95, 20);
            this.dpktNgayGioKetThuc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "đến ngày";
            // 
            // crvCuocHen
            // 
            this.crvCuocHen.ActiveViewIndex = -1;
            this.crvCuocHen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCuocHen.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCuocHen.Location = new System.Drawing.Point(12, 91);
            this.crvCuocHen.Name = "crvCuocHen";
            this.crvCuocHen.Size = new System.Drawing.Size(1236, 469);
            this.crvCuocHen.TabIndex = 5;
            // 
            // frmBaoCao_CuocHen
            // 
            this.ClientSize = new System.Drawing.Size(1260, 585);
            this.Controls.Add(this.crvCuocHen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpktNgayGioKetThuc);
            this.Controls.Add(this.dpktNgayGioBatDau);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmBaoCao_CuocHen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCao_CuocHen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CuocHen CuocHen1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dpktNgayGioBatDau;
        private System.Windows.Forms.DateTimePicker dpktNgayGioKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCuocHen;
    }
}