namespace chessBurger
{
    partial class Igredientes
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
            txt_nomeLancheShow = new TextBox();
            txt_igredientes = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_nomeLancheShow
            // 
            txt_nomeLancheShow.Location = new Point(12, 12);
            txt_nomeLancheShow.Name = "txt_nomeLancheShow";
            txt_nomeLancheShow.ReadOnly = true;
            txt_nomeLancheShow.Size = new Size(289, 23);
            txt_nomeLancheShow.TabIndex = 0;
            // 
            // txt_igredientes
            // 
            txt_igredientes.Location = new Point(12, 43);
            txt_igredientes.Multiline = true;
            txt_igredientes.Name = "txt_igredientes";
            txt_igredientes.Size = new Size(289, 233);
            txt_igredientes.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 286);
            button1.Name = "button1";
            button1.Size = new Size(289, 24);
            button1.TabIndex = 2;
            button1.Text = "Adicionar Igredientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Igredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 315);
            Controls.Add(button1);
            Controls.Add(txt_igredientes);
            Controls.Add(txt_nomeLancheShow);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Igredientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Igredientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nomeLancheShow;
        private TextBox txt_igredientes;
        private Button button1;
    }
}