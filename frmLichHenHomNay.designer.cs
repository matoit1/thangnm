namespace HaMy
{
    partial class frmLichHenHomNay
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
            this.grvLichHenHomNay = new System.Windows.Forms.DataGridView();
            this.PK_lCuocHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNgayGioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNgayGioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpktNgayGioBatDauDate = new System.Windows.Forms.DateTimePicker();
            this.dpktNgayGioBatDauTime = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichHenHomNay)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLichHenHomNay
            // 
            this.grvLichHenHomNay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLichHenHomNay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_lCuocHen,
            this.FK_iNguoiDung,
            this.FK_iDoiTac,
            this.sNoiDung,
            this.sDiaDiem,
            this.tNgayGioBatDau,
            this.tNgayGioKetThuc,
            this.iTrangThai});
            this.grvLichHenHomNay.Location = new System.Drawing.Point(34, 84);
            this.grvLichHenHomNay.Name = "grvLichHenHomNay";
            this.grvLichHenHomNay.Size = new System.Drawing.Size(847, 150);
            this.grvLichHenHomNay.TabIndex = 56;
            // 
            // PK_lCuocHen
            // 
            this.PK_lCuocHen.DataPropertyName = "PK_lCuocHen";
            this.PK_lCuocHen.HeaderText = "Cuộc hẹn";
            this.PK_lCuocHen.Name = "PK_lCuocHen";
            // 
            // FK_iNguoiDung
            // 
            this.FK_iNguoiDung.DataPropertyName = "FK_iNguoiDung";
            this.FK_iNguoiDung.HeaderText = "Người dùng";
            this.FK_iNguoiDung.Name = "FK_iNguoiDung";
            // 
            // FK_iDoiTac
            // 
            this.FK_iDoiTac.DataPropertyName = "FK_iDoiTac";
            this.FK_iDoiTac.HeaderText = "Đối tác";
            this.FK_iDoiTac.Name = "FK_iDoiTac";
            // 
            // sNoiDung
            // 
            this.sNoiDung.DataPropertyName = "sNoiDung";
            this.sNoiDung.HeaderText = "Nội dung";
            this.sNoiDung.Name = "sNoiDung";
            // 
            // sDiaDiem
            // 
            this.sDiaDiem.DataPropertyName = "sDiaDiem";
            this.sDiaDiem.HeaderText = "Địa điểm";
            this.sDiaDiem.Name = "sDiaDiem";
            // 
            // tNgayGioBatDau
            // 
            this.tNgayGioBatDau.DataPropertyName = "tNgayGioBatDau";
            this.tNgayGioBatDau.HeaderText = "Ngày giờ bắt đầu";
            this.tNgayGioBatDau.Name = "tNgayGioBatDau";
            // 
            // tNgayGioKetThuc
            // 
            this.tNgayGioKetThuc.DataPropertyName = "tNgayGioKetThuc";
            this.tNgayGioKetThuc.HeaderText = "Ngày giờ kết thúc";
            this.tNgayGioKetThuc.Name = "tNgayGioKetThuc";
            // 
            // iTrangThai
            // 
            this.iTrangThai.DataPropertyName = "iTrangThai";
            this.iTrangThai.HeaderText = "Trạng thái";
            this.iTrangThai.Name = "iTrangThai";
            // 
            // dpktNgayGioBatDauDate
            // 
            this.dpktNgayGioBatDauDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpktNgayGioBatDauDate.Location = new System.Drawing.Point(434, 22);
            this.dpktNgayGioBatDauDate.Name = "dpktNgayGioBatDauDate";
            this.dpktNgayGioBatDauDate.Size = new System.Drawing.Size(95, 20);
            this.dpktNgayGioBatDauDate.TabIndex = 57;
            // 
            // dpktNgayGioBatDauTime
            // 
            this.dpktNgayGioBatDauTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpktNgayGioBatDauTime.Location = new System.Drawing.Point(535, 22);
            this.dpktNgayGioBatDauTime.Name = "dpktNgayGioBatDauTime";
            this.dpktNgayGioBatDauTime.Size = new System.Drawing.Size(80, 20);
            this.dpktNgayGioBatDauTime.TabIndex = 58;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(621, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 59;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmLichHenHomNay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 262);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dpktNgayGioBatDauTime);
            this.Controls.Add(this.dpktNgayGioBatDauDate);
            this.Controls.Add(this.grvLichHenHomNay);
            this.Name = "frmLichHenHomNay";
            this.Text = "frmLichHenHomNay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLichHenHomNay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvLichHenHomNay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvLichHenHomNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_lCuocHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNgayGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNgayGioKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThai;
        private System.Windows.Forms.DateTimePicker dpktNgayGioBatDauDate;
        private System.Windows.Forms.DateTimePicker dpktNgayGioBatDauTime;
        private System.Windows.Forms.Button btnTimKiem;
    }
}