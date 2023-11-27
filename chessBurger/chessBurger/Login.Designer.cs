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
            label1 = new Label();
            txt_senha = new TextBox();
            label2 = new Label();
            btn_entrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.ControlLight;
            txt_usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_usuario.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_usuario.ForeColor = Color.FromArgb(71, 65, 67);
            txt_usuario.Location = new Point(24, 173);
            txt_usuario.MaxLength = 24;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(269, 26);
            txt_usuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 148);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 1;
            label1.Text = "Usuário:";
            label1.Click += label1_Click;
            // 
            // txt_senha
            // 
            txt_senha.BackColor = SystemColors.ControlLight;
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_senha.ForeColor = Color.FromArgb(71, 65, 67);
            txt_senha.Location = new Point(24, 229);
            txt_senha.MaxLength = 24;
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(269, 26);
            txt_senha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 204);
            label2.Name = "label2";
            label2.Size = new Size(58, 22);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // btn_entrar
            // 
            btn_entrar.FlatStyle = FlatStyle.Flat;
            btn_entrar.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.Location = new Point(202, 271);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(91, 29);
            btn_entrar.TabIndex = 4;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(315, 312);
            Controls.Add(pictureBox1);
            Controls.Add(btn_entrar);
            Controls.Add(label2);
            Controls.Add(txt_senha);
            Controls.Add(label1);
            Controls.Add(txt_usuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private Label label1;
        private TextBox txt_senha;
        private Label label2;
        private Button btn_entrar;
        private PictureBox pictureBox1;
    }
}