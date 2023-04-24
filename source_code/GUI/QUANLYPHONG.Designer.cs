namespace GUI
{
    partial class QUANLYPHONG
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            sua = new Button();
            them = new Button();
            tenphong = new TextBox();
            label3 = new Label();
            maphong = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(sua);
            groupBox1.Controls.Add(them);
            groupBox1.Controls.Add(tenphong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maphong);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(54, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(938, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(485, 80);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sua
            // 
            sua.Location = new Point(597, 80);
            sua.Name = "sua";
            sua.Size = new Size(94, 29);
            sua.TabIndex = 5;
            sua.Text = "Sửa ";
            sua.UseVisualStyleBackColor = true;
            sua.Click += sua_Click;
            // 
            // them
            // 
            them.Location = new Point(711, 80);
            them.Name = "them";
            them.Size = new Size(94, 29);
            them.TabIndex = 4;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = true;
            them.Click += them_Click;
            // 
            // tenphong
            // 
            tenphong.Location = new Point(597, 29);
            tenphong.Name = "tenphong";
            tenphong.Size = new Size(207, 27);
            tenphong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(485, 29);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên phòng học";
            // 
            // maphong
            // 
            maphong.Location = new Point(149, 23);
            maphong.Name = "maphong";
            maphong.Size = new Size(207, 27);
            maphong.TabIndex = 1;
            maphong.TextChanged += maphong_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 23);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Phòng Học";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 38);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ PHÒNG HỌC";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(938, 439);
            dataGridView1.TabIndex = 2;
            dataGridView1.AutoSizeColumnsModeChanged += dataGridView1_AutoSizeColumnsModeChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // QUANLYPHONG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1054, 659);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "QUANLYPHONG";
            Text = "QUANLYPHONG";
            Load += QUANLYPHONG_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox maphong;
        private Label label2;
        private TextBox tenphong;
        private Label label3;
        private Button sua;
        private Button them;
        private DataGridView dataGridView1;
        private Button button1;
    }
}