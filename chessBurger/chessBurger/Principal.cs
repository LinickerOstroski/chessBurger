using System.Data;

namespace chessBurger
{
    public partial class FormJanelaPrincipal : Form
    {
        public FormJanelaPrincipal()
        {
            InitializeComponent();
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
            Igredientes igredientes = new Igredientes(txt_nomeLanche.Text);
            igredientes.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            listaCOBLanches();
            listaGridPedidos();
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
            //dgPedidos.Columns["idPedido"].Visible = false;
        }

        private void txt_filtrarPedido_TextChanged(object sender, EventArgs e)
        {
            (dgPedidos.DataSource as DataTable).DefaultView.RowFilter = string.Format("nomeCliente like '{0}%'", txt_filtrarPedido.Text);
        }
    }
}