namespace GUI
{
    partial class QUANLYDIEM
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
            dataGridView2 = new DataGridView();
            xoa = new Button();
            chon = new Button();
            tim = new Button();
            label9 = new Label();
            mahv2 = new TextBox();
            groupBox1 = new GroupBox();
            sua = new Button();
            huy = new Button();
            them = new Button();
            label8 = new Label();
            mahv = new TextBox();
            kt2 = new TextBox();
            kt1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            diemthi = new TextBox();
            mamon = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 414);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(991, 698);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(xoa);
            groupBox2.Controls.Add(chon);
            groupBox2.Controls.Add(tim);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(mahv2);
            groupBox2.Location = new Point(174, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(991, 150);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(25, 68);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(927, 51);
            dataGridView2.TabIndex = 18;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // xoa
            // 
            xoa.Location = new Point(858, 33);
            xoa.Name = "xoa";
            xoa.Size = new Size(94, 29);
            xoa.TabIndex = 14;
            xoa.Text = "XÓA";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // chon
            // 
            chon.Location = new Point(731, 33);
            chon.Name = "chon";
            chon.Size = new Size(94, 29);
            chon.TabIndex = 17;
            chon.Text = "CHỌN";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // tim
            // 
            tim.Location = new Point(594, 29);
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
            label9.Location = new Point(25, 32);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 14;
            label9.Text = "Mã Học Viên";
            // 
            // mahv2
            // 
            mahv2.Location = new Point(125, 29);
            mahv2.Name = "mahv2";
            mahv2.Size = new Size(250, 27);
            mahv2.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(sua);
            groupBox1.Controls.Add(huy);
            groupBox1.Controls.Add(them);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(mahv);
            groupBox1.Controls.Add(kt2);
            groupBox1.Controls.Add(kt1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(diemthi);
            groupBox1.Controls.Add(mamon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(174, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(991, 195);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // sua
            // 
            sua.Location = new Point(25, 147);
            sua.Name = "sua";
            sua.Size = new Size(94, 29);
            sua.TabIndex = 16;
            sua.Text = "SỬA";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // huy
            // 
            huy.Location = new Point(281, 147);
            huy.Name = "huy";
            huy.Size = new Size(94, 29);
            huy.TabIndex = 2;
            huy.Text = "HỦY";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // them
            // 
            them.Location = new Point(147, 147);
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
            label8.Location = new Point(25, 32);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 13;
            label8.Text = "Mã Học Viên";
            // 
            // mahv
            // 
            mahv.Location = new Point(125, 27);
            mahv.Name = "mahv";
            mahv.Size = new Size(250, 27);
            mahv.TabIndex = 12;
            // 
            // kt2
            // 
            kt2.Location = new Point(702, 87);
            kt2.Name = "kt2";
            kt2.Size = new Size(250, 27);
            kt2.TabIndex = 11;
            // 
            // kt1
            // 
            kt1.Location = new Point(702, 27);
            kt1.Name = "kt1";
            kt1.Size = new Size(250, 27);
            kt1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(585, 89);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 9;
            label7.Text = "Điểm kiểm tra 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(585, 32);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 8;
            label6.Text = "Điểm kiểm tra 1";
            // 
            // diemthi
            // 
            diemthi.Location = new Point(702, 136);
            diemthi.Name = "diemthi";
            diemthi.Size = new Size(250, 27);
            diemthi.TabIndex = 7;
            // 
            // mamon
            // 
            mamon.Location = new Point(125, 87);
            mamon.Name = "mamon";
            mamon.Size = new Size(250, 27);
            mamon.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(585, 145);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 3;
            label5.Text = "Điểm Thi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Môn Học";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(544, 23);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 8;
            label1.Text = "QUẢN LÝ ĐIỂM SỐ";
            // 
            // QUANLYDIEM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1338, 845);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QUANLYDIEM";
            Text = "QUANLYDIEM";
            Load += QUANLYDIEM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button xoa;
        private Button chon;
        private Button tim;
        private Label label9;
        private TextBox mahv2;
        private GroupBox groupBox1;
        private Button sua;
        private Button huy;
        private Button them;
        private Label label8;
        private TextBox mahv;
        private TextBox kt2;
        private TextBox kt1;
        private Label label7;
        private Label label6;
        private TextBox diemthi;
        private TextBox mamon;
        private Label label5;
        private Label label2;
        private Label label1;
    }
}