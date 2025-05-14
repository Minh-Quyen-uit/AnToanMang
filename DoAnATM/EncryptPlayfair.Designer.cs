namespace DoAnATM
{
    partial class EncryptPlayfair
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
            PreFormattingTxt = new TextBox();
            EncrytionTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // PreFormattingTxt
            // 
            PreFormattingTxt.Location = new Point(12, 49);
            PreFormattingTxt.Multiline = true;
            PreFormattingTxt.Name = "PreFormattingTxt";
            PreFormattingTxt.ReadOnly = true;
            PreFormattingTxt.Size = new Size(660, 198);
            PreFormattingTxt.TabIndex = 0;
            // 
            // EncrytionTxt
            // 
            EncrytionTxt.Location = new Point(12, 291);
            EncrytionTxt.Multiline = true;
            EncrytionTxt.Name = "EncrytionTxt";
            EncrytionTxt.ReadOnly = true;
            EncrytionTxt.Size = new Size(660, 198);
            EncrytionTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 26);
            label1.TabIndex = 2;
            label1.Text = "Pre-formatting:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 262);
            label2.Name = "label2";
            label2.Size = new Size(109, 26);
            label2.TabIndex = 3;
            label2.Text = "Encrption:";
            // 
            // EncryptPlayfair
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(684, 501);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EncrytionTxt);
            Controls.Add(PreFormattingTxt);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "EncryptPlayfair";
            Text = "EncryptPlayfair";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PreFormattingTxt;
        private TextBox EncrytionTxt;
        private Label label1;
        private Label label2;
    }
}