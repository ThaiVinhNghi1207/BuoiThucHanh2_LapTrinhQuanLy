namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtHoVaTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colQuyenHan = new DataGridViewTextBoxColumn();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(852, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(556, 133);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(151, 28);
            cboQuyenHan.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(569, 78);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 10;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(569, 38);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(141, 130);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(141, 82);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(125, 27);
            txtDienThoai.TabIndex = 7;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(141, 38);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(125, 27);
            txtHoVaTen.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 128);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "Quyền hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 78);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 41);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên đăng nhập ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 133);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1329, 210);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colHoTen, colDienThoai, colDiaChi, colTenDangNhap, colQuyenHan });
            dataGridView.Location = new Point(18, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1282, 178);
            dataGridView.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ và tên ";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            // 
            // colDienThoai
            // 
            colDienThoai.HeaderText = "ĐIện thoại ";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.HeaderText = "Tên đăng nhập ";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colQuyenHan
            // 
            colQuyenHan.HeaderText = "Quyền hạn";
            colQuyenHan.MinimumWidth = 6;
            colQuyenHan.Name = "colQuyenHan";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1182, 136);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 19;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1182, 90);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 18;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1182, 48);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1050, 136);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1050, 90);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 15;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1050, 48);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(921, 136);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(921, 90);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(921, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 450);
            Controls.Add(btnXuat);
            Controls.Add(btnNhap);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtHoVaTen;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colQuyenHan;
    }
}