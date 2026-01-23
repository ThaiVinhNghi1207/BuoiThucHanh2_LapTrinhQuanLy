using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
        {
            InitializeComponent();
        }

        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHang.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // 1. Load dữ liệu
            var listHang = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listHang;

            // 2. Cấu hình DataGridView
            dgvHangSanXuat.AutoGenerateColumns = false;
            dgvHangSanXuat.DataSource = bindingSource;

            // Ánh xạ đúng tên thuộc tính từ CSDL vào cột của lưới
            if (dgvHangSanXuat.Columns.Contains("ID"))
                dgvHangSanXuat.Columns["ID"].DataPropertyName = "ID";

            if (dgvHangSanXuat.Columns.Contains("TenHangSanXuat"))
                dgvHangSanXuat.Columns["TenHangSanXuat"].DataPropertyName = "TenHangSanXuat";

            // 3. Đổ dữ liệu vào TextBox (Sửa TenHang -> TenHangSanXuat)
            txtTenHang.DataBindings.Clear();
            txtTenHang.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHang.Clear();
            txtTenHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHangSanXuat.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvHangSanXuat.CurrentRow.Cells["ID"].Value);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHangSanXuat.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa hãng sản xuất này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dgvHangSanXuat.CurrentRow.Cells["ID"].Value);
                    var hang = context.HangSanXuat.Find(id);
                    if (hang != null)
                    {
                        context.HangSanXuat.Remove(hang);
                        context.SaveChanges();
                    }
                    frmHangSanXuat_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (xuLyThem)
            {
                HangSanXuat hangMoi = new HangSanXuat();
                // Sửa TenHang -> TenHangSanXuat để khớp CSDL
                hangMoi.TenHangSanXuat = txtTenHang.Text;
                context.HangSanXuat.Add(hangMoi);
            }
            else
            {
                var hangSua = context.HangSanXuat.Find(id);
                if (hangSua != null)
                {
                    // Sửa TenHang -> TenHangSanXuat để khớp CSDL
                    hangSua.TenHangSanXuat = txtTenHang.Text;
                    context.HangSanXuat.Update(hangSua);
                }
            }

            context.SaveChanges();
            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmHangSanXuat_Load(sender, e);
        }
    }
}