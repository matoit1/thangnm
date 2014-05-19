namespace HaMy
{
    partial class frmMoiQuanHe
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPK_iMoiQuanHe = new System.Windows.Forms.Label();
            this.lblsTen = new System.Windows.Forms.Label();
            this.txtPK_iMoiQuanHe = new System.Windows.Forms.TextBox();
            this.txtsTen = new System.Windows.Forms.TextBox();
            this.grvMoiQuanHe = new System.Windows.Forms.DataGridView();
            this.PK_iMoiQuanHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvMoiQuanHe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(280, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 24);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Mối Quan Hệ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã quan hệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên quan hệ";
            // 
            // lblPK_iMoiQuanHe
            // 
            this.lblPK_iMoiQuanHe.AutoSize = true;
            this.lblPK_iMoiQuanHe.Location = new System.Drawing.Point(477, 100);
            this.lblPK_iMoiQuanHe.Name = "lblPK_iMoiQuanHe";
            this.lblPK_iMoiQuanHe.Size = new System.Drawing.Size(35, 13);
            this.lblPK_iMoiQuanHe.TabIndex = 13;
            this.lblPK_iMoiQuanHe.Text = "label3";
            // 
            // lblsTen
            // 
            this.lblsTen.AutoSize = true;
            this.lblsTen.Location = new System.Drawing.Point(477, 136);
            this.lblsTen.Name = "lblsTen";
            this.lblsTen.Size = new System.Drawing.Size(35, 13);
            this.lblsTen.TabIndex = 14;
            this.lblsTen.Text = "label4";
            // 
            // txtPK_iMoiQuanHe
            // 
            this.txtPK_iMoiQuanHe.Location = new System.Drawing.Point(284, 93);
            this.txtPK_iMoiQuanHe.Name = "txtPK_iMoiQuanHe";
            this.txtPK_iMoiQuanHe.Size = new System.Drawing.Size(100, 20);
            this.txtPK_iMoiQuanHe.TabIndex = 15;
            // 
            // txtsTen
            // 
            this.txtsTen.Location = new System.Drawing.Point(284, 129);
            this.txtsTen.Name = "txtsTen";
            this.txtsTen.Size = new System.Drawing.Size(100, 20);
            this.txtsTen.TabIndex = 16;
            // 
            // grvMoiQuanHe
            // 
            this.grvMoiQuanHe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMoiQuanHe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_iMoiQuanHe,
            this.sTen});
            this.grvMoiQuanHe.Location = new System.Drawing.Point(38, 292);
            this.grvMoiQuanHe.Name = "grvMoiQuanHe";
            this.grvMoiQuanHe.Size = new System.Drawing.Size(630, 150);
            this.grvMoiQuanHe.TabIndex = 17;
            // 
            // PK_iMoiQuanHe
            // 
            this.PK_iMoiQuanHe.HeaderText = "Mã quan hệ";
            this.PK_iMoiQuanHe.Name = "PK_iMoiQuanHe";
            // 
            // sTen
            // 
            this.sTen.HeaderText = "Tên quan hệ";
            this.sTen.Name = "sTen";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(73, 242);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(179, 242);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(284, 242);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(385, 242);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(284, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 49;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(492, 242);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 48;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(304, 68);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(35, 13);
            this.lblMsg.TabIndex = 50;
            this.lblMsg.Text = "label3";
            // 
            // frmMoiQuanHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 454);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grvMoiQuanHe);
            this.Controls.Add(this.txtsTen);
            this.Controls.Add(this.txtPK_iMoiQuanHe);
            this.Controls.Add(this.lblsTen);
            this.Controls.Add(this.lblPK_iMoiQuanHe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMoiQuanHe";
            this.Text = "Mối Quan Hệ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMoiQuanHe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvMoiQuanHe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPK_iMoiQuanHe;
        private System.Windows.Forms.Label lblsTen;
        private System.Windows.Forms.TextBox txtPK_iMoiQuanHe;
        private System.Windows.Forms.TextBox txtsTen;
        private System.Windows.Forms.DataGridView grvMoiQuanHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_iMoiQuanHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblMsg;
    }
}