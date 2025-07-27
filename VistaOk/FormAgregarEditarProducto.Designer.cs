namespace VistaOk
{
    partial class FormAgregarEditarProducto
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
            txtDescripcion = new TextBox();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            comboboxCate = new ComboBox();
            dateProductos = new DateTimePicker();
            checkBoxProducto = new CheckBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCosto = new TextBox();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(138, 290);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(222, 23);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(138, 328);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(285, 328);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // comboboxCate
            // 
            comboboxCate.FormattingEnabled = true;
            comboboxCate.Location = new Point(138, 87);
            comboboxCate.Name = "comboboxCate";
            comboboxCate.Size = new Size(222, 23);
            comboboxCate.TabIndex = 6;
            comboboxCate.SelectedIndexChanged += comboboxCate_SelectedIndexChanged;
            // 
            // dateProductos
            // 
            dateProductos.Location = new Point(138, 212);
            dateProductos.Name = "dateProductos";
            dateProductos.Size = new Size(222, 23);
            dateProductos.TabIndex = 7;
            dateProductos.ValueChanged += dateProductos_ValueChanged;
            // 
            // checkBoxProducto
            // 
            checkBoxProducto.AutoSize = true;
            checkBoxProducto.Location = new Point(138, 256);
            checkBoxProducto.Name = "checkBoxProducto";
            checkBoxProducto.Size = new Size(60, 19);
            checkBoxProducto.TabIndex = 8;
            checkBoxProducto.Text = "Activo";
            checkBoxProducto.UseVisualStyleBackColor = true;
            checkBoxProducto.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += txtNombre_TextChanged_1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(138, 133);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(222, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.TextChanged += txtPrecio_TextChanged_1;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(140, 170);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(220, 23);
            txtCosto.TabIndex = 11;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // FormAgregarEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 450);
            Controls.Add(txtCosto);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(checkBoxProducto);
            Controls.Add(dateProductos);
            Controls.Add(comboboxCate);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(txtDescripcion);
            Name = "FormAgregarEditarProducto";
            Text = "FormAgregarEditarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private ComboBox comboboxCate;
        private DateTimePicker dateProductos;
        private CheckBox checkBoxProducto;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCosto;
    }
}