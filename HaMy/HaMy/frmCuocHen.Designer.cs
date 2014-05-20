namespace HaMy
{
    partial class frmCuocHen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFK_iNguoiDung = new System.Windows.Forms.ComboBox();
            this.cboFK_iDoiTac = new System.Windows.Forms.ComboBox();
            this.cboiTrangThai = new System.Windows.Forms.ComboBox();
            this.txtPK_lCuocHen = new System.Windows.Forms.TextBox();
            this.txtsDiaDiem = new System.Windows.Forms.TextBox();
            this.txtsNoiDung = new System.Windows.Forms.TextBox();
            this.lblPK_lCuocHen = new System.Windows.Forms.Label();
            this.lblFK_iNguoiDung = new System.Windows.Forms.Label();
            this.lblFK_iDoiTac = new System.Windows.Forms.Label();
            this.lblsNoiDung = new System.Windows.Forms.Label();
            this.lblsDiaDiem = new System.Windows.Forms.Label();
            this.lbltNgayGioBatDau = new System.Windows.Forms.Label();
            this.lbltNgayGioKetThuc = new System.Windows.Forms.Label();
            this.lbliTrangThai = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grvCuocHen = new System.Windows.Forms.DataGridView();
            this.PK_lCuocHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNgayGioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNgayGioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMsg = new System.Windows.Forms.Label();
            this.dpktNgayGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dpktNgayGioKetThuc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grvCuocHen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuộc hẹn";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(261, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 24);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Thông tin Cuộc hẹn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Đối tác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nội dung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Địa điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ngày giờ bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ngày giờ kết thúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Trạng thái";
            // 
            // cboFK_iNguoiDung
            // 
            this.cboFK_iNguoiDung.FormattingEnabled = true;
            this.cboFK_iNguoiDung.Location = new System.Drawing.Point(213, 131);
            this.cboFK_iNguoiDung.Name = "cboFK_iNguoiDung";
            this.cboFK_iNguoiDung.Size = new System.Drawing.Size(172, 21);
            this.cboFK_iNguoiDung.TabIndex = 33;
            // 
            // cboFK_iDoiTac
            // 
            this.cboFK_iDoiTac.FormattingEnabled = true;
            this.cboFK_iDoiTac.Location = new System.Drawing.Point(213, 160);
            this.cboFK_iDoiTac.Name = "cboFK_iDoiTac";
            this.cboFK_iDoiTac.Size = new System.Drawing.Size(172, 21);
            this.cboFK_iDoiTac.TabIndex = 34;
            // 
            // cboiTrangThai
            // 
            this.cboiTrangThai.FormattingEnabled = true;
            this.cboiTrangThai.Location = new System.Drawing.Point(213, 298);
            this.cboiTrangThai.Name = "cboiTrangThai";
            this.cboiTrangThai.Size = new System.Drawing.Size(172, 21);
            this.cboiTrangThai.TabIndex = 35;
            // 
            // txtPK_lCuocHen
            // 
            this.txtPK_lCuocHen.Location = new System.Drawing.Point(213, 98);
            this.txtPK_lCuocHen.Name = "txtPK_lCuocHen";
            this.txtPK_lCuocHen.Size = new System.Drawing.Size(172, 20);
            this.txtPK_lCuocHen.TabIndex = 36;
            // 
            // txtsDiaDiem
            // 
            this.txtsDiaDiem.Location = new System.Drawing.Point(213, 216);
            this.txtsDiaDiem.Name = "txtsDiaDiem";
            this.txtsDiaDiem.Size = new System.Drawing.Size(172, 20);
            this.txtsDiaDiem.TabIndex = 38;
            // 
            // txtsNoiDung
            // 
            this.txtsNoiDung.Location = new System.Drawing.Point(213, 187);
            this.txtsNoiDung.Name = "txtsNoiDung";
            this.txtsNoiDung.Size = new System.Drawing.Size(172, 20);
            this.txtsNoiDung.TabIndex = 39;
            // 
            // lblPK_lCuocHen
            // 
            this.lblPK_lCuocHen.AutoSize = true;
            this.lblPK_lCuocHen.Location = new System.Drawing.Point(468, 104);
            this.lblPK_lCuocHen.Name = "lblPK_lCuocHen";
            this.lblPK_lCuocHen.Size = new System.Drawing.Size(35, 13);
            this.lblPK_lCuocHen.TabIndex = 41;
            this.lblPK_lCuocHen.Text = "label1";
            // 
            // lblFK_iNguoiDung
            // 
            this.lblFK_iNguoiDung.AutoSize = true;
            this.lblFK_iNguoiDung.Location = new System.Drawing.Point(468, 139);
            this.lblFK_iNguoiDung.Name = "lblFK_iNguoiDung";
            this.lblFK_iNguoiDung.Size = new System.Drawing.Size(35, 13);
            this.lblFK_iNguoiDung.TabIndex = 42;
            this.lblFK_iNguoiDung.Text = "label2";
            // 
            // lblFK_iDoiTac
            // 
            this.lblFK_iDoiTac.AutoSize = true;
            this.lblFK_iDoiTac.Location = new System.Drawing.Point(468, 168);
            this.lblFK_iDoiTac.Name = "lblFK_iDoiTac";
            this.lblFK_iDoiTac.Size = new System.Drawing.Size(35, 13);
            this.lblFK_iDoiTac.TabIndex = 43;
            this.lblFK_iDoiTac.Text = "label3";
            // 
            // lblsNoiDung
            // 
            this.lblsNoiDung.AutoSize = true;
            this.lblsNoiDung.Location = new System.Drawing.Point(468, 194);
            this.lblsNoiDung.Name = "lblsNoiDung";
            this.lblsNoiDung.Size = new System.Drawing.Size(35, 13);
            this.lblsNoiDung.TabIndex = 44;
            this.lblsNoiDung.Text = "label4";
            // 
            // lblsDiaDiem
            // 
            this.lblsDiaDiem.AutoSize = true;
            this.lblsDiaDiem.Location = new System.Drawing.Point(468, 223);
            this.lblsDiaDiem.Name = "lblsDiaDiem";
            this.lblsDiaDiem.Size = new System.Drawing.Size(35, 13);
            this.lblsDiaDiem.TabIndex = 45;
            this.lblsDiaDiem.Text = "label5";
            // 
            // lbltNgayGioBatDau
            // 
            this.lbltNgayGioBatDau.AutoSize = true;
            this.lbltNgayGioBatDau.Location = new System.Drawing.Point(468, 253);
            this.lbltNgayGioBatDau.Name = "lbltNgayGioBatDau";
            this.lbltNgayGioBatDau.Size = new System.Drawing.Size(35, 13);
            this.lbltNgayGioBatDau.TabIndex = 46;
            this.lbltNgayGioBatDau.Text = "label6";
            // 
            // lbltNgayGioKetThuc
            // 
            this.lbltNgayGioKetThuc.AutoSize = true;
            this.lbltNgayGioKetThuc.Location = new System.Drawing.Point(468, 279);
            this.lbltNgayGioKetThuc.Name = "lbltNgayGioKetThuc";
            this.lbltNgayGioKetThuc.Size = new System.Drawing.Size(35, 13);
            this.lbltNgayGioKetThuc.TabIndex = 47;
            this.lbltNgayGioKetThuc.Text = "label7";
            // 
            // lbliTrangThai
            // 
            this.lbliTrangThai.AutoSize = true;
            this.lbliTrangThai.Location = new System.Drawing.Point(468, 306);
            this.lbliTrangThai.Name = "lbliTrangThai";
            this.lbliTrangThai.Size = new System.Drawing.Size(35, 13);
            this.lbliTrangThai.TabIndex = 48;
            this.lbliTrangThai.Text = "label8";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(265, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(530, 381);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 53;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(421, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(310, 381);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(192, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(80, 381);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 49;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grvCuocHen
            // 
            this.grvCuocHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCuocHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_lCuocHen,
            this.FK_iNguoiDung,
            this.FK_iDoiTac,
            this.sNoiDung,
            this.sDiaDiem,
            this.tNgayGioBatDau,
            this.tNgayGioKetThuc,
            this.iTrangThai});
            this.grvCuocHen.Location = new System.Drawing.Point(12, 426);
            this.grvCuocHen.Name = "grvCuocHen";
            this.grvCuocHen.Size = new System.Drawing.Size(748, 150);
            this.grvCuocHen.TabIndex = 55;
            this.grvCuocHen.SelectionChanged += new System.EventHandler(this.grvCuocHen_SelectionChanged);
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
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(339, 59);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(35, 13);
            this.lblMsg.TabIndex = 56;
            this.lblMsg.Text = "label1";
            // 
            // dpktNgayGioBatDau
            // 
            this.dpktNgayGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpktNgayGioBatDau.Location = new System.Drawing.Point(213, 247);
            this.dpktNgayGioBatDau.Name = "dpktNgayGioBatDau";
            this.dpktNgayGioBatDau.Size = new System.Drawing.Size(172, 20);
            this.dpktNgayGioBatDau.TabIndex = 57;
            // 
            // dpktNgayGioKetThuc
            // 
            this.dpktNgayGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpktNgayGioKetThuc.Location = new System.Drawing.Point(213, 273);
            this.dpktNgayGioKetThuc.Name = "dpktNgayGioKetThuc";
            this.dpktNgayGioKetThuc.Size = new System.Drawing.Size(172, 20);
            this.dpktNgayGioKetThuc.TabIndex = 58;
            // 
            // frmCuocHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(786, 597);
            this.Controls.Add(this.dpktNgayGioKetThuc);
            this.Controls.Add(this.dpktNgayGioBatDau);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.grvCuocHen);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lbliTrangThai);
            this.Controls.Add(this.lbltNgayGioKetThuc);
            this.Controls.Add(this.lbltNgayGioBatDau);
            this.Controls.Add(this.lblsDiaDiem);
            this.Controls.Add(this.lblsNoiDung);
            this.Controls.Add(this.lblFK_iDoiTac);
            this.Controls.Add(this.lblFK_iNguoiDung);
            this.Controls.Add(this.lblPK_lCuocHen);
            this.Controls.Add(this.txtsNoiDung);
            this.Controls.Add(this.txtsDiaDiem);
            this.Controls.Add(this.txtPK_lCuocHen);
            this.Controls.Add(this.cboiTrangThai);
            this.Controls.Add(this.cboFK_iDoiTac);
            this.Controls.Add(this.cboFK_iNguoiDung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmCuocHen";
            this.Text = "Cuộc Hẹn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCuocHen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCuocHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFK_iNguoiDung;
        private System.Windows.Forms.ComboBox cboFK_iDoiTac;
        private System.Windows.Forms.ComboBox cboiTrangThai;
        private System.Windows.Forms.TextBox txtPK_lCuocHen;
        private System.Windows.Forms.TextBox txtsDiaDiem;
        private System.Windows.Forms.TextBox txtsNoiDung;
        private System.Windows.Forms.Label lblPK_lCuocHen;
        private System.Windows.Forms.Label lblFK_iNguoiDung;
        private System.Windows.Forms.Label lblFK_iDoiTac;
        private System.Windows.Forms.Label lblsNoiDung;
        private System.Windows.Forms.Label lblsDiaDiem;
        private System.Windows.Forms.Label lbltNgayGioBatDau;
        private System.Windows.Forms.Label lbltNgayGioKetThuc;
        private System.Windows.Forms.Label lbliTrangThai;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView grvCuocHen;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_lCuocHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNgayGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNgayGioKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThai;
        private System.Windows.Forms.DateTimePicker dpktNgayGioBatDau;
        private System.Windows.Forms.DateTimePicker dpktNgayGioKetThuc;
    }
}