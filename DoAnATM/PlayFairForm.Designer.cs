namespace DoAnATM
{
    partial class PlayFairForm
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
            DelOutputBtn = new Button();
            SaveFilePFBtn = new Button();
            DelInputBtn = new Button();
            SelectFilePFBtn = new Button();
            OutputTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            InputTxt = new TextBox();
            panel2 = new Panel();
            ReversePFBtn = new Button();
            DecryptPFBtn = new Button();
            EncryptPFBtn = new Button();
            PlayfairKeyGR = new GroupBox();
            DelKeyPFBtn = new Button();
            label2 = new Label();
            RandomKeyPFBtn = new Button();
            Size6x6 = new RadioButton();
            label1 = new Label();
            PanelMaTrix = new Panel();
            PlayfairKey = new TextBox();
            Size5x5 = new RadioButton();
            CloseBtn = new Button();
            DelAllBtn = new Button();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            PlayfairKeyGR.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DelOutputBtn);
            groupBox1.Controls.Add(SaveFilePFBtn);
            groupBox1.Controls.Add(DelInputBtn);
            groupBox1.Controls.Add(SelectFilePFBtn);
            groupBox1.Controls.Add(OutputTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(InputTxt);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(23, 507);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 339);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "MÃ HÓA, GIẢI MÃ";
            // 
            // DelOutputBtn
            // 
            DelOutputBtn.BackColor = Color.Red;
            DelOutputBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DelOutputBtn.ForeColor = Color.White;
            DelOutputBtn.Location = new Point(544, 145);
            DelOutputBtn.Name = "DelOutputBtn";
            DelOutputBtn.Size = new Size(165, 35);
            DelOutputBtn.TabIndex = 7;
            DelOutputBtn.Text = "Xóa";
            DelOutputBtn.UseVisualStyleBackColor = false;
            DelOutputBtn.Click += DelOutputBtn_Click;
            // 
            // SaveFilePFBtn
            // 
            SaveFilePFBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveFilePFBtn.Location = new Point(373, 145);
            SaveFilePFBtn.Name = "SaveFilePFBtn";
            SaveFilePFBtn.Size = new Size(165, 35);
            SaveFilePFBtn.TabIndex = 6;
            SaveFilePFBtn.Text = "Lưu File";
            SaveFilePFBtn.UseVisualStyleBackColor = true;
            SaveFilePFBtn.Click += SaveFilePFBtn_Click;
            // 
            // DelInputBtn
            // 
            DelInputBtn.BackColor = Color.Red;
            DelInputBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DelInputBtn.ForeColor = Color.White;
            DelInputBtn.Location = new Point(547, 33);
            DelInputBtn.Name = "DelInputBtn";
            DelInputBtn.Size = new Size(165, 35);
            DelInputBtn.TabIndex = 5;
            DelInputBtn.Text = "Xóa ";
            DelInputBtn.UseVisualStyleBackColor = false;
            DelInputBtn.Click += DelInputBtn_Click;
            // 
            // SelectFilePFBtn
            // 
            SelectFilePFBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectFilePFBtn.Location = new Point(376, 33);
            SelectFilePFBtn.Name = "SelectFilePFBtn";
            SelectFilePFBtn.Size = new Size(165, 35);
            SelectFilePFBtn.TabIndex = 4;
            SelectFilePFBtn.Text = "Chọn File";
            SelectFilePFBtn.UseVisualStyleBackColor = true;
            SelectFilePFBtn.Click += SelectFilePFBtn_Click;
            // 
            // OutputTxt
            // 
            OutputTxt.Location = new Point(30, 186);
            OutputTxt.Multiline = true;
            OutputTxt.Name = "OutputTxt";
            OutputTxt.Size = new Size(682, 54);
            OutputTxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 150);
            label4.Name = "label4";
            label4.Size = new Size(160, 26);
            label4.TabIndex = 2;
            label4.Text = "Văn bản đầu ra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 42);
            label3.Name = "label3";
            label3.Size = new Size(176, 26);
            label3.TabIndex = 1;
            label3.Text = "Văn bản đầu vào:";
            // 
            // InputTxt
            // 
            InputTxt.BackColor = Color.White;
            InputTxt.ForeColor = Color.Black;
            InputTxt.Location = new Point(30, 78);
            InputTxt.Multiline = true;
            InputTxt.Name = "InputTxt";
            InputTxt.Size = new Size(682, 54);
            InputTxt.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ReversePFBtn);
            panel2.Controls.Add(DecryptPFBtn);
            panel2.Controls.Add(EncryptPFBtn);
            panel2.Location = new Point(30, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 53);
            panel2.TabIndex = 0;
            // 
            // ReversePFBtn
            // 
            ReversePFBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReversePFBtn.Location = new Point(514, 3);
            ReversePFBtn.Name = "ReversePFBtn";
            ReversePFBtn.Size = new Size(165, 48);
            ReversePFBtn.TabIndex = 2;
            ReversePFBtn.Text = "Đảo ngược";
            ReversePFBtn.UseVisualStyleBackColor = true;
            ReversePFBtn.Click += ReversePFBtn_Click;
            // 
            // DecryptPFBtn
            // 
            DecryptPFBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            DecryptPFBtn.Location = new Point(194, 3);
            DecryptPFBtn.Name = "DecryptPFBtn";
            DecryptPFBtn.Size = new Size(165, 47);
            DecryptPFBtn.TabIndex = 1;
            DecryptPFBtn.Text = "Giải mã";
            DecryptPFBtn.UseVisualStyleBackColor = true;
            DecryptPFBtn.Click += DecryptPFBtn_Click;
            // 
            // EncryptPFBtn
            // 
            EncryptPFBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            EncryptPFBtn.Location = new Point(3, 3);
            EncryptPFBtn.Name = "EncryptPFBtn";
            EncryptPFBtn.Size = new Size(165, 47);
            EncryptPFBtn.TabIndex = 0;
            EncryptPFBtn.Text = "Mã hóa";
            EncryptPFBtn.UseVisualStyleBackColor = true;
            EncryptPFBtn.Click += EncryptPFBtn_Click;
            // 
            // PlayfairKeyGR
            // 
            PlayfairKeyGR.BackColor = Color.Transparent;
            PlayfairKeyGR.Controls.Add(DelKeyPFBtn);
            PlayfairKeyGR.Controls.Add(label2);
            PlayfairKeyGR.Controls.Add(RandomKeyPFBtn);
            PlayfairKeyGR.Controls.Add(Size6x6);
            PlayfairKeyGR.Controls.Add(label1);
            PlayfairKeyGR.Controls.Add(PanelMaTrix);
            PlayfairKeyGR.Controls.Add(PlayfairKey);
            PlayfairKeyGR.Controls.Add(Size5x5);
            PlayfairKeyGR.Location = new Point(23, 89);
            PlayfairKeyGR.Name = "PlayfairKeyGR";
            PlayfairKeyGR.Size = new Size(729, 393);
            PlayfairKeyGR.TabIndex = 7;
            PlayfairKeyGR.TabStop = false;
            PlayfairKeyGR.Text = "KHÓA";
            // 
            // DelKeyPFBtn
            // 
            DelKeyPFBtn.BackColor = Color.Red;
            DelKeyPFBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DelKeyPFBtn.ForeColor = Color.White;
            DelKeyPFBtn.Location = new Point(231, 132);
            DelKeyPFBtn.Name = "DelKeyPFBtn";
            DelKeyPFBtn.Size = new Size(119, 43);
            DelKeyPFBtn.TabIndex = 6;
            DelKeyPFBtn.Text = "Xóa Khóa";
            DelKeyPFBtn.UseVisualStyleBackColor = false;
            DelKeyPFBtn.Click += DelKeyPFBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 207);
            label2.Name = "label2";
            label2.Size = new Size(248, 26);
            label2.TabIndex = 5;
            label2.Text = "Kích thước ma trận khóa:";
            // 
            // RandomKeyPFBtn
            // 
            RandomKeyPFBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RandomKeyPFBtn.Location = new Point(30, 132);
            RandomKeyPFBtn.Name = "RandomKeyPFBtn";
            RandomKeyPFBtn.Size = new Size(195, 43);
            RandomKeyPFBtn.TabIndex = 3;
            RandomKeyPFBtn.Text = "Khóa ngẫu nhiên";
            RandomKeyPFBtn.UseVisualStyleBackColor = true;
            RandomKeyPFBtn.Click += RandomKeyPFBtn_Click;
            // 
            // Size6x6
            // 
            Size6x6.AutoSize = true;
            Size6x6.Location = new Point(284, 249);
            Size6x6.Name = "Size6x6";
            Size6x6.Size = new Size(66, 30);
            Size6x6.TabIndex = 4;
            Size6x6.TabStop = true;
            Size6x6.Text = "6x6";
            Size6x6.UseVisualStyleBackColor = true;
            Size6x6.CheckedChanged += Size6x6_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(120, 26);
            label1.TabIndex = 2;
            label1.Text = "Nhập khóa:";
            // 
            // PanelMaTrix
            // 
            PanelMaTrix.Location = new Point(376, 33);
            PanelMaTrix.Name = "PanelMaTrix";
            PanelMaTrix.Size = new Size(336, 337);
            PanelMaTrix.TabIndex = 2;
            // 
            // PlayfairKey
            // 
            PlayfairKey.Location = new Point(30, 83);
            PlayfairKey.Name = "PlayfairKey";
            PlayfairKey.Size = new Size(320, 34);
            PlayfairKey.TabIndex = 1;
            PlayfairKey.TextChanged += PlayfairKey_TextChanged;
            // 
            // Size5x5
            // 
            Size5x5.AutoSize = true;
            Size5x5.Location = new Point(284, 203);
            Size5x5.Name = "Size5x5";
            Size5x5.Size = new Size(66, 30);
            Size5x5.TabIndex = 3;
            Size5x5.TabStop = true;
            Size5x5.Text = "5x5";
            Size5x5.UseVisualStyleBackColor = true;
            Size5x5.CheckedChanged += Size5x5_CheckedChanged;
            // 
            // CloseBtn
            // 
            CloseBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.Location = new Point(634, 46);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(118, 37);
            CloseBtn.TabIndex = 9;
            CloseBtn.Text = "Tắt";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            CloseBtn.MouseEnter += CloseBtn_MouseEnter;
            CloseBtn.MouseLeave += CloseBtn_MouseLeave;
            // 
            // DelAllBtn
            // 
            DelAllBtn.BackColor = Color.Red;
            DelAllBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DelAllBtn.ForeColor = Color.White;
            DelAllBtn.Location = new Point(570, 865);
            DelAllBtn.Name = "DelAllBtn";
            DelAllBtn.Size = new Size(162, 47);
            DelAllBtn.TabIndex = 10;
            DelAllBtn.Text = "Xóa hết";
            DelAllBtn.UseVisualStyleBackColor = false;
            DelAllBtn.Click += DelAllBtn_Click;
            // 
            // PlayFairForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 933);
            Controls.Add(DelAllBtn);
            Controls.Add(CloseBtn);
            Controls.Add(groupBox1);
            Controls.Add(PlayfairKeyGR);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PlayFairForm";
            Text = "PlayFair Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            PlayfairKeyGR.ResumeLayout(false);
            PlayfairKeyGR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button DelOutputBtn;
        private Button SaveFilePFBtn;
        private Button DelInputBtn;
        private Button SelectFilePFBtn;
        private TextBox OutputTxt;
        private Label label4;
        private Label label3;
        private TextBox InputTxt;
        private Panel panel2;
        private Button ReversePFBtn;
        private Button DecryptPFBtn;
        private Button EncryptPFBtn;
        private GroupBox PlayfairKeyGR;
        private Button DelKeyPFBtn;
        private Label label2;
        private Button RandomKeyPFBtn;
        private RadioButton Size6x6;
        private Label label1;
        private Panel PanelMaTrix;
        private TextBox PlayfairKey;
        private RadioButton Size5x5;
        private Button CloseBtn;
        private Button DelAllBtn;
    }
}