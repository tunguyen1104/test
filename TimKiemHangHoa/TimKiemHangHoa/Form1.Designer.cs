namespace TimKiemHangHoa
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
            txtMaHang = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBoxChatLieu = new ComboBox();
            txtDonGiaTo = new TextBox();
            txtTenHang = new TextBox();
            txtDonGiaFrom = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            btnInExcel = new Button();
            btnExit = new Button();
            dataGridViewProducts = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(118, 26);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(349, 27);
            txtMaHang.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 27);
            label1.Name = "label1";
            label1.Size = new Size(292, 41);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm hàng hoá";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxChatLieu);
            groupBox1.Controls.Add(txtDonGiaTo);
            groupBox1.Controls.Add(txtTenHang);
            groupBox1.Controls.Add(txtDonGiaFrom);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaHang);
            groupBox1.Location = new Point(58, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1011, 131);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // comboBoxChatLieu
            // 
            comboBoxChatLieu.FormattingEnabled = true;
            comboBoxChatLieu.Location = new Point(722, 80);
            comboBoxChatLieu.Name = "comboBoxChatLieu";
            comboBoxChatLieu.Size = new Size(165, 28);
            comboBoxChatLieu.TabIndex = 12;
            // 
            // txtDonGiaTo
            // 
            txtDonGiaTo.Location = new Point(353, 77);
            txtDonGiaTo.Name = "txtDonGiaTo";
            txtDonGiaTo.Size = new Size(72, 27);
            txtDonGiaTo.TabIndex = 11;
            txtDonGiaTo.KeyPress += txtDonGiaTo_KeyPress;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(724, 35);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(163, 27);
            txtTenHang.TabIndex = 10;
            // 
            // txtDonGiaFrom
            // 
            txtDonGiaFrom.Location = new Point(176, 77);
            txtDonGiaFrom.Name = "txtDonGiaFrom";
            txtDonGiaFrom.Size = new Size(69, 27);
            txtDonGiaFrom.TabIndex = 9;
            txtDonGiaFrom.KeyPress += txtDonGiaFrom_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(617, 83);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 8;
            label8.Text = "Chất liệu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(431, 80);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "(VNĐ)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(251, 80);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 6;
            label6.Text = "(VNĐ) đến";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(141, 80);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 5;
            label5.Text = "từ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 33);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "Tên Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 80);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá bán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 26);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã Hàng";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(99, 237);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnInExcel
            // 
            btnInExcel.Location = new Point(234, 237);
            btnInExcel.Name = "btnInExcel";
            btnInExcel.Size = new Size(97, 35);
            btnInExcel.TabIndex = 4;
            btnInExcel.Text = "In ra Excel";
            btnInExcel.UseVisualStyleBackColor = true;
            btnInExcel.Click += btnInExcel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(368, 237);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(35, 289);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(1054, 270);
            dataGridViewProducts.TabIndex = 6;
            dataGridViewProducts.CellDoubleClick += dataGridViewProducts_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 571);
            Controls.Add(dataGridViewProducts);
            Controls.Add(btnExit);
            Controls.Add(btnInExcel);
            Controls.Add(btnSearch);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHang;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBoxChatLieu;
        private TextBox txtDonGiaTo;
        private TextBox txtTenHang;
        private TextBox txtDonGiaFrom;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSearch;
        private Button btnInExcel;
        private Button btnExit;
        private DataGridView dataGridViewProducts;
    }
}
