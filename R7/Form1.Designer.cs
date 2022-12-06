namespace CaPhe
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.maHang = new System.Windows.Forms.TextBox();
            this.tenHang = new System.Windows.Forms.TextBox();
            this.donViTinh = new System.Windows.Forms.TextBox();
            this.donGiaBan = new System.Windows.Forms.TextBox();
            this.maLoaiHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnNguyenLieu = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(450, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb1.Location = new System.Drawing.Point(29, 223);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(74, 20);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Mã Hàng";
            this.lb1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb2.Location = new System.Drawing.Point(29, 276);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(79, 20);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Tên Hàng";
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb3.Location = new System.Drawing.Point(29, 336);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(91, 20);
            this.lb3.TabIndex = 3;
            this.lb3.Text = "Đơn Vị Tính";
            this.lb3.Click += new System.EventHandler(this.lb3_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb4.Location = new System.Drawing.Point(29, 394);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(101, 20);
            this.lb4.TabIndex = 4;
            this.lb4.Text = "Đơn Giá Bán";
            this.lb4.Click += new System.EventHandler(this.lb4_Click);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb5.Location = new System.Drawing.Point(29, 453);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(108, 20);
            this.lb5.TabIndex = 5;
            this.lb5.Text = "Mã Loại Hàng";
            this.lb5.Click += new System.EventHandler(this.lb5_Click);
            // 
            // maHang
            // 
            this.maHang.Location = new System.Drawing.Point(151, 223);
            this.maHang.Name = "maHang";
            this.maHang.Size = new System.Drawing.Size(243, 20);
            this.maHang.TabIndex = 6;
            this.maHang.TextChanged += new System.EventHandler(this.maHang_TextChanged);
            // 
            // tenHang
            // 
            this.tenHang.Location = new System.Drawing.Point(151, 276);
            this.tenHang.Name = "tenHang";
            this.tenHang.Size = new System.Drawing.Size(243, 20);
            this.tenHang.TabIndex = 7;
            this.tenHang.TextChanged += new System.EventHandler(this.tenHang_TextChanged);
            // 
            // donViTinh
            // 
            this.donViTinh.Location = new System.Drawing.Point(151, 336);
            this.donViTinh.Name = "donViTinh";
            this.donViTinh.Size = new System.Drawing.Size(243, 20);
            this.donViTinh.TabIndex = 8;
            this.donViTinh.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // donGiaBan
            // 
            this.donGiaBan.Location = new System.Drawing.Point(151, 394);
            this.donGiaBan.Name = "donGiaBan";
            this.donGiaBan.Size = new System.Drawing.Size(243, 20);
            this.donGiaBan.TabIndex = 9;
            this.donGiaBan.TextChanged += new System.EventHandler(this.donGiaBan_TextChanged);
            // 
            // maLoaiHang
            // 
            this.maLoaiHang.Location = new System.Drawing.Point(151, 453);
            this.maLoaiHang.Name = "maLoaiHang";
            this.maLoaiHang.Size = new System.Drawing.Size(243, 20);
            this.maLoaiHang.TabIndex = 10;
            this.maLoaiHang.TextChanged += new System.EventHandler(this.maLoaiHang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(452, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản Lý Cà Phê";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(151, 557);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 45);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(450, 557);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 45);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(744, 557);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 45);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHang
            // 
            this.btnHang.Location = new System.Drawing.Point(12, 87);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(153, 53);
            this.btnHang.TabIndex = 15;
            this.btnHang.Text = "Hàng";
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(196, 87);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(150, 53);
            this.btnNhanVien.TabIndex = 16;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnNguyenLieu
            // 
            this.btnNguyenLieu.Location = new System.Drawing.Point(383, 87);
            this.btnNguyenLieu.Name = "btnNguyenLieu";
            this.btnNguyenLieu.Size = new System.Drawing.Size(150, 53);
            this.btnNguyenLieu.TabIndex = 17;
            this.btnNguyenLieu.Text = "Nguyên Liệu";
            this.btnNguyenLieu.UseVisualStyleBackColor = true;
            this.btnNguyenLieu.Click += new System.EventHandler(this.btnNguyenLieu_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(584, 87);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(150, 53);
            this.btnHoaDon.TabIndex = 18;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Location = new System.Drawing.Point(783, 87);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(150, 53);
            this.btnPhieuNhap.TabIndex = 19;
            this.btnPhieuNhap.Text = "Phiếu Nhập";
            this.btnPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(992, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 53);
            this.button6.TabIndex = 20;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 623);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPhieuNhap);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnNguyenLieu);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maLoaiHang);
            this.Controls.Add(this.donGiaBan);
            this.Controls.Add(this.donViTinh);
            this.Controls.Add(this.tenHang);
            this.Controls.Add(this.maHang);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox maHang;
        private System.Windows.Forms.TextBox tenHang;
        private System.Windows.Forms.TextBox donViTinh;
        private System.Windows.Forms.TextBox donGiaBan;
        private System.Windows.Forms.TextBox maLoaiHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnNguyenLieu;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button button6;
    }
}

