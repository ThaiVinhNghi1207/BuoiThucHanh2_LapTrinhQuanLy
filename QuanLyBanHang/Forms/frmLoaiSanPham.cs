using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;

        // Hàm bật/tắt các điều khiển để tránh thao tác sai luồng
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Tải lại danh sách mới nhất từ Database
            var danhSachLSP = context.LoaiSanPham.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachLSP;

            // Xóa và thiết lập lại Binding cho TextBox
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            // Đổ dữ liệu lên lưới hiển thị
            dgvLoaiSanPham.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.Clear();
            txtTenLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                // Lấy ID từ cột "ID" của dòng đang chọn trên lưới
                id = Convert.ToInt32(dgvLoaiSanPham.CurrentRow.Cells["ID"].Value);
                txtTenLoai.Focus();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa loại sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dgvLoaiSanPham.CurrentRow.Cells["ID"].Value);
                    var lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        context.LoaiSanPham.Remove(lsp);
                        context.SaveChanges();
                        MessageBox.Show("Đã xóa thành công!");
                    }
                    frmLoaiSanPham_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra ràng buộc dữ liệu trống
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Tên loại sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                // Thực hiện thêm mới
                LoaiSanPham lsp = new LoaiSanPham();
                lsp.TenLoai = txtTenLoai.Text.Trim();
                context.LoaiSanPham.Add(lsp);
            }
            else
            {
                // Thực hiện cập nhật
                var lsp = context.LoaiSanPham.Find(id);
                if (lsp != null)
                {
                    lsp.TenLoai = txtTenLoai.Text.Trim();
                    context.LoaiSanPham.Update(lsp);
                }
            }

            context.SaveChanges();
            MessageBox.Show("Đã lưu dữ liệu thành công!");
            frmLoaiSanPham_Load(sender, e);
        }
    }
}