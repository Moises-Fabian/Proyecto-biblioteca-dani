namespace BookWorldApp
{
    partial class Form1
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
            label1 = new Label();
            btn_usuarios = new Button();
            btn_biblioteca = new Button();
            btn_prestamos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca";
            // 
            // btn_usuarios
            // 
            btn_usuarios.Location = new Point(79, 183);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(166, 29);
            btn_usuarios.TabIndex = 1;
            btn_usuarios.Text = "Gestión usuarios";
            btn_usuarios.UseVisualStyleBackColor = true;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // btn_biblioteca
            // 
            btn_biblioteca.Location = new Point(320, 183);
            btn_biblioteca.Name = "btn_biblioteca";
            btn_biblioteca.Size = new Size(166, 29);
            btn_biblioteca.TabIndex = 2;
            btn_biblioteca.Text = "Gestión biblioteca";
            btn_biblioteca.UseVisualStyleBackColor = true;
            btn_biblioteca.Click += btn_biblioteca_Click;
            // 
            // btn_prestamos
            // 
            btn_prestamos.Location = new Point(556, 183);
            btn_prestamos.Name = "btn_prestamos";
            btn_prestamos.Size = new Size(166, 29);
            btn_prestamos.TabIndex = 3;
            btn_prestamos.Text = "Préstamos";
            btn_prestamos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_prestamos);
            Controls.Add(btn_biblioteca);
            Controls.Add(btn_usuarios);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_usuarios;
        private Button btn_biblioteca;
        private Button btn_prestamos;
    }
}
