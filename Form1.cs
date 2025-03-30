using System.Numerics;

namespace RSA {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs ev) {
            try {
                BigInteger N = BigInteger.Parse(textBox5.Text);
                BigInteger e = BigInteger.Parse(textBox6.Text);
                if (e <= 1 || N <= 1) {
                    MessageBox.Show("Ошибка шифрования: длина e и N должна быть больше 1");
                    return;
                }
                if (radioButton1.Checked) {
                    if (BigInteger.Log2(N) <= textBox3.Text.Length * 16) {
                        MessageBox.Show("Ошибка шифрования: длина ключа N меньше сообщения. Разбейте сообщение на блоки, либо увеличьте ключ");
                        return;
                    }
                    BigInteger encrypted = RSA.encryptMes(textBox3.Text, e, N);
                    textBox4.Text = encrypted.ToString();
                }
                else {
                    BigInteger mes = BigInteger.Parse(textBox3.Text);
                    if (N <= mes) {
                        MessageBox.Show("Ошибка шифрования: длина ключа N меньше сообщения. Разбейте сообщение на блоки, либо увеличьте ключ");
                        return;
                    }
                    textBox4.Text = RSA.encryptMes(mes, e, N).ToString();
                }
            }
            catch (FormatException ex) {
                MessageBox.Show("Ошибка шифрования: убедитесь в корректности сообщения, либо проверьте N, e в открытом ключе");
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = RSA.generatePrimeNum().ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox2.Text = RSA.generatePrimeNum().ToString();
        }

        private void button4_Click(object sender, EventArgs ev) {
            try {
                BigInteger p = BigInteger.Parse(textBox1.Text);
                BigInteger q = BigInteger.Parse(textBox2.Text);
                if (!RSA.isPrime(p) || !RSA.isPrime(q) || p <= 1 || q <= 1) {
                    MessageBox.Show("Ошибка генерации: P и Q должны быть простыми числами и быть больше 1");
                    return;
                }
                BigInteger N = p * q;
                BigInteger f = (p - 1) * (q - 1);
                BigInteger e = RSA.generateE(f);
                textBox5.Text = N.ToString();
                textBox6.Text = e.ToString();
            }
            catch (FormatException ex) {
                MessageBox.Show("Ошибка генерации: проверьте P и Q");
            }
        }

        private void button5_Click(object sender, EventArgs ev) {
            try {
                BigInteger p = BigInteger.Parse(textBox1.Text);
                BigInteger q = BigInteger.Parse(textBox2.Text);
                BigInteger e = BigInteger.Parse(textBox6.Text);
                if (!RSA.isPrime(p) || !RSA.isPrime(q) || p <= 1 || q <= 1) {
                    MessageBox.Show("Ошибка генерации: P и Q должны быть простыми числами и быть больше 1");
                    return;
                }
                BigInteger N = p * q;
                BigInteger f = (p - 1) * (q - 1);
                if (e <= 1 || BigInteger.GreatestCommonDivisor(f, e) != 1 || e >= f) {
                    MessageBox.Show("Ошибка генерации: e должно быть 1 < e < f и быть взаимно простым с функцией Эйлера");
                    return;
                }
                BigInteger d = RSA.generateD(e, f);
                textBox7.Text = N.ToString();
                textBox8.Text = d.ToString();
            }
            catch (FormatException ex) {
                MessageBox.Show("Ошибка генерации: проверьте P,Q или e");
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            try {
                BigInteger N = BigInteger.Parse(textBox7.Text);
                BigInteger d = BigInteger.Parse(textBox8.Text);
                if (d <= 1 || N <= 1) {
                    MessageBox.Show("Ошибка расшифрования: длина d и N должна быть больше 1");
                    return;
                }
                if (radioButton1.Checked) {
                    string message = RSA.decryptMes(textBox3.Text, d, N);
                    textBox4.Text = message.ToString();
                }
                else {
                    BigInteger mes = BigInteger.Abs(BigInteger.Parse(textBox3.Text));
                    if (mes >= N) {
                        MessageBox.Show("Ошибка расшифрования: N < длины сообщения. Проверьте данные");
                        return;
                    }
                    textBox4.Text = RSA.decryptMes(mes, d, N);
                }
            }
            catch (FormatException ex) {
                MessageBox.Show("Ошибка расшифрования: убедитесь в корректности сообщения, либо проверьте N, d в закрытом ключе");
            }
        }

        private void button7_Click(object sender, EventArgs ev) {
            try {
                BigInteger N = BigInteger.Parse(textBox5.Text);
                if(BigInteger.Log2(N) > 32) {
                    MessageBox.Show("Ошибка взлома: невозможно взломать за разумное время");
                    return;
                }
                BigInteger p, q;
                if(RSA.hackKey(N, out p, out q)) {
                    textBox1.Text = p.ToString();
                    textBox2.Text = q.ToString();
                    MessageBox.Show("Взлом удался");
                }
                else {
                    MessageBox.Show("Ошибка взлома: проверьте открытый ключ");
                }

            }
            catch (FormatException ex) {
                MessageBox.Show("Ошибка взлома: Проверьте N в открытом ключе");
            }
        }
    }
}
