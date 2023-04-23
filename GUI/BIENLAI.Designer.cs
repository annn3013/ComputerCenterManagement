namespace GUI
{
    partial class BIENLAI
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
            label2 = new Label();
            nguoidong = new TextBox();
            mahv = new TextBox();
            label3 = new Label();
            sotien = new TextBox();
            label4 = new Label();
            ngaydong = new DateTimePicker();
            label5 = new Label();
            groupBox1 = new GroupBox();
            xoa = new Button();
            sua = new Button();
            xacnhan = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            chon = new Button();
            label6 = new Label();
            id = new TextBox();
            groupBox3 = new GroupBox();
            huy = new Button();
            button4 = new Button();
            label7 = new Label();
            mahv2 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(657, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 41);
            label1.TabIndex = 0;
            label1.Text = "Biên Lai Học Phí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 43);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 1;
            label2.Text = "Tên Người Đóng";
            // 
            // nguoidong
            // 
            nguoidong.Location = new Point(245, 43);
            nguoidong.Multiline = true;
            nguoidong.Name = "nguoidong";
            nguoidong.Size = new Size(285, 31);
            nguoidong.TabIndex = 2;
            // 
            // mahv
            // 
            mahv.Location = new Point(743, 43);
            mahv.Multiline = true;
            mahv.Name = "mahv";
            mahv.Size = new Size(285, 31);
            mahv.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(565, 43);
            label3.Name = "label3";
            label3.Size = new Size(151, 31);
            label3.TabIndex = 3;
            label3.Text = "Mã Học Viên";
            // 
            // sotien
            // 
            sotien.Location = new Point(245, 125);
            sotien.Multiline = true;
            sotien.Name = "sotien";
            sotien.Size = new Size(285, 31);
            sotien.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 125);
            label4.Name = "label4";
            label4.Size = new Size(93, 31);
            label4.TabIndex = 5;
            label4.Text = "Số Tiền";
            // 
            // ngaydong
            // 
            ngaydong.Location = new Point(743, 129);
            ngaydong.Name = "ngaydong";
            ngaydong.Size = new Size(285, 27);
            ngaydong.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(565, 125);
            label5.Name = "label5";
            label5.Size = new Size(135, 31);
            label5.TabIndex = 8;
            label5.Text = "Ngày Đóng";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(xoa);
            groupBox1.Controls.Add(sua);
            groupBox1.Controls.Add(nguoidong);
            groupBox1.Controls.Add(xacnhan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ngaydong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(sotien);
            groupBox1.Controls.Add(mahv);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(234, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1083, 243);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Biên Lai";
            // 
            // xoa
            // 
            xoa.Location = new Point(743, 187);
            xoa.Name = "xoa";
            xoa.Size = new Size(106, 41);
            xoa.TabIndex = 10;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(561, 187);
            sua.Name = "sua";
            sua.Size = new Size(106, 41);
            sua.TabIndex = 9;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // xacnhan
            // 
            xacnhan.Location = new Point(922, 187);
            xacnhan.Name = "xacnhan";
            xacnhan.Size = new Size(106, 41);
            xacnhan.TabIndex = 7;
            xacnhan.Text = "Xác Nhận";
            xacnhan.UseVisualStyleBackColor = true;
            xacnhan.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(240, 515);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1083, 528);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(chon);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(id);
            groupBox2.Location = new Point(234, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1083, 83);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // chon
            // 
            chon.Location = new Point(393, 20);
            chon.Name = "chon";
            chon.Size = new Size(94, 37);
            chon.TabIndex = 9;
            chon.Text = "Chọn ";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 27);
            label6.Name = "label6";
            label6.Size = new Size(123, 28);
            label6.TabIndex = 6;
            label6.Text = "Mã Biên Lai";
            // 
            // id
            // 
            id.Location = new Point(135, 27);
            id.Name = "id";
            id.Size = new Size(196, 27);
            id.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(huy);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(mahv2);
            groupBox3.Location = new Point(234, 408);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1083, 83);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // huy
            // 
            huy.Location = new Point(573, 13);
            huy.Name = "huy";
            huy.Size = new Size(94, 44);
            huy.TabIndex = 9;
            huy.Text = "Hủy";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // button4
            // 
            button4.Location = new Point(393, 13);
            button4.Name = "button4";
            button4.Size = new Size(94, 44);
            button4.TabIndex = 8;
            button4.Text = "Tìm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 27);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 6;
            label7.Text = "Mã Học Viên";
            // 
            // mahv2
            // 
            mahv2.Location = new Point(135, 27);
            mahv2.Name = "mahv2";
            mahv2.Size = new Size(196, 27);
            mahv2.TabIndex = 0;
            // 
            // BIENLAI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1475, 845);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "BIENLAI";
            Text = "BIÊN LAI";
            Load += BIENLAI_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nguoidong;
        private TextBox mahv;
        private Label label3;
        private TextBox sotien;
        private Label label4;
        private DateTimePicker ngaydong;
        private Label label5;
        private GroupBox groupBox1;
        private Button xacnhan;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button chon;
        private Label label6;
        private TextBox id;
        private Button xoa;
        private Button sua;
        private GroupBox groupBox3;
        private Button button4;
        private Label label7;
        private TextBox mahv2;
        private Button huy;
    }
}