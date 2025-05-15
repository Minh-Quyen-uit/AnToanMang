using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            public PointKT(string kyTu) { KyTu = kyTu; Row = -1; Col = -1; }

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
            Size5x5.Checked = true;
        }

        #region PlayFair

        #region MaTrix
        public void Matrix()
        {
            // Xác định kích thước ma trận
            int rows = Size5x5.Checked ? 5 : 6;
            int cols = Size5x5.Checked ? 5 : 6;

            string rawKey = PlayfairKey.Text.ToUpper();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            //tạo bộ ký tự phù hợp 
            string baseChars = Size5x5.Checked ? alphabet.Replace("J", "I") : alphabet + digits;

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
            PanelMaTrix.Controls.Clear();
            PanelMaTrix.SuspendLayout();

            for (int i = 0; i < rows * cols; i++)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
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

                PanelMaTrix.Controls.Add(btn);
            }
            PanelMaTrix.Width = cols * (buttonSize + spacing);
            PanelMaTrix.Height = rows * (buttonSize + spacing);

            PanelMaTrix.ResumeLayout();
        }

        public string GetSymbolAt(int row, int col, int size)
        {
            int index = row * size + col;

            var buttons = PanelMaTrix.Controls.OfType<System.Windows.Forms.Button>()
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
            var buttons = PanelMaTrix.Controls.OfType<System.Windows.Forms.Button>()
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

        public string Preformatting(string textPF)
        {
            // Bước 1: Xử lý chuỗi đầu vào
            textPF = new string(InputTxt.Text
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
            int size = Size5x5.Checked ? 5 : 6;
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

        private string DelX(string text)
        {
            text = new string(text
                .Where(char.IsLetterOrDigit)
                .ToArray());

            StringBuilder sb = new StringBuilder(text);
            // Xóa ký tự 'X' nằm giữa các ký tự giống nhau
            for (int i = 1; i < text.Length - 1; i++)
            {
                if (sb[i] == 'X' && sb[i - 1] == sb[i + 1])
                {
                    sb.Remove(i, 1);
                    i--; // Cập nhật lại độ dài chuỗi
                }
            }

            // Xóa ký tự 'X' ở cuối chuỗi nếu có
            if (sb.Length > 0 && sb[sb.Length - 1] == 'X')
                sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

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
            int size = Size5x5.Checked ? 5 : 6;
            StringBuilder result = new StringBuilder();

            textPre = new string(textPre
                .Where(char.IsLetterOrDigit)
                .ToArray());

            if (textPre.Length % 2 != 0)
            {
                textPre += "X";
            }

            for (int i = 0; i < textPre.Length; i += 2)
            {
                PointKT pointChar1 = new PointKT { KyTu = textPre[i].ToString() };
                PointKT pointChar2 = new PointKT { KyTu = textPre[i + 1].ToString() };

                FindSymbolPositions(ref pointChar1, size);
                FindSymbolPositions(ref pointChar2, size);

                DecryptionCases(ref pointChar1, ref pointChar2, size);

                result.Append(pointChar1.KyTu);
                result.Append(pointChar2.KyTu);
            }

            return DelX(result.ToString());
        }

        #endregion

        #region RandomKey

        private string RandomKeyFunc()
        {
            string key = (Size5x5.Checked == true) ? "ABCDEFGHIKLMNOPQRSTUVWXYZ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random Rand = new Random();
            return new string(key.OrderBy(c => Rand.Next()).Take(10).ToArray());
        }

        #endregion

        #region Btn_Click

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputTxt.Text))
            {
                MessageBox.Show("You have not entered anything!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textPreFormatting = Preformatting(InputTxt.Text);
            string textEncryp = Encrytion(textPreFormatting);
            OutputTxt.Text = textEncryp;
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputTxt.Text))
            {
                MessageBox.Show("You have not entered anything!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textPreFormatting = Preformatting(InputTxt.Text);
            string textDecryp = Decrytion(textPreFormatting);
            OutputTxt.Text = textDecryp;
        }

        private void ReverseBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OutputTxt.Text))
            {
                MessageBox.Show("You have not entered anything!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string textDecryp = Decrytion(OutputTxt.Text);
            InputTxt.Text = textDecryp;
        }

        private void RandomKeyBtn_Click(object sender, EventArgs e)
        {
            PlayfairKey.Text = RandomKeyFunc();
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn File";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;

                    try
                    {
                        string noidung = File.ReadAllText(path);
                        InputTxt.Text = string.Empty;
                        InputTxt.Text = noidung.Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi đọc tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void SaveFilePFBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OutputTxt.Text.Trim()))
            {
                MessageBox.Show("Vui lòng thêm nội dung trước khi lưu tệp.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Lưu Tệp Văn Bản";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = saveFileDialog.FileName;
                        string content = OutputTxt.Text;

                        File.WriteAllText(filePath, content);

                        MessageBox.Show("Tệp đã được lưu thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi lưu tệp:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DelKeyBtn_Click(object sender, EventArgs e)
        {
            PlayfairKey.Clear();
        }

        private void DelInputBtn_Click(object sender, EventArgs e)
        {
            InputTxt.Clear();
        }

        private void DelOutputBtn_Click(object sender, EventArgs e)
        {
            OutputTxt.Clear();
        }

        #endregion

        #region event

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

        #region RSA_Algorithm

        private BigInteger num_p = 0, num_q = 0, num_n = 0, phi = 0, num_e = 0, num_d = 0;

        private bool IsPrime(BigInteger n)
        {
            if (n < 2) return false;
            for (BigInteger i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private bool IsJustNumberAndSpace(string content)
        {
            foreach (char c in content)
            {
                if (!char.IsDigit(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, x0 = 0, x1 = 1;
            if (m == 1)
                return 0;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger temp = m;

                m = a % m;
                a = temp;
                temp = x0;

                x0 = x1 - q * x0;
                x1 = temp;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }
        private BigInteger GenerateRandomNumber(Random random, int bits)
        {
            byte[] bytes = new byte[(bits + 7) / 8];
            random.NextBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F;
            BigInteger number = new BigInteger(bytes);
            return number | (BigInteger.One << (bits - 1));
        }
        private BigInteger GeneratePrime(Random r, int bits)
        {
            BigInteger one;
            do
            {
                one = GenerateRandomNumber(r, bits);
                if (one % 2 == 0)
                    one++;
            } while (!IsPrime(one));
            return one;
        }
        private void Find_D_and_E()
        {
            Random r = new Random();
            num_n = num_p * num_q;
            phi = (num_p - 1) * (num_q - 1);

            do
            {
                num_e = r.Next(2, (int)phi);
            } while (GCD(num_e, phi) != 1);

            num_d = ModInverse(num_e, phi);
        }
        private void GenerateKeyPair()
        {
            Random random = new Random();
            do
            {
                num_p = GeneratePrime(random, 8);
                num_q = GeneratePrime(random, 8);
            }
            while (num_p == num_q);
            Find_D_and_E();

        }

        private bool IsBinary(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsHexadecimal(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            foreach (char c in input)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                {
                    return false;
                }
            }
            return true;
        }
        private BigInteger ParseBinary(string binaryText)
        {
            if (string.IsNullOrEmpty(binaryText) || !IsBinary(binaryText))
            {
                throw new ArgumentException("Invalid binary format");
            }

            return new BigInteger(Convert.ToInt64(binaryText, 2));
        }

        private BigInteger ParseHexadecimal(string hexText)
        {
            if (string.IsNullOrEmpty(hexText) || !IsHexadecimal(hexText))
            {
                throw new ArgumentException("Invalid hexadecimal format");
            }

            try
            {
                return BigInteger.Parse(hexText, System.Globalization.NumberStyles.HexNumber);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid hexadecimal format");
            }
        }
        private bool IsValueAccepted()
        {
            int selectedIndex = TypeNumberBox.SelectedIndex;
            string pText = PTxt.Text;
            string qText = QTxt.Text;

            if (string.IsNullOrWhiteSpace(pText) && string.IsNullOrWhiteSpace(qText))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BigInteger p, q;

            switch (selectedIndex)
            {
                case 1:
                    if (!BigInteger.TryParse(pText, out p) || !BigInteger.TryParse(qText, out q))
                    {
                        MessageBox.Show("P và Q phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;

                case 2:
                    if (!IsBinary(pText) || !IsBinary(qText))
                    {
                        MessageBox.Show("P và Q phải là số nhị phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    p = ParseBinary(pText);
                    q = ParseBinary(qText);
                    break;

                case 3:
                    if (!IsHexadecimal(pText) || !IsHexadecimal(qText))
                    {
                        MessageBox.Show("P và Q phải là số thập lục phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    p = ParseHexadecimal(pText);
                    q = ParseHexadecimal(qText);
                    break;

                default:
                    MessageBox.Show("Vui lòng chọn loại đầu vào hợp lệ từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }

            if (!IsPrime(p) || !IsPrime(q))
            {
                MessageBox.Show("P và Q phải là số nguyên tố!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (p == q)
            {
                MessageBox.Show("P và Q phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (p * q < 128)
            {
                MessageBox.Show("Nhập lại P và Q do tích của cả hai phải hơn 128", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            num_p = p;
            num_q = q;

            Find_D_and_E();

            PublicKeyTxt.Text = $"e = {num_e}, n = {num_n}";
            PrivateKeyTxt.Text = $"d = {num_d}, n = {num_n}";
            return true;

        }

        #endregion

        #region Encrypt

        private string Encrypt(string plaintext)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plaintext);
            BigInteger[] cipherBytes = new BigInteger[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                cipherBytes[i] = BigInteger.ModPow(bytes[i], num_e, num_n);
            }

            return string.Join(" ", cipherBytes);
        }

        #endregion

        #region Decrypt

        private string Decrypt(string ciphertext)
        {
            string[] parts = ciphertext.Split(' ');
            StringBuilder plainTextBuilder = new StringBuilder();

            for (int i = 0; i < parts.Length; i++)
            {
                BigInteger cipherValue = BigInteger.Parse(parts[i]);
                BigInteger decryptedValue = BigInteger.ModPow(cipherValue, num_d, num_n);


                plainTextBuilder.Append((char)(decryptedValue));
            }

            return plainTextBuilder.ToString();
        }

        #endregion

        #region Btn_Click

        private void ManualBtn_Click(object sender, EventArgs e)
        {
            TypeNumberBox.Enabled = true;
        }

        private void RandomKeyRSABtn_Click(object sender, EventArgs e)
        {
            PTxt.Enabled = true;
            PTxt.ReadOnly = true;
            QTxt.Enabled = true;
            PTxt.ReadOnly = true;
            TypeNumberBox.SelectedIndex = 0;
            TypeNumberBox.Enabled = false;
            GenerateKeyPair();
            PTxt.Text = $"{num_p}";
            QTxt.Text = $"{num_q}";
            PublicKeyTxt.Text = $"e = {num_e}, n = {num_n}";
            PrivateKeyTxt.Text = $"d = {num_d}, n = {num_n}";
        }

        private void DelKeyRSABtn_Click(object sender, EventArgs e)
        {
            PTxt.Clear();
            QTxt.Clear();
            PublicKeyTxt.Clear();
            PrivateKeyTxt.Clear();
            ETxt.Clear();
        }

        private void UpdateEBtn_Click(object sender, EventArgs e)
        {
            string newEText = ETxt.Text; // ETextBox là TextBox chứa giá trị E mới
            BigInteger newE;

            if (!BigInteger.TryParse(newEText, out newE))
            {
                MessageBox.Show("E phải là một số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newE <= 1 || newE >= phi)
            {
                MessageBox.Show($"E phải nằm trong khoảng (1, {phi})!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GCD(newE, phi) != 1)
            {
                MessageBox.Show("E phải nguyên tố cùng nhau với φ(n)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            num_e = newE;
            num_d = ModInverse(num_e, phi);

            MessageBox.Show("Số E đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PublicKeyTxt.Text = $"e = {num_e}, n = {num_n}";
            PrivateKeyTxt.Text = $"d = {num_d}, n = {num_n}";
        }

        private void EncryptRSABtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlainTxt1.Text))
            {
                MessageBox.Show("Vui lòng nhập thông điệp cần mã hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ciphertext = Encrypt(PlainTxt1.Text);
            CipherTxt1.Enabled = true;
            CipherTxt1.Text = ciphertext;
        }

        private void ReverseRSABtn1_Click(object sender, EventArgs e)
        {
            RSATabControl.SelectedIndex = 1;
            CipherTxt2.Text = CipherTxt1.Text;
        }

        private void SelectFileRSABtn1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn File";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;

                    try
                    {
                        string noidung = File.ReadAllText(path);
                        PlainTxt1.Text = string.Empty;
                        PlainTxt1.Text = noidung.Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi đọc tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void SaveFileRSABtn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CipherTxt1.Text.Trim()))
            {
                MessageBox.Show("Vui lòng thêm nội dung trước khi lưu tệp.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Lưu Tệp Văn Bản";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = saveFileDialog.FileName;
                        string content = CipherTxt1.Text;

                        File.WriteAllText(filePath, content);

                        MessageBox.Show("Tệp đã được lưu thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi lưu tệp:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DelTxtBtn1_Click(object sender, EventArgs e)
        {
            PlainTxt1.Clear();
            CipherTxt1.Clear();
        }

        private void DecryptRSABtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CipherTxt2.Text))
            {
                MessageBox.Show("Vui lòng nhập bản mã cần giải mã.");
                return;
            }
            string plaintext = Decrypt(CipherTxt2.Text);
            PlainTxt2.Text = plaintext;
        }

        private void ReverseBtn2_Click(object sender, EventArgs e)
        {
            RSATabControl.SelectedIndex = 0;
            PlainTxt1.Text = PlainTxt2.Text;
        }

        private void SelectFileRSABtn2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn File";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;

                    try
                    {
                        string noidung = File.ReadAllText(path);
                        CipherTxt2.Text = string.Empty;
                        CipherTxt2.Text = noidung.Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi đọc tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void SaveFileRSABtn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlainTxt2.Text.Trim()))
            {
                MessageBox.Show("Vui lòng thêm nội dung trước khi lưu tệp.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Lưu Tệp Văn Bản";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = saveFileDialog.FileName;
                        string content = PlainTxt2.Text;

                        File.WriteAllText(filePath, content);

                        MessageBox.Show("Tệp đã được lưu thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi lưu tệp:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DelTxtBtn2_Click(object sender, EventArgs e)
        {
            CipherTxt2.Clear();
            PlainTxt2.Clear();
        }

        private void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            DelKeyRSABtn_Click(sender, e);
            DelTxtBtn1_Click(sender, e);
            DelTxtBtn2_Click(sender, e);
        }


        #endregion

        #region Event

        private void TypeNumberBox_SelectedValueChanged(object sender, EventArgs e)
        {
            PTxt.Enabled = true;
            PTxt.ReadOnly = false;
            QTxt.Enabled = true;
            QTxt.ReadOnly = false;
        }

        private void PTxt_Leave(object sender, EventArgs e)
        {
            IsValueAccepted();
        }

        private void QTxt_Leave(object sender, EventArgs e)
        {
            IsValueAccepted();
        }

        private void RSATabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RSATabControl.SelectedIndex == 1)
            {

                ETxt.Enabled = true;
                ETxt.ReadOnly = false;
            }
            else
                ETxt.Enabled = false;
        }

        #endregion

        #endregion












        
    }
}
