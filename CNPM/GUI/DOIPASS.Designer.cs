namespace GUI
{
    partial class DOIPASS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOIPASS));
            matkhaucuTxt = new TextBox();
            matkhaumoiTxt = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            xacnhanTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // matkhaucuTxt
            // 
            matkhaucuTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            matkhaucuTxt.Location = new Point(789, 75);
            matkhaucuTxt.Multiline = true;
            matkhaucuTxt.Name = "matkhaucuTxt";
            matkhaucuTxt.PasswordChar = '*';
            matkhaucuTxt.Size = new Size(409, 43);
            matkhaucuTxt.TabIndex = 2;
            matkhaucuTxt.UseSystemPasswordChar = true;
            // 
            // matkhaumoiTxt
            // 
            matkhaumoiTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            matkhaumoiTxt.Location = new Point(789, 171);
            matkhaumoiTxt.Multiline = true;
            matkhaumoiTxt.Name = "matkhaumoiTxt";
            matkhaumoiTxt.PasswordChar = '*';
            matkhaumoiTxt.Size = new Size(409, 43);
            matkhaumoiTxt.TabIndex = 3;
            matkhaumoiTxt.UseSystemPasswordChar = true;
            matkhaumoiTxt.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(xacnhanTxt);
            groupBox1.Controls.Add(matkhaucuTxt);
            groupBox1.Controls.Add(matkhaumoiTxt);
            groupBox1.Location = new Point(120, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1253, 485);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(912, 435);
            button2.Name = "button2";
            button2.Size = new Size(133, 45);
            button2.TabIndex = 8;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(759, 435);
            button3.Name = "button3";
            button3.Size = new Size(133, 45);
            button3.TabIndex = 9;
            button3.Text = "HỦY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(1070, 339);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Hiện Mật Khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1066, 435);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 6;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(581, 376);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1029, 245);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 7;
            label3.Text = "Xác Nhận Mật Khẩu Mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1096, 147);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật Khẩu Mới";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1105, 51);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Mật Khẩu Cũ";
            // 
            // xacnhanTxt
            // 
            xacnhanTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xacnhanTxt.Location = new Point(789, 268);
            xacnhanTxt.Multiline = true;
            xacnhanTxt.Name = "xacnhanTxt";
            xacnhanTxt.PasswordChar = '*';
            xacnhanTxt.Size = new Size(409, 43);
            xacnhanTxt.TabIndex = 4;
            xacnhanTxt.UseSystemPasswordChar = true;
            xacnhanTxt.TextChanged += xacnhanTxt_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(665, 9);
            label4.Name = "label4";
            label4.Size = new Size(235, 35);
            label4.TabIndex = 5;
            label4.Text = "ĐỔI MẬT KHẨU";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(827, 477);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // DOIPASS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1499, 691);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DOIPASS";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi Mật Khẩu";
            Load += DOIPASS_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox matkhaucuTxt;
        private TextBox matkhaumoiTxt;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox xacnhanTxt;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox checkBox1;
        private Button button1;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}