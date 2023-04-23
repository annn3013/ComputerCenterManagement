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
            matkhaucuTxt.Location = new Point(690, 56);
            matkhaucuTxt.Margin = new Padding(3, 2, 3, 2);
            matkhaucuTxt.Multiline = true;
            matkhaucuTxt.Name = "matkhaucuTxt";
            matkhaucuTxt.PasswordChar = '*';
            matkhaucuTxt.Size = new Size(358, 33);
            matkhaucuTxt.TabIndex = 2;
            matkhaucuTxt.UseSystemPasswordChar = true;
            // 
            // matkhaumoiTxt
            // 
            matkhaumoiTxt.Location = new Point(690, 128);
            matkhaumoiTxt.Margin = new Padding(3, 2, 3, 2);
            matkhaumoiTxt.Multiline = true;
            matkhaumoiTxt.Name = "matkhaumoiTxt";
            matkhaumoiTxt.PasswordChar = '*';
            matkhaumoiTxt.Size = new Size(358, 33);
            matkhaumoiTxt.TabIndex = 3;
            matkhaumoiTxt.UseSystemPasswordChar = true;
            matkhaumoiTxt.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
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
            groupBox1.Location = new Point(105, 56);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1096, 364);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(798, 326);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 34);
            button2.TabIndex = 8;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(664, 326);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(116, 34);
            button3.TabIndex = 9;
            button3.Text = "HỦY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(936, 254);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Hiện Mật Khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(933, 326);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(115, 34);
            button1.TabIndex = 6;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(900, 184);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 7;
            label3.Text = "Xác Nhận Mật Khẩu Mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(959, 110);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 6;
            label2.Text = "Mật Khẩu Mới";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(967, 38);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "Mật Khẩu Cũ";
            // 
            // xacnhanTxt
            // 
            xacnhanTxt.Location = new Point(690, 201);
            xacnhanTxt.Margin = new Padding(3, 2, 3, 2);
            xacnhanTxt.Multiline = true;
            xacnhanTxt.Name = "xacnhanTxt";
            xacnhanTxt.PasswordChar = '*';
            xacnhanTxt.Size = new Size(358, 33);
            xacnhanTxt.TabIndex = 4;
            xacnhanTxt.UseSystemPasswordChar = true;
            xacnhanTxt.TextChanged += xacnhanTxt_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(589, 14);
            label4.Name = "label4";
            label4.Size = new Size(161, 29);
            label4.TabIndex = 5;
            label4.Text = "ĐỔI MẬT KHẨU";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(724, 358);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // DOIPASS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 468);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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