namespace GUI
{
    partial class QUANLYKHOAHOC
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
            textBox2 = new TextBox();
            xoa = new Button();
            label4 = new Label();
            chon = new Button();
            tim = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            sua = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            them = new Button();
            hoten = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(188, 264);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(867, 190);
            dataGridView1.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(xoa);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(chon);
            groupBox2.Controls.Add(tim);
            groupBox2.Location = new Point(188, 188);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(867, 63);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 12);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 37);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // xoa
            // 
            xoa.Location = new Point(748, 17);
            xoa.Margin = new Padding(3, 2, 3, 2);
            xoa.Name = "xoa";
            xoa.Size = new Size(101, 32);
            xoa.TabIndex = 19;
            xoa.Text = "XÓA";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 19);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 19;
            label4.Text = "Mã Khóa Học";
            // 
            // chon
            // 
            chon.Location = new Point(614, 16);
            chon.Margin = new Padding(3, 2, 3, 2);
            chon.Name = "chon";
            chon.Size = new Size(101, 32);
            chon.TabIndex = 18;
            chon.Text = "CHỌN";
            chon.UseVisualStyleBackColor = true;
            chon.Click += chon_Click;
            // 
            // tim
            // 
            tim.Location = new Point(486, 16);
            tim.Margin = new Padding(3, 2, 3, 2);
            tim.Name = "tim";
            tim.Size = new Size(101, 32);
            tim.TabIndex = 17;
            tim.Text = "TÌM";
            tim.UseVisualStyleBackColor = true;
            tim.Click += tim_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(sua);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(them);
            groupBox1.Controls.Add(hoten);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(188, 38);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(867, 146);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(732, 106);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(101, 32);
            button1.TabIndex = 20;
            button1.Text = "HỦY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sua
            // 
            sua.Location = new Point(614, 106);
            sua.Margin = new Padding(3, 2, 3, 2);
            sua.Name = "sua";
            sua.Size = new Size(101, 32);
            sua.TabIndex = 17;
            sua.Text = "SỬA";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 25);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(219, 37);
            textBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 32);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 17;
            label3.Text = "Mã Khóa Học";
            // 
            // them
            // 
            them.Location = new Point(486, 106);
            them.Margin = new Padding(3, 2, 3, 2);
            them.Name = "them";
            them.Size = new Size(101, 32);
            them.TabIndex = 16;
            them.Text = "THÊM";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // hoten
            // 
            hoten.Location = new Point(614, 25);
            hoten.Margin = new Padding(3, 2, 3, 2);
            hoten.Multiline = true;
            hoten.Name = "hoten";
            hoten.Size = new Size(219, 37);
            hoten.TabIndex = 4;
            hoten.TextChanged += hoten_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(480, 32);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên Khóa Học";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(512, -39);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ HỌC VIÊN";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(531, 7);
            label10.Name = "label10";
            label10.Size = new Size(220, 30);
            label10.TabIndex = 8;
            label10.Text = "QUẢN LÝ KHÓA HỌC";
            // 
            // QUANLYKHOAHOC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 486);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QUANLYKHOAHOC";
            Text = "QUANLYKHOAHOC";
            Load += QUANLYKHOAHOC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button xoa;
        private Button sua;
        private TextBox textBox1;
        private Label label3;
        private Button them;
        private TextBox hoten;
        private Label label2;
        private Label label1;
        private Label label10;
        private Button chon;
        private Button tim;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
    }
}