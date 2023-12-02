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

namespace chessBurger
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            string senha = txt_senha.Text;
            string senhaHashed = Biblioteca.makeHash(senha);

            int idUsuario = conecta.verificaID(txt_usuario.Text, senhaHashed);


            if (conecta.verifica(txt_usuario.Text, txt_senha.Text) == true)
            {
                FormJanelaPrincipal principal = new FormJanelaPrincipal(idUsuario);
                this.Hide();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                //MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                MessageBox.Show("Usuario ou senha incorreta" + conecta.mensagem);
                txt_usuario.Focus();
                txt_usuario.Clear();
                txt_senha.Clear();
            }
        }

    }
}
