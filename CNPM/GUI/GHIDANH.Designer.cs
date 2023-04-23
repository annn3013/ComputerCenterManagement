namespace GUI
{
    partial class GHIDANH
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            chon2 = new Button();
            groupBox1 = new GroupBox();
            tim = new Button();
            mahv = new TextBox();
            huy = new Button();
            chon = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox3 = new GroupBox();
            xoa = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView3 = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(702, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÍ LỚP HỌC";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(chon2);
            groupBox2.Location = new Point(797, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(669, 356);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp Học";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.GridColor = SystemColors.Control;
            dataGridView2.Location = new Point(3, 84);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(663, 269);
            dataGridView2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 25);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Lớp Học";
            // 
            // chon2
            // 
            chon2.Location = new Point(272, 20);
            chon2.Name = "chon2";
            chon2.Size = new Size(75, 38);
            chon2.TabIndex = 5;
            chon2.Text = "CHỌN";
            chon2.UseVisualStyleBackColor = true;
            chon2.Click += chon2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(tim);
            groupBox1.Controls.Add(mahv);
            groupBox1.Controls.Add(huy);
            groupBox1.Controls.Add(chon);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(114, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 356);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Học Viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tim
            // 
            tim.Location = new Point(282, 22);
            tim.Name = "tim";
            tim.Size = new Size(75, 36);
            tim.TabIndex = 8;
            tim.Text = "TÌM";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // mahv
            // 
            mahv.Location = new Point(103, 23);
            mahv.Name = "mahv";
            mahv.Size = new Size(142, 23);
            mahv.TabIndex = 7;
            // 
            // huy
            // 
            huy.Location = new Point(503, 22);
            huy.Name = "huy";
            huy.Size = new Size(75, 36);
            huy.TabIndex = 6;
            huy.Text = "HỦY";
            huy.UseVisualStyleBackColor = true;
            huy.Click += huy_Click;
            // 
            // chon
            // 
            chon.Location = new Point(392, 23);
            chon.Name = "chon";
            chon.Size = new Size(75, 35);
            chon.TabIndex = 5;
            chon.Text = "CHỌN";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(3, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(660, 269);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 28);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Mã Học Viên";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(xoa);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(dataGridView3);
            groupBox3.Location = new Point(114, 413);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1352, 319);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Ghi Danh";
            // 
            // xoa
            // 
            xoa.Location = new Point(712, 14);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 36);
            xoa.TabIndex = 10;
            xoa.Text = "XÓA";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(374, 30);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 9;
            label5.Text = "Mã Lớp Học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 30);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "Mã Học Viên";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(462, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 6;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.GridColor = SystemColors.Control;
            dataGridView3.Location = new Point(3, 56);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(1346, 260);
            dataGridView3.TabIndex = 5;
            // 
            // GHIDANH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1540, 776);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "GHIDANH";
            Text = "GHIDANH";
            Load += GHIDANH_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Label label2;
        private Button chon2;
        private GroupBox groupBox1;
        private Button huy;
        private Button chon;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox mahv;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox3;
        private DataGridView dataGridView3;
        private Button tim;
        private Button xoa;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}