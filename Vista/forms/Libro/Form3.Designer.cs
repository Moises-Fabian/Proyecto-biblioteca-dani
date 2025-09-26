namespace BookWorldApp.Vista.forms.Libro
{
    partial class Form3
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
            label2 = new Label();
            label = new Label();
            btn_eliminarLibro = new Button();
            campo_titulo = new TextBox();
            btn_editarLibro = new Button();
            btn_agregarLibro = new Button();
            campo_anio = new TextBox();
            correo_usuario = new Label();
            campo_genero = new TextBox();
            telefono_usuario = new Label();
            campo_autor = new TextBox();
            nombre_usuario = new Label();
            librosDataGridView = new DataGridView();
            campo_id_libro = new TextBox();
            label1 = new Label();
            campo_existencias = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(12, 431);
            label2.Name = "label2";
            label2.Size = new Size(245, 20);
            label2.TabIndex = 27;
            label2.Text = "(*Ingresar ID para editar o eliminar)";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(28, 69);
            label.Name = "label";
            label.Size = new Size(47, 20);
            label.TabIndex = 26;
            label.Text = "Título";
            // 
            // btn_eliminarLibro
            // 
            btn_eliminarLibro.Location = new Point(31, 567);
            btn_eliminarLibro.Name = "btn_eliminarLibro";
            btn_eliminarLibro.Size = new Size(94, 29);
            btn_eliminarLibro.TabIndex = 25;
            btn_eliminarLibro.Text = "Eliminar";
            btn_eliminarLibro.UseVisualStyleBackColor = true;
            btn_eliminarLibro.Click += btn_eliminarLibro_Click;
            // 
            // campo_titulo
            // 
            campo_titulo.Location = new Point(28, 92);
            campo_titulo.Name = "campo_titulo";
            campo_titulo.Size = new Size(125, 27);
            campo_titulo.TabIndex = 24;
            // 
            // btn_editarLibro
            // 
            btn_editarLibro.Location = new Point(31, 532);
            btn_editarLibro.Name = "btn_editarLibro";
            btn_editarLibro.Size = new Size(94, 29);
            btn_editarLibro.TabIndex = 23;
            btn_editarLibro.Text = "Editar";
            btn_editarLibro.UseVisualStyleBackColor = true;
            btn_editarLibro.Click += btn_editarLibro_Click;
            // 
            // btn_agregarLibro
            // 
            btn_agregarLibro.Location = new Point(28, 385);
            btn_agregarLibro.Name = "btn_agregarLibro";
            btn_agregarLibro.Size = new Size(94, 29);
            btn_agregarLibro.TabIndex = 22;
            btn_agregarLibro.Text = "Agregar";
            btn_agregarLibro.UseVisualStyleBackColor = true;
            btn_agregarLibro.Click += btn_agregarLibro_Click;
            // 
            // campo_anio
            // 
            campo_anio.Location = new Point(28, 208);
            campo_anio.Name = "campo_anio";
            campo_anio.Size = new Size(125, 27);
            campo_anio.TabIndex = 21;
            // 
            // correo_usuario
            // 
            correo_usuario.AutoSize = true;
            correo_usuario.Location = new Point(28, 185);
            correo_usuario.Name = "correo_usuario";
            correo_usuario.Size = new Size(36, 20);
            correo_usuario.TabIndex = 20;
            correo_usuario.Text = "Año";
            // 
            // campo_genero
            // 
            campo_genero.Location = new Point(28, 271);
            campo_genero.Name = "campo_genero";
            campo_genero.Size = new Size(125, 27);
            campo_genero.TabIndex = 19;
            // 
            // telefono_usuario
            // 
            telefono_usuario.AutoSize = true;
            telefono_usuario.Location = new Point(28, 248);
            telefono_usuario.Name = "telefono_usuario";
            telefono_usuario.Size = new Size(57, 20);
            telefono_usuario.TabIndex = 18;
            telefono_usuario.Text = "Género";
            // 
            // campo_autor
            // 
            campo_autor.Location = new Point(28, 145);
            campo_autor.Name = "campo_autor";
            campo_autor.Size = new Size(125, 27);
            campo_autor.TabIndex = 17;
            // 
            // nombre_usuario
            // 
            nombre_usuario.AutoSize = true;
            nombre_usuario.Location = new Point(28, 122);
            nombre_usuario.Name = "nombre_usuario";
            nombre_usuario.Size = new Size(46, 20);
            nombre_usuario.TabIndex = 16;
            nombre_usuario.Text = "Autor";
            // 
            // librosDataGridView
            // 
            librosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            librosDataGridView.Location = new Point(297, 69);
            librosDataGridView.Name = "librosDataGridView";
            librosDataGridView.RowHeadersWidth = 51;
            librosDataGridView.Size = new Size(849, 253);
            librosDataGridView.TabIndex = 15;
            // 
            // campo_id_libro
            // 
            campo_id_libro.Location = new Point(31, 499);
            campo_id_libro.Name = "campo_id_libro";
            campo_id_libro.Size = new Size(125, 27);
            campo_id_libro.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 476);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 29;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // campo_existencias
            // 
            campo_existencias.Location = new Point(28, 335);
            campo_existencias.Name = "campo_existencias";
            campo_existencias.Size = new Size(125, 27);
            campo_existencias.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 312);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 30;
            label3.Text = "Existencias";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 617);
            Controls.Add(campo_existencias);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(campo_id_libro);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(btn_eliminarLibro);
            Controls.Add(campo_titulo);
            Controls.Add(btn_editarLibro);
            Controls.Add(btn_agregarLibro);
            Controls.Add(campo_anio);
            Controls.Add(correo_usuario);
            Controls.Add(campo_genero);
            Controls.Add(telefono_usuario);
            Controls.Add(campo_autor);
            Controls.Add(nombre_usuario);
            Controls.Add(librosDataGridView);
            Name = "Form3";
            Text = "Form3";
            Activated += Form3_Activated;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)librosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label;
        private Button btn_eliminarLibro;
        private TextBox campo_titulo;
        private Button btn_editarLibro;
        private Button btn_agregarLibro;
        private TextBox campo_anio;
        private Label correo_usuario;
        private TextBox campo_genero;
        private Label telefono_usuario;
        private TextBox campo_autor;
        private Label nombre_usuario;
        private DataGridView librosDataGridView;
        private TextBox campo_id_libro;
        private Label label1;
        private TextBox campo_existencias;
        private Label label3;
    }
}