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
            rdo6x6 = new RadioButton();
            rdo5x5 = new RadioButton();
            panelMatrix = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            PlayfairKey = new TextBox();
            TextBox = new TextBox();
            panel2 = new Panel();
            DecryptBtn = new Button();
            EncryptBtn = new Button();
            RSA = new TabPage();
            TabControl.SuspendLayout();
            PlayFair.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            TabControl.Size = new Size(612, 661);
            TabControl.TabIndex = 0;
            // 
            // PlayFair
            // 
            PlayFair.Controls.Add(panel1);
            PlayFair.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayFair.Location = new Point(4, 35);
            PlayFair.Name = "PlayFair";
            PlayFair.Padding = new Padding(3);
            PlayFair.Size = new Size(604, 622);
            PlayFair.TabIndex = 0;
            PlayFair.Text = "PlayFair";
            PlayFair.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdo6x6);
            panel1.Controls.Add(rdo5x5);
            panel1.Controls.Add(panelMatrix);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 574);
            panel1.TabIndex = 0;
            // 
            // rdo6x6
            // 
            rdo6x6.AutoSize = true;
            rdo6x6.Location = new Point(361, 290);
            rdo6x6.Name = "rdo6x6";
            rdo6x6.Size = new Size(66, 30);
            rdo6x6.TabIndex = 4;
            rdo6x6.TabStop = true;
            rdo6x6.Text = "6x6";
            rdo6x6.UseVisualStyleBackColor = true;
            rdo6x6.CheckedChanged += rdo6x6_CheckedChanged;
            // 
            // rdo5x5
            // 
            rdo5x5.AutoSize = true;
            rdo5x5.Location = new Point(361, 244);
            rdo5x5.Name = "rdo5x5";
            rdo5x5.Size = new Size(66, 30);
            rdo5x5.TabIndex = 3;
            rdo5x5.TabStop = true;
            rdo5x5.Text = "5x5";
            rdo5x5.UseVisualStyleBackColor = true;
            rdo5x5.CheckedChanged += rdo5x5_CheckedChanged;
            // 
            // panelMatrix
            // 
            panelMatrix.Location = new Point(6, 175);
            panelMatrix.Name = "panelMatrix";
            panelMatrix.Size = new Size(336, 337);
            panelMatrix.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(PlayfairKey);
            panel3.Controls.Add(TextBox);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 155);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 121);
            label1.Name = "label1";
            label1.Size = new Size(327, 26);
            label1.TabIndex = 2;
            label1.Text = "Short version of the Playfair Key:";
            // 
            // PlayfairKey
            // 
            PlayfairKey.Location = new Point(331, 115);
            PlayfairKey.Name = "PlayfairKey";
            PlayfairKey.Size = new Size(246, 34);
            PlayfairKey.TabIndex = 1;
            PlayfairKey.TextChanged += PlayfairKey_TextChanged;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(3, 3);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(574, 100);
            TextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(DecryptBtn);
            panel2.Controls.Add(EncryptBtn);
            panel2.Location = new Point(0, 518);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 53);
            panel2.TabIndex = 0;
            // 
            // DecryptBtn
            // 
            DecryptBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            DecryptBtn.Location = new Point(174, 3);
            DecryptBtn.Name = "DecryptBtn";
            DecryptBtn.Size = new Size(165, 47);
            DecryptBtn.TabIndex = 1;
            DecryptBtn.Text = "Decrypt";
            DecryptBtn.UseVisualStyleBackColor = true;
            DecryptBtn.Click += DecryptBtn_Click;
            // 
            // EncryptBtn
            // 
            EncryptBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            EncryptBtn.Location = new Point(3, 3);
            EncryptBtn.Name = "EncryptBtn";
            EncryptBtn.Size = new Size(165, 47);
            EncryptBtn.TabIndex = 0;
            EncryptBtn.Text = "Encrypt";
            EncryptBtn.UseVisualStyleBackColor = true;
            EncryptBtn.Click += EncryptBtn_Click;
            // 
            // RSA
            // 
            RSA.Location = new Point(4, 35);
            RSA.Name = "RSA";
            RSA.Padding = new Padding(3);
            RSA.Size = new Size(604, 622);
            RSA.TabIndex = 1;
            RSA.Text = "RSA";
            RSA.UseVisualStyleBackColor = true;
            // 
            // ProjectATM
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 685);
            Controls.Add(TabControl);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ProjectATM";
            Text = "ProjectATM";
            TabControl.ResumeLayout(false);
            PlayFair.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage PlayFair;
        private TabPage RSA;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button DecryptBtn;
        private Button EncryptBtn;
        private Panel panelMatrix;
        private Label label1;
        private TextBox PlayfairKey;
        private TextBox TextBox;
        private RadioButton rdo6x6;
        private RadioButton rdo5x5;
    }
}