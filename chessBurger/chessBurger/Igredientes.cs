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
    public partial class Igredientes : Form
    {
        public Igredientes(String retorno)
        {
            InitializeComponent();
            if(retorno == "")
            {
                MessageBox.Show("O lanche não possui um nome!");
            }

            if(retorno != "")
            {
                txt_nomeLancheShow.Text = "Igredientes de " + retorno;
                txt_igredientes.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_igredientes.Text == "")
            {
                MessageBox.Show("Digite os igredientes!");
                txt_igredientes.Focus();
                return;
            }
        }
    }
}
