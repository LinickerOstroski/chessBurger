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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            Pedidos = new TabPage();
            panel3 = new Panel();
            panel9 = new Panel();
            txt_filtrarPedido = new TextBox();
            label8 = new Label();
            panel6 = new Panel();
            button1 = new Button();
            btn_finalizarPedido = new Button();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            dgPedidos = new DataGridView();
            panel5 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txt_nomeCliente = new TextBox();
            cob_lancheEscolhido = new ComboBox();
            Lanches = new TabPage();
            panel4 = new Panel();
            btn_removerLanche = new Button();
            tabControl3 = new TabControl();
            LanchesCadastrados = new TabPage();
            dgLanches = new DataGridView();
            panel7 = new Panel();
            panel8 = new Panel();
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
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            Pedidos.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            panel5.SuspendLayout();
            Lanches.SuspendLayout();
            panel4.SuspendLayout();
            tabControl3.SuspendLayout();
            LanchesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLanches).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            Sobre.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 213, 169);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 123);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 234, 212);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 115);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(585, 64);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 3;
            label6.Text = "alpha 1.2";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(259, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(164, 24);
            label4.Name = "label4";
            label4.Size = new Size(435, 73);
            label4.TabIndex = 1;
            label4.Text = "Ch   ssBurger";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(Pedidos);
            tabControl1.Controls.Add(Lanches);
            tabControl1.Controls.Add(Alterar);
            tabControl1.Controls.Add(Sobre);
            tabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(10, 130);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 316);
            tabControl1.TabIndex = 2;
            // 
            // Pedidos
            // 
            Pedidos.BackColor = Color.FromArgb(247, 213, 169);
            Pedidos.BackgroundImageLayout = ImageLayout.None;
            Pedidos.Controls.Add(panel3);
            Pedidos.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Pedidos.Location = new Point(4, 4);
            Pedidos.Name = "Pedidos";
            Pedidos.Padding = new Padding(3);
            Pedidos.RightToLeft = RightToLeft.No;
            Pedidos.Size = new Size(912, 283);
            Pedidos.TabIndex = 0;
            Pedidos.Text = "Pedidos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(251, 234, 212);
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(btn_finalizarPedido);
            panel3.Controls.Add(tabControl2);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(6, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(888, 248);
            panel3.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Window;
            panel9.Controls.Add(txt_filtrarPedido);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(11, 170);
            panel9.Name = "panel9";
            panel9.Size = new Size(415, 42);
            panel9.TabIndex = 9;
            // 
            // txt_filtrarPedido
            // 
            txt_filtrarPedido.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_filtrarPedido.Location = new Point(167, 8);
            txt_filtrarPedido.Name = "txt_filtrarPedido";
            txt_filtrarPedido.Size = new Size(233, 27);
            txt_filtrarPedido.TabIndex = 6;
            txt_filtrarPedido.TextChanged += txt_filtrarPedido_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 8);
            label8.Name = "label8";
            label8.Size = new Size(154, 24);
            label8.TabIndex = 5;
            label8.Text = "Filtrar por cliente:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 224, 192);
            panel6.Controls.Add(button1);
            panel6.Location = new Point(20, 117);
            panel6.Name = "panel6";
            panel6.Size = new Size(176, 39);
            panel6.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(239, 171, 82);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(6, 5);
            button1.Name = "button1";
            button1.Size = new Size(163, 28);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar Pedido";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_finalizarPedido
            // 
            btn_finalizarPedido.BackColor = Color.FromArgb(255, 192, 128);
            btn_finalizarPedido.FlatStyle = FlatStyle.Flat;
            btn_finalizarPedido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_finalizarPedido.Image = (Image)resources.GetObject("btn_finalizarPedido.Image");
            btn_finalizarPedido.ImageAlign = ContentAlignment.BottomRight;
            btn_finalizarPedido.Location = new Point(753, 217);
            btn_finalizarPedido.Name = "btn_finalizarPedido";
            btn_finalizarPedido.Size = new Size(125, 24);
            btn_finalizarPedido.TabIndex = 2;
            btn_finalizarPedido.Text = "Finalizar Pedido";
            btn_finalizarPedido.TextAlign = ContentAlignment.MiddleLeft;
            btn_finalizarPedido.UseVisualStyleBackColor = false;
            btn_finalizarPedido.Click += btn_finalizarPedido_Click;
            // 
            // tabControl2
            // 
            tabControl2.Alignment = TabAlignment.Bottom;
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl2.Location = new Point(432, 20);
            tabControl2.Multiline = true;
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(453, 219);
            tabControl2.TabIndex = 8;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgPedidos);
            tabPage4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage4.Location = new Point(4, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(445, 188);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Pedidos Cadastrados";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgPedidos
            // 
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.BackgroundColor = SystemColors.Window;
            dgPedidos.BorderStyle = BorderStyle.None;
            dgPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidos.Dock = DockStyle.Fill;
            dgPedidos.GridColor = SystemColors.InfoText;
            dgPedidos.Location = new Point(3, 3);
            dgPedidos.MultiSelect = false;
            dgPedidos.Name = "dgPedidos";
            dgPedidos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPedidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgPedidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgPedidos.RowTemplate.Height = 25;
            dgPedidos.ScrollBars = ScrollBars.Vertical;
            dgPedidos.Size = new Size(439, 182);
            dgPedidos.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txt_nomeCliente);
            panel5.Controls.Add(cob_lancheEscolhido);
            panel5.Location = new Point(11, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(415, 144);
            panel5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 13);
            label2.Name = "label2";
            label2.Size = new Size(154, 24);
            label2.TabIndex = 2;
            label2.Text = "Nome do cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 56);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 1;
            label1.Text = "Lanche escolhido:";
            label1.Click += label1_Click;
            // 
            // txt_nomeCliente
            // 
            txt_nomeCliente.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeCliente.Location = new Point(167, 13);
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.Size = new Size(233, 27);
            txt_nomeCliente.TabIndex = 3;
            txt_nomeCliente.TextChanged += textBox1_TextChanged;
            // 
            // cob_lancheEscolhido
            // 
            cob_lancheEscolhido.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cob_lancheEscolhido.FormattingEnabled = true;
            cob_lancheEscolhido.Location = new Point(178, 55);
            cob_lancheEscolhido.Name = "cob_lancheEscolhido";
            cob_lancheEscolhido.Size = new Size(222, 27);
            cob_lancheEscolhido.TabIndex = 4;
            cob_lancheEscolhido.SelectedIndexChanged += cob_lancheEscolhido_SelectedIndexChanged;
            // 
            // Lanches
            // 
            Lanches.BackColor = Color.FromArgb(247, 213, 169);
            Lanches.Controls.Add(panel4);
            Lanches.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Lanches.Location = new Point(4, 4);
            Lanches.Name = "Lanches";
            Lanches.Padding = new Padding(3);
            Lanches.Size = new Size(912, 283);
            Lanches.TabIndex = 1;
            Lanches.Text = "Lanches";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(251, 234, 212);
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btn_removerLanche);
            panel4.Controls.Add(tabControl3);
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(6, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(888, 248);
            panel4.TabIndex = 6;
            // 
            // btn_removerLanche
            // 
            btn_removerLanche.BackColor = Color.FromArgb(255, 192, 128);
            btn_removerLanche.FlatStyle = FlatStyle.Flat;
            btn_removerLanche.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_removerLanche.Location = new Point(753, 218);
            btn_removerLanche.Name = "btn_removerLanche";
            btn_removerLanche.Size = new Size(128, 24);
            btn_removerLanche.TabIndex = 2;
            btn_removerLanche.Text = "Remover";
            btn_removerLanche.UseVisualStyleBackColor = false;
            btn_removerLanche.Click += button2_Click;
            // 
            // tabControl3
            // 
            tabControl3.Alignment = TabAlignment.Bottom;
            tabControl3.Controls.Add(LanchesCadastrados);
            tabControl3.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl3.Location = new Point(460, 22);
            tabControl3.Multiline = true;
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(425, 217);
            tabControl3.TabIndex = 8;
            // 
            // LanchesCadastrados
            // 
            LanchesCadastrados.Controls.Add(dgLanches);
            LanchesCadastrados.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LanchesCadastrados.Location = new Point(4, 4);
            LanchesCadastrados.Name = "LanchesCadastrados";
            LanchesCadastrados.Padding = new Padding(3);
            LanchesCadastrados.Size = new Size(417, 186);
            LanchesCadastrados.TabIndex = 0;
            LanchesCadastrados.Text = "Lanches  Cadastrados";
            LanchesCadastrados.UseVisualStyleBackColor = true;
            // 
            // dgLanches
            // 
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgLanches.BackgroundColor = SystemColors.Window;
            dgLanches.BorderStyle = BorderStyle.None;
            dgLanches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgLanches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLanches.Dock = DockStyle.Fill;
            dgLanches.GridColor = SystemColors.InfoText;
            dgLanches.Location = new Point(3, 3);
            dgLanches.MultiSelect = false;
            dgLanches.Name = "dgLanches";
            dgLanches.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgLanches.RowHeadersWidth = 50;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dgLanches.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgLanches.RowTemplate.Height = 25;
            dgLanches.ScrollBars = ScrollBars.Vertical;
            dgLanches.Size = new Size(411, 180);
            dgLanches.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Window;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(txt_igredientes);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(txt_precoLanche);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txt_nomeLanche);
            panel7.Location = new Point(11, 22);
            panel7.Name = "panel7";
            panel7.Size = new Size(434, 220);
            panel7.TabIndex = 7;
            panel7.Paint += panel7_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 224, 192);
            panel8.Controls.Add(btn_cadastrarLanche);
            panel8.Location = new Point(154, 174);
            panel8.Name = "panel8";
            panel8.Size = new Size(119, 36);
            panel8.TabIndex = 5;
            // 
            // btn_cadastrarLanche
            // 
            btn_cadastrarLanche.BackColor = Color.FromArgb(239, 171, 82);
            btn_cadastrarLanche.FlatStyle = FlatStyle.Flat;
            btn_cadastrarLanche.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastrarLanche.Image = (Image)resources.GetObject("btn_cadastrarLanche.Image");
            btn_cadastrarLanche.ImageAlign = ContentAlignment.MiddleRight;
            btn_cadastrarLanche.Location = new Point(8, 5);
            btn_cadastrarLanche.Name = "btn_cadastrarLanche";
            btn_cadastrarLanche.Size = new Size(103, 26);
            btn_cadastrarLanche.TabIndex = 0;
            btn_cadastrarLanche.Text = "Cadastrar";
            btn_cadastrarLanche.TextAlign = ContentAlignment.MiddleLeft;
            btn_cadastrarLanche.UseVisualStyleBackColor = false;
            btn_cadastrarLanche.Click += button4_Click;
            // 
            // txt_igredientes
            // 
            txt_igredientes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_igredientes.Location = new Point(10, 126);
            txt_igredientes.Multiline = true;
            txt_igredientes.Name = "txt_igredientes";
            txt_igredientes.Size = new Size(409, 42);
            txt_igredientes.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 95);
            label7.Name = "label7";
            label7.Size = new Size(221, 25);
            label7.TabIndex = 7;
            label7.Text = "Igredientes utilizados:";
            // 
            // txt_precoLanche
            // 
            txt_precoLanche.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_precoLanche.Location = new Point(186, 57);
            txt_precoLanche.Name = "txt_precoLanche";
            txt_precoLanche.Size = new Size(233, 27);
            txt_precoLanche.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 13);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 2;
            label3.Text = "Nome do lanche:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 56);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 1;
            label5.Text = "Preço do lanche:";
            // 
            // txt_nomeLanche
            // 
            txt_nomeLanche.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nomeLanche.Location = new Point(186, 13);
            txt_nomeLanche.Name = "txt_nomeLanche";
            txt_nomeLanche.Size = new Size(233, 27);
            txt_nomeLanche.TabIndex = 3;
            // 
            // Alterar
            // 
            Alterar.BackColor = Color.FromArgb(247, 213, 169);
            Alterar.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Alterar.Location = new Point(4, 4);
            Alterar.Name = "Alterar";
            Alterar.Padding = new Padding(3);
            Alterar.Size = new Size(912, 283);
            Alterar.TabIndex = 2;
            Alterar.Text = "Alterar lanches";
            // 
            // Sobre
            // 
            Sobre.BackColor = Color.FromArgb(247, 213, 169);
            Sobre.Controls.Add(textBox2);
            Sobre.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            Sobre.Location = new Point(4, 4);
            Sobre.Name = "Sobre";
            Sobre.Size = new Size(912, 283);
            Sobre.TabIndex = 3;
            Sobre.Text = "Sobre";
            // 
            // textBox2
            // 
            textBox2.AccessibleRole = AccessibleRole.OutlineButton;
            textBox2.BackColor = SystemColors.Window;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(3, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(894, 260);
            textBox2.TabIndex = 4;
            textBox2.Text = resources.GetString("textBox2.Text");
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // FormJanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 171, 82);
            ClientSize = new Size(944, 451);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormJanelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChessBurger";
            Load += FormJanelaPrincipal_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            Pedidos.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            Lanches.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            LanchesCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLanches).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            Sobre.ResumeLayout(false);
            Sobre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage Pedidos;
        private TabPage Lanches;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txt_nomeCliente;
        private ComboBox cob_lancheEscolhido;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label2;
        private TabPage Alterar;
        private TabPage Sobre;
        private Label label6;
        private TextBox textBox2;
        private Panel panel5;
        private Panel panel6;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private Button btn_finalizarPedido;
        private Panel panel4;
        private TabControl tabControl3;
        private TabPage LanchesCadastrados;
        private Button btn_removerLanche;
        private Panel panel7;
        private Label label7;
        private TextBox txt_precoLanche;
        private Label label3;
        private Label label5;
        private TextBox txt_nomeLanche;
        private Panel panel8;
        private Button btn_cadastrarLanche;
        private Label lbl_mensagem;
        private DataGridView dgPedidos;
        private Panel panel9;
        private TextBox txt_filtrarPedido;
        private Label label8;
        private TextBox txt_igredientes;
        private DataGridView dgLanches;
    }
}