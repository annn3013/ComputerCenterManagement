namespace GUI
{
    partial class QUANLYNHANVIEN
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            xoa = new Button();
            chon = new Button();
            tim = new Button();
            label9 = new Label();
            manv2 = new TextBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            sua = new Button();
            huy = new Button();
            them = new Button();
            label8 = new Label();
            manv = new TextBox();
            sdt = new TextBox();
            diachi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            chucvu = new TextBox();
            gioitinh = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            hoten = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            huy2 = new Button();
            tim2 = new Button();
            label11 = new Label();
            hoten2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(229, 409);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(991, 673);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(xoa);
            groupBox2.Controls.Add(chon);
            groupBox2.Controls.Add(tim);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(manv2);
            groupBox2.Location = new Point(229, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(991, 67);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // xoa
            // 
            xoa.Location = new Point(790, 29);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 14;
            xoa.Text = "XÓA";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // chon
            // 
            chon.Location = new Point(617, 29);
            chon.Name = "chon";
            chon.Size = new Size(94, 29);
            chon.TabIndex = 17;
            chon.Text = "CHỌN";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // tim
            // 
            tim.Location = new Point(449, 29);
            tim.Name = "tim";
            tim.Size = new Size(94, 29);
            tim.TabIndex = 16;
            tim.Text = "TÌM";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(25, 33);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 14;
            label9.Text = "Mã Nhân Viên";
            // 
            // manv2
            // 
            manv2.Location = new Point(152, 29);
            manv2.Name = "manv2";
            manv2.Size = new Size(250, 27);
            manv2.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(sua);
            groupBox1.Controls.Add(huy);
            groupBox1.Controls.Add(them);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(manv);
            groupBox1.Controls.Add(sdt);
            groupBox1.Controls.Add(diachi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(chucvu);
            groupBox1.Controls.Add(gioitinh);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(hoten);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(229, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(991, 195);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(585, 35);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 17;
            label10.Text = "Địa chỉ";
            // 
            // sua
            // 
            sua.Location = new Point(585, 156);
            sua.Name = "sua";
            sua.Size = new Size(94, 29);
            sua.TabIndex = 16;
            sua.Text = "SỬA";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // huy
            // 
            huy.Location = new Point(858, 156);
            huy.Name = "huy";
            huy.Size = new Size(94, 29);
            huy.TabIndex = 2;
            huy.Text = "HỦY";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // them
            // 
            them.Location = new Point(734, 156);
            them.Name = "them";
            them.Size = new Size(94, 29);
            them.TabIndex = 15;
            them.Text = "THÊM";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 35);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 13;
            label8.Text = "Mã Nhân Viên";
            // 
            // manv
            // 
            manv.Location = new Point(152, 27);
            manv.Name = "manv";
            manv.ReadOnly = true;
            manv.Size = new Size(250, 27);
            manv.TabIndex = 12;
            // 
            // sdt
            // 
            sdt.Location = new Point(702, 68);
            sdt.Name = "sdt";
            sdt.Size = new Size(250, 27);
            sdt.TabIndex = 11;
            // 
            // diachi
            // 
            diachi.Location = new Point(702, 27);
            diachi.Name = "diachi";
            diachi.Size = new Size(250, 27);
            diachi.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(585, 75);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 9;
            label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(585, 33);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 8;
            // 
            // chucvu
            // 
            chucvu.Location = new Point(702, 113);
            chucvu.Name = "chucvu";
            chucvu.Size = new Size(250, 27);
            chucvu.TabIndex = 7;
            // 
            // gioitinh
            // 
            gioitinh.FormattingEnabled = true;
            gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioitinh.Location = new Point(152, 107);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(250, 28);
            gioitinh.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // hoten
            // 
            hoten.Location = new Point(152, 67);
            hoten.Name = "hoten";
            hoten.Size = new Size(250, 27);
            hoten.TabIndex = 4;
            hoten.TextChanged += hoten_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(585, 120);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 3;
            label5.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 160);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 2;
            label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 116);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 1;
            label3.Text = "Giới Tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(599, 27);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 8;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(huy2);
            groupBox3.Controls.Add(tim2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(hoten2);
            groupBox3.Location = new Point(229, 327);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(991, 67);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(790, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "CHỌN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // huy2
            // 
            huy2.Location = new Point(617, 27);
            huy2.Name = "huy2";
            huy2.Size = new Size(94, 29);
            huy2.TabIndex = 14;
            huy2.Text = "HỦY";
            huy2.UseVisualStyleBackColor = true;
            huy2.Click += huy2_Click;
            // 
            // tim2
            // 
            tim2.Location = new Point(449, 29);
            tim2.Name = "tim2";
            tim2.Size = new Size(94, 29);
            tim2.TabIndex = 16;
            tim2.Text = "TÌM";
            tim2.UseVisualStyleBackColor = true;
            tim2.Click += tim2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(25, 29);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 14;
            label11.Text = "Tên Nhân Viên";
            // 
            // hoten2
            // 
            hoten2.Location = new Point(152, 27);
            hoten2.Name = "hoten2";
            hoten2.Size = new Size(250, 27);
            hoten2.TabIndex = 13;
            // 
            // QUANLYNHANVIEN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1449, 845);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "QUANLYNHANVIEN";
            Text = "QUANLYNHANVIEN";
            Load += QUANLYNHANVIEN_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button xoa;
        private Button chon;
        private Button tim;
        private Label label9;
        private TextBox manv2;
        private GroupBox groupBox1;
        private Label label10;
        private Button sua;
        private Button huy;
        private Button them;
        private Label label8;
        private TextBox manv;
        private TextBox sdt;
        private TextBox diachi;
        private Label label7;
        private Label label6;
        private TextBox chucvu;
        private ComboBox gioitinh;
        private DateTimePicker dateTimePicker1;
        private TextBox hoten;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button huy2;
        private Button tim2;
        private Label label11;
        private TextBox hoten2;
        private Button button1;
    }
}