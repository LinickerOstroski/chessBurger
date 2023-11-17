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
            }
            else
            {
                MessageBox.Show("Digite os dados");
                txt_nomeCliente.Focus();
            }

            limpaCampos();

        }

        private void btn_finalizarPedido_Click(object sender, EventArgs e)
        {
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

    }
}