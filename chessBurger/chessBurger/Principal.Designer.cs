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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            btnSobre = new Button();
            marcador = new Panel();
            btnAlterarLanches = new Button();
            btnLanches = new Button();
            btnPedidos = new Button();
            label4 = new Label();
            tabControl1 = new TabControl();
            Pedidos = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            cob_lancheEscolhido = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txt_nomeCliente = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            button3 = new Button();
            button1 = new Button();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            dgPedidos = new DataGridView();
            btn_finalizarPedido = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            label8 = new Label();
            txt_filtrarPedido = new TextBox();
            Lanches = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            txt_nomeLanche = new TextBox();
            txt_precoLanche = new TextBox();
            txt_igredientes = new TextBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            btn_limpar1 = new Button();
            btn_cadastrarLanche = new Button();
            tabControl3 = new TabControl();
            LanchesCadastrados = new TabPage();
            dgLanches = new DataGridView();
            tableLayoutPanel8 = new TableLayoutPanel();
            button2 = new Button();
            btn_removerLanche = new Button();
            Alterar = new TabPage();
            panel4 = new Panel();
            panel3 = new Panel();
            btn_limpar2 = new Button();
            btn_confirmaAlteracao = new Button();
            label6 = new Label();
            txt_alteraNomeLanche = new TextBox();
            txt_alteraPrecoLanche = new TextBox();
            txt_alteraIgredienteLanche = new TextBox();
            label9 = new Label();
            label10 = new Label();
            Sobre = new TabPage();
            textBox2 = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            Pedidos.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            Lanches.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tabControl3.SuspendLayout();
            LanchesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLanches).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            Alterar.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = Color.FromArgb(142, 63, 26);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tabControl1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.FromArgb(142, 63, 26);
            panel2.Controls.Add(btnSobre);
            panel2.Controls.Add(marcador);
            panel2.Controls.Add(btnAlterarLanches);
            panel2.Controls.Add(btnLanches);
            panel2.Controls.Add(btnPedidos);
            panel2.Controls.Add(label4);
            panel2.Name = "panel2";
            panel2.Paint += panel2_Paint;
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
            // marcador
            // 
            resources.ApplyResources(marcador, "marcador");
            marcador.BackColor = Color.BlanchedAlmond;
            marcador.Name = "marcador";
            marcador.Paint += marcador_Paint;
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
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
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
            Pedidos.Controls.Add(tableLayoutPanel6);
            Pedidos.Name = "Pedidos";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(tableLayoutPanel6, "tableLayoutPanel6");
            tableLayoutPanel6.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
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
            tableLayoutPanel2.Controls.Add(txt_nomeCliente, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel10, 1, 3);
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
            // txt_nomeCliente
            // 
            resources.ApplyResources(txt_nomeCliente, "txt_nomeCliente");
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.TextChanged += textBox1_TextChanged;
            // 
            // tableLayoutPanel10
            // 
            resources.ApplyResources(tableLayoutPanel10, "tableLayoutPanel10");
            tableLayoutPanel10.Controls.Add(button3, 1, 0);
            tableLayoutPanel10.Controls.Add(button1, 0, 0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = SystemColors.ControlLight;
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
            dgPedidos.BackgroundColor = SystemColors.MenuBar;
            dgPedidos.BorderStyle = BorderStyle.None;
            dgPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidos.GridColor = SystemColors.ControlLight;
            dgPedidos.MultiSelect = false;
            dgPedidos.Name = "dgPedidos";
            dgPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(156, 173, 239);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgPedidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgPedidos.RowTemplate.Height = 25;
            // 
            // btn_finalizarPedido
            // 
            resources.ApplyResources(btn_finalizarPedido, "btn_finalizarPedido");
            btn_finalizarPedido.BackColor = SystemColors.Control;
            btn_finalizarPedido.Name = "btn_finalizarPedido";
            btn_finalizarPedido.UseVisualStyleBackColor = false;
            btn_finalizarPedido.Click += btn_finalizarPedido_Click;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(tableLayoutPanel7, "tableLayoutPanel7");
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(txt_filtrarPedido, 1, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.Transparent;
            label8.Name = "label8";
            // 
            // txt_filtrarPedido
            // 
            resources.ApplyResources(txt_filtrarPedido, "txt_filtrarPedido");
            txt_filtrarPedido.Name = "txt_filtrarPedido";
            txt_filtrarPedido.TextChanged += txt_filtrarPedido_TextChanged;
            // 
            // Lanches
            // 
            resources.ApplyResources(Lanches, "Lanches");
            Lanches.BackColor = Color.White;
            Lanches.Controls.Add(tableLayoutPanel4);
            Lanches.Name = "Lanches";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tabControl3, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 1, 1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(label5, 0, 1);
            tableLayoutPanel5.Controls.Add(label7, 0, 2);
            tableLayoutPanel5.Controls.Add(txt_nomeLanche, 1, 0);
            tableLayoutPanel5.Controls.Add(txt_precoLanche, 1, 1);
            tableLayoutPanel5.Controls.Add(txt_igredientes, 1, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel9, 1, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
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
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.Transparent;
            label7.Name = "label7";
            // 
            // txt_nomeLanche
            // 
            resources.ApplyResources(txt_nomeLanche, "txt_nomeLanche");
            txt_nomeLanche.Name = "txt_nomeLanche";
            // 
            // txt_precoLanche
            // 
            resources.ApplyResources(txt_precoLanche, "txt_precoLanche");
            txt_precoLanche.Name = "txt_precoLanche";
            // 
            // txt_igredientes
            // 
            resources.ApplyResources(txt_igredientes, "txt_igredientes");
            txt_igredientes.Name = "txt_igredientes";
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(tableLayoutPanel9, "tableLayoutPanel9");
            tableLayoutPanel9.Controls.Add(btn_limpar1, 1, 0);
            tableLayoutPanel9.Controls.Add(btn_cadastrarLanche, 0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // btn_limpar1
            // 
            resources.ApplyResources(btn_limpar1, "btn_limpar1");
            btn_limpar1.BackColor = SystemColors.ControlLight;
            btn_limpar1.Name = "btn_limpar1";
            btn_limpar1.UseVisualStyleBackColor = false;
            btn_limpar1.Click += btn_limpar1_Click;
            // 
            // btn_cadastrarLanche
            // 
            resources.ApplyResources(btn_cadastrarLanche, "btn_cadastrarLanche");
            btn_cadastrarLanche.BackColor = SystemColors.Control;
            btn_cadastrarLanche.Name = "btn_cadastrarLanche";
            btn_cadastrarLanche.UseVisualStyleBackColor = false;
            btn_cadastrarLanche.Click += button4_Click;
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
            dgLanches.BackgroundColor = SystemColors.ScrollBar;
            dgLanches.BorderStyle = BorderStyle.None;
            dgLanches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgLanches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLanches.GridColor = SystemColors.ControlLight;
            dgLanches.MultiSelect = false;
            dgLanches.Name = "dgLanches";
            dgLanches.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(156, 173, 239);
            dgLanches.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgLanches.RowTemplate.Height = 25;
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(tableLayoutPanel8, "tableLayoutPanel8");
            tableLayoutPanel8.Controls.Add(button2, 0, 0);
            tableLayoutPanel8.Controls.Add(btn_removerLanche, 1, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = SystemColors.Control;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // btn_removerLanche
            // 
            resources.ApplyResources(btn_removerLanche, "btn_removerLanche");
            btn_removerLanche.BackColor = SystemColors.ControlLight;
            btn_removerLanche.ForeColor = Color.Black;
            btn_removerLanche.Name = "btn_removerLanche";
            btn_removerLanche.UseVisualStyleBackColor = false;
            btn_removerLanche.Click += button2_Click;
            // 
            // Alterar
            // 
            resources.ApplyResources(Alterar, "Alterar");
            Alterar.BackColor = Color.White;
            Alterar.Controls.Add(panel4);
            Alterar.Controls.Add(panel3);
            Alterar.Name = "Alterar";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label11);
            panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btn_limpar2);
            panel3.Controls.Add(btn_confirmaAlteracao);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txt_alteraNomeLanche);
            panel3.Controls.Add(txt_alteraPrecoLanche);
            panel3.Controls.Add(txt_alteraIgredienteLanche);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Name = "panel3";
            // 
            // btn_limpar2
            // 
            resources.ApplyResources(btn_limpar2, "btn_limpar2");
            btn_limpar2.BackColor = SystemColors.ControlLight;
            btn_limpar2.Name = "btn_limpar2";
            btn_limpar2.UseVisualStyleBackColor = false;
            btn_limpar2.Click += btn_limpar2_Click;
            // 
            // btn_confirmaAlteracao
            // 
            resources.ApplyResources(btn_confirmaAlteracao, "btn_confirmaAlteracao");
            btn_confirmaAlteracao.BackColor = SystemColors.Control;
            btn_confirmaAlteracao.Name = "btn_confirmaAlteracao";
            btn_confirmaAlteracao.UseVisualStyleBackColor = false;
            btn_confirmaAlteracao.Click += button3_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.Name = "label6";
            // 
            // txt_alteraNomeLanche
            // 
            resources.ApplyResources(txt_alteraNomeLanche, "txt_alteraNomeLanche");
            txt_alteraNomeLanche.Name = "txt_alteraNomeLanche";
            // 
            // txt_alteraPrecoLanche
            // 
            resources.ApplyResources(txt_alteraPrecoLanche, "txt_alteraPrecoLanche");
            txt_alteraPrecoLanche.Name = "txt_alteraPrecoLanche";
            // 
            // txt_alteraIgredienteLanche
            // 
            resources.ApplyResources(txt_alteraIgredienteLanche, "txt_alteraIgredienteLanche");
            txt_alteraIgredienteLanche.Name = "txt_alteraIgredienteLanche";
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
            BackColor = Color.FromArgb(208, 221, 255);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormJanelaPrincipal";
            ShowIcon = false;
            Load += FormJanelaPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            Pedidos.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            Lanches.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            LanchesCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLanches).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            Alterar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Sobre.ResumeLayout(false);
            Sobre.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_mensagem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button btnSobre;
        private Panel marcador;
        private Button btnAlterarLanches;
        private Button btnLanches;
        private Button btnPedidos;
        private Label label4;
        private TabControl tabControl1;
        private TabPage Pedidos;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cob_lancheEscolhido;
        private Label label1;
        private Label label2;
        private TextBox txt_nomeCliente;
        private TableLayoutPanel tableLayoutPanel10;
        private Button button3;
        private Button button1;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private DataGridView dgPedidos;
        private Button btn_finalizarPedido;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label8;
        private TextBox txt_filtrarPedido;
        private TabPage Lanches;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private Label label5;
        private Label label7;
        private TextBox txt_nomeLanche;
        private TextBox txt_precoLanche;
        private TextBox txt_igredientes;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btn_limpar1;
        private Button btn_cadastrarLanche;
        private TabControl tabControl3;
        private TabPage LanchesCadastrados;
        private DataGridView dgLanches;
        private TableLayoutPanel tableLayoutPanel8;
        private Button button2;
        private Button btn_removerLanche;
        private TabPage Alterar;
        private Panel panel4;
        private Panel panel3;
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
    }
}