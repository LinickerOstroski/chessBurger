namespace chessBurger
{
    partial class FormJanelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJanelaPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            Pedidos = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            cob_lancheEscolhido = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txt_filtrarPedido = new TextBox();
            label8 = new Label();
            txt_nomeCliente = new TextBox();
            button1 = new Button();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            dgPedidos = new DataGridView();
            btn_finalizarPedido = new Button();
            Lanches = new TabPage();
            btn_removerLanche = new Button();
            tabControl3 = new TabControl();
            LanchesCadastrados = new TabPage();
            dgLanches = new DataGridView();
            panel7 = new Panel();
            btn_cadastrarLanche = new Button();
            txt_igredientes = new TextBox();
            label7 = new Label();
            txt_precoLanche = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txt_nomeLanche = new TextBox();
            Alterar = new TabPage();
            Sobre = new TabPage();
            textBox2 = new TextBox();
            btnPedidos = new Button();
            marcador = new Panel();
            btnLanches = new Button();
            btnAlterarLanches = new Button();
            btnSobre = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            Pedidos.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            Lanches.SuspendLayout();
            tabControl3.SuspendLayout();
            LanchesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLanches).BeginInit();
            panel7.SuspendLayout();
            Sobre.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(Pedidos);
            tabControl1.Controls.Add(Lanches);
            tabControl1.Controls.Add(Alterar);
            tabControl1.Controls.Add(Sobre);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // Pedidos
            // 
            resources.ApplyResources(Pedidos, "Pedidos");
            Pedidos.BackColor = Color.White;
            Pedidos.Controls.Add(tableLayoutPanel3);
            Pedidos.Name = "Pedidos";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(tabControl2, 1, 0);
            tableLayoutPanel3.Controls.Add(btn_finalizarPedido, 1, 1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(cob_lancheEscolhido, 1, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(txt_filtrarPedido, 1, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(txt_nomeCliente, 1, 1);
            tableLayoutPanel2.Controls.Add(button1, 0, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // cob_lancheEscolhido
            // 
            resources.ApplyResources(cob_lancheEscolhido, "cob_lancheEscolhido");
            cob_lancheEscolhido.FormattingEnabled = true;
            cob_lancheEscolhido.Name = "cob_lancheEscolhido";
            cob_lancheEscolhido.SelectedIndexChanged += cob_lancheEscolhido_SelectedIndexChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.Name = "label2";
            // 
            // txt_filtrarPedido
            // 
            resources.ApplyResources(txt_filtrarPedido, "txt_filtrarPedido");
            txt_filtrarPedido.Name = "txt_filtrarPedido";
            txt_filtrarPedido.TextChanged += txt_filtrarPedido_TextChanged;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.Transparent;
            label8.Name = "label8";
            // 
            // txt_nomeCliente
            // 
            resources.ApplyResources(txt_nomeCliente, "txt_nomeCliente");
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.FromArgb(111, 172, 192);
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabControl2
            // 
            resources.ApplyResources(tabControl2, "tabControl2");
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Multiline = true;
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            // 
            // tabPage4
            // 
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Controls.Add(dgPedidos);
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgPedidos
            // 
            resources.ApplyResources(dgPedidos, "dgPedidos");
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.BackgroundColor = SystemColors.Window;
            dgPedidos.BorderStyle = BorderStyle.None;
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidos.GridColor = SystemColors.InfoText;
            dgPedidos.MultiSelect = false;
            dgPedidos.Name = "dgPedidos";
            dgPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 195, 216);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(61, 125, 144);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgPedidos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgPedidos.RowTemplate.Height = 25;
            // 
            // btn_finalizarPedido
            // 
            resources.ApplyResources(btn_finalizarPedido, "btn_finalizarPedido");
            btn_finalizarPedido.BackColor = Color.FromArgb(111, 172, 192);
            btn_finalizarPedido.Name = "btn_finalizarPedido";
            btn_finalizarPedido.UseVisualStyleBackColor = false;
            btn_finalizarPedido.Click += btn_finalizarPedido_Click;
            // 
            // Lanches
            // 
            resources.ApplyResources(Lanches, "Lanches");
            Lanches.BackColor = Color.White;
            Lanches.Controls.Add(btn_removerLanche);
            Lanches.Controls.Add(tabControl3);
            Lanches.Controls.Add(panel7);
            Lanches.Name = "Lanches";
            // 
            // btn_removerLanche
            // 
            resources.ApplyResources(btn_removerLanche, "btn_removerLanche");
            btn_removerLanche.BackColor = Color.FromArgb(251, 234, 212);
            btn_removerLanche.Name = "btn_removerLanche";
            btn_removerLanche.UseVisualStyleBackColor = false;
            btn_removerLanche.Click += button2_Click;
            // 
            // tabControl3
            // 
            resources.ApplyResources(tabControl3, "tabControl3");
            tabControl3.Controls.Add(LanchesCadastrados);
            tabControl3.Multiline = true;
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            // 
            // LanchesCadastrados
            // 
            resources.ApplyResources(LanchesCadastrados, "LanchesCadastrados");
            LanchesCadastrados.Controls.Add(dgLanches);
            LanchesCadastrados.Name = "LanchesCadastrados";
            LanchesCadastrados.UseVisualStyleBackColor = true;
            // 
            // dgLanches
            // 
            resources.ApplyResources(dgLanches, "dgLanches");
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgLanches.BackgroundColor = SystemColors.Window;
            dgLanches.BorderStyle = BorderStyle.None;
            dgLanches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgLanches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLanches.GridColor = SystemColors.InfoText;
            dgLanches.MultiSelect = false;
            dgLanches.Name = "dgLanches";
            dgLanches.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dgLanches.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgLanches.RowTemplate.Height = 25;
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.BackColor = SystemColors.Window;
            panel7.Controls.Add(btn_cadastrarLanche);
            panel7.Controls.Add(txt_igredientes);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(txt_precoLanche);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txt_nomeLanche);
            panel7.Name = "panel7";
            panel7.Paint += panel7_Paint;
            // 
            // btn_cadastrarLanche
            // 
            resources.ApplyResources(btn_cadastrarLanche, "btn_cadastrarLanche");
            btn_cadastrarLanche.BackColor = Color.FromArgb(251, 234, 212);
            btn_cadastrarLanche.Name = "btn_cadastrarLanche";
            btn_cadastrarLanche.UseVisualStyleBackColor = false;
            btn_cadastrarLanche.Click += button4_Click;
            // 
            // txt_igredientes
            // 
            resources.ApplyResources(txt_igredientes, "txt_igredientes");
            txt_igredientes.Name = "txt_igredientes";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.Transparent;
            label7.Name = "label7";
            // 
            // txt_precoLanche
            // 
            resources.ApplyResources(txt_precoLanche, "txt_precoLanche");
            txt_precoLanche.Name = "txt_precoLanche";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.Name = "label5";
            // 
            // txt_nomeLanche
            // 
            resources.ApplyResources(txt_nomeLanche, "txt_nomeLanche");
            txt_nomeLanche.Name = "txt_nomeLanche";
            // 
            // Alterar
            // 
            resources.ApplyResources(Alterar, "Alterar");
            Alterar.BackColor = Color.FromArgb(247, 213, 169);
            Alterar.Name = "Alterar";
            // 
            // Sobre
            // 
            resources.ApplyResources(Sobre, "Sobre");
            Sobre.BackColor = Color.White;
            Sobre.Controls.Add(textBox2);
            Sobre.Name = "Sobre";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.AccessibleRole = AccessibleRole.OutlineButton;
            textBox2.BackColor = SystemColors.Window;
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnPedidos
            // 
            resources.ApplyResources(btnPedidos, "btnPedidos");
            btnPedidos.BackColor = Color.FromArgb(136, 195, 216);
            btnPedidos.FlatAppearance.BorderColor = Color.FromArgb(136, 195, 216);
            btnPedidos.ForeColor = SystemColors.Desktop;
            btnPedidos.Name = "btnPedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += button2_Click_1;
            // 
            // marcador
            // 
            resources.ApplyResources(marcador, "marcador");
            marcador.BackColor = Color.Black;
            marcador.Name = "marcador";
            // 
            // btnLanches
            // 
            resources.ApplyResources(btnLanches, "btnLanches");
            btnLanches.BackColor = Color.FromArgb(136, 195, 216);
            btnLanches.FlatAppearance.BorderColor = Color.FromArgb(136, 195, 216);
            btnLanches.Name = "btnLanches";
            btnLanches.UseVisualStyleBackColor = false;
            btnLanches.Click += btnLanches_Click;
            // 
            // btnAlterarLanches
            // 
            resources.ApplyResources(btnAlterarLanches, "btnAlterarLanches");
            btnAlterarLanches.BackColor = Color.FromArgb(136, 195, 216);
            btnAlterarLanches.FlatAppearance.BorderColor = Color.FromArgb(136, 195, 216);
            btnAlterarLanches.Name = "btnAlterarLanches";
            btnAlterarLanches.UseVisualStyleBackColor = false;
            btnAlterarLanches.Click += btnAlterarLanches_Click;
            // 
            // btnSobre
            // 
            resources.ApplyResources(btnSobre, "btnSobre");
            btnSobre.BackColor = Color.FromArgb(136, 195, 216);
            btnSobre.FlatAppearance.BorderColor = Color.FromArgb(136, 195, 216);
            btnSobre.Name = "btnSobre";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(136, 195, 216);
            panel1.Controls.Add(pictureBox3);
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.FromArgb(136, 195, 216);
            panel2.Controls.Add(btnSobre);
            panel2.Controls.Add(marcador);
            panel2.Controls.Add(btnAlterarLanches);
            panel2.Controls.Add(btnLanches);
            panel2.Controls.Add(btnPedidos);
            panel2.Name = "panel2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tabControl1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // FormJanelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(136, 195, 216);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormJanelaPrincipal";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            Load += FormJanelaPrincipal_Load;
            tabControl1.ResumeLayout(false);
            Pedidos.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            Lanches.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            LanchesCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLanches).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            Sobre.ResumeLayout(false);
            Sobre.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage Pedidos;
        private TabPage Lanches;
        private Label label1;
        private TextBox txt_nomeCliente;
        private ComboBox cob_lancheEscolhido;
        private Label label2;
        private TabPage Alterar;
        private TabPage Sobre;
        private TextBox textBox2;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabControl tabControl3;
        private TabPage LanchesCadastrados;
        private Button btn_removerLanche;
        private Panel panel7;
        private Label label7;
        private TextBox txt_precoLanche;
        private Label label3;
        private Label label5;
        private TextBox txt_nomeLanche;
        private Button btn_cadastrarLanche;
        private Label lbl_mensagem;
        private DataGridView dgPedidos;
        private TextBox txt_filtrarPedido;
        private Label label8;
        private TextBox txt_igredientes;
        private DataGridView dgLanches;
        private Button btnPedidos;
        private Panel marcador;
        private Button btnLanches;
        private Button btnAlterarLanches;
        private Button btnSobre;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_finalizarPedido;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private PictureBox pictureBox3;
    }
}