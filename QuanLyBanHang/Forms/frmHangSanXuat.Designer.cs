namespace QuanLyBanHang.Forms
{
    partial class frmHangSanXuat
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
            groupBox2 = new GroupBox();
            dgvHangSanXuat = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            grpHangSanXuat = new GroupBox();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtTenHang = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangSanXuat).BeginInit();
            grpHangSanXuat.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHangSanXuat);
            groupBox2.Location = new Point(22, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 255);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sach Hang San Xuat";
            // 
            // dgvHangSanXuat
            // 
            dgvHangSanXuat.AllowUserToAddRows = false;
            dgvHangSanXuat.AllowUserToDeleteRows = false;
            dgvHangSanXuat.AllowUserToResizeColumns = false;
            dgvHangSanXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangSanXuat.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvHangSanXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangSanXuat.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat });
            dgvHangSanXuat.Dock = DockStyle.Fill;
            dgvHangSanXuat.Location = new Point(3, 19);
            dgvHangSanXuat.MultiSelect = false;
            dgvHangSanXuat.Name = "dgvHangSanXuat";
            dgvHangSanXuat.Size = new Size(760, 233);
            dgvHangSanXuat.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.HeaderText = "TenHangSanXuat";
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // grpHangSanXuat
            // 
            grpHangSanXuat.Controls.Add(btnThoat);
            grpHangSanXuat.Controls.Add(btnLuu);
            grpHangSanXuat.Controls.Add(btnHuyBo);
            grpHangSanXuat.Controls.Add(btnXoa);
            grpHangSanXuat.Controls.Add(btnSua);
            grpHangSanXuat.Controls.Add(btnThem);
            grpHangSanXuat.Controls.Add(label1);
            grpHangSanXuat.Controls.Add(txtTenHang);
            grpHangSanXuat.Location = new Point(12, 32);
            grpHangSanXuat.Name = "grpHangSanXuat";
            grpHangSanXuat.Size = new Size(776, 100);
            grpHangSanXuat.TabIndex = 2;
            grpHangSanXuat.TabStop = false;
            grpHangSanXuat.Text = "Thong tin hang san xuat";
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
            btnSua.Click += btnSua_Click;
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
            label1.Text = "Ten hang san xuat";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(142, 22);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(413, 23);
            txtTenHang.TabIndex = 0;
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(grpHangSanXuat);
            Name = "frmHangSanXuat";
            Text = "Hang San Xuat";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHangSanXuat).EndInit();
            grpHangSanXuat.ResumeLayout(false);
            grpHangSanXuat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvHangSanXuat;
        private GroupBox grpHangSanXuat;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private TextBox txtTenHang;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
    }
}