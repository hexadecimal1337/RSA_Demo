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
                    MessageBox.Show("������ ����������: ����� e � N ������ ���� ������ 1");
                    return;
                }
                if (radioButton1.Checked) {
                    if (BigInteger.Log2(N) <= textBox3.Text.Length * 16) {
                        MessageBox.Show("������ ����������: ����� ����� N ������ ���������. �������� ��������� �� �����, ���� ��������� ����");
                        return;
                    }
                    BigInteger encrypted = RSA.encryptMes(textBox3.Text, e, N);
                    textBox4.Text = encrypted.ToString();
                }
                else {
                    BigInteger mes = BigInteger.Parse(textBox3.Text);
                    if (N <= mes) {
                        MessageBox.Show("������ ����������: ����� ����� N ������ ���������. �������� ��������� �� �����, ���� ��������� ����");
                        return;
                    }
                    textBox4.Text = RSA.encryptMes(mes, e, N).ToString();
                }
            }
            catch (FormatException ex) {
                MessageBox.Show("������ ����������: ��������� � ������������ ���������, ���� ��������� N, e � �������� �����");
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
                    MessageBox.Show("������ ���������: P � Q ������ ���� �������� ������� � ���� ������ 1");
                    return;
                }
                BigInteger N = p * q;
                BigInteger f = (p - 1) * (q - 1);
                BigInteger e = RSA.generateE(f);
                textBox5.Text = N.ToString();
                textBox6.Text = e.ToString();
            }
            catch (FormatException ex) {
                MessageBox.Show("������ ���������: ��������� P � Q");
            }
        }

        private void button5_Click(object sender, EventArgs ev) {
            try {
                BigInteger p = BigInteger.Parse(textBox1.Text);
                BigInteger q = BigInteger.Parse(textBox2.Text);
                BigInteger e = BigInteger.Parse(textBox6.Text);
                if (!RSA.isPrime(p) || !RSA.isPrime(q) || p <= 1 || q <= 1) {
                    MessageBox.Show("������ ���������: P � Q ������ ���� �������� ������� � ���� ������ 1");
                    return;
                }
                BigInteger N = p * q;
                BigInteger f = (p - 1) * (q - 1);
                if (e <= 1 || BigInteger.GreatestCommonDivisor(f, e) != 1 || e >= f) {
                    MessageBox.Show("������ ���������: e ������ ���� 1 < e < f � ���� ������� ������� � �������� ������");
                    return;
                }
                BigInteger d = RSA.generateD(e, f);
                textBox7.Text = N.ToString();
                textBox8.Text = d.ToString();
            }
            catch (FormatException ex) {
                MessageBox.Show("������ ���������: ��������� P,Q ��� e");
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            try {
                BigInteger N = BigInteger.Parse(textBox7.Text);
                BigInteger d = BigInteger.Parse(textBox8.Text);
                if (d <= 1 || N <= 1) {
                    MessageBox.Show("������ �������������: ����� d � N ������ ���� ������ 1");
                    return;
                }
                if (radioButton1.Checked) {
                    string message = RSA.decryptMes(textBox3.Text, d, N);
                    textBox4.Text = message.ToString();
                }
                else {
                    BigInteger mes = BigInteger.Abs(BigInteger.Parse(textBox3.Text));
                    if (mes >= N) {
                        MessageBox.Show("������ �������������: N < ����� ���������. ��������� ������");
                        return;
                    }
                    textBox4.Text = RSA.decryptMes(mes, d, N);
                }
            }
            catch (FormatException ex) {
                MessageBox.Show("������ �������������: ��������� � ������������ ���������, ���� ��������� N, d � �������� �����");
            }
        }

        private void button7_Click(object sender, EventArgs ev) {
            try {
                BigInteger N = BigInteger.Parse(textBox5.Text);
                if(BigInteger.Log2(N) > 32) {
                    MessageBox.Show("������ ������: ���������� �������� �� �������� �����");
                    return;
                }
                BigInteger p, q;
                if(RSA.hackKey(N, out p, out q)) {
                    textBox1.Text = p.ToString();
                    textBox2.Text = q.ToString();
                    MessageBox.Show("����� ������");
                }
                else {
                    MessageBox.Show("������ ������: ��������� �������� ����");
                }

            }
            catch (FormatException ex) {
                MessageBox.Show("������ ������: ��������� N � �������� �����");
            }
        }
    }
}
