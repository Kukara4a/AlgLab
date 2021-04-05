using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AlgorithmsLab1
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                long q = Convert.ToInt64(textBox_q.Text);

                if (RSA.IsTheNumberSimple(p) && RSA.IsTheNumberSimple(q))
                {
                    string textForEncryption = "";

                    StreamReader text = new StreamReader("in.txt");

                    while (!text.EndOfStream)                    
                        textForEncryption += text.ReadLine();
                    
                    text.Close();

                    long n = p * q;
                    long fi = (p - 1) * (q - 1);
                    long e_ = RSA.Calculate_e(fi);
                    long d = RSA.Calculate_d(e_, fi);

                    List<string> result = RSA.Encode(textForEncryption, e_, n);

                    StreamWriter encryptedText = new StreamWriter("out1.txt");

                    foreach (string item in result)
                        encryptedText.WriteLine(item);

                    encryptedText.Close();

                    textBox_e.Text = e_.ToString();
                    textBox_n.Text = n.ToString();
                    textBox_n1.Text = n.ToString();
                    textBox_d.Text = d.ToString();

                    Process.Start("out1.txt");
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox_e.Text.Length > 0) && (textBox_n.Text.Length > 0))
            {
                long d = Convert.ToInt64(textBox_d.Text);
                long n = Convert.ToInt64(textBox_n.Text);

                List<string> input = new List<string>();
               
                StreamReader encryptedText = new StreamReader("out1.txt");

                while (!encryptedText.EndOfStream)             
                    input.Add(encryptedText.ReadLine());
                
                encryptedText.Close();

                string result = RSA.Decode(input, d, n);

                StreamWriter decryptedText = new StreamWriter("out2.txt");
                decryptedText.WriteLine(result);
                decryptedText.Close();

                Process.Start("out2.txt");
            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
    }
}
