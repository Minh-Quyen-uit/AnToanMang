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
            TabControl = new TabControl();
            PlayFair = new TabPage();
            panel1 = new Panel();
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
            RSA = new TabPage();
            DeleteAllBtn = new Button();
            groupBox3 = new GroupBox();
            RSATabControl = new TabControl();
            EncryptPage = new TabPage();
            ReverseRSABtn1 = new Button();
            EncryptRSABtn = new Button();
            DelTxtBtn1 = new Button();
            SaveFileRSABtn1 = new Button();
            SelectFileRSABtn1 = new Button();
            label12 = new Label();
            label11 = new Label();
            CipherTxt1 = new TextBox();
            PlainTxt1 = new TextBox();
            DecryptPage = new TabPage();
            ReverseBtn2 = new Button();
            DecryptRSABtn = new Button();
            DelTxtBtn2 = new Button();
            SaveFileRSABtn2 = new Button();
            SelectFileRSABtn2 = new Button();
            label13 = new Label();
            label14 = new Label();
            PlainTxt2 = new TextBox();
            CipherTxt2 = new TextBox();
            groupBox2 = new GroupBox();
            UpdateEBtn = new Button();
            label10 = new Label();
            ETxt = new TextBox();
            PrivateKeyTxt = new TextBox();
            PublicKeyTxt = new TextBox();
            QTxt = new TextBox();
            PTxt = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            DelKeyRSABtn = new Button();
            RandomKeyRSABtn = new Button();
            TypeNumberBox = new ComboBox();
            label5 = new Label();
            ManualBtn = new Button();
            TabControl.SuspendLayout();
            PlayFair.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            PlayfairKeyGR.SuspendLayout();
            RSA.SuspendLayout();
            groupBox3.SuspendLayout();
            RSATabControl.SuspendLayout();
            EncryptPage.SuspendLayout();
            DecryptPage.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(PlayFair);
            TabControl.Controls.Add(RSA);
            TabControl.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(792, 857);
            TabControl.TabIndex = 0;
            // 
            // PlayFair
            // 
            PlayFair.BackColor = Color.LightCyan;
            PlayFair.Controls.Add(panel1);
            PlayFair.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayFair.Location = new Point(4, 35);
            PlayFair.Name = "PlayFair";
            PlayFair.Padding = new Padding(3);
            PlayFair.Size = new Size(784, 818);
            PlayFair.TabIndex = 0;
            PlayFair.Text = "PlayFair";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(PlayfairKeyGR);
            panel1.Location = new Point(6, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 802);
            panel1.TabIndex = 0;
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
            groupBox1.Location = new Point(20, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 344);
            groupBox1.TabIndex = 6;
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
            SelectFilePFBtn.Click += SelectFileBtn_Click;
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
            ReversePFBtn.Click += ReverseBtn_Click;
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
            DecryptPFBtn.Click += DecryptBtn_Click;
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
            EncryptPFBtn.Click += EncryptBtn_Click;
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
            PlayfairKeyGR.Location = new Point(20, 17);
            PlayfairKeyGR.Name = "PlayfairKeyGR";
            PlayfairKeyGR.Size = new Size(729, 393);
            PlayfairKeyGR.TabIndex = 5;
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
            DelKeyPFBtn.Click += DelKeyBtn_Click;
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
            RandomKeyPFBtn.Click += RandomKeyBtn_Click;
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
            Size6x6.CheckedChanged += rdo6x6_CheckedChanged;
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
            Size5x5.CheckedChanged += rdo5x5_CheckedChanged;
            // 
            // RSA
            // 
            RSA.Controls.Add(DeleteAllBtn);
            RSA.Controls.Add(groupBox3);
            RSA.Controls.Add(groupBox2);
            RSA.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RSA.Location = new Point(4, 35);
            RSA.Name = "RSA";
            RSA.Padding = new Padding(3);
            RSA.Size = new Size(784, 818);
            RSA.TabIndex = 1;
            RSA.Text = "RSA";
            RSA.UseVisualStyleBackColor = true;
            // 
            // DeleteAllBtn
            // 
            DeleteAllBtn.BackColor = Color.Red;
            DeleteAllBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteAllBtn.ForeColor = Color.White;
            DeleteAllBtn.Location = new Point(581, 769);
            DeleteAllBtn.Name = "DeleteAllBtn";
            DeleteAllBtn.Size = new Size(140, 37);
            DeleteAllBtn.TabIndex = 2;
            DeleteAllBtn.Text = "Xóa hết";
            DeleteAllBtn.UseVisualStyleBackColor = false;
            DeleteAllBtn.Click += DeleteAllBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RSATabControl);
            groupBox3.Location = new Point(31, 404);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(728, 359);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "MÃ HÓA, GIẢI MÃ";
            // 
            // RSATabControl
            // 
            RSATabControl.Controls.Add(EncryptPage);
            RSATabControl.Controls.Add(DecryptPage);
            RSATabControl.Location = new Point(16, 43);
            RSATabControl.Name = "RSATabControl";
            RSATabControl.SelectedIndex = 0;
            RSATabControl.Size = new Size(696, 300);
            RSATabControl.TabIndex = 0;
            // 
            // EncryptPage
            // 
            EncryptPage.Controls.Add(ReverseRSABtn1);
            EncryptPage.Controls.Add(EncryptRSABtn);
            EncryptPage.Controls.Add(DelTxtBtn1);
            EncryptPage.Controls.Add(SaveFileRSABtn1);
            EncryptPage.Controls.Add(SelectFileRSABtn1);
            EncryptPage.Controls.Add(label12);
            EncryptPage.Controls.Add(label11);
            EncryptPage.Controls.Add(CipherTxt1);
            EncryptPage.Controls.Add(PlainTxt1);
            EncryptPage.Location = new Point(4, 35);
            EncryptPage.Name = "EncryptPage";
            EncryptPage.Padding = new Padding(3);
            EncryptPage.Size = new Size(688, 261);
            EncryptPage.TabIndex = 0;
            EncryptPage.Text = "Mã hóa";
            EncryptPage.UseVisualStyleBackColor = true;
            // 
            // ReverseRSABtn1
            // 
            ReverseRSABtn1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            ReverseRSABtn1.Location = new Point(384, 205);
            ReverseRSABtn1.Name = "ReverseRSABtn1";
            ReverseRSABtn1.Size = new Size(140, 37);
            ReverseRSABtn1.TabIndex = 9;
            ReverseRSABtn1.Text = "Đảo ngược";
            ReverseRSABtn1.UseVisualStyleBackColor = true;
            ReverseRSABtn1.Click += ReverseRSABtn1_Click;
            // 
            // EncryptRSABtn
            // 
            EncryptRSABtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            EncryptRSABtn.Location = new Point(238, 205);
            EncryptRSABtn.Name = "EncryptRSABtn";
            EncryptRSABtn.Size = new Size(140, 37);
            EncryptRSABtn.TabIndex = 8;
            EncryptRSABtn.Text = "Mã hóa";
            EncryptRSABtn.UseVisualStyleBackColor = true;
            EncryptRSABtn.Click += EncryptRSABtn_Click;
            // 
            // DelTxtBtn1
            // 
            DelTxtBtn1.BackColor = Color.Red;
            DelTxtBtn1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DelTxtBtn1.ForeColor = Color.White;
            DelTxtBtn1.Location = new Point(530, 205);
            DelTxtBtn1.Name = "DelTxtBtn1";
            DelTxtBtn1.Size = new Size(140, 37);
            DelTxtBtn1.TabIndex = 7;
            DelTxtBtn1.Text = "Xóa";
            DelTxtBtn1.UseVisualStyleBackColor = false;
            DelTxtBtn1.Click += DelTxtBtn1_Click;
            // 
            // SaveFileRSABtn1
            // 
            SaveFileRSABtn1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            SaveFileRSABtn1.Location = new Point(530, 109);
            SaveFileRSABtn1.Name = "SaveFileRSABtn1";
            SaveFileRSABtn1.Size = new Size(140, 37);
            SaveFileRSABtn1.TabIndex = 6;
            SaveFileRSABtn1.Text = "Lưu File";
            SaveFileRSABtn1.UseVisualStyleBackColor = true;
            SaveFileRSABtn1.Click += SaveFileRSABtn1_Click;
            // 
            // SelectFileRSABtn1
            // 
            SelectFileRSABtn1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            SelectFileRSABtn1.Location = new Point(530, 15);
            SelectFileRSABtn1.Name = "SelectFileRSABtn1";
            SelectFileRSABtn1.Size = new Size(140, 37);
            SelectFileRSABtn1.TabIndex = 4;
            SelectFileRSABtn1.Text = "Chọn File";
            SelectFileRSABtn1.UseVisualStyleBackColor = true;
            SelectFileRSABtn1.Click += SelectFileRSABtn1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 115);
            label12.Name = "label12";
            label12.Size = new Size(170, 26);
            label12.TabIndex = 3;
            label12.Text = "Văn bản mã hóa:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 21);
            label11.Name = "label11";
            label11.Size = new Size(135, 26);
            label11.TabIndex = 2;
            label11.Text = "Văn bản gốc:";
            // 
            // CipherTxt1
            // 
            CipherTxt1.Enabled = false;
            CipherTxt1.Location = new Point(17, 155);
            CipherTxt1.Multiline = true;
            CipherTxt1.Name = "CipherTxt1";
            CipherTxt1.ReadOnly = true;
            CipherTxt1.Size = new Size(653, 34);
            CipherTxt1.TabIndex = 1;
            // 
            // PlainTxt1
            // 
            PlainTxt1.Location = new Point(17, 60);
            PlainTxt1.Multiline = true;
            PlainTxt1.Name = "PlainTxt1";
            PlainTxt1.Size = new Size(653, 34);
            PlainTxt1.TabIndex = 0;
            // 
            // DecryptPage
            // 
            DecryptPage.Controls.Add(ReverseBtn2);
            DecryptPage.Controls.Add(DecryptRSABtn);
            DecryptPage.Controls.Add(DelTxtBtn2);
            DecryptPage.Controls.Add(SaveFileRSABtn2);
            DecryptPage.Controls.Add(SelectFileRSABtn2);
            DecryptPage.Controls.Add(label13);
            DecryptPage.Controls.Add(label14);
            DecryptPage.Controls.Add(PlainTxt2);
            DecryptPage.Controls.Add(CipherTxt2);
            DecryptPage.Location = new Point(4, 35);
            DecryptPage.Name = "DecryptPage";
            DecryptPage.Padding = new Padding(3);
            DecryptPage.Size = new Size(688, 261);
            DecryptPage.TabIndex = 1;
            DecryptPage.Text = "Giải mã";
            DecryptPage.UseVisualStyleBackColor = true;
            // 
            // ReverseBtn2
            // 
            ReverseBtn2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            ReverseBtn2.Location = new Point(385, 207);
            ReverseBtn2.Name = "ReverseBtn2";
            ReverseBtn2.Size = new Size(140, 37);
            ReverseBtn2.TabIndex = 19;
            ReverseBtn2.Text = "Đảo ngược";
            ReverseBtn2.UseVisualStyleBackColor = true;
            ReverseBtn2.Click += ReverseBtn2_Click;
            // 
            // DecryptRSABtn
            // 
            DecryptRSABtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            DecryptRSABtn.Location = new Point(239, 207);
            DecryptRSABtn.Name = "DecryptRSABtn";
            DecryptRSABtn.Size = new Size(140, 37);
            DecryptRSABtn.TabIndex = 18;
            DecryptRSABtn.Text = "Giải mã";
            DecryptRSABtn.UseVisualStyleBackColor = true;
            DecryptRSABtn.Click += DecryptRSABtn_Click;
            // 
            // DelTxtBtn2
            // 
            DelTxtBtn2.BackColor = Color.Red;
            DelTxtBtn2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic);
            DelTxtBtn2.ForeColor = Color.White;
            DelTxtBtn2.Location = new Point(530, 207);
            DelTxtBtn2.Name = "DelTxtBtn2";
            DelTxtBtn2.Size = new Size(140, 37);
            DelTxtBtn2.TabIndex = 17;
            DelTxtBtn2.Text = "Xóa";
            DelTxtBtn2.UseVisualStyleBackColor = false;
            DelTxtBtn2.Click += DelTxtBtn2_Click;
            // 
            // SaveFileRSABtn2
            // 
            SaveFileRSABtn2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            SaveFileRSABtn2.Location = new Point(530, 108);
            SaveFileRSABtn2.Name = "SaveFileRSABtn2";
            SaveFileRSABtn2.Size = new Size(140, 37);
            SaveFileRSABtn2.TabIndex = 16;
            SaveFileRSABtn2.Text = "Lưu File";
            SaveFileRSABtn2.UseVisualStyleBackColor = true;
            SaveFileRSABtn2.Click += SaveFileRSABtn2_Click;
            // 
            // SelectFileRSABtn2
            // 
            SelectFileRSABtn2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            SelectFileRSABtn2.Location = new Point(530, 14);
            SelectFileRSABtn2.Name = "SelectFileRSABtn2";
            SelectFileRSABtn2.Size = new Size(140, 37);
            SelectFileRSABtn2.TabIndex = 14;
            SelectFileRSABtn2.Text = "Chọn File";
            SelectFileRSABtn2.UseVisualStyleBackColor = true;
            SelectFileRSABtn2.Click += SelectFileRSABtn2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 114);
            label13.Name = "label13";
            label13.Size = new Size(169, 26);
            label13.TabIndex = 13;
            label13.Text = "Văn bản giải mã:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 20);
            label14.Name = "label14";
            label14.Size = new Size(170, 26);
            label14.TabIndex = 12;
            label14.Text = "Văn bản mã hóa:";
            // 
            // PlainTxt2
            // 
            PlainTxt2.Enabled = false;
            PlainTxt2.Location = new Point(18, 154);
            PlainTxt2.Multiline = true;
            PlainTxt2.Name = "PlainTxt2";
            PlainTxt2.ReadOnly = true;
            PlainTxt2.Size = new Size(653, 34);
            PlainTxt2.TabIndex = 11;
            // 
            // CipherTxt2
            // 
            CipherTxt2.Location = new Point(18, 59);
            CipherTxt2.Multiline = true;
            CipherTxt2.Name = "CipherTxt2";
            CipherTxt2.Size = new Size(653, 34);
            CipherTxt2.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UpdateEBtn);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(ETxt);
            groupBox2.Controls.Add(PrivateKeyTxt);
            groupBox2.Controls.Add(PublicKeyTxt);
            groupBox2.Controls.Add(QTxt);
            groupBox2.Controls.Add(PTxt);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(DelKeyRSABtn);
            groupBox2.Controls.Add(RandomKeyRSABtn);
            groupBox2.Controls.Add(TypeNumberBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(ManualBtn);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(31, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(728, 364);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "KHÓA";
            // 
            // UpdateEBtn
            // 
            UpdateEBtn.Location = new Point(572, 293);
            UpdateEBtn.Name = "UpdateEBtn";
            UpdateEBtn.Size = new Size(140, 39);
            UpdateEBtn.TabIndex = 10;
            UpdateEBtn.Text = "Sửa e";
            UpdateEBtn.UseVisualStyleBackColor = true;
            UpdateEBtn.Click += UpdateEBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 299);
            label10.Name = "label10";
            label10.Size = new Size(145, 26);
            label10.TabIndex = 14;
            label10.Text = "Thay đổi số e:";
            // 
            // ETxt
            // 
            ETxt.Location = new Point(245, 296);
            ETxt.Multiline = true;
            ETxt.Name = "ETxt";
            ETxt.Size = new Size(313, 34);
            ETxt.TabIndex = 13;
            // 
            // PrivateKeyTxt
            // 
            PrivateKeyTxt.Location = new Point(245, 238);
            PrivateKeyTxt.Multiline = true;
            PrivateKeyTxt.Name = "PrivateKeyTxt";
            PrivateKeyTxt.ReadOnly = true;
            PrivateKeyTxt.Size = new Size(467, 34);
            PrivateKeyTxt.TabIndex = 12;
            // 
            // PublicKeyTxt
            // 
            PublicKeyTxt.Location = new Point(245, 123);
            PublicKeyTxt.Multiline = true;
            PublicKeyTxt.Name = "PublicKeyTxt";
            PublicKeyTxt.ReadOnly = true;
            PublicKeyTxt.Size = new Size(467, 34);
            PublicKeyTxt.TabIndex = 11;
            // 
            // QTxt
            // 
            QTxt.Enabled = false;
            QTxt.Location = new Point(541, 37);
            QTxt.Multiline = true;
            QTxt.Name = "QTxt";
            QTxt.ReadOnly = true;
            QTxt.Size = new Size(171, 34);
            QTxt.TabIndex = 10;
            QTxt.Leave += QTxt_Leave;
            // 
            // PTxt
            // 
            PTxt.Enabled = false;
            PTxt.Location = new Point(306, 37);
            PTxt.Multiline = true;
            PTxt.Name = "PTxt";
            PTxt.ReadOnly = true;
            PTxt.Size = new Size(157, 34);
            PTxt.TabIndex = 9;
            PTxt.Leave += PTxt_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(238, 185);
            label9.Name = "label9";
            label9.Size = new Size(132, 26);
            label9.TabIndex = 8;
            label9.Text = "Khóa bí mật:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 84);
            label8.Name = "label8";
            label8.Size = new Size(165, 26);
            label8.TabIndex = 7;
            label8.Text = "Khóa công khai:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 40);
            label7.Name = "label7";
            label7.Size = new Size(61, 26);
            label7.TabIndex = 6;
            label7.Text = "Số q:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 40);
            label6.Name = "label6";
            label6.Size = new Size(61, 26);
            label6.TabIndex = 5;
            label6.Text = "Số p:";
            // 
            // DelKeyRSABtn
            // 
            DelKeyRSABtn.BackColor = Color.Red;
            DelKeyRSABtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DelKeyRSABtn.ForeColor = Color.White;
            DelKeyRSABtn.Location = new Point(16, 234);
            DelKeyRSABtn.Name = "DelKeyRSABtn";
            DelKeyRSABtn.Size = new Size(192, 38);
            DelKeyRSABtn.TabIndex = 4;
            DelKeyRSABtn.Text = "Xóa Khóa";
            DelKeyRSABtn.UseVisualStyleBackColor = false;
            DelKeyRSABtn.Click += DelKeyRSABtn_Click;
            // 
            // RandomKeyRSABtn
            // 
            RandomKeyRSABtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RandomKeyRSABtn.Location = new Point(16, 178);
            RandomKeyRSABtn.Name = "RandomKeyRSABtn";
            RandomKeyRSABtn.Size = new Size(192, 38);
            RandomKeyRSABtn.TabIndex = 3;
            RandomKeyRSABtn.Text = "Khóa ngẫu nhiên";
            RandomKeyRSABtn.UseVisualStyleBackColor = true;
            RandomKeyRSABtn.Click += RandomKeyRSABtn_Click;
            // 
            // TypeNumberBox
            // 
            TypeNumberBox.Enabled = false;
            TypeNumberBox.FormattingEnabled = true;
            TypeNumberBox.Items.AddRange(new object[] { "Không", "Thập Phân", "Nhị Phân", "Thập Lục Phân" });
            TypeNumberBox.Location = new Point(16, 123);
            TypeNumberBox.Name = "TypeNumberBox";
            TypeNumberBox.Size = new Size(192, 34);
            TypeNumberBox.TabIndex = 2;
            TypeNumberBox.SelectedValueChanged += TypeNumberBox_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 84);
            label5.Name = "label5";
            label5.Size = new Size(176, 26);
            label5.TabIndex = 1;
            label5.Text = "Chọn cơ sở nhập:";
            // 
            // ManualBtn
            // 
            ManualBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManualBtn.Location = new Point(16, 33);
            ManualBtn.Name = "ManualBtn";
            ManualBtn.Size = new Size(192, 38);
            ManualBtn.TabIndex = 0;
            ManualBtn.Text = "Nhập thủ công";
            ManualBtn.UseVisualStyleBackColor = true;
            ManualBtn.Click += ManualBtn_Click;
            // 
            // ProjectATM
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 884);
            Controls.Add(TabControl);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProjectATM";
            Text = "ProjectATM";
            TabControl.ResumeLayout(false);
            PlayFair.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            PlayfairKeyGR.ResumeLayout(false);
            PlayfairKeyGR.PerformLayout();
            RSA.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            RSATabControl.ResumeLayout(false);
            EncryptPage.ResumeLayout(false);
            EncryptPage.PerformLayout();
            DecryptPage.ResumeLayout(false);
            DecryptPage.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage PlayFair;
        private TabPage RSA;
        private Panel panel1;
        private Panel panel2;
        private Button DecryptPFBtn;
        private Button EncryptPFBtn;
        private Panel PanelMaTrix;
        private RadioButton Size6x6;
        private RadioButton Size5x5;
        private Button RandomKeyPFBtn;
        private Label label1;
        private TextBox PlayfairKey;
        private TextBox InputTxt;
        private GroupBox PlayfairKeyGR;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox OutputTxt;
        private Button ReversePFBtn;
        private Button DelInputBtn;
        private Button SelectFilePFBtn;
        private Button DelOutputBtn;
        private Button SaveFilePFBtn;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button ManualBtn;
        private ComboBox TypeNumberBox;
        private Label label5;
        private Button RandomKeyRSABtn;
        private Button DelKeyPFBtn;
        private Button DelKeyRSABtn;
        private Label label7;
        private Label label6;
        private TextBox PublicKeyTxt;
        private TextBox QTxt;
        private TextBox PTxt;
        private Label label9;
        private Label label8;
        private TextBox PrivateKeyTxt;
        private Label label10;
        private TextBox ETxt;
        private TabControl RSATabControl;
        private TabPage EncryptPage;
        private Label label12;
        private Label label11;
        private TextBox CipherTxt1;
        private TextBox PlainTxt1;
        private TabPage DecryptPage;
        private Button DelTxtBtn1;
        private Button SaveFileRSABtn1;
        private Button SelectFileRSABtn1;
        private Button EncryptRSABtn;
        private Button ReverseRSABtn1;
        private Button ReverseBtn2;
        private Button DecryptRSABtn;
        private Button DelTxtBtn2;
        private Button SaveFileRSABtn2;
        private Button SelectFileRSABtn2;
        private Label label13;
        private Label label14;
        private TextBox PlainTxt2;
        private TextBox CipherTxt2;
        private Button DeleteAllBtn;
        private Button UpdateEBtn;
    }
}