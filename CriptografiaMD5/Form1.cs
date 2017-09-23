using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CriptografiaMD5
{
    public partial class Form1 : Form
    {
        Password p = new Password();

        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            p.Senha = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StringBuilder senhaCript = new StringBuilder();
            MD5 md5 = MD5.Create();

            byte[] entrada = Encoding.ASCII.GetBytes(p.Senha);
            byte[] hash = md5.ComputeHash(entrada);

            for (int i = 0; i < hash.Length; i++)
            {
                senhaCript.Append(hash[i].ToString("X2"));
            }

            MessageBox.Show("Senha criptografada: " + senhaCript, "Resposta ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
