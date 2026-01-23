namespace QuanLyBanHang.Forms
{
    partial class frmLoaiSanPham
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
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtTenLoai = new TextBox();
            groupBox2 = new GroupBox();
            dgvLoaiSanPham = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoaiSanPham = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenLoai);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin loai san pham";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(608, 58);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Lime;
            btnLuu.Location = new Point(417, 58);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = Color.FromArgb(192, 64, 0);
            btnHuyBo.Location = new Point(509, 58);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Huy Bo";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(326, 58);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(230, 58);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(133, 58);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Ten loai san pham";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(142, 22);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(413, 23);
            txtTenLoai.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLoaiSanPham);
            groupBox2.Location = new Point(22, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 255);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sach Loai San Pham";
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.AllowUserToAddRows = false;
            dgvLoaiSanPham.AllowUserToDeleteRows = false;
            dgvLoaiSanPham.AllowUserToResizeColumns = false;
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoaiSanPham });
            dgvLoaiSanPham.Dock = DockStyle.Fill;
            dgvLoaiSanPham.Location = new Point(3, 19);
            dgvLoaiSanPham.MultiSelect = false;
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.Size = new Size(760, 233);
            dgvLoaiSanPham.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenLoaiSanPham
            // 
            TenLoaiSanPham.HeaderText = "TenLoaiSanPham";
            TenLoaiSanPham.Name = "TenLoaiSanPham";
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiSanPham";
            Text = " Loai San Pham";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTenLoai;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dgvLoaiSanPham;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoaiSanPham;
    }
}