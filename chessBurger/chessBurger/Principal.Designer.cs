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
            Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJanelaPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnPedidos = new Button();
            btnSobre = new Button();
            btnAlterarLanches = new Button();
            btnLanches = new Button();
            marcador = new Panel();
            tabControl1 = new TabControl();
            Pedidos = new TabPage();
            btn_finalizarPedido = new Button();
            label8 = new Label();
            button3 = new Button();
            button1 = new Button();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            dgPedidos = new DataGridView();
            txt_filtrarPedido = new TextBox();
            cob_lancheEscolhido = new ComboBox();
            label2 = new Label();
            txt_nomeCliente = new TextBox();
            label1 = new Label();
            Lanches = new TabPage();
            button2 = new Button();
            btn_limpar1 = new Button();
            tabControl3 = new TabControl();
            LanchesCadastrados = new TabPage();
            dgLanches = new DataGridView();
            btn_removerLanche = new Button();
            btn_cadastrarLanche = new Button();
            txt_igredientes = new TextBox();
            label3 = new Label();
            txt_nomeLanche = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txt_precoLanche = new TextBox();
            Alterar = new TabPage();
            panel2 = new Panel();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            btn_confirmaAlteracao = new Button();
            btn_limpar2 = new Button();
            txt_alteraNomeLanche = new TextBox();
            txt_alteraIgredienteLanche = new TextBox();
            txt_alteraPrecoLanche = new TextBox();
            Sobre = new TabPage();
            textBox2 = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            Pedidos.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            Lanches.SuspendLayout();
            tabControl3.SuspendLayout();
            LanchesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLanches).BeginInit();
            Alterar.SuspendLayout();
            panel2.SuspendLayout();
            Sobre.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.BackColor = Color.Transparent;
            label11.Name = "label11";
            // 
            // btnPedidos
            // 
            resources.ApplyResources(btnPedidos, "btnPedidos");
            btnPedidos.BackColor = Color.FromArgb(146, 63, 26);
            btnPedidos.FlatAppearance.BorderColor = Color.FromArgb(146, 63, 26);
            btnPedidos.ForeColor = SystemColors.Desktop;
            btnPedidos.Name = "btnPedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += button2_Click_1;
            // 
            // btnSobre
            // 
            resources.ApplyResources(btnSobre, "btnSobre");
            btnSobre.BackColor = Color.FromArgb(146, 63, 26);
            btnSobre.FlatAppearance.BorderColor = Color.FromArgb(146, 63, 26);
            btnSobre.Name = "btnSobre";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // btnAlterarLanches
            // 
            resources.ApplyResources(btnAlterarLanches, "btnAlterarLanches");
            btnAlterarLanches.BackColor = Color.FromArgb(146, 63, 26);
            btnAlterarLanches.FlatAppearance.BorderColor = Color.FromArgb(146, 63, 26);
            btnAlterarLanches.Name = "btnAlterarLanches";
            btnAlterarLanches.UseVisualStyleBackColor = false;
            btnAlterarLanches.Click += btnAlterarLanches_Click;
            // 
            // btnLanches
            // 
            resources.ApplyResources(btnLanches, "btnLanches");
            btnLanches.BackColor = Color.FromArgb(146, 63, 26);
            btnLanches.FlatAppearance.BorderColor = Color.FromArgb(146, 63, 26);
            btnLanches.Name = "btnLanches";
            btnLanches.UseVisualStyleBackColor = false;
            btnLanches.Click += btnLanches_Click;
            // 
            // marcador
            // 
            resources.ApplyResources(marcador, "marcador");
            marcador.BackColor = Color.BlanchedAlmond;
            marcador.Name = "marcador";
            marcador.Paint += marcador_Paint;
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
            Pedidos.Controls.Add(btn_finalizarPedido);
            Pedidos.Controls.Add(label8);
            Pedidos.Controls.Add(button3);
            Pedidos.Controls.Add(button1);
            Pedidos.Controls.Add(tabControl2);
            Pedidos.Controls.Add(txt_filtrarPedido);
            Pedidos.Controls.Add(cob_lancheEscolhido);
            Pedidos.Controls.Add(label2);
            Pedidos.Controls.Add(txt_nomeCliente);
            Pedidos.Controls.Add(label1);
            Pedidos.Name = "Pedidos";
            // 
            // btn_finalizarPedido
            // 
            resources.ApplyResources(btn_finalizarPedido, "btn_finalizarPedido");
            btn_finalizarPedido.BackColor = Color.FromArgb(21, 126, 44);
            btn_finalizarPedido.ForeColor = Color.White;
            btn_finalizarPedido.Name = "btn_finalizarPedido";
            btn_finalizarPedido.UseVisualStyleBackColor = false;
            btn_finalizarPedido.Click += btn_finalizarPedido_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.Transparent;
            label8.Name = "label8";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.FromArgb(71, 65, 67);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.FromArgb(21, 126, 44);
            button1.ForeColor = SystemColors.Control;
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
            dgPedidos.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgPedidos.BorderStyle = BorderStyle.None;
            dgPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidos.GridColor = SystemColors.ControlLight;
            dgPedidos.MultiSelect = false;
            dgPedidos.Name = "dgPedidos";
            dgPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(191, 100, 36);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 237, 180);
            dgPedidos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgPedidos.RowTemplate.Height = 25;
            // 
            // txt_filtrarPedido
            // 
            resources.ApplyResources(txt_filtrarPedido, "txt_filtrarPedido");
            txt_filtrarPedido.BackColor = SystemColors.ControlLight;
            txt_filtrarPedido.BorderStyle = BorderStyle.FixedSingle;
            txt_filtrarPedido.ForeColor = Color.FromArgb(71, 65, 67);
            txt_filtrarPedido.Name = "txt_filtrarPedido";
            txt_filtrarPedido.TextChanged += txt_filtrarPedido_TextChanged;
            // 
            // cob_lancheEscolhido
            // 
            resources.ApplyResources(cob_lancheEscolhido, "cob_lancheEscolhido");
            cob_lancheEscolhido.BackColor = SystemColors.ControlLight;
            cob_lancheEscolhido.ForeColor = Color.FromArgb(71, 65, 67);
            cob_lancheEscolhido.FormattingEnabled = true;
            cob_lancheEscolhido.Name = "cob_lancheEscolhido";
            cob_lancheEscolhido.SelectedIndexChanged += cob_lancheEscolhido_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Name = "label2";
            // 
            // txt_nomeCliente
            // 
            resources.ApplyResources(txt_nomeCliente, "txt_nomeCliente");
            txt_nomeCliente.BackColor = SystemColors.ControlLight;
            txt_nomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txt_nomeCliente.ForeColor = Color.FromArgb(71, 65, 67);
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // Lanches
            // 
            resources.ApplyResources(Lanches, "Lanches");
            Lanches.BackColor = Color.White;
            Lanches.Controls.Add(button2);
            Lanches.Controls.Add(btn_limpar1);
            Lanches.Controls.Add(tabControl3);
            Lanches.Controls.Add(btn_removerLanche);
            Lanches.Controls.Add(btn_cadastrarLanche);
            Lanches.Controls.Add(txt_igredientes);
            Lanches.Controls.Add(label3);
            Lanches.Controls.Add(txt_nomeLanche);
            Lanches.Controls.Add(label5);
            Lanches.Controls.Add(label7);
            Lanches.Controls.Add(txt_precoLanche);
            Lanches.Name = "Lanches";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(71, 65, 67);
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // btn_limpar1
            // 
            resources.ApplyResources(btn_limpar1, "btn_limpar1");
            btn_limpar1.BackColor = Color.FromArgb(71, 65, 67);
            btn_limpar1.ForeColor = Color.White;
            btn_limpar1.Name = "btn_limpar1";
            btn_limpar1.UseVisualStyleBackColor = false;
            btn_limpar1.Click += btn_limpar1_Click;
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
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgLanches.BorderStyle = BorderStyle.None;
            dgLanches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgLanches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLanches.GridColor = SystemColors.ControlLight;
            dgLanches.MultiSelect = false;
            dgLanches.Name = "dgLanches";
            dgLanches.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(191, 100, 36);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 237, 180);
            dgLanches.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgLanches.RowTemplate.Height = 25;
            dgLanches.CellContentClick += dgLanches_CellContentClick;
            // 
            // btn_removerLanche
            // 
            resources.ApplyResources(btn_removerLanche, "btn_removerLanche");
            btn_removerLanche.BackColor = Color.FromArgb(191, 15, 15);
            btn_removerLanche.ForeColor = Color.White;
            btn_removerLanche.Name = "btn_removerLanche";
            btn_removerLanche.UseVisualStyleBackColor = false;
            btn_removerLanche.Click += button2_Click;
            // 
            // btn_cadastrarLanche
            // 
            resources.ApplyResources(btn_cadastrarLanche, "btn_cadastrarLanche");
            btn_cadastrarLanche.BackColor = Color.FromArgb(21, 126, 44);
            btn_cadastrarLanche.ForeColor = Color.White;
            btn_cadastrarLanche.Name = "btn_cadastrarLanche";
            btn_cadastrarLanche.UseVisualStyleBackColor = false;
            btn_cadastrarLanche.Click += button4_Click;
            // 
            // txt_igredientes
            // 
            resources.ApplyResources(txt_igredientes, "txt_igredientes");
            txt_igredientes.BackColor = SystemColors.ControlLight;
            txt_igredientes.BorderStyle = BorderStyle.FixedSingle;
            txt_igredientes.ForeColor = Color.FromArgb(71, 65, 67);
            txt_igredientes.Name = "txt_igredientes";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Name = "label3";
            // 
            // txt_nomeLanche
            // 
            resources.ApplyResources(txt_nomeLanche, "txt_nomeLanche");
            txt_nomeLanche.BackColor = SystemColors.ControlLight;
            txt_nomeLanche.BorderStyle = BorderStyle.FixedSingle;
            txt_nomeLanche.Name = "txt_nomeLanche";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Name = "label7";
            // 
            // txt_precoLanche
            // 
            resources.ApplyResources(txt_precoLanche, "txt_precoLanche");
            txt_precoLanche.BackColor = SystemColors.ControlLight;
            txt_precoLanche.BorderStyle = BorderStyle.FixedSingle;
            txt_precoLanche.Name = "txt_precoLanche";
            // 
            // Alterar
            // 
            resources.ApplyResources(Alterar, "Alterar");
            Alterar.BackColor = Color.White;
            Alterar.Controls.Add(panel2);
            Alterar.Controls.Add(label11);
            Alterar.Controls.Add(btn_confirmaAlteracao);
            Alterar.Controls.Add(btn_limpar2);
            Alterar.Controls.Add(txt_alteraNomeLanche);
            Alterar.Controls.Add(txt_alteraIgredienteLanche);
            Alterar.Controls.Add(txt_alteraPrecoLanche);
            Alterar.Name = "Alterar";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Name = "panel2";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.Name = "label6";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.BackColor = Color.Transparent;
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.BackColor = Color.Transparent;
            label10.Name = "label10";
            // 
            // btn_confirmaAlteracao
            // 
            resources.ApplyResources(btn_confirmaAlteracao, "btn_confirmaAlteracao");
            btn_confirmaAlteracao.BackColor = Color.FromArgb(21, 126, 44);
            btn_confirmaAlteracao.ForeColor = SystemColors.Control;
            btn_confirmaAlteracao.Name = "btn_confirmaAlteracao";
            btn_confirmaAlteracao.UseVisualStyleBackColor = false;
            btn_confirmaAlteracao.Click += button3_Click;
            // 
            // btn_limpar2
            // 
            resources.ApplyResources(btn_limpar2, "btn_limpar2");
            btn_limpar2.BackColor = Color.FromArgb(191, 15, 15);
            btn_limpar2.ForeColor = SystemColors.Control;
            btn_limpar2.Name = "btn_limpar2";
            btn_limpar2.UseVisualStyleBackColor = false;
            btn_limpar2.Click += btn_limpar2_Click;
            // 
            // txt_alteraNomeLanche
            // 
            resources.ApplyResources(txt_alteraNomeLanche, "txt_alteraNomeLanche");
            txt_alteraNomeLanche.BackColor = SystemColors.ControlLight;
            txt_alteraNomeLanche.BorderStyle = BorderStyle.FixedSingle;
            txt_alteraNomeLanche.ForeColor = Color.FromArgb(71, 65, 67);
            txt_alteraNomeLanche.Name = "txt_alteraNomeLanche";
            // 
            // txt_alteraIgredienteLanche
            // 
            resources.ApplyResources(txt_alteraIgredienteLanche, "txt_alteraIgredienteLanche");
            txt_alteraIgredienteLanche.BackColor = SystemColors.ControlLight;
            txt_alteraIgredienteLanche.BorderStyle = BorderStyle.FixedSingle;
            txt_alteraIgredienteLanche.ForeColor = Color.FromArgb(71, 65, 67);
            txt_alteraIgredienteLanche.Name = "txt_alteraIgredienteLanche";
            // 
            // txt_alteraPrecoLanche
            // 
            resources.ApplyResources(txt_alteraPrecoLanche, "txt_alteraPrecoLanche");
            txt_alteraPrecoLanche.BackColor = SystemColors.ControlLight;
            txt_alteraPrecoLanche.BorderStyle = BorderStyle.FixedSingle;
            txt_alteraPrecoLanche.ForeColor = Color.FromArgb(71, 65, 67);
            txt_alteraPrecoLanche.Name = "txt_alteraPrecoLanche";
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
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(217, 141, 48);
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
            // FormJanelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 63, 26);
            Controls.Add(tabControl1);
            Controls.Add(btnSobre);
            Controls.Add(marcador);
            Controls.Add(btnPedidos);
            Controls.Add(btnAlterarLanches);
            Controls.Add(btnLanches);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormJanelaPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FormJanelaPrincipal_Load;
            tabControl1.ResumeLayout(false);
            Pedidos.ResumeLayout(false);
            Pedidos.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            Lanches.ResumeLayout(false);
            Lanches.PerformLayout();
            tabControl3.ResumeLayout(false);
            LanchesCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLanches).EndInit();
            Alterar.ResumeLayout(false);
            Alterar.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Sobre.ResumeLayout(false);
            Sobre.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_mensagem;
        private Button btnSobre;
        private Panel marcador;
        private Button btnAlterarLanches;
        private Button btnLanches;
        private Button btnPedidos;
        private TabControl tabControl1;
        private TabPage Pedidos;
        private ComboBox cob_lancheEscolhido;
        private Label label1;
        private Label label2;
        private TextBox txt_nomeCliente;
        private Button button3;
        private Button button1;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private DataGridView dgPedidos;
        private Button btn_finalizarPedido;
        private Label label8;
        private TextBox txt_filtrarPedido;
        private TabPage Lanches;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox txt_nomeLanche;
        private TextBox txt_precoLanche;
        private TextBox txt_igredientes;
        private Button btn_limpar1;
        private Button btn_cadastrarLanche;
        private TabControl tabControl3;
        private TabPage LanchesCadastrados;
        private DataGridView dgLanches;
        private Button button2;
        private Button btn_removerLanche;
        private TabPage Alterar;
        private Button btn_limpar2;
        private Button btn_confirmaAlteracao;
        private Label label6;
        private TextBox txt_alteraNomeLanche;
        private TextBox txt_alteraPrecoLanche;
        private TextBox txt_alteraIgredienteLanche;
        private Label label9;
        private Label label10;
        private TabPage Sobre;
        private TextBox textBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
    }
}