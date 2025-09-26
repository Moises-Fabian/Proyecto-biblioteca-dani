namespace BookWorldApp.Vista.forms.Prestamo
{
    partial class Form4
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
            prestamosDataGridView = new DataGridView();
            campo_rut = new TextBox();
            label1 = new Label();
            label2 = new Label();
            campo_id_libro = new TextBox();
            btn_guardar = new Button();
            campo_fecha_prestamo = new DateTimePicker();
            campo_fecha_devolucion = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btn_devolucion = new Button();
            btn_existencias = new Button();
            ((System.ComponentModel.ISupportInitialize)prestamosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // prestamosDataGridView
            // 
            prestamosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prestamosDataGridView.Location = new Point(33, 127);
            prestamosDataGridView.Name = "prestamosDataGridView";
            prestamosDataGridView.RowHeadersWidth = 51;
            prestamosDataGridView.Size = new Size(1061, 210);
            prestamosDataGridView.TabIndex = 0;
            // 
            // campo_rut
            // 
            campo_rut.Location = new Point(33, 50);
            campo_rut.Name = "campo_rut";
            campo_rut.Size = new Size(125, 27);
            campo_rut.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Rut Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 27);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 4;
            label2.Text = "ID libro";
            // 
            // campo_id_libro
            // 
            campo_id_libro.Location = new Point(185, 50);
            campo_id_libro.Name = "campo_id_libro";
            campo_id_libro.Size = new Size(125, 27);
            campo_id_libro.TabIndex = 3;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(33, 92);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(141, 29);
            btn_guardar.TabIndex = 5;
            btn_guardar.Text = "Generar préstamo";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // campo_fecha_prestamo
            // 
            campo_fecha_prestamo.Location = new Point(333, 50);
            campo_fecha_prestamo.Name = "campo_fecha_prestamo";
            campo_fecha_prestamo.Size = new Size(207, 27);
            campo_fecha_prestamo.TabIndex = 6;
            // 
            // campo_fecha_devolucion
            // 
            campo_fecha_devolucion.Location = new Point(569, 48);
            campo_fecha_devolucion.Name = "campo_fecha_devolucion";
            campo_fecha_devolucion.Size = new Size(250, 27);
            campo_fecha_devolucion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 27);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha préstamo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 27);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 9;
            label4.Text = "Fecha devolución";
            // 
            // btn_devolucion
            // 
            btn_devolucion.Location = new Point(185, 92);
            btn_devolucion.Name = "btn_devolucion";
            btn_devolucion.Size = new Size(136, 29);
            btn_devolucion.TabIndex = 10;
            btn_devolucion.Text = "Devolver libro";
            btn_devolucion.UseVisualStyleBackColor = true;
            btn_devolucion.Click += btn_devolucion_Click;
            // 
            // btn_existencias
            // 
            btn_existencias.Location = new Point(333, 92);
            btn_existencias.Name = "btn_existencias";
            btn_existencias.Size = new Size(94, 29);
            btn_existencias.TabIndex = 11;
            btn_existencias.Text = "Ver stock";
            btn_existencias.UseVisualStyleBackColor = true;
            btn_existencias.Click += btn_existencias_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 439);
            Controls.Add(btn_existencias);
            Controls.Add(btn_devolucion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(campo_fecha_devolucion);
            Controls.Add(campo_fecha_prestamo);
            Controls.Add(btn_guardar);
            Controls.Add(label2);
            Controls.Add(campo_id_libro);
            Controls.Add(label1);
            Controls.Add(campo_rut);
            Controls.Add(prestamosDataGridView);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)prestamosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView prestamosDataGridView;
        private TextBox campo_rut;
        private Label label1;
        private Label label2;
        private TextBox campo_id_libro;
        private Button btn_guardar;
        private DateTimePicker campo_fecha_prestamo;
        private DateTimePicker campo_fecha_devolucion;
        private Label label3;
        private Label label4;
        private Button btn_devolucion;
        private Button btn_existencias;
    }
}