using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnATM
{
    public partial class ProjectATM : Form
    {
        

        public ProjectATM()
        {
            InitializeComponent();
            formStart();

        }
        public struct PointKT
        {
            public int Row;
            public int Col;
            public string KyTu;

            public PointKT(string kyTu) {KyTu = kyTu; Row = -1; Col = -1;}

            public PointKT(int row, int col, string kyTu)
            {
                Row = row;
                Col = col;
                KyTu = kyTu;
            }

            public override string ToString()
            {
                return $"({Row}, {Col}): '{KyTu}'";
            }
        }
        public void formStart()
        {
            rdo5x5.Checked = true;
        }

        #region PlayFair

        #region Matrix
        public void Matrix()
        {
            // Xác định kích thước ma trận
            int rows = rdo5x5.Checked ? 5 : 6;
            int cols = rdo5x5.Checked ? 5 : 6;

            string rawKey = PlayfairKey.Text.ToUpper();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            //tạo bộ ký tự phù hợp 
            string baseChars = rdo5x5.Checked ? alphabet.Replace("J", "I") : alphabet + digits;

            //Loại bỏ những ký tự trùng hoặc không phù hợp
            string key = new string(rawKey
                .Where(c => baseChars.Contains(c))
                .Distinct()
                .ToArray());

            foreach (char c in baseChars)
                if (!key.Contains(c)) key += c;

            // Kích thước mỗi nút (có thể chỉnh tùy ý)
            int buttonSize = 45;
            int spacing = 4; // khoảng cách giữa các nút

            // Xóa các nút cũ
            panelMatrix.Controls.Clear();
            panelMatrix.SuspendLayout();

            for (int i = 0; i < rows * cols; i++)
            {
                Button btn = new Button();
                btn.Text = key.Length > i ? key[i].ToString() : "";
                btn.Width = buttonSize;
                btn.Height = buttonSize;
                btn.Enabled = false;
                btn.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;

                // Tính vị trí (X, Y)
                int x = (i % cols) * (buttonSize + spacing);
                int y = (i / cols) * (buttonSize + spacing);

                btn.Location = new Point(x, y);

                panelMatrix.Controls.Add(btn);
            }
            panelMatrix.Width = cols * (buttonSize + spacing);
            panelMatrix.Height = rows * (buttonSize + spacing);

            panelMatrix.ResumeLayout();
        }

        public string GetSymbolAt(int row, int col, int size)
        {
            int index = row * size + col;

            var buttons = panelMatrix.Controls.OfType<Button>()
                .OrderBy(b => b.Top)
                .ThenBy(b => b.Left)
                .ToList();

            if (index >= 0 && index < buttons.Count)
            {
                return buttons[index].Text;
            }

            return "";
        }

        public void FindSymbolPositions(ref PointKT pointChar, int size)
        {
            var buttons = panelMatrix.Controls.OfType<Button>()
                .OrderBy(b => b.Top)
                .ThenBy(b => b.Left)
                .ToList();
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Text == pointChar.KyTu)
                {
                    pointChar.Row = i / size;
                    pointChar.Col = i % size;
                    return;
                }
            }
        }

        #endregion

        public string Preformatting()
        {
            // Bước 1: Xử lý chuỗi đầu vào
            string textPF = new string(TextBox.Text
                .ToUpper()
                .Where(char.IsLetterOrDigit)
                .ToArray());

            // Bước 2: Tách cặp và xử lý trùng
            StringBuilder processed = new StringBuilder();

            int i = 0;
            while (i < textPF.Length)
            {
                char first = textPF[i];
                char second = (i + 1 < textPF.Length) ? textPF[i + 1] : 'X';

                if (first == second)
                {
                    // Nếu 2 ký tự trùng nhau: thêm X và lùi lại 1 ký tự
                    processed.Append(first);
                    processed.Append('X');
                    i += 1; // chỉ tăng 1 để giữ lại second làm first lần sau
                }
                else
                {
                    processed.Append(first);
                    processed.Append(second);
                    i += 2;
                }
            }

            // Nếu sau khi xử lý mà độ dài lẻ → thêm X
            if (processed.Length % 2 != 0)
            {
                processed.Append('X');
            }

            // Bước 3: Chèn khoảng trắng sau mỗi cặp
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < processed.Length; j += 2)
            {
                if (j > 0) sb.Append(" ");
                sb.Append(processed[j]);
                sb.Append(processed[j + 1]);
            }

            return sb.ToString();
        }

        #region Encryt
        public void EncryptionCases(ref PointKT point1, ref PointKT point2, int size)
        {
            if (point1.Row == point2.Row)
            {
                point1.Col = (point1.Col + 1) % size;
                point2.Col = (point2.Col + 1) % size;
            }
            else if (point1.Col == point2.Col)
            {
                point1.Row = (point1.Row + 1) % size;
                point2.Row = (point2.Row + 1) % size;
            }
            else
            {
                int col = point1.Col;
                point1.Col = point2.Col;
                point2.Col = col;
            }

            point1.KyTu = GetSymbolAt(point1.Row, point1.Col, size);
            point2.KyTu = GetSymbolAt(point2.Row, point2.Col, size);
        }


        public string Encrytion(string textPre)
        {
            int size = rdo5x5.Checked ? 5 : 6;
            StringBuilder result = new StringBuilder();

            textPre = new string(textPre
                .Where(char.IsLetterOrDigit)
                .ToArray());


            for (int i = 0; i < textPre.Length; i += 2)
            {
                PointKT pointChar1 = new PointKT { KyTu = textPre[i].ToString() };
                PointKT pointChar2 = new PointKT { KyTu = textPre[i + 1].ToString() };

                FindSymbolPositions(ref pointChar1, size);
                FindSymbolPositions(ref pointChar2, size);

                EncryptionCases(ref pointChar1, ref pointChar2, size);

                result.Append(pointChar1.KyTu);
                result.Append(pointChar2.KyTu);
                result.Append(' ');
            }

            return result.ToString().TrimEnd();
        }

        #endregion

        #region Decryt

        public void DecryptionCases(ref PointKT point1, ref PointKT point2, int size)
        {
            if (point1.Row == point2.Row)
            {
                point1.Col = (point1.Col - 1 + size) % size;
                point2.Col = (point2.Col - 1 + size) % size;
            }
            else if (point1.Col == point2.Col)
            {
                point1.Row = (point1.Row - 1 + size) % size;
                point2.Row = (point2.Row - 1 + size) % size;
            }
            else
            {
                int col = point1.Col;
                point1.Col = point2.Col;
                point2.Col = col;
            }

            point1.KyTu = GetSymbolAt(point1.Row, point1.Col, size);
            point2.KyTu = GetSymbolAt(point2.Row, point2.Col, size);
        }

        public string Decrytion(string textPre)
        {
            int size = rdo5x5.Checked ? 5 : 6;
            StringBuilder result = new StringBuilder();

            textPre = new string(textPre
                .Where(char.IsLetterOrDigit)
                .ToArray());


            for (int i = 0; i < textPre.Length; i += 2)
            {
                PointKT pointChar1 = new PointKT { KyTu = textPre[i].ToString() };
                PointKT pointChar2 = new PointKT { KyTu = textPre[i + 1].ToString() };

                FindSymbolPositions(ref pointChar1, size);
                FindSymbolPositions(ref pointChar2, size);

                DecryptionCases(ref pointChar1, ref pointChar2, size);

                result.Append(pointChar1.KyTu);
                result.Append(pointChar2.KyTu);
                result.Append(' ');
            }

            return result.ToString().TrimEnd();
        }

        #endregion

        #region event
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            string textPreFormatting = Preformatting();
            string textEncryp = Encrytion(textPreFormatting);
            EncryptPlayfair encryptPlayfair = new EncryptPlayfair(textPreFormatting, textEncryp);
            encryptPlayfair.Show();
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            string textPreFormatting = Preformatting();
            string textDecryp = Decrytion(textPreFormatting);
            DecryptPlayfair decryptPlayfair = new DecryptPlayfair(textDecryp);
            decryptPlayfair.Show();
        }

        private void PlayfairKey_TextChanged(object sender, EventArgs e)
        {
            Matrix();
        }

        private void rdo5x5_CheckedChanged(object sender, EventArgs e)
        {
            Matrix();
        }

        private void rdo6x6_CheckedChanged(object sender, EventArgs e)
        {
            Matrix();
        }
        #endregion

        #endregion


        #region RSA

        #endregion





        
    }
}
