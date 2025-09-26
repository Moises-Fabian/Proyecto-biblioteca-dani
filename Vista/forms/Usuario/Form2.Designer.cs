namespace BookWorldApp.Vista
{
    partial class Form2
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
            usuariosDataGridView = new DataGridView();
            nombre_usuario = new Label();
            campo_nombre = new TextBox();
            campo_telefono = new TextBox();
            telefono_usuario = new Label();
            campo_correo = new TextBox();
            correo_usuario = new Label();
            btn_agregarUsuario = new Button();
            btn_editar = new Button();
            campo_rut = new TextBox();
            button1 = new Button();
            label = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usuariosDataGridView
            // 
            usuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuariosDataGridView.Location = new Point(333, 79);
            usuariosDataGridView.Name = "usuariosDataGridView";
            usuariosDataGridView.RowHeadersWidth = 51;
            usuariosDataGridView.Size = new Size(737, 253);
            usuariosDataGridView.TabIndex = 0;
            // 
            // nombre_usuario
            // 
            nombre_usuario.AutoSize = true;
            nombre_usuario.Location = new Point(33, 109);
            nombre_usuario.Name = "nombre_usuario";
            nombre_usuario.Size = new Size(64, 20);
            nombre_usuario.TabIndex = 1;
            nombre_usuario.Text = "Nombre";
            // 
            // campo_nombre
            // 
            campo_nombre.Location = new Point(33, 132);
            campo_nombre.Name = "campo_nombre";
            campo_nombre.Size = new Size(125, 27);
            campo_nombre.TabIndex = 2;
            // 
            // campo_telefono
            // 
            campo_telefono.Location = new Point(33, 258);
            campo_telefono.Name = "campo_telefono";
            campo_telefono.Size = new Size(125, 27);
            campo_telefono.TabIndex = 6;
            // 
            // telefono_usuario
            // 
            telefono_usuario.AutoSize = true;
            telefono_usuario.Location = new Point(33, 235);
            telefono_usuario.Name = "telefono_usuario";
            telefono_usuario.Size = new Size(67, 20);
            telefono_usuario.TabIndex = 5;
            telefono_usuario.Text = "Teléfono";
            // 
            // campo_correo
            // 
            campo_correo.Location = new Point(33, 195);
            campo_correo.Name = "campo_correo";
            campo_correo.Size = new Size(125, 27);
            campo_correo.TabIndex = 8;
            // 
            // correo_usuario
            // 
            correo_usuario.AutoSize = true;
            correo_usuario.Location = new Point(33, 172);
            correo_usuario.Name = "correo_usuario";
            correo_usuario.Size = new Size(54, 20);
            correo_usuario.TabIndex = 7;
            correo_usuario.Text = "Correo";
            // 
            // btn_agregarUsuario
            // 
            btn_agregarUsuario.Location = new Point(33, 308);
            btn_agregarUsuario.Name = "btn_agregarUsuario";
            btn_agregarUsuario.Size = new Size(94, 29);
            btn_agregarUsuario.TabIndex = 9;
            btn_agregarUsuario.Text = "Agregar";
            btn_agregarUsuario.UseVisualStyleBackColor = true;
            btn_agregarUsuario.Click += btn_agregarUsuario_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(33, 379);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(94, 29);
            btn_editar.TabIndex = 10;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // campo_rut
            // 
            campo_rut.Location = new Point(33, 79);
            campo_rut.Name = "campo_rut";
            campo_rut.Size = new Size(125, 27);
            campo_rut.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(33, 414);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_eliminar;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(33, 56);
            label.Name = "label";
            label.Size = new Size(31, 20);
            label.TabIndex = 13;
            label.Text = "Rut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(14, 346);
            label2.Name = "label2";
            label2.Size = new Size(252, 20);
            label2.TabIndex = 14;
            label2.Text = "(*Ingresar Rut para editar o eliminar)";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 531);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(button1);
            Controls.Add(campo_rut);
            Controls.Add(btn_editar);
            Controls.Add(btn_agregarUsuario);
            Controls.Add(campo_correo);
            Controls.Add(correo_usuario);
            Controls.Add(campo_telefono);
            Controls.Add(telefono_usuario);
            Controls.Add(campo_nombre);
            Controls.Add(nombre_usuario);
            Controls.Add(usuariosDataGridView);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usuariosDataGridView;
        private Label nombre_usuario;
        private TextBox campo_nombre;
        private TextBox campo_telefono;
        private Label telefono_usuario;
        private TextBox campo_correo;
        private Label correo_usuario;
        private Button btn_agregarUsuario;
        private Button btn_editar;
        private TextBox campo_rut;
        private Button button1;
        private Label label;
        private Label label2;
    }
}