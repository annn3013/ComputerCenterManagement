namespace GUI
{
    partial class THONGKEHOCPHI
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
            groupBox2 = new GroupBox();
            dongdu2 = new Button();
            dongdu = new Button();
            dongthieu = new Button();
            label6 = new Label();
            chuadong = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tim = new Button();
            hoten = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            cancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(520, 7);
            label1.Name = "label1";
            label1.Size = new Size(242, 32);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ HỌC PHÍ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(cancel);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(tim);
            groupBox1.Controls.Add(hoten);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(73, 62);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1141, 164);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dongdu2);
            groupBox2.Controls.Add(dongdu);
            groupBox2.Controls.Add(dongthieu);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(chuadong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(27, 58);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(628, 86);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // dongdu2
            // 
            dongdu2.Location = new Point(508, 44);
            dongdu2.Margin = new Padding(3, 2, 3, 2);
            dongdu2.Name = "dongdu2";
            dongdu2.Size = new Size(82, 28);
            dongdu2.TabIndex = 9;
            dongdu2.Text = "HIỆN";
            dongdu2.UseVisualStyleBackColor = true;
            dongdu2.Click += dongdu2_Click;
            // 
            // dongdu
            // 
            dongdu.Location = new Point(358, 44);
            dongdu.Margin = new Padding(3, 2, 3, 2);
            dongdu.Name = "dongdu";
            dongdu.Size = new Size(82, 28);
            dongdu.TabIndex = 8;
            dongdu.Text = "HIỆN";
            dongdu.UseVisualStyleBackColor = true;
            dongdu.Click += dongdu_Click;
            // 
            // dongthieu
            // 
            dongthieu.Location = new Point(183, 44);
            dongthieu.Margin = new Padding(3, 2, 3, 2);
            dongthieu.Name = "dongthieu";
            dongthieu.Size = new Size(82, 28);
            dongthieu.TabIndex = 7;
            dongthieu.Text = "HIỆN";
            dongthieu.UseVisualStyleBackColor = true;
            dongthieu.Click += dongthieu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(508, 17);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 4;
            label6.Text = "Đóng dư";
            // 
            // chuadong
            // 
            chuadong.Location = new Point(27, 44);
            chuadong.Margin = new Padding(3, 2, 3, 2);
            chuadong.Name = "chuadong";
            chuadong.Size = new Size(82, 28);
            chuadong.TabIndex = 6;
            chuadong.Text = "HIỆN";
            chuadong.UseVisualStyleBackColor = true;
            chuadong.Click += chuadong_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 17);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Đóng Đủ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 17);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 2;
            label4.Text = "Đóng thiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 17);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "Chưa Đóng";
            // 
            // tim
            // 
            tim.Location = new Point(260, 18);
            tim.Margin = new Padding(3, 2, 3, 2);
            tim.Name = "tim";
            tim.Size = new Size(82, 22);
            tim.TabIndex = 2;
            tim.Text = "TÌM";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // hoten
            // 
            hoten.Location = new Point(122, 20);
            hoten.Margin = new Padding(3, 2, 3, 2);
            hoten.Name = "hoten";
            hoten.Size = new Size(110, 23);
            hoten.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 22);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên Học Viên";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 255);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1141, 544);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cancel
            // 
            cancel.Location = new Point(385, 15);
            cancel.Margin = new Padding(3, 2, 3, 2);
            cancel.Name = "cancel";
            cancel.Size = new Size(82, 22);
            cancel.TabIndex = 8;
            cancel.Text = "CANCEL";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // THONGKEHOCPHI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 634);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "THONGKEHOCPHI";
            Text = "THONGKEHOCPHI";
            Load += THONGKEHOCPHI_Load;
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
        private Label label2;
        private TextBox hoten;
        private Button tim;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button dongdu2;
        private Button dongdu;
        private Button dongthieu;
        private Label label6;
        private Button chuadong;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button cancel;
    }
}