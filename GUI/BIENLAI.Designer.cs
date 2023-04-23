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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(575, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 0;
            label1.Text = "Biên Lai Học Phí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 32);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Người Đóng";
            // 
            // nguoidong
            // 
            nguoidong.Location = new Point(214, 32);
            nguoidong.Margin = new Padding(3, 2, 3, 2);
            nguoidong.Multiline = true;
            nguoidong.Name = "nguoidong";
            nguoidong.Size = new Size(250, 24);
            nguoidong.TabIndex = 2;
            // 
            // mahv
            // 
            mahv.Location = new Point(650, 32);
            mahv.Margin = new Padding(3, 2, 3, 2);
            mahv.Multiline = true;
            mahv.Name = "mahv";
            mahv.Size = new Size(250, 24);
            mahv.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(494, 32);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 3;
            label3.Text = "Mã Học Viên";
            // 
            // sotien
            // 
            sotien.Location = new Point(214, 94);
            sotien.Margin = new Padding(3, 2, 3, 2);
            sotien.Multiline = true;
            sotien.Name = "sotien";
            sotien.Size = new Size(250, 24);
            sotien.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 94);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 5;
            label4.Text = "Số Tiền";
            // 
            // ngaydong
            // 
            ngaydong.Location = new Point(650, 97);
            ngaydong.Margin = new Padding(3, 2, 3, 2);
            ngaydong.Name = "ngaydong";
            ngaydong.Size = new Size(250, 23);
            ngaydong.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(494, 94);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 8;
            label5.Text = "Ngày Đóng";
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(205, 33);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(948, 182);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Biên Lai";
            // 
            // xoa
            // 
            xoa.Location = new Point(650, 140);
            xoa.Margin = new Padding(3, 2, 3, 2);
            xoa.Name = "xoa";
            xoa.Size = new Size(93, 31);
            xoa.TabIndex = 10;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // sua
            // 
            sua.Location = new Point(491, 140);
            sua.Margin = new Padding(3, 2, 3, 2);
            sua.Name = "sua";
            sua.Size = new Size(93, 31);
            sua.TabIndex = 9;
            sua.Text = "Sửa";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // xacnhan
            // 
            xacnhan.Location = new Point(807, 140);
            xacnhan.Margin = new Padding(3, 2, 3, 2);
            xacnhan.Name = "xacnhan";
            xacnhan.Size = new Size(93, 31);
            xacnhan.TabIndex = 7;
            xacnhan.Text = "Xác Nhận";
            xacnhan.UseVisualStyleBackColor = true;
            xacnhan.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 386);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(948, 396);
            dataGridView1.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chon);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(id);
            groupBox2.Location = new Point(205, 229);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(948, 62);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // chon
            // 
            chon.Location = new Point(344, 22);
            chon.Margin = new Padding(3, 2, 3, 2);
            chon.Name = "chon";
            chon.Size = new Size(82, 22);
            chon.TabIndex = 9;
            chon.Text = "Chọn ";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 20);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 6;
            label6.Text = "Mã Biên Lai";
            // 
            // id
            // 
            id.Location = new Point(118, 20);
            id.Margin = new Padding(3, 2, 3, 2);
            id.Name = "id";
            id.Size = new Size(172, 23);
            id.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(huy);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(mahv2);
            groupBox3.Location = new Point(205, 306);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(948, 62);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // huy
            // 
            huy.Location = new Point(501, 22);
            huy.Margin = new Padding(3, 2, 3, 2);
            huy.Name = "huy";
            huy.Size = new Size(82, 22);
            huy.TabIndex = 9;
            huy.Text = "Hủy";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // button4
            // 
            button4.Location = new Point(344, 22);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 8;
            button4.Text = "Tìm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 20);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 6;
            label7.Text = "Mã Học Viên";
            // 
            // mahv2
            // 
            mahv2.Location = new Point(118, 20);
            mahv2.Margin = new Padding(3, 2, 3, 2);
            mahv2.Name = "mahv2";
            mahv2.Size = new Size(172, 23);
            mahv2.TabIndex = 0;
            // 
            // BIENLAI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 634);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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