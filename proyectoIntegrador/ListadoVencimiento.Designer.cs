﻿namespace proyectoIntegrador
{
    partial class ListadoVencimiento
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
            gridVencimientos = new DataGridView();
            lblTituloVencimientos = new Label();
            IdCliente = new DataGridViewLinkColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridVencimientos).BeginInit();
            SuspendLayout();
            // 
            // gridVencimientos
            // 
            gridVencimientos.AllowUserToAddRows = false;
            gridVencimientos.AllowUserToDeleteRows = false;
            gridVencimientos.AllowUserToOrderColumns = true;
            gridVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVencimientos.Columns.AddRange(new DataGridViewColumn[] { IdCliente, NombreCompleto, Dni, FechaVencimiento });
            gridVencimientos.Location = new Point(12, 78);
            gridVencimientos.Name = "gridVencimientos";
            gridVencimientos.ReadOnly = true;
            gridVencimientos.RowTemplate.Height = 25;
            gridVencimientos.Size = new Size(776, 360);
            gridVencimientos.TabIndex = 0;
            gridVencimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Al inicializar el DataGridView en el constructor o en el evento Load
            gridVencimientos.RowHeadersVisible = false;
            gridVencimientos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridVencimientos.CellContentClick += gridVencimientos_CellContentClick;
            // 
            // lblTituloVencimientos
            // 
            lblTituloVencimientos.AutoSize = true;
            lblTituloVencimientos.Location = new Point(303, 29);
            lblTituloVencimientos.Name = "lblTituloVencimientos";
            lblTituloVencimientos.Size = new Size(172, 15);
            lblTituloVencimientos.TabIndex = 1;
            lblTituloVencimientos.Text = "Listado de vencimientos al dia: ";
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "Nro del socio";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Visible = true;
            // 
            // Dni
            // 
            Dni.HeaderText = "Documento";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            Dni.Visible = true;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "Fecha de vencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            FechaVencimiento.Visible = true;
            // 
            // ListadoVencimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTituloVencimientos);
            Controls.Add(gridVencimientos);
            Name = "ListadoVencimiento";
            Text = "Listado de Vencimientos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridVencimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridVencimientos;
        private Label lblTituloVencimientos;
        private DataGridViewLinkColumn IdCliente;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn FechaVencimiento;
    }
}