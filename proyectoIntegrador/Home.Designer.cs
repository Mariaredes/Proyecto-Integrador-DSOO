using System;
using System.Windows.Forms;

namespace proyectoIntegrador
{
    partial class Home : Form
    {
        /// <summary>
        /// Variable que controla si los componentes se han desinfectado.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que esté utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos se deben eliminar; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Requerido por el Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            btnInscribirCliente = new Button();
            btnInscribirActividades = new Button();
            btnPagos = new Button();
            btnListadoVencimientos = new Button();
            btnSalir = new Button();
            lblTitulo = new Label();
            btnCarnet = new Button();
            SuspendLayout();
            // 
            // btnInscribirCliente
            // 
            btnInscribirCliente.BackColor = Color.FromArgb(233, 239, 236);
            btnInscribirCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirCliente.Location = new Point(78, 114);
            btnInscribirCliente.Margin = new Padding(4);
            btnInscribirCliente.Name = "btnInscribirCliente";
            btnInscribirCliente.Size = new Size(246, 70);
            btnInscribirCliente.TabIndex = 0;
            btnInscribirCliente.Text = "Inscribir Cliente";
            btnInscribirCliente.UseVisualStyleBackColor = false;
            btnInscribirCliente.Click += btnInscribirCliente_Click;
            // 
            // btnInscribirActividades
            // 
            btnInscribirActividades.BackColor = Color.FromArgb(233, 239, 236);
            btnInscribirActividades.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirActividades.Location = new Point(420, 114);
            btnInscribirActividades.Margin = new Padding(4);
            btnInscribirActividades.Name = "btnInscribirActividades";
            btnInscribirActividades.Size = new Size(244, 70);
            btnInscribirActividades.TabIndex = 1;
            btnInscribirActividades.Text = "Inscribir Actividades";
            btnInscribirActividades.UseVisualStyleBackColor = false;
            btnInscribirActividades.Click += btnInscribirActividades_Click;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.FromArgb(233, 239, 236);
            btnPagos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagos.Location = new Point(78, 229);
            btnPagos.Margin = new Padding(4);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(246, 75);
            btnPagos.TabIndex = 2;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnListadoVencimientos
            // 
            btnListadoVencimientos.BackColor = Color.FromArgb(233, 239, 236);
            btnListadoVencimientos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListadoVencimientos.Location = new Point(420, 229);
            btnListadoVencimientos.Margin = new Padding(4);
            btnListadoVencimientos.Name = "btnListadoVencimientos";
            btnListadoVencimientos.Size = new Size(244, 75);
            btnListadoVencimientos.TabIndex = 3;
            btnListadoVencimientos.Text = "Listado de Vencimientos";
            btnListadoVencimientos.UseVisualStyleBackColor = false;
            btnListadoVencimientos.Click += btnListadoVencimientos_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(233, 239, 236);
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(430, 375);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(234, 46);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(250, 34);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 26);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Bienvenido al Sistema";
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.FromArgb(233, 239, 236);
            btnCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarnet.Location = new Point(78, 346);
            btnCarnet.Margin = new Padding(4);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(246, 75);
            btnCarnet.TabIndex = 6;
            btnCarnet.Text = "Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 242);
            ClientSize = new Size(744, 439);
            Controls.Add(btnCarnet);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnListadoVencimientos);
            Controls.Add(btnPagos);
            Controls.Add(btnInscribirActividades);
            Controls.Add(btnInscribirCliente);
            Margin = new Padding(4);
            Name = "Home";
            Text = "Ventana Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnInscribirCliente;
        private System.Windows.Forms.Button btnInscribirActividades;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnListadoVencimientos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label labelTitulo;
        private Label lblTitulo;
        private Button btnCarnet;
    }
}
