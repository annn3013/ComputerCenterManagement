namespace GUI
{
    partial class QUANLYACC
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
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            timkiemTextBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            maTKtextBox = new TextBox();
            tkTextBox = new TextBox();
            comboBox1 = new ComboBox();
            mkTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1037, 155);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(timkiemTextBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maTKtextBox);
            groupBox1.Controls.Add(tkTextBox);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(mkTextBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(18, 48);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1033, 289);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(513, 177);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(509, 75);
            dataGridView2.TabIndex = 109;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Location = new Point(918, 121);
            button5.Name = "button5";
            button5.Size = new Size(93, 41);
            button5.TabIndex = 108;
            button5.Text = "XÓA";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Enabled = false;
            button4.Location = new Point(777, 121);
            button4.Name = "button4";
            button4.Size = new Size(93, 41);
            button4.TabIndex = 107;
            button4.Text = "Chọn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Location = new Point(616, 121);
            button3.Name = "button3";
            button3.Size = new Size(93, 41);
            button3.TabIndex = 106;
            button3.Text = "TÌM";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timkiemTextBox1
            // 
            timkiemTextBox1.Anchor = AnchorStyles.Top;
            timkiemTextBox1.Location = new Point(616, 52);
            timkiemTextBox1.Multiline = true;
            timkiemTextBox1.Name = "timkiemTextBox1";
            timkiemTextBox1.Size = new Size(394, 40);
            timkiemTextBox1.TabIndex = 105;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(529, 69);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 104;
            label5.Text = "Tìm Kiếm";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 248);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 103;
            label6.Text = "Mã Tài Khoản";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 183);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 102;
            label4.Text = "Phân Quyền ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 121);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 101;
            label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 100;
            label2.Text = "Tên Tài Khoản";
            // 
            // maTKtextBox
            // 
            maTKtextBox.Anchor = AnchorStyles.Top;
            maTKtextBox.Location = new Point(138, 240);
            maTKtextBox.Multiline = true;
            maTKtextBox.Name = "maTKtextBox";
            maTKtextBox.ReadOnly = true;
            maTKtextBox.Size = new Size(210, 32);
            maTKtextBox.TabIndex = 99;
            // 
            // tkTextBox
            // 
            tkTextBox.Anchor = AnchorStyles.Top;
            tkTextBox.Location = new Point(138, 53);
            tkTextBox.Multiline = true;
            tkTextBox.Name = "tkTextBox";
            tkTextBox.Size = new Size(210, 39);
            tkTextBox.TabIndex = 96;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Quản Lý Nhân Sự", "Nhân Viên Lễ Tân", "Quản Lý Kế Hoạch" });
            comboBox1.Location = new Point(138, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 28);
            comboBox1.TabIndex = 98;
            // 
            // mkTextBox
            // 
            mkTextBox.Anchor = AnchorStyles.Top;
            mkTextBox.Location = new Point(138, 113);
            mkTextBox.Multiline = true;
            mkTextBox.Name = "mkTextBox";
            mkTextBox.Size = new Size(210, 32);
            mkTextBox.TabIndex = 97;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(386, 53);
            button1.Name = "button1";
            button1.Size = new Size(93, 41);
            button1.TabIndex = 93;
            button1.Text = "THÊM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(386, 113);
            button2.Name = "button2";
            button2.Size = new Size(93, 41);
            button2.TabIndex = 94;
            button2.Text = "HỦY";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.Location = new Point(386, 171);
            button6.Name = "button6";
            button6.Size = new Size(93, 41);
            button6.TabIndex = 95;
            button6.Text = "SỬA";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 35);
            label1.TabIndex = 92;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QUANLYACC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 491);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "QUANLYACC";
            Load += QUANLYACC_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox timkiemTextBox1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox maTKtextBox;
        private TextBox tkTextBox;
        private ComboBox comboBox1;
        private TextBox mkTextBox;
        private Button button1;
        private Button button2;
        private Button button6;
        private Label label1;
    }
}