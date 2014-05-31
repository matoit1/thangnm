namespace HaMy
{
    partial class frmThongBao
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
            this.btnStop = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.grvCuocHen = new System.Windows.Forms.DataGridView();
            this.PK_lCuocHen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_iDoiTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNgayGioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNgayGioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsNoiDung = new System.Windows.Forms.TextBox();
            this.txtsDiaDiem = new System.Windows.Forms.TextBox();
            this.txtPK_lCuocHen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFK_iNguoiDung = new System.Windows.Forms.TextBox();
            this.txttNgayGioKetThuc = new System.Windows.Forms.TextBox();
            this.txttNgayGioBatDau = new System.Windows.Forms.TextBox();
            this.txtiTrangThai = new System.Windows.Forms.TextBox();
            this.txtFK_iDoiTac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvCuocHen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(589, 127);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Tắt nhắc nhở";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(227, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(37, 13);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Text = "lblMsg";
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
            this.grvCuocHen.Location = new System.Drawing.Point(12, 293);
            this.grvCuocHen.Name = "grvCuocHen";
            this.grvCuocHen.Size = new System.Drawing.Size(847, 150);
            this.grvCuocHen.TabIndex = 56;
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
            // txtsNoiDung
            // 
            this.txtsNoiDung.Location = new System.Drawing.Point(174, 123);
            this.txtsNoiDung.MaxLength = 500;
            this.txtsNoiDung.Multiline = true;
            this.txtsNoiDung.Name = "txtsNoiDung";
            this.txtsNoiDung.Size = new System.Drawing.Size(346, 51);
            this.txtsNoiDung.TabIndex = 61;
            // 
            // txtsDiaDiem
            // 
            this.txtsDiaDiem.Location = new System.Drawing.Point(174, 180);
            this.txtsDiaDiem.MaxLength = 500;
            this.txtsDiaDiem.Name = "txtsDiaDiem";
            this.txtsDiaDiem.Size = new System.Drawing.Size(346, 20);
            this.txtsDiaDiem.TabIndex = 62;
            // 
            // txtPK_lCuocHen
            // 
            this.txtPK_lCuocHen.Location = new System.Drawing.Point(174, 35);
            this.txtPK_lCuocHen.Name = "txtPK_lCuocHen";
            this.txtPK_lCuocHen.Size = new System.Drawing.Size(346, 20);
            this.txtPK_lCuocHen.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Ngày giờ kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Ngày giờ bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Địa điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Nội dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Đối tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Cuộc hẹn";
            // 
            // txtFK_iNguoiDung
            // 
            this.txtFK_iNguoiDung.Location = new System.Drawing.Point(174, 68);
            this.txtFK_iNguoiDung.Name = "txtFK_iNguoiDung";
            this.txtFK_iNguoiDung.Size = new System.Drawing.Size(346, 20);
            this.txtFK_iNguoiDung.TabIndex = 75;
            // 
            // txttNgayGioKetThuc
            // 
            this.txttNgayGioKetThuc.Location = new System.Drawing.Point(174, 239);
            this.txttNgayGioKetThuc.Name = "txttNgayGioKetThuc";
            this.txttNgayGioKetThuc.Size = new System.Drawing.Size(346, 20);
            this.txttNgayGioKetThuc.TabIndex = 76;
            // 
            // txttNgayGioBatDau
            // 
            this.txttNgayGioBatDau.Location = new System.Drawing.Point(174, 210);
            this.txttNgayGioBatDau.Name = "txttNgayGioBatDau";
            this.txttNgayGioBatDau.Size = new System.Drawing.Size(346, 20);
            this.txttNgayGioBatDau.TabIndex = 77;
            // 
            // txtiTrangThai
            // 
            this.txtiTrangThai.Location = new System.Drawing.Point(174, 266);
            this.txtiTrangThai.Name = "txtiTrangThai";
            this.txtiTrangThai.Size = new System.Drawing.Size(346, 20);
            this.txtiTrangThai.TabIndex = 78;
            // 
            // txtFK_iDoiTac
            // 
            this.txtFK_iDoiTac.Location = new System.Drawing.Point(174, 95);
            this.txtFK_iDoiTac.Name = "txtFK_iDoiTac";
            this.txtFK_iDoiTac.Size = new System.Drawing.Size(346, 20);
            this.txtFK_iDoiTac.TabIndex = 79;
            // 
            // frmThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 480);
            this.Controls.Add(this.txtFK_iDoiTac);
            this.Controls.Add(this.txtiTrangThai);
            this.Controls.Add(this.txttNgayGioBatDau);
            this.Controls.Add(this.txttNgayGioKetThuc);
            this.Controls.Add(this.txtFK_iNguoiDung);
            this.Controls.Add(this.txtsNoiDung);
            this.Controls.Add(this.txtsDiaDiem);
            this.Controls.Add(this.txtPK_lCuocHen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvCuocHen);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnStop);
            this.Name = "frmThongBao";
            this.Text = "frmThongBao";
            this.Load += new System.EventHandler(this.frmThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCuocHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridView grvCuocHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_lCuocHen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_iDoiTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNgayGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNgayGioKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTrangThai;
        private System.Windows.Forms.TextBox txtsNoiDung;
        private System.Windows.Forms.TextBox txtsDiaDiem;
        private System.Windows.Forms.TextBox txtPK_lCuocHen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFK_iNguoiDung;
        private System.Windows.Forms.TextBox txttNgayGioKetThuc;
        private System.Windows.Forms.TextBox txttNgayGioBatDau;
        private System.Windows.Forms.TextBox txtiTrangThai;
        private System.Windows.Forms.TextBox txtFK_iDoiTac;
    }
}