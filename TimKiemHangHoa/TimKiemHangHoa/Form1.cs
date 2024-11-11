using System.Data;
using WinFormsApp1.Classes;
using ClosedXML.Excel;

namespace TimKiemHangHoa
{
    public partial class Form1 : Form
    {
        private ConnectData connectData = new ConnectData();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadChatLieu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoadChatLieu()
        {
            string sql = "SELECT TenChatLieu, MaChatLieu FROM tblChatLieu";
            DataTable dt = connectData.ReadData(sql);
            comboBoxChatLieu.DataSource = dt;
            comboBoxChatLieu.DisplayMember = "TenChatLieu";
            comboBoxChatLieu.ValueMember = "MaChatLieu";
        }
        private void txtDonGiaFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGiaTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text.Trim();
            string tenHang = txtTenHang.Text.Trim();
            string maChatLieu = comboBoxChatLieu.SelectedValue.ToString();
            string donGiaFrom = txtDonGiaFrom.Text.Trim();
            string donGiaTo = txtDonGiaTo.Text.Trim();

            // Điều kiện "WHERE 1=1" giúp dễ dàng thêm các điều kiện sau
            string sql = "SELECT MaHang, TenHang, tblChatLieu.TenChatLieu, DonGiaNhap, DonGiaBan, SoLuong FROM tblHang " +
                 "JOIN tblChatLieu ON tblHang.MaChatLieu = tblChatLieu.MaChatLieu WHERE 1=1";

            if (!string.IsNullOrEmpty(maHang))
                sql += " AND MaHang LIKE '%" + maHang + "%'";
            if (!string.IsNullOrEmpty(tenHang))
                sql += " AND TenHang LIKE '%" + tenHang + "%'";
            if (!string.IsNullOrEmpty(maChatLieu))
                sql += " AND tblHang.MaChatLieu = '" + maChatLieu + "'";
            if (!string.IsNullOrEmpty(donGiaFrom))
                sql += " AND DonGiaBan >= " + donGiaFrom;
            if (!string.IsNullOrEmpty(donGiaTo))
                sql += " AND DonGiaBan <= " + donGiaTo;

            DataTable dt = connectData.ReadData(sql);
            dataGridViewProducts.DataSource = dt;
        }

        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string chatLieu = dataGridViewProducts.Rows[e.RowIndex].Cells["TenChatLieu"].Value.ToString();

            string sql = $"SELECT COUNT(*) FROM tblHang WHERE MaChatLieu = (SELECT MaChatLieu FROM tblChatLieu WHERE TenChatLieu = N'{chatLieu}')";

            DataTable dt = connectData.ReadData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show($"Có {dt.Rows[0][0]} mặt hàng có chất liệu {chatLieu}.", "Thông tin", MessageBoxButtons.OK);
            }
        }
        private void btnInExcel_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu trong DataGridView
            if (dataGridViewProducts.DataSource == null || dataGridViewProducts.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Tạo workbook và worksheet với ClosedXML
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Danh sách sản phẩm");

                // Đặt tiêu đề
                worksheet.Cell("A1").Value = "HANG HOA";
                worksheet.Cell("A1").Style.Font.Bold = true;
                worksheet.Cell("A1").Style.Font.FontSize = 15;
                worksheet.Cell("A1").Style.Font.FontColor = XLColor.Blue;

                // Thêm thông tin vào Excel
                worksheet.Cell("A5").Value = "Mã hàng: " + txtMaHang.Text ?? "";
                worksheet.Cell("A6").Value = "Tên hàng: " + txtTenHang.Text ?? "";
                worksheet.Cell("A7").Value = "Chất liệu: " + comboBoxChatLieu.Text ?? "";
                worksheet.Cell("A8").Value = "Đơn giá bán từ: " + txtDonGiaFrom.Text ?? "" + " đến " + txtDonGiaTo.Text ?? "";

                // Đặt tiêu đề cột
                worksheet.Cell("A10").Value = "STT";
                worksheet.Cell("B10").Value = "Mã hàng";
                worksheet.Cell("C10").Value = "Tên hàng";
                worksheet.Cell("D10").Value = "Chất liệu";
                worksheet.Cell("E10").Value = "Giá nhập";
                worksheet.Cell("F10").Value = "Giá bán";
                worksheet.Cell("G10").Value = "Số lượng";
                worksheet.Range("A10:G10").Style.Font.Bold = true;

                // Thêm dữ liệu từ DataGridView vào Excel
                int line = 11;
                for (int i = 0; i < dataGridViewProducts.Rows.Count; i++)
                {
                    worksheet.Cell("A" + (line + i)).Value = (i + 1).ToString();
                    worksheet.Cell("B" + (line + i)).Value = dataGridViewProducts.Rows[i].Cells[0].Value?.ToString() ?? string.Empty;
                    worksheet.Cell("C" + (line + i)).Value = dataGridViewProducts.Rows[i].Cells[1].Value?.ToString() ?? string.Empty;
                    worksheet.Cell("D" + (line + i)).Value = dataGridViewProducts.Rows[i].Cells[2].Value?.ToString() ?? string.Empty;
                    worksheet.Cell("E" + (line + i)).Value = dataGridViewProducts.Rows[i].Cells[3].Value?.ToString() ?? string.Empty;
                    worksheet.Cell("F" + (line + i)).Value = dataGridViewProducts.Rows[i].Cells[4].Value?.ToString() ?? string.Empty;
                    worksheet.Cell("G" + (line + i)).Value = dataGridViewProducts.Rows[i].Cells[5].Value?.ToString() ?? string.Empty;
                }

                // Tự động điều chỉnh độ rộng cột
                worksheet.Columns().AdjustToContents();

                // Mở hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = "DanhSachSanPham.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
