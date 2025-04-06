namespace Project_HK2_KTLT
{
    partial class ChucVu
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
            this.dtgChucVu = new System.Windows.Forms.DataGridView();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.lblThanhCong = new System.Windows.Forms.Label();
            this.lblErrorCV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThemCV = new System.Windows.Forms.Button();
            this.btnSuaCV = new System.Windows.Forms.Button();
            this.btnXoaCV = new System.Windows.Forms.Button();
            this.btnGhiCV = new System.Windows.Forms.Button();
            this.btnHuyCV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimCV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgChucVu
            // 
            this.dtgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChucVu.Location = new System.Drawing.Point(12, 59);
            this.dtgChucVu.Name = "dtgChucVu";
            this.dtgChucVu.Size = new System.Drawing.Size(606, 187);
            this.dtgChucVu.TabIndex = 0;
            this.dtgChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChucVu_CellContentClick);
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.ForeColor = System.Drawing.Color.Blue;
            this.lblTongSo.Location = new System.Drawing.Point(13, 37);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(120, 19);
            this.lblTongSo.TabIndex = 1;
            this.lblTongSo.Text = "Tổng số: 0 bản ghi";
            // 
            // lblThanhCong
            // 
            this.lblThanhCong.AutoSize = true;
            this.lblThanhCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblThanhCong.Location = new System.Drawing.Point(326, 37);
            this.lblThanhCong.Name = "lblThanhCong";
            this.lblThanhCong.Size = new System.Drawing.Size(79, 19);
            this.lblThanhCong.TabIndex = 2;
            this.lblThanhCong.Text = "Thành công";
            // 
            // lblErrorCV
            // 
            this.lblErrorCV.AutoSize = true;
            this.lblErrorCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCV.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCV.Location = new System.Drawing.Point(268, 37);
            this.lblErrorCV.Name = "lblErrorCV";
            this.lblErrorCV.Size = new System.Drawing.Size(29, 19);
            this.lblErrorCV.TabIndex = 3;
            this.lblErrorCV.Text = "Lỗi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(320, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã chức vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên chức vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ghi chú:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(99, 261);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 26);
            this.txtID.TabIndex = 9;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Location = new System.Drawing.Point(99, 300);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(198, 26);
            this.txtTenCV.TabIndex = 10;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Location = new System.Drawing.Point(411, 265);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(193, 26);
            this.txtMaCV.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(99, 342);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(505, 64);
            this.txtGhiChu.TabIndex = 12;
            // 
            // btnThemCV
            // 
            this.btnThemCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCV.Location = new System.Drawing.Point(36, 421);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(97, 42);
            this.btnThemCV.TabIndex = 13;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.UseVisualStyleBackColor = true;
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCV.Location = new System.Drawing.Point(155, 421);
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.Size = new System.Drawing.Size(97, 42);
            this.btnSuaCV.TabIndex = 14;
            this.btnSuaCV.Text = "Sửa";
            this.btnSuaCV.UseVisualStyleBackColor = true;
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCV.Location = new System.Drawing.Point(272, 421);
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.Size = new System.Drawing.Size(97, 42);
            this.btnXoaCV.TabIndex = 15;
            this.btnXoaCV.Text = "Xóa";
            this.btnXoaCV.UseVisualStyleBackColor = true;
            // 
            // btnGhiCV
            // 
            this.btnGhiCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiCV.Location = new System.Drawing.Point(391, 421);
            this.btnGhiCV.Name = "btnGhiCV";
            this.btnGhiCV.Size = new System.Drawing.Size(97, 42);
            this.btnGhiCV.TabIndex = 16;
            this.btnGhiCV.Text = "Ghi dữ liệu";
            this.btnGhiCV.UseVisualStyleBackColor = true;
            // 
            // btnHuyCV
            // 
            this.btnHuyCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCV.Location = new System.Drawing.Point(507, 421);
            this.btnHuyCV.Name = "btnHuyCV";
            this.btnHuyCV.Size = new System.Drawing.Size(97, 42);
            this.btnHuyCV.TabIndex = 17;
            this.btnHuyCV.Text = "Hủy bỏ";
            this.btnHuyCV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Từ khóa:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(99, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(306, 26);
            this.txtTimKiem.TabIndex = 19;
            // 
            // btnTimCV
            // 
            this.btnTimCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimCV.Location = new System.Drawing.Point(411, 2);
            this.btnTimCV.Name = "btnTimCV";
            this.btnTimCV.Size = new System.Drawing.Size(97, 26);
            this.btnTimCV.TabIndex = 20;
            this.btnTimCV.Text = "Tìm";
            this.btnTimCV.UseVisualStyleBackColor = true;
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.btnTimCV);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuyCV);
            this.Controls.Add(this.btnGhiCV);
            this.Controls.Add(this.btnXoaCV);
            this.Controls.Add(this.btnSuaCV);
            this.Controls.Add(this.btnThemCV);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErrorCV);
            this.Controls.Add(this.lblThanhCong);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.dtgChucVu);
            this.Name = "ChucVu";
            this.Text = "Danh Mục Chức Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgChucVu;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.Label lblThanhCong;
        private System.Windows.Forms.Label lblErrorCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThemCV;
        private System.Windows.Forms.Button btnSuaCV;
        private System.Windows.Forms.Button btnXoaCV;
        private System.Windows.Forms.Button btnGhiCV;
        private System.Windows.Forms.Button btnHuyCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimCV;
    }
}