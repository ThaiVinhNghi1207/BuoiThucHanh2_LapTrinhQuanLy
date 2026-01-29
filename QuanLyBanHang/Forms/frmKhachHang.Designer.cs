namespace QuanLyBanHang.Forms
{
    partial class frmKhachHang
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
            txtDiaChi = new TextBox();
            txtHoVaTen = new TextBox();
            txtDienThoai = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(509, 31);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(156, 34);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(125, 27);
            txtHoVaTen.TabIndex = 4;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(156, 81);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(125, 27);
            txtDienThoai.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 34);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvKhachHang);
            groupBox2.Location = new Point(31, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1307, 226);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colID, colHoTen, colDienThoai, colDiaChi });
            dgvKhachHang.Location = new Point(11, 32);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1290, 188);
            dgvKhachHang.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            // 
            // colDienThoai
            // 
            colDienThoai.HeaderText = "Điện thoại ";
            colDienThoai.MinimumWidth = 6;
            colDienThoai.Name = "colDienThoai";
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(869, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(869, 84);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(869, 130);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(998, 42);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(998, 84);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(998, 130);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1130, 42);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1130, 84);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 9;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1130, 130);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 10;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 450);
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
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvKhachHang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private TextBox txtDienThoai;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
    }
}