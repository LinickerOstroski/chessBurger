namespace chessBurger
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_usuario = new TextBox();
            lbl_usuario = new Label();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            btn_entrar = new Button();
            lbl_informacao = new Label();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            tab_login = new TabControl();
            LoginPage = new TabPage();
            label4 = new Label();
            RegisterPage = new TabPage();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            txt_confirmarSenha = new TextBox();
            label3 = new Label();
            btn_Registrar = new Button();
            btn_cancelar = new Button();
            txt_registrarSenha = new TextBox();
            txt_registrarUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tab_login.SuspendLayout();
            LoginPage.SuspendLayout();
            RegisterPage.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.Window;
            txt_usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_usuario.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.ForeColor = Color.FromArgb(71, 65, 67);
            txt_usuario.Location = new Point(26, 245);
            txt_usuario.MaxLength = 24;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(269, 26);
            txt_usuario.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_usuario.Location = new Point(22, 220);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(68, 22);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuário:";
            lbl_usuario.Click += label1_Click;
            // 
            // txt_senha
            // 
            txt_senha.BackColor = SystemColors.Window;
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.ForeColor = Color.FromArgb(71, 65, 67);
            txt_senha.Location = new Point(26, 299);
            txt_senha.MaxLength = 24;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(269, 26);
            txt_senha.TabIndex = 2;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha.Location = new Point(26, 274);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(58, 22);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha:";
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.FromArgb(21, 126, 44);
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_entrar.ForeColor = Color.White;
            btn_entrar.Location = new Point(26, 331);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(269, 29);
            btn_entrar.TabIndex = 4;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += button1_Click;
            // 
            // lbl_informacao
            // 
            lbl_informacao.AutoSize = true;
            lbl_informacao.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_informacao.ForeColor = Color.FromArgb(71, 65, 67);
            lbl_informacao.Location = new Point(26, 368);
            lbl_informacao.Name = "lbl_informacao";
            lbl_informacao.Size = new Size(177, 18);
            lbl_informacao.TabIndex = 6;
            lbl_informacao.Text = "Ainda não possui uma conta?";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(198, 390);
            button1.Name = "button1";
            button1.Size = new Size(97, 26);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 141, 48);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbl_usuario);
            panel1.Controls.Add(lbl_informacao);
            panel1.Controls.Add(btn_entrar);
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_senha);
            panel1.Location = new Point(239, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 446);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(217, 141, 48);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 228);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-36, 119);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(316, 291);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // tab_login
            // 
            tab_login.Alignment = TabAlignment.Bottom;
            tab_login.Controls.Add(LoginPage);
            tab_login.Controls.Add(RegisterPage);
            tab_login.Location = new Point(-6, -6);
            tab_login.Multiline = true;
            tab_login.Name = "tab_login";
            tab_login.SelectedIndex = 0;
            tab_login.Size = new Size(578, 464);
            tab_login.TabIndex = 7;
            // 
            // LoginPage
            // 
            LoginPage.Controls.Add(label4);
            LoginPage.Controls.Add(panel1);
            LoginPage.Controls.Add(pictureBox4);
            LoginPage.Location = new Point(4, 4);
            LoginPage.Name = "LoginPage";
            LoginPage.Padding = new Padding(3);
            LoginPage.Size = new Size(570, 436);
            LoginPage.TabIndex = 0;
            LoginPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(141, 61);
            label4.TabIndex = 8;
            label4.Text = "Login";
            // 
            // RegisterPage
            // 
            RegisterPage.Controls.Add(panel2);
            RegisterPage.Controls.Add(txt_confirmarSenha);
            RegisterPage.Controls.Add(label3);
            RegisterPage.Controls.Add(btn_Registrar);
            RegisterPage.Controls.Add(btn_cancelar);
            RegisterPage.Controls.Add(txt_registrarSenha);
            RegisterPage.Controls.Add(txt_registrarUsuario);
            RegisterPage.Controls.Add(label2);
            RegisterPage.Controls.Add(label1);
            RegisterPage.Controls.Add(pictureBox1);
            RegisterPage.Location = new Point(4, 4);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Padding = new Padding(3);
            RegisterPage.Size = new Size(570, 436);
            RegisterPage.TabIndex = 1;
            RegisterPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 141, 48);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-4, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 450);
            panel2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-94, 132);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(415, 317);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 40);
            label5.Name = "label5";
            label5.Size = new Size(218, 61);
            label5.TabIndex = 9;
            label5.Text = "Registrar";
            // 
            // txt_confirmarSenha
            // 
            txt_confirmarSenha.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_confirmarSenha.Location = new Point(278, 287);
            txt_confirmarSenha.MaxLength = 8;
            txt_confirmarSenha.Name = "txt_confirmarSenha";
            txt_confirmarSenha.PasswordChar = '*';
            txt_confirmarSenha.Size = new Size(262, 26);
            txt_confirmarSenha.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(278, 264);
            label3.Name = "label3";
            label3.Size = new Size(126, 22);
            label3.TabIndex = 7;
            label3.Text = "Confirmar senha";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Registrar
            // 
            btn_Registrar.BackColor = Color.FromArgb(21, 126, 44);
            btn_Registrar.FlatStyle = FlatStyle.Flat;
            btn_Registrar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Registrar.ForeColor = Color.White;
            btn_Registrar.Image = (Image)resources.GetObject("btn_Registrar.Image");
            btn_Registrar.ImageAlign = ContentAlignment.MiddleRight;
            btn_Registrar.Location = new Point(418, 380);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(122, 30);
            btn_Registrar.TabIndex = 6;
            btn_Registrar.Text = "Criar conta";
            btn_Registrar.TextAlign = ContentAlignment.MiddleLeft;
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(71, 65, 67);
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(322, 379);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(90, 30);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_registrarSenha
            // 
            txt_registrarSenha.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_registrarSenha.Location = new Point(278, 234);
            txt_registrarSenha.MaxLength = 8;
            txt_registrarSenha.Name = "txt_registrarSenha";
            txt_registrarSenha.PasswordChar = '*';
            txt_registrarSenha.Size = new Size(262, 26);
            txt_registrarSenha.TabIndex = 4;
            // 
            // txt_registrarUsuario
            // 
            txt_registrarUsuario.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_registrarUsuario.Location = new Point(278, 178);
            txt_registrarUsuario.MaxLength = 23;
            txt_registrarUsuario.Name = "txt_registrarUsuario";
            txt_registrarUsuario.Size = new Size(262, 26);
            txt_registrarUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(278, 209);
            label2.Name = "label2";
            label2.Size = new Size(217, 22);
            label2.TabIndex = 2;
            label2.Text = "Senha (máximo 8 caracteres)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 152);
            label1.Name = "label1";
            label1.Size = new Size(129, 22);
            label1.TabIndex = 1;
            label1.Text = "Nome do usuário";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(550, 420);
            Controls.Add(tab_login);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tab_login.ResumeLayout(false);
            LoginPage.ResumeLayout(false);
            LoginPage.PerformLayout();
            RegisterPage.ResumeLayout(false);
            RegisterPage.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_usuario;
        private Label lbl_usuario;
        private TextBox txt_senha;
        private Label lbl_senha;
        private Button btn_entrar;
        private Label lbl_informacao;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private TabControl tab_login;
        private TabPage LoginPage;
        private TabPage RegisterPage;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txt_registrarUsuario;
        private Button btn_cancelar;
        private TextBox txt_registrarSenha;
        private Button btn_Registrar;
        private Label label3;
        private TextBox txt_confirmarSenha;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
    }
}