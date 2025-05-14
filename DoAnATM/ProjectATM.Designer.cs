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
            button3 = new Button();
            ExportFileBtn = new Button();
            DelInputBtn = new Button();
            SelectFileBtn = new Button();
            OutputTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            InputText = new TextBox();
            panel2 = new Panel();
            ReverseBtn = new Button();
            DecryptBtn = new Button();
            EncryptBtn = new Button();
            PlayfairKeyGR = new GroupBox();
            label2 = new Label();
            RandomKeyBtn = new Button();
            rdo6x6 = new RadioButton();
            label1 = new Label();
            panelMatrix = new Panel();
            PlayfairKey = new TextBox();
            rdo5x5 = new RadioButton();
            RSA = new TabPage();
            TabControl.SuspendLayout();
            PlayFair.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            PlayfairKeyGR.SuspendLayout();
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
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(ExportFileBtn);
            groupBox1.Controls.Add(DelInputBtn);
            groupBox1.Controls.Add(SelectFileBtn);
            groupBox1.Controls.Add(OutputTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(InputText);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(20, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 344);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "ENCRYPT, DECRYPT";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(544, 145);
            button3.Name = "button3";
            button3.Size = new Size(165, 35);
            button3.TabIndex = 7;
            button3.Text = "Delete Output";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ExportFileBtn
            // 
            ExportFileBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExportFileBtn.Location = new Point(373, 145);
            ExportFileBtn.Name = "ExportFileBtn";
            ExportFileBtn.Size = new Size(165, 35);
            ExportFileBtn.TabIndex = 6;
            ExportFileBtn.Text = "Export File";
            ExportFileBtn.UseVisualStyleBackColor = true;
            ExportFileBtn.Click += ExportFileBtn_Click;
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
            DelInputBtn.Text = "Delete Input";
            DelInputBtn.UseVisualStyleBackColor = false;
            DelInputBtn.Click += DelInputBtn_Click;
            // 
            // SelectFileBtn
            // 
            SelectFileBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectFileBtn.Location = new Point(376, 33);
            SelectFileBtn.Name = "SelectFileBtn";
            SelectFileBtn.Size = new Size(165, 35);
            SelectFileBtn.TabIndex = 4;
            SelectFileBtn.Text = "Select File";
            SelectFileBtn.UseVisualStyleBackColor = true;
            SelectFileBtn.Click += SelectFileBtn_Click;
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
            label4.Size = new Size(128, 26);
            label4.TabIndex = 2;
            label4.Text = "Output Text:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 42);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 1;
            label3.Text = "Input Text:";
            // 
            // InputText
            // 
            InputText.Location = new Point(30, 78);
            InputText.Multiline = true;
            InputText.Name = "InputText";
            InputText.Size = new Size(682, 54);
            InputText.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ReverseBtn);
            panel2.Controls.Add(DecryptBtn);
            panel2.Controls.Add(EncryptBtn);
            panel2.Location = new Point(30, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 53);
            panel2.TabIndex = 0;
            // 
            // ReverseBtn
            // 
            ReverseBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReverseBtn.Location = new Point(514, 3);
            ReverseBtn.Name = "ReverseBtn";
            ReverseBtn.Size = new Size(165, 48);
            ReverseBtn.TabIndex = 2;
            ReverseBtn.Text = "Reverse";
            ReverseBtn.UseVisualStyleBackColor = true;
            ReverseBtn.Click += ReverseBtn_Click;
            // 
            // DecryptBtn
            // 
            DecryptBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            DecryptBtn.Location = new Point(194, 3);
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
            // PlayfairKeyGR
            // 
            PlayfairKeyGR.BackColor = Color.Transparent;
            PlayfairKeyGR.Controls.Add(label2);
            PlayfairKeyGR.Controls.Add(RandomKeyBtn);
            PlayfairKeyGR.Controls.Add(rdo6x6);
            PlayfairKeyGR.Controls.Add(label1);
            PlayfairKeyGR.Controls.Add(panelMatrix);
            PlayfairKeyGR.Controls.Add(PlayfairKey);
            PlayfairKeyGR.Controls.Add(rdo5x5);
            PlayfairKeyGR.Location = new Point(20, 17);
            PlayfairKeyGR.Name = "PlayfairKeyGR";
            PlayfairKeyGR.Size = new Size(729, 393);
            PlayfairKeyGR.TabIndex = 5;
            PlayfairKeyGR.TabStop = false;
            PlayfairKeyGR.Text = "KEY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 140);
            label2.Name = "label2";
            label2.Size = new Size(122, 26);
            label2.TabIndex = 5;
            label2.Text = "Matrix Size:";
            // 
            // RandomKeyBtn
            // 
            RandomKeyBtn.Location = new Point(169, 33);
            RandomKeyBtn.Name = "RandomKeyBtn";
            RandomKeyBtn.Size = new Size(181, 38);
            RandomKeyBtn.TabIndex = 3;
            RandomKeyBtn.Text = "Random Key";
            RandomKeyBtn.UseVisualStyleBackColor = true;
            RandomKeyBtn.Click += RandomKeyBtn_Click;
            // 
            // rdo6x6
            // 
            rdo6x6.AutoSize = true;
            rdo6x6.Location = new Point(284, 140);
            rdo6x6.Name = "rdo6x6";
            rdo6x6.Size = new Size(66, 30);
            rdo6x6.TabIndex = 4;
            rdo6x6.TabStop = true;
            rdo6x6.Text = "6x6";
            rdo6x6.UseVisualStyleBackColor = true;
            rdo6x6.CheckedChanged += rdo6x6_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 26);
            label1.TabIndex = 2;
            label1.Text = "Enter Key:";
            // 
            // panelMatrix
            // 
            panelMatrix.Location = new Point(376, 33);
            panelMatrix.Name = "panelMatrix";
            panelMatrix.Size = new Size(336, 337);
            panelMatrix.TabIndex = 2;
            // 
            // PlayfairKey
            // 
            PlayfairKey.Location = new Point(30, 83);
            PlayfairKey.Name = "PlayfairKey";
            PlayfairKey.Size = new Size(320, 34);
            PlayfairKey.TabIndex = 1;
            PlayfairKey.TextChanged += PlayfairKey_TextChanged;
            // 
            // rdo5x5
            // 
            rdo5x5.AutoSize = true;
            rdo5x5.Location = new Point(169, 140);
            rdo5x5.Name = "rdo5x5";
            rdo5x5.Size = new Size(66, 30);
            rdo5x5.TabIndex = 3;
            rdo5x5.TabStop = true;
            rdo5x5.Text = "5x5";
            rdo5x5.UseVisualStyleBackColor = true;
            rdo5x5.CheckedChanged += rdo5x5_CheckedChanged;
            // 
            // RSA
            // 
            RSA.Location = new Point(4, 35);
            RSA.Name = "RSA";
            RSA.Padding = new Padding(3);
            RSA.Size = new Size(784, 818);
            RSA.TabIndex = 1;
            RSA.Text = "RSA";
            RSA.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage PlayFair;
        private TabPage RSA;
        private Panel panel1;
        private Panel panel2;
        private Button DecryptBtn;
        private Button EncryptBtn;
        private Panel panelMatrix;
        private RadioButton rdo6x6;
        private RadioButton rdo5x5;
        private Button RandomKeyBtn;
        private Label label1;
        private TextBox PlayfairKey;
        private TextBox InputText;
        private GroupBox PlayfairKeyGR;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox OutputTxt;
        private Button ReverseBtn;
        private Button DelInputBtn;
        private Button SelectFileBtn;
        private Button button3;
        private Button ExportFileBtn;
    }
}