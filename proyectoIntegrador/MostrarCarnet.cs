using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using proyectoIntegrador.Datos;


namespace proyectoIntegrador
{
    public partial class MostrarCarnet : Form
    {
        public MostrarCarnet()
        {
            InitializeComponent();
        }

        private void MostrarCarnet_Load(object sender, EventArgs e)
        {

        }


        private void txtNroCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNroCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa el número de DNI del cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lblId_Cliente.Text))
            {
                MessageBox.Show("Por favor, presione el boton buscar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF File|*.pdf",
                Title = "Guardar carnet como PDF",
                FileName = "Carnet_Socio.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document pdfDoc = new Document(PageSize.A4);
                try
                {

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    pdfDoc.Add(new Paragraph("Carnet de Socio"));
                    pdfDoc.Add(new Paragraph(" "));

                    pdfDoc.Add(new Paragraph("Nro de Socio: " + lblId_Cliente.Text));
                    pdfDoc.Add(new Paragraph("Nombre: " + lblNombre.Text));
                    pdfDoc.Add(new Paragraph("Apellido: " + lblApellido.Text));
                    pdfDoc.Add(new Paragraph("DNI: " + lblDNI.Text));
                    pdfDoc.Add(new Paragraph("Fecha de Nacimiento: " + lblFechaNac.Text));

                    MessageBox.Show("Carnet generado exitosamente como PDF.", "PDF Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message);
                }
                finally
                {
                    pdfDoc.Close();
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Home formPrevio = new Home();
            this.Close();
            formPrevio.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNroCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa el número de cliente.");
                return;
            }

            string query = "SELECT id_cliente, nombre, apellido, dni, fechaNacimiento, asociado FROM cliente WHERE dni = @dni";

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    // Abrir la conexión a la base de datos
                    sqlCon.Open();


                    using (MySqlCommand command = new MySqlCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@dni", txtNroCliente.Text);


                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            
                            int asociado = Convert.ToInt32(reader["asociado"]);
                            if (asociado == 0)
                            {
                                MessageBox.Show("El usuario que esta buscando no es socio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }

                            else
                            {
                                lblId_Cliente.Text = reader["id_cliente"].ToString();
                                lblNombre.Text = reader["nombre"].ToString();
                                lblApellido.Text = reader["apellido"].ToString();
                                lblDNI.Text = reader["dni"].ToString();
                                lblFechaNac.Text = Convert.ToDateTime(reader["fechaNacimiento"]).ToShortDateString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.");
                            txtNroCliente.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNroCliente.Text = "";
            lblId_Cliente.Text = "";
            lblNombre.Text = "";
            lblApellido.Text = "";
            lblDNI.Text = "";
            lblFechaNac.Text = "";
            txtNroCliente.Focus();
        }
    }
}
