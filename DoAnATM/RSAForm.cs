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

namespace DoAnATM
{
    public partial class RSAForm : MetroFramework.Forms.MetroForm
    {
        public RSAForm()
        {
            InitializeComponent();
        }

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
            TypeNumberBox.SelectedIndex = 0;
            TypeNumberBox.Enabled = false;
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
            TypeNumberBox.SelectedIndex = 0;
            TypeNumberBox.Enabled = false;
            DelKeyRSABtn_Click(sender, e);
            DelTxtBtn1_Click(sender, e);
            DelTxtBtn2_Click(sender, e);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.Red;
            CloseBtn.ForeColor = Color.White;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.White;
            CloseBtn.ForeColor = Color.Black;
        }

        #endregion
        
    }
}
