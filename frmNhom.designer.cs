﻿namespace HaMy
{
    partial class frmNhom
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
            this.txtPK_iNhom = new System.Windows.Forms.TextBox();
            this.txtsTenNhom = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grvNhom = new System.Windows.Forms.DataGridView();
            this.PK_iNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPK_iNhom = new System.Windows.Forms.Label();
            this.lblsTenNhom = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm";
            // 
            // txtPK_iNhom
            // 
            this.txtPK_iNhom.Location = new System.Drawing.Point(237, 115);
            this.txtPK_iNhom.Name = "txtPK_iNhom";
            this.txtPK_iNhom.Size = new System.Drawing.Size(226, 20);
            this.txtPK_iNhom.TabIndex = 0;
            // 
            // txtsTenNhom
            // 
            this.txtsTenNhom.Location = new System.Drawing.Point(237, 153);
            this.txtsTenNhom.MaxLength = 50;
            this.txtsTenNhom.Name = "txtsTenNhom";
            this.txtsTenNhom.Size = new System.Drawing.Size(226, 20);
            this.txtsTenNhom.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(40, 242);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(174, 242);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(304, 242);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(445, 242);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grvNhom
            // 
            this.grvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_iNhom,
            this.sTenNhom});
            this.grvNhom.Location = new System.Drawing.Point(12, 280);
            this.grvNhom.Name = "grvNhom";
            this.grvNhom.Size = new System.Drawing.Size(711, 150);
            this.grvNhom.TabIndex = 8;
            this.grvNhom.SelectionChanged += new System.EventHandler(this.grvNhom_SelectionChanged);
            // 
            // PK_iNhom
            // 
            this.PK_iNhom.DataPropertyName = "PK_iNhom";
            this.PK_iNhom.HeaderText = "Mã nhóm";
            this.PK_iNhom.Name = "PK_iNhom";
            // 
            // sTenNhom
            // 
            this.sTenNhom.DataPropertyName = "sTenNhom";
            this.sTenNhom.HeaderText = "Tên nhóm";
            this.sTenNhom.Name = "sTenNhom";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(275, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Thông tin nhóm";
            // 
            // lblPK_iNhom
            // 
            this.lblPK_iNhom.AutoSize = true;
            this.lblPK_iNhom.Location = new System.Drawing.Point(476, 121);
            this.lblPK_iNhom.Name = "lblPK_iNhom";
            this.lblPK_iNhom.Size = new System.Drawing.Size(35, 13);
            this.lblPK_iNhom.TabIndex = 10;
            this.lblPK_iNhom.Text = "label1";
            // 
            // lblsTenNhom
            // 
            this.lblsTenNhom.AutoSize = true;
            this.lblsTenNhom.Location = new System.Drawing.Point(476, 157);
            this.lblsTenNhom.Name = "lblsTenNhom";
            this.lblsTenNhom.Size = new System.Drawing.Size(35, 13);
            this.lblsTenNhom.TabIndex = 11;
            this.lblsTenNhom.Text = "label2";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(302, 202);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(580, 242);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(336, 78);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(35, 13);
            this.lblMsg.TabIndex = 51;
            this.lblMsg.Text = "label3";
            // 
            // frmNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 430);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblsTenNhom);
            this.Controls.Add(this.lblPK_iNhom);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grvNhom);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtsTenNhom);
            this.Controls.Add(this.txtPK_iNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhom";
            this.Text = "Nhóm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPK_iNhom;
        private System.Windows.Forms.TextBox txtsTenNhom;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView grvNhom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPK_iNhom;
        private System.Windows.Forms.Label lblsTenNhom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_iNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNhom;
    }
}