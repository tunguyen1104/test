using System.Data;
using System.Data.SqlClient;
using WinFormsApp1.Classes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ConnectData connectData = new ConnectData();
        string? txtAnh;
        string basePath;

        public Form1()
        {
            InitializeComponent();
            basePath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Assets"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            SetButtonState(true, false, false);
        }

        private void LoadData()
        {
            DataTable dataTable = connectData.ReadData("SELECT * FROM VatLieu");
            dgvVatLieu.DataSource = dataTable;
        }

        private void SetButtonState(bool addEnabled, bool editEnabled, bool deleteEnabled)
        {
            btnThem.Enabled = addEnabled;
            btnSua.Enabled = editEnabled;
            btnXoa.Enabled = deleteEnabled;
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAnh.Image = Image.FromFile(openFileDialog.FileName);
                    txtAnh = Path.GetFileName(openFileDialog.FileName);
                }
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVL.Text) || string.IsNullOrWhiteSpace(txtTenVatLieu.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) || string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string checkSql = $"SELECT COUNT(*) FROM VatLieu WHERE MaVL = '{txtMaVL.Text}'";
            DataTable checkTable = connectData.ReadData(checkSql);
            if (checkTable.Rows[0][0].ToString() != "0")
            {
                MessageBox.Show("Mã vật liệu đã tồn tại, vui lòng nhập mã khác.");
                return;
            }

            string insertSql = $"INSERT INTO VatLieu (MaVL, TenVatLieu, DonViTinh, GiaNhap, GiaBan, SoLuong, Anh, GhiChu) " +
                               $"VALUES ('{txtMaVL.Text}', '{txtTenVatLieu.Text}', '{txtDonViTinh.Text}', " +
                               $"'{txtGiaNhap.Text}', '{txtGiaBan.Text}', {txtSoLuong.Text}, '{txtAnh}', '{txtGhiChu.Text}')";
            connectData.UpdateData(insertSql);
            LoadData();
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtMaVL.Clear();
            txtTenVatLieu.Clear();
            txtDonViTinh.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtGhiChu.Clear();
            txtAnh = string.Empty;
            pictureBoxAnh.Image = null;
        }

        private void dgvVatLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVatLieu.CurrentRow != null)
            {
                txtMaVL.Text = dgvVatLieu.CurrentRow.Cells["MaVL"]?.Value?.ToString();
                txtTenVatLieu.Text = dgvVatLieu.CurrentRow.Cells["TenVatLieu"]?.Value?.ToString();
                txtDonViTinh.Text = dgvVatLieu.CurrentRow.Cells["DonViTinh"]?.Value?.ToString();
                txtGiaNhap.Text = dgvVatLieu.CurrentRow.Cells["GiaNhap"]?.Value?.ToString();
                txtGiaBan.Text = dgvVatLieu.CurrentRow.Cells["GiaBan"]?.Value?.ToString();
                txtSoLuong.Text = dgvVatLieu.CurrentRow.Cells["SoLuong"]?.Value?.ToString();
                txtGhiChu.Text = dgvVatLieu.CurrentRow.Cells["GhiChu"]?.Value?.ToString();

                txtAnh = dgvVatLieu.CurrentRow.Cells["Anh"]?.Value?.ToString();
                string imagePath = Path.Combine(basePath, txtAnh);

                if (File.Exists(imagePath))
                {
                    pictureBoxAnh.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxAnh.Image = null;
                }

                SetButtonState(false, true, true);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa vật liệu này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string deleteSql = string.Format("DELETE FROM VatLieu WHERE MaVL = '{0}'", txtMaVL.Text);
                connectData.UpdateData(deleteSql);
                LoadData();
                ClearInputFields();
                SetButtonState(true, false, false);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string updateSql = "UPDATE VatLieu SET TenVatLieu = '" + txtTenVatLieu.Text + "', " +
                   "DonViTinh = '" + txtDonViTinh.Text + "', " +
                   "GiaNhap = '" + txtGiaNhap.Text + "', " +
                   "GiaBan = '" + txtGiaBan.Text + "', " +
                   "SoLuong = '" + txtSoLuong.Text + "', " +
                   "Anh = '" + txtAnh + "', " +
                   "GhiChu = '" + txtGhiChu.Text + "' " +
                   "WHERE MaVL = '" + txtMaVL.Text + "'";
                connectData.UpdateData(updateSql);
                LoadData();
                ClearInputFields();
                SetButtonState(true, false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }
    }
}
