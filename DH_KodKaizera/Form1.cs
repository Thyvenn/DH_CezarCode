using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH_KodKaizera
{
    public partial class DH_kodKaizera : Form
    {
        public DH_kodKaizera()
        {
            InitializeComponent();
        }

        // Określenie tablicy z alfabetem
       static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        // funkcja szyfrująca
            public static string ciper(string ciper_input, int drift)
            {
                string ciper_out = string.Empty;
                string builder = string.Empty;
                foreach (char xchar in ciper_input)
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (alphabet[i] == xchar)
                        {
                            if (alphabet.Length <= (i + drift))
                            {
                                int reszta = (i + drift) - alphabet.Length;
                                builder += alphabet[reszta];
                            }
                            else
                            {
                                builder += alphabet[i + drift];

                            }
                        }
                    }
                }
                ciper_out = builder;
                return ciper_out;
            }


        // Funkcja Deszyfrująca
        public static string deciper(string deciper_input, int drift)
        {
            string deciper_out = string.Empty;
            string builder = string.Empty;
            foreach (char xchar in deciper_input)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == xchar)
                    {
                        if (0 > (i - drift))
                        {
                            int reszta = alphabet.Length + (i - drift);
                            builder += alphabet[reszta];
                        }
                        else
                        {
                            builder += alphabet[i - drift];

                        }
                    }
                }
            }
            deciper_out = builder;
            return deciper_out;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Button szyfrujący
            int bt1_drift = (int)numericUpDown1.Value;
            string bt1_text = textBox1.Text;
            var bt1_result = ciper(bt1_text, bt1_drift);
            label3.Visible = true;
            label3.Text = bt1_result;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Button szyfrujący
            int bt2_drift = (int)numericUpDown2.Value;
            string bt2_text = textBox2.Text;
            var bt2_result = deciper(bt2_text, bt2_drift);
            label4.Visible = true;
            label4.Text = bt2_result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
