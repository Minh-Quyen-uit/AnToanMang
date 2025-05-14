namespace DoAnATM
{
    partial class DecryptPlayfair
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
            DecryptionTxt = new TextBox();
            SuspendLayout();
            // 
            // DecryptionTxt
            // 
            DecryptionTxt.Location = new Point(12, 41);
            DecryptionTxt.Multiline = true;
            DecryptionTxt.Name = "DecryptionTxt";
            DecryptionTxt.ReadOnly = true;
            DecryptionTxt.Size = new Size(499, 156);
            DecryptionTxt.TabIndex = 0;
            // 
            // DecryptPlayfair
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(523, 209);
            Controls.Add(DecryptionTxt);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "DecryptPlayfair";
            Text = "DecryptPlayfair";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DecryptionTxt;
    }
}