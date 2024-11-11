namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pictureBoxAnh = new PictureBox();
            btnAnh = new Button();
            txtGhiChu = new TextBox();
            txtSoLuong = new TextBox();
            txtGiaBan = new TextBox();
            txtGiaNhap = new TextBox();
            txtDonViTinh = new TextBox();
            txtTenVatLieu = new TextBox();
            txtMaVL = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnBoQua = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvVatLieu = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVatLieu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxAnh);
            groupBox1.Controls.Add(btnAnh);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtDonViTinh);
            groupBox1.Controls.Add(txtTenVatLieu);
            groupBox1.Controls.Add(txtMaVL);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vật liệu";
            // 
            // pictureBoxAnh
            // 
            pictureBoxAnh.Location = new Point(763, 11);
            pictureBoxAnh.Name = "pictureBoxAnh";
            pictureBoxAnh.Size = new Size(235, 208);
            pictureBoxAnh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnh.TabIndex = 16;
            pictureBoxAnh.TabStop = false;
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(613, 28);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(89, 42);
            btnAnh.TabIndex = 15;
            btnAnh.Text = "Ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(746, 225);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(273, 37);
            txtGhiChu.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(111, 221);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(290, 27);
            txtSoLuong.TabIndex = 13;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(111, 180);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(290, 27);
            txtGiaBan.TabIndex = 12;
            txtGiaBan.KeyPress += txtGiaBan_KeyPress;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(111, 145);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(290, 27);
            txtGiaNhap.TabIndex = 11;
            txtGiaNhap.KeyPress += txtGiaNhap_KeyPress;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(111, 109);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(290, 27);
            txtDonViTinh.TabIndex = 10;
            // 
            // txtTenVatLieu
            // 
            txtTenVatLieu.Location = new Point(111, 72);
            txtTenVatLieu.Name = "txtTenVatLieu";
            txtTenVatLieu.Size = new Size(290, 27);
            txtTenVatLieu.TabIndex = 9;
            // 
            // txtMaVL
            // 
            txtMaVL.Location = new Point(111, 33);
            txtMaVL.Name = "txtMaVL";
            txtMaVL.Size = new Size(290, 27);
            txtMaVL.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(652, 228);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Ghi chú";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 228);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 187);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 148);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Giá nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 109);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 75);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên vật liệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã vật liệu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBoQua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(1, 506);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 98);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(638, 36);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(109, 41);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(456, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 41);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(256, 36);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(109, 41);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 41);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvVatLieu
            // 
            dgvVatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVatLieu.Location = new Point(1, 275);
            dgvVatLieu.Name = "dgvVatLieu";
            dgvVatLieu.RowHeadersWidth = 51;
            dgvVatLieu.Size = new Size(1176, 237);
            dgvVatLieu.TabIndex = 2;
            dgvVatLieu.SelectionChanged += dgvVatLieu_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 604);
            Controls.Add(dgvVatLieu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnh).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVatLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBoxAnh;
        private Button btnAnh;
        private TextBox txtGhiChu;
        private TextBox txtSoLuong;
        private TextBox txtGiaBan;
        private TextBox txtGiaNhap;
        private TextBox txtDonViTinh;
        private TextBox txtTenVatLieu;
        private TextBox txtMaVL;
        private GroupBox groupBox2;
        private Button btnBoQua;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvVatLieu;
    }
}
