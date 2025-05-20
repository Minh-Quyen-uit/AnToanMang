namespace DoAnATM
{
    partial class ProjectATM
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
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            RSABtn = new Button();
            groupBox3 = new GroupBox();
            PlayFairBtn = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            CloseBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 286);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(366, 136);
            label10.Name = "label10";
            label10.Size = new Size(152, 35);
            label10.TabIndex = 10;
            label10.Text = "NT101.P21";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 239);
            label5.Name = "label5";
            label5.Size = new Size(727, 33);
            label5.TabIndex = 9;
            label5.Text = "Viết ứng dụng mô phỏng các giải thuật mã hóa Playfair và RSA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 196);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 8;
            label4.Text = "Đề tài:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(235, 136);
            label3.Name = "label3";
            label3.Size = new Size(138, 35);
            label3.TabIndex = 7;
            label3.Text = "Mã Lớp: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold);
            label2.Location = new Point(180, 76);
            label2.Name = "label2";
            label2.Size = new Size(427, 40);
            label2.TabIndex = 6;
            label2.Text = "AN TOÀN MẠNG MÁY TÍNH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(304, 30);
            label1.Name = "label1";
            label1.Size = new Size(178, 40);
            label1.TabIndex = 5;
            label1.Text = "MÔN HỌC:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(23, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(796, 238);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RSABtn);
            groupBox4.Location = new Point(567, 122);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(212, 95);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // RSABtn
            // 
            RSABtn.BackColor = Color.Lime;
            RSABtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            RSABtn.ForeColor = Color.MidnightBlue;
            RSABtn.Location = new Point(15, 28);
            RSABtn.Name = "RSABtn";
            RSABtn.Size = new Size(183, 47);
            RSABtn.TabIndex = 1;
            RSABtn.Text = "RSA";
            RSABtn.UseVisualStyleBackColor = false;
            RSABtn.Click += RSABtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(PlayFairBtn);
            groupBox3.Location = new Point(567, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 95);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // PlayFairBtn
            // 
            PlayFairBtn.BackColor = Color.DeepSkyBlue;
            PlayFairBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            PlayFairBtn.ForeColor = Color.White;
            PlayFairBtn.Location = new Point(16, 30);
            PlayFairBtn.Name = "PlayFairBtn";
            PlayFairBtn.Size = new Size(183, 47);
            PlayFairBtn.TabIndex = 0;
            PlayFairBtn.Text = "PlayFair";
            PlayFairBtn.UseVisualStyleBackColor = false;
            PlayFairBtn.Click += PlayFairBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(141, 116);
            label9.Name = "label9";
            label9.Size = new Size(346, 104);
            label9.TabIndex = 3;
            label9.Text = "23521325 - Nguyễn Minh Quyền\r\n23521324 - Ngô Trọng Quyền\r\n23521346 - Phạm Nguyễn Tấn Sang\r\n23521195 - Đỗ Hoàng Phúc";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 75);
            label8.Name = "label8";
            label8.Size = new Size(209, 25);
            label8.TabIndex = 2;
            label8.Text = "Sinh viên thực hiện:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 31);
            label7.Name = "label7";
            label7.Size = new Size(286, 26);
            label7.TabIndex = 1;
            label7.Text = "ThS. Tô Nguyễn Nhật Quang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 31);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 0;
            label6.Text = "GVHD: ";
            // 
            // CloseBtn
            // 
            CloseBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.Location = new Point(698, 46);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 37);
            CloseBtn.TabIndex = 7;
            CloseBtn.Text = "Tắt\r\n";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            CloseBtn.MouseEnter += CloseBtn_MouseEnter;
            CloseBtn.MouseLeave += CloseBtn_MouseLeave;
            // 
            // ProjectATM
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 673);
            Controls.Add(CloseBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProjectATM";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private GroupBox groupBox4;
        private Button RSABtn;
        private GroupBox groupBox3;
        private Button PlayFairBtn;
        private Button CloseBtn;
    }
}