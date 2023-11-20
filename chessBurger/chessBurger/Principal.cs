using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace chessBurger
{
    public partial class FormJanelaPrincipal : Form
    {
        public FormJanelaPrincipal()
        {
            InitializeComponent();
            marcador.BringToFront();
            tabControl1.ItemSize = new System.Drawing.Size(0, 01); // deixando os botões invisíveis
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void limpaCampos()
        {
            txt_nomeCliente.Clear();
            cob_lancheEscolhido.Text = "";
            txt_nomeCliente.Focus();
            txt_nomeLanche.Clear();
            txt_precoLanche.Clear();
            txt_igredientes.Clear();
            txt_nomeLanche.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Pedido novoPedido = new Pedido();
            novoPedido.NomeCliente = txt_nomeCliente.Text;
            novoPedido.LancheEscolhido = Convert.ToInt32(cob_lancheEscolhido.SelectedValue.ToString());

            bool retorno;

            if (txt_nomeCliente.Text != "" && cob_lancheEscolhido.Text != "")
            {
                retorno = con.inserePedido(novoPedido);
                MessageBox.Show("Pedido registrado!");
                txt_nomeCliente.Focus();
            }
            else
            {
                MessageBox.Show("Digite os dados");
                txt_nomeCliente.Focus();
            }

            limpaCampos();
            listaGridPedidos();
            listaGridLanches();

        }

        private void btn_finalizarPedido_Click(object sender, EventArgs e)
        {
            int linha = dgPedidos.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgPedidos.Rows[linha].Cells["idpedido"].Value.ToString());
            DialogResult resp = MessageBox.Show("O pedido foi entregue?",
                "Finalizar Pedido", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaPedidos(id);
                if (retorno == true)
                {
                    MessageBox.Show("Pedido finalizado!");
                    listaGridPedidos();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Operação cancelada");
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bem vindo");
            txt_filtrarPedido.Focus();
            listaCOBLanches();
            listaGridPedidos();
            listaGridLanches();
        }

        public void listaCOBLanches()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaLanches(); ;
            cob_lancheEscolhido.DataSource = tabelaDados;
            cob_lancheEscolhido.DisplayMember = "nomeLanche"; //O que vai mostrar
            cob_lancheEscolhido.ValueMember = "idLanche"; //O que vai buscar do Banco
        }

        public void listaGridPedidos()
        {
            ConectaBanco con = new ConectaBanco();
            dgPedidos.DataSource = con.listaPedidos();
            dgPedidos.Columns["idPedido"].Visible = false;
        }

        public void listaGridLanches()
        {
            ConectaBanco con = new ConectaBanco();
            dgLanches.DataSource = con.listaLanches();
            dgLanches.Columns["idLanche"].Visible = false;
        }

        private void txt_filtrarPedido_TextChanged(object sender, EventArgs e)
        {
            (dgPedidos.DataSource as DataTable).DefaultView.RowFilter = string.Format("nomeCliente like '{0}%'", txt_filtrarPedido.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Lanche novoLanche = new Lanche();


            bool retorno;

            if (txt_nomeLanche.Text != "" && txt_igredientes.Text != "" && txt_precoLanche.ToString() != "")
            {
                novoLanche.NomeLanche = txt_nomeLanche.Text;
                novoLanche.Igredientes = txt_igredientes.Text;
                novoLanche.Preco = float.Parse(txt_precoLanche.Text);
                retorno = con.insereLanche(novoLanche);
                MessageBox.Show("Lanche registrado!");
                txt_nomeLanche.Focus();
            }
            else
            {
                MessageBox.Show("Digite os dados!");
                txt_nomeLanche.Focus();
            }

            limpaCampos();
            listaCOBLanches();
            listaGridLanches();

        }

        private void cob_lancheEscolhido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int linha = dgLanches.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgLanches.Rows[linha].Cells["idlanche"].Value.ToString());
            DialogResult resp = MessageBox.Show("Deseja mesmo remover esse Lanche?",
                "Remover lanche", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaLanches(id);
                if (retorno == true)
                {
                    MessageBox.Show("Lanche removido.");
                    listaGridLanches();
                }// fim if retorno true
                else
                    MessageBox.Show("Tem um pedido cadastrado com esse lanche!\n\n" + con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Operação cancelada");

            listaCOBLanches();
            listaGridPedidos();
            listaGridLanches();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            marcador.Height = btnPedidos.Height;
            marcador.Top = btnPedidos.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void btnLanches_Click(object sender, EventArgs e)
        {
            marcador.Height = btnLanches.Height;
            marcador.Top = btnLanches.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void btnAlterarLanches_Click(object sender, EventArgs e)
        {
            marcador.Height = btnAlterarLanches.Height;
            marcador.Top = btnAlterarLanches.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            marcador.Height = btnSobre.Height;
            marcador.Top = btnSobre.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[3];
        }
    }
}
