namespace GUI
{
    partial class QUANLYLOPHOC
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            xoa = new Button();
            sua = new Button();
            huy = new Button();
            them = new Button();
            ngayketthuc = new DateTimePicker();
            ngaybatdau = new DateTimePicker();
            ca = new TextBox();
            siso = new TextBox();
            mamon = new TextBox();
            maphong = new TextBox();
            tenlop = new TextBox();
            malop = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            tim = new Button();
            malop2 = new TextBox();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(499, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(xoa);
            groupBox1.Controls.Add(sua);
            groupBox1.Controls.Add(huy);
            groupBox1.Controls.Add(them);
            groupBox1.Controls.Add(ngayketthuc);
            groupBox1.Controls.Add(ngaybatdau);
            groupBox1.Controls.Add(ca);
            groupBox1.Controls.Add(siso);
            groupBox1.Controls.Add(mamon);
            groupBox1.Controls.Add(maphong);
            groupBox1.Controls.Add(tenlop);
            groupBox1.Controls.Add(malop);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // xoa
            // 
            xoa.Anchor = AnchorStyles.Top;
            xoa.Location = new Point(428, 192);
            xoa.Name = "xoa";
            xoa.Size = new Size(112, 36);
            xoa.TabIndex = 21;
            xoa.Text = "XÓA";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Anchor = AnchorStyles.Top;
            sua.Location = new Point(624, 192);
            sua.Name = "sua";
            sua.Size = new Size(112, 36);
            sua.TabIndex = 20;
            sua.Text = "SỬA";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // huy
            // 
            huy.Anchor = AnchorStyles.Top;
            huy.Location = new Point(811, 192);
            huy.Name = "huy";
            huy.Size = new Size(112, 36);
            huy.TabIndex = 19;
            huy.Text = "HỦY";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // them
            // 
            them.Anchor = AnchorStyles.Top;
            them.Location = new Point(1012, 192);
            them.Name = "them";
            them.Size = new Size(112, 36);
            them.TabIndex = 18;
            them.Text = "THÊM";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // ngayketthuc
            // 
            ngayketthuc.Anchor = AnchorStyles.Top;
            ngayketthuc.Location = new Point(929, 85);
            ngayketthuc.Name = "ngayketthuc";
            ngayketthuc.Size = new Size(195, 23);
            ngayketthuc.TabIndex = 17;
            // 
            // ngaybatdau
            // 
            ngaybatdau.Anchor = AnchorStyles.Top;
            ngaybatdau.Location = new Point(929, 30);
            ngaybatdau.Name = "ngaybatdau";
            ngaybatdau.Size = new Size(195, 23);
            ngaybatdau.TabIndex = 16;
            // 
            // ca
            // 
            ca.Anchor = AnchorStyles.Top;
            ca.Location = new Point(929, 140);
            ca.Multiline = true;
            ca.Name = "ca";
            ca.Size = new Size(78, 29);
            ca.TabIndex = 15;
            // 
            // siso
            // 
            siso.Anchor = AnchorStyles.Top;
            siso.Location = new Point(121, 140);
            siso.Multiline = true;
            siso.Name = "siso";
            siso.Size = new Size(78, 29);
            siso.TabIndex = 13;
            // 
            // mamon
            // 
            mamon.Anchor = AnchorStyles.Top;
            mamon.Location = new Point(531, 88);
            mamon.Multiline = true;
            mamon.Name = "mamon";
            mamon.Size = new Size(246, 29);
            mamon.TabIndex = 12;
            // 
            // maphong
            // 
            maphong.Anchor = AnchorStyles.Top;
            maphong.Location = new Point(531, 27);
            maphong.Multiline = true;
            maphong.Name = "maphong";
            maphong.Size = new Size(246, 29);
            maphong.TabIndex = 11;
            // 
            // tenlop
            // 
            tenlop.Anchor = AnchorStyles.Top;
            tenlop.Location = new Point(121, 88);
            tenlop.Multiline = true;
            tenlop.Name = "tenlop";
            tenlop.Size = new Size(246, 29);
            tenlop.TabIndex = 10;
            tenlop.TextChanged += tenlop_TextChanged;
            // 
            // malop
            // 
            malop.Anchor = AnchorStyles.Top;
            malop.Location = new Point(121, 27);
            malop.Multiline = true;
            malop.Name = "malop";
            malop.ReadOnly = true;
            malop.Size = new Size(246, 29);
            malop.TabIndex = 9;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(839, 91);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 8;
            label10.Text = "Ngày Kết Thúc";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(839, 33);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 7;
            label9.Text = "Ngày Bắt Đầu";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(428, 91);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 5;
            label7.Text = "Mã Môn Học";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(428, 33);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 4;
            label6.Text = "Mã Phòng Học";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(839, 143);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 3;
            label5.Text = "Ca Học";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(28, 143);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 2;
            label4.Text = "Sĩ Số";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(27, 91);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Lớp Học";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(28, 30);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Lớp Học";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(tim);
            groupBox2.Controls.Add(malop2);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(22, 289);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1131, 73);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(1013, 20);
            button2.Name = "button2";
            button2.Size = new Size(112, 36);
            button2.TabIndex = 23;
            button2.Text = "CHỌN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tim
            // 
            tim.Anchor = AnchorStyles.Top;
            tim.Location = new Point(812, 20);
            tim.Name = "tim";
            tim.Size = new Size(112, 36);
            tim.TabIndex = 22;
            tim.Text = "TÌM";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // malop2
            // 
            malop2.Anchor = AnchorStyles.Top;
            malop2.Location = new Point(122, 20);
            malop2.Multiline = true;
            malop2.Name = "malop2";
            malop2.Size = new Size(246, 29);
            malop2.TabIndex = 12;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(28, 23);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 11;
            label11.Text = "Mã Lớp Học";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(23, 368);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1130, 265);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // QUANLYLOPHOC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 645);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "QUANLYLOPHOC";
            Text = "QUANLYLOPHOC";
            Load += QUANLYLOPHOC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button xoa;
        private Button sua;
        private Button huy;
        private Button them;
        private DateTimePicker ngayketthuc;
        private DateTimePicker ngaybatdau;
        private TextBox ca;
        private TextBox siso;
        private TextBox mamon;
        private TextBox maphong;
        private TextBox tenlop;
        private TextBox malop;
        private Label label10;
        private GroupBox groupBox2;
        private Button button2;
        private Button tim;
        private TextBox malop2;
        private Label label11;
        private DataGridView dataGridView1;
    }
}