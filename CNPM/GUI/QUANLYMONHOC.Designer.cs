namespace GUI
{
    partial class QUANLYMONHOC
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
            label10 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            mamon2 = new TextBox();
            xoa = new Button();
            label4 = new Label();
            chon = new Button();
            tim = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            makh = new TextBox();
            hocphi = new TextBox();
            sobuoi = new TextBox();
            button1 = new Button();
            sua = new Button();
            mamon = new TextBox();
            label3 = new Label();
            them = new Button();
            tenmon = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(662, 9);
            label10.Name = "label10";
            label10.Size = new Size(271, 38);
            label10.TabIndex = 12;
            label10.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(270, 352);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(991, 270);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(mamon2);
            groupBox2.Controls.Add(xoa);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(chon);
            groupBox2.Controls.Add(tim);
            groupBox2.Location = new Point(270, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(991, 84);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // mamon2
            // 
            mamon2.Location = new Point(199, 16);
            mamon2.Multiline = true;
            mamon2.Name = "mamon2";
            mamon2.Size = new Size(250, 48);
            mamon2.TabIndex = 20;
            // 
            // xoa
            // 
            xoa.Location = new Point(855, 23);
            xoa.Name = "xoa";
            xoa.Size = new Size(115, 43);
            xoa.TabIndex = 19;
            xoa.Text = "XÓA";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 25);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 19;
            label4.Text = "Mã Môn Học";
            // 
            // chon
            // 
            chon.Location = new Point(702, 21);
            chon.Name = "chon";
            chon.Size = new Size(115, 43);
            chon.TabIndex = 18;
            chon.Text = "CHỌN";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // tim
            // 
            tim.Location = new Point(555, 21);
            tim.Name = "tim";
            tim.Size = new Size(115, 43);
            tim.TabIndex = 17;
            tim.Text = "TÌM";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(makh);
            groupBox1.Controls.Add(hocphi);
            groupBox1.Controls.Add(sobuoi);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(sua);
            groupBox1.Controls.Add(mamon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(them);
            groupBox1.Controls.Add(tenmon);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(270, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(991, 195);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(520, 156);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 27;
            label7.Text = "Mã Khóa Học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(506, 156);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(520, 90);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 25;
            label5.Text = "Học Phí";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(520, 29);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 24;
            label1.Text = "Số Buổi";
            // 
            // makh
            // 
            makh.Location = new Point(656, 149);
            makh.Multiline = true;
            makh.Name = "makh";
            makh.Size = new Size(117, 38);
            makh.TabIndex = 23;
            // 
            // hocphi
            // 
            hocphi.Location = new Point(656, 90);
            hocphi.Multiline = true;
            hocphi.Name = "hocphi";
            hocphi.Size = new Size(117, 38);
            hocphi.TabIndex = 22;
            // 
            // sobuoi
            // 
            sobuoi.Location = new Point(656, 25);
            sobuoi.Multiline = true;
            sobuoi.Name = "sobuoi";
            sobuoi.Size = new Size(117, 38);
            sobuoi.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(855, 141);
            button1.Name = "button1";
            button1.Size = new Size(115, 43);
            button1.TabIndex = 20;
            button1.Text = "HỦY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sua
            // 
            sua.Location = new Point(855, 85);
            sua.Name = "sua";
            sua.Size = new Size(115, 43);
            sua.TabIndex = 17;
            sua.Text = "SỬA";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // mamon
            // 
            mamon.Location = new Point(199, 33);
            mamon.Multiline = true;
            mamon.Name = "mamon";
            mamon.ReadOnly = true;
            mamon.Size = new Size(250, 38);
            mamon.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 43);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 17;
            label3.Text = "Mã Môn Học";
            // 
            // them
            // 
            them.Location = new Point(855, 25);
            them.Name = "them";
            them.Size = new Size(115, 43);
            them.TabIndex = 16;
            them.Text = "THÊM";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // tenmon
            // 
            tenmon.Location = new Point(199, 141);
            tenmon.Multiline = true;
            tenmon.Name = "tenmon";
            tenmon.Size = new Size(250, 38);
            tenmon.TabIndex = 4;
            tenmon.TextChanged += tenmon_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 147);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên Môn Học";
            // 
            // QUANLYMONHOC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1488, 634);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QUANLYMONHOC";
            Text = "QUANLYMONHOC";
            Load += QUANLYMONHOC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox mamon2;
        private Button xoa;
        private Label label4;
        private Button chon;
        private Button tim;
        private GroupBox groupBox1;
        private Button button1;
        private Button sua;
        private TextBox mamon;
        private Label label3;
        private Button them;
        private TextBox tenmon;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox makh;
        private TextBox hocphi;
        private TextBox sobuoi;
        private Label label7;
    }
}