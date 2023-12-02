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
            tab_login.ItemSize = new System.Drawing.Size(0, 01); // deixando os botões invisíveis
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            tab_login.SelectedTab = tab_login.TabPages[1];
            txt_registrarUsuario.Focus();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_registrarUsuario.Clear();
            txt_registrarSenha.Clear();
            txt_confirmarSenha.Clear();
            tab_login.SelectedTab = tab_login.TabPages[0];
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            ConectaBanco conecta = new ConectaBanco();

            string senha = txt_confirmarSenha.Text;
            string senhaHash = Biblioteca.makeHash(senha);


            if (txt_registrarUsuario.Text != "" && txt_registrarSenha.Text != "" && txt_confirmarSenha.Text != "" && txt_registrarSenha.Text == txt_confirmarSenha.Text)
            {
                conecta.novoUsuario(txt_registrarUsuario.Text, senhaHash);
                MessageBox.Show("Sua conta foi registrada com sucesso!");
                txt_registrarUsuario.Clear();
                txt_registrarSenha.Clear();
                txt_confirmarSenha.Clear();
                tab_login.SelectedTab = tab_login.TabPages[0];
                MessageBox.Show("Faça o login com a conta cadastrada");
            }
            else
            {
                MessageBox.Show("Digite os dados corretamente!");
                txt_registrarUsuario.Focus();
            }
        }
    }
}
