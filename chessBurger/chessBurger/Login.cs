using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (txt_usuario.Text.Equals("adm") && txt_senha.Text.Equals("123"))
            {
                FormJanelaPrincipal principal = new FormJanelaPrincipal();
                this.Hide();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_usuario.Focus();
                txt_usuario.Clear();
                txt_senha.Clear();
            }
        }
    }
}
