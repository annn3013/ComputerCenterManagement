namespace GUI
{
    partial class XEPLOP
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
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            groupBox3 = new GroupBox();
            mamon = new TextBox();
            label6 = new Label();
            magv = new TextBox();
            label5 = new Label();
            tim = new Button();
            hoten = new TextBox();
            xoa = new Button();
            dataGridView3 = new DataGridView();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(583, 12);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 0;
            label1.Text = "Phân Công Giảng Dạy";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(154, 56);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1193, 313);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(477, 28);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "HỦY";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(345, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "CHỌN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(3, 76);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1187, 233);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(118, 29);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 35);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã Lớp Học";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 16);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 24);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Giáo Viên";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(154, 373);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1193, 214);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(603, 19);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 9;
            button3.Text = "HỦY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Location = new Point(465, 19);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 8;
            button5.Text = "OKE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.GridColor = SystemColors.Control;
            dataGridView2.Location = new Point(3, 61);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1187, 149);
            dataGridView2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Location = new Point(345, 19);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 5;
            button4.Text = "CHỌN";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(mamon);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(magv);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(tim);
            groupBox3.Controls.Add(hoten);
            groupBox3.Controls.Add(xoa);
            groupBox3.Controls.Add(dataGridView3);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(157, 595);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1193, 414);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // mamon
            // 
            mamon.Anchor = AnchorStyles.Top;
            mamon.Location = new Point(834, 19);
            mamon.Margin = new Padding(3, 4, 3, 4);
            mamon.Name = "mamon";
            mamon.Size = new Size(114, 27);
            mamon.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(739, 25);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 13;
            label6.Text = "Mã Lớp Học";
            // 
            // magv
            // 
            magv.Anchor = AnchorStyles.Top;
            magv.Location = new Point(603, 17);
            magv.Margin = new Padding(3, 4, 3, 4);
            magv.Name = "magv";
            magv.Size = new Size(114, 27);
            magv.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(509, 24);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 11;
            label5.Text = "Mã Giáo Viên";
            // 
            // tim
            // 
            tim.Anchor = AnchorStyles.Top;
            tim.Location = new Point(257, 19);
            tim.Margin = new Padding(3, 4, 3, 4);
            tim.Name = "tim";
            tim.Size = new Size(86, 31);
            tim.TabIndex = 10;
            tim.Text = "TÌM";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // hoten
            // 
            hoten.Anchor = AnchorStyles.Top;
            hoten.Location = new Point(112, 19);
            hoten.Margin = new Padding(3, 4, 3, 4);
            hoten.Name = "hoten";
            hoten.Size = new Size(114, 27);
            hoten.TabIndex = 9;
            // 
            // xoa
            // 
            xoa.Anchor = AnchorStyles.Top;
            xoa.Location = new Point(973, 20);
            xoa.Margin = new Padding(3, 4, 3, 4);
            xoa.Name = "xoa";
            xoa.Size = new Size(86, 31);
            xoa.TabIndex = 8;
            xoa.Text = "XÓA";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.GridColor = SystemColors.Control;
            dataGridView3.Location = new Point(3, 54);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(1187, 356);
            dataGridView3.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(18, 24);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 0;
            label4.Text = "Mã Giáo Viên";
            // 
            // XEPLOP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1457, 1055);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "XEPLOP";
            Text = "XEPLOP";
            Load += XEPLOP_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView2;
        private Button button3;
        private GroupBox groupBox3;
        private TextBox magv;
        private Label label5;
        private Button tim;
        private TextBox hoten;
        private Button xoa;
        private DataGridView dataGridView3;
        private Label label4;
        private TextBox mamon;
        private Label label6;
    }
}