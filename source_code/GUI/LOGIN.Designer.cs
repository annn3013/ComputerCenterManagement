namespace GUI
{
    partial class LOGIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            groupBox1 = new GroupBox();
            hienmk = new CheckBox();
            dangnhap = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            mkbox = new TextBox();
            tkbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(hienmk);
            groupBox1.Controls.Add(dangnhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(mkbox);
            groupBox1.Controls.Add(tkbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 549);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // hienmk
            // 
            hienmk.AutoSize = true;
            hienmk.Location = new Point(458, 446);
            hienmk.Name = "hienmk";
            hienmk.Size = new Size(127, 24);
            hienmk.TabIndex = 7;
            hienmk.Text = "Hiện mật khẩu";
            hienmk.UseVisualStyleBackColor = true;
            hienmk.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dangnhap
            // 
            dangnhap.Location = new Point(339, 443);
            dangnhap.Name = "dangnhap";
            dangnhap.Size = new Size(104, 29);
            dangnhap.TabIndex = 6;
            dangnhap.Text = "Đăng nhập";
            dangnhap.UseVisualStyleBackColor = true;
            dangnhap.Click += dangnhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(230, 272);
            label3.Name = "label3";
            label3.Size = new Size(404, 33);
            label3.TabIndex = 5;
            label3.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(258, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 148);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mkbox
            // 
            mkbox.Location = new Point(339, 381);
            mkbox.Name = "mkbox";
            mkbox.Size = new Size(246, 27);
            mkbox.TabIndex = 3;
            mkbox.UseSystemPasswordChar = true;
            // 
            // tkbox
            // 
            tkbox.Location = new Point(339, 315);
            tkbox.Name = "tkbox";
            tkbox.Size = new Size(246, 27);
            tkbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 388);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 322);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 574);
            Controls.Add(groupBox1);
            Name = "LOGIN";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private TextBox mkbox;
        private TextBox tkbox;
        private Label label2;
        private Label label1;
        private CheckBox hienmk;
        private Button dangnhap;
    }
}