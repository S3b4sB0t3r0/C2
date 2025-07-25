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
            productoRepositoryBindingSource = new BindingSource(components);
            Activo = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewLinkColumn();
            Price = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoRepositoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Activo, ProductName, Category, Price, Cost, Action });
            dataGridView1.DataSource = productoRepositoryBindingSource;
            dataGridView1.Location = new Point(63, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 273);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // productoRepositoryBindingSource
            // 
            productoRepositoryBindingSource.DataSource = typeof(Datos.Repositories.ProductoRepository);
            // 
            // Activo
            // 
            Activo.HeaderText = "Active";
            Activo.Name = "Activo";
            Activo.Resizable = DataGridViewTriState.True;
            Activo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "ProductName";
            ProductName.Name = "ProductName";
            ProductName.Resizable = DataGridViewTriState.True;
            ProductName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.Resizable = DataGridViewTriState.True;
            Category.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.Name = "Cost";
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoRepositoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource productoRepositoryBindingSource;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewLinkColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewButtonColumn Action;
        private DataGridViewTextBoxColumn Activo;
    }
}
