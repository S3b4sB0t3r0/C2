namespace VistaOk
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Id_Cate = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Category = new DataGridViewLinkColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Fecha_Intro = new DataGridViewTextBoxColumn();
            Acciones = new DataGridViewComboBoxColumn();
            productoRepositoryBindingSource = new BindingSource(components);
            productoRepositoryBindingSource1 = new BindingSource(components);
            txtBuscar = new TextBox();
            BuscarE = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            AgregarP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoRepositoryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Activo, ProductName, Id_Cate, Price, Cost, Category, Descripcion, Fecha_Intro, Acciones });
            dataGridView1.DataSource = productoRepositoryBindingSource;
            dataGridView1.Location = new Point(12, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1032, 311);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Activo
            // 
            Activo.HeaderText = "Active";
            Activo.Name = "Activo";
            Activo.ReadOnly = true;
            Activo.Resizable = DataGridViewTriState.True;
            Activo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Resizable = DataGridViewTriState.True;
            ProductName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Id_Cate
            // 
            Id_Cate.HeaderText = "Id_Cate";
            Id_Cate.Name = "Id_Cate";
            Id_Cate.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Resizable = DataGridViewTriState.True;
            Category.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Fecha_Intro
            // 
            Fecha_Intro.HeaderText = "Fecha_Intro";
            Fecha_Intro.Name = "Fecha_Intro";
            Fecha_Intro.ReadOnly = true;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            Acciones.Sorted = true;
            Acciones.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // productoRepositoryBindingSource
            // 
            productoRepositoryBindingSource.DataSource = typeof(Datos.Repositories.ProductoRepository);
            // 
            // productoRepositoryBindingSource1
            // 
            productoRepositoryBindingSource1.DataSource = typeof(Datos.Repositories.ProductoRepository);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 63);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(192, 23);
            txtBuscar.TabIndex = 1;
            
            // 
            // BuscarE
            // 
            BuscarE.Location = new Point(210, 63);
            BuscarE.Name = "BuscarE";
            BuscarE.Size = new Size(75, 23);
            BuscarE.TabIndex = 2;
            BuscarE.Text = "Buscar";
            BuscarE.UseVisualStyleBackColor = true;
            BuscarE.Click += BuscarE_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AgregarP
            // 
            AgregarP.Location = new Point(895, 63);
            AgregarP.Name = "AgregarP";
            AgregarP.Size = new Size(149, 23);
            AgregarP.TabIndex = 3;
            AgregarP.Text = "Agregar Producto";
            AgregarP.UseVisualStyleBackColor = true;
            AgregarP.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 467);
            Controls.Add(AgregarP);
            Controls.Add(BuscarE);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoRepositoryBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource productoRepositoryBindingSource;
        private TextBox txtBuscar;
        private Button BuscarE;
        private ContextMenuStrip contextMenuStrip1;
        private BindingSource productoRepositoryBindingSource1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Id_Cate;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewLinkColumn Category;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Fecha_Intro;
        private DataGridViewComboBoxColumn Acciones;
        private Button AgregarP;
    }
}
