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
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            txt_pedidos = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            textBox5 = new TextBox();
            txt_lanches = new TextBox();
            button2 = new Button();
            label3 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            Alterar = new TabPage();
            tabPage3 = new TabPage();
            label6 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 213, 169);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(943, 167);
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
            panel1.Size = new Size(940, 127);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(271, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gadugi", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(135, 8);
            label4.Name = "label4";
            label4.Size = new Size(610, 115);
            label4.TabIndex = 1;
            label4.Text = "Ch  ssBurger";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(Alterar);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 187);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(908, 293);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(247, 213, 169);
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(panel3);
            tabPage1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(900, 259);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pedidos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(251, 234, 212);
            panel3.Controls.Add(txt_pedidos);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(6, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(877, 213);
            panel3.TabIndex = 5;
            // 
            // txt_pedidos
            // 
            txt_pedidos.BackColor = SystemColors.Window;
            txt_pedidos.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pedidos.Location = new Point(491, 20);
            txt_pedidos.Multiline = true;
            txt_pedidos.Name = "txt_pedidos";
            txt_pedidos.ReadOnly = true;
            txt_pedidos.Size = new Size(366, 176);
            txt_pedidos.TabIndex = 6;
            txt_pedidos.Text = "Pedidos Cadastrados:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(239, 171, 82);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(26, 94);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar Pedido";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(216, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 27);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 2;
            label2.Text = "Nome do cliente:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(216, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 50);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 1;
            label1.Text = "Lanche escolhido:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(247, 213, 169);
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(900, 259);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lanches";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(251, 234, 212);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(txt_lanches);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(10, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(877, 213);
            panel4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(264, 54);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(256, 107);
            textBox5.TabIndex = 7;
            // 
            // txt_lanches
            // 
            txt_lanches.BackColor = SystemColors.Window;
            txt_lanches.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lanches.Location = new Point(543, 17);
            txt_lanches.Multiline = true;
            txt_lanches.Name = "txt_lanches";
            txt_lanches.ReadOnly = true;
            txt_lanches.Size = new Size(314, 179);
            txt_lanches.TabIndex = 6;
            txt_lanches.Text = "Lanches Cadastrados:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(239, 171, 82);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(303, 172);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 0;
            button2.Text = "Cadastrar Lanche";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 15);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 2;
            label3.Text = "Nome do Lanche:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(216, 17);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(304, 27);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 52);
            label5.Name = "label5";
            label5.Size = new Size(244, 28);
            label5.TabIndex = 1;
            label5.Text = "Igredientes utilizados:";
            label5.Click += label5_Click;
            // 
            // Alterar
            // 
            Alterar.Location = new Point(4, 30);
            Alterar.Name = "Alterar";
            Alterar.Padding = new Padding(3);
            Alterar.Size = new Size(900, 259);
            Alterar.TabIndex = 2;
            Alterar.Text = "Alterar";
            Alterar.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(900, 259);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Sobre";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(717, 85);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 3;
            label6.Text = "alpha 0.1";
            // 
            // FormJanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 171, 82);
            ClientSize = new Size(932, 492);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormJanelaPrincipal";
            Text = "ChessBurger";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label2;
        public TextBox txt_pedidos;
        private Panel panel4;
        private TextBox textBox5;
        public TextBox txt_lanches;
        private Button button2;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
        private TabPage Alterar;
        private TabPage tabPage3;
        private Label label6;
    }
}