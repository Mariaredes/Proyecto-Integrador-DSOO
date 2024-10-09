using System;
using System.Windows.Forms;
using proyectoIntegrador.Datos; // Aseg�rate de incluir esta l�nea

namespace proyectoIntegrador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Evento para manejar el clic en el bot�n de inicio de sesi�n
        private void Button1_Click(object sender, EventArgs e)
        {
            // Obtener valores de los campos de texto
            string usuario = textBox1.Text;
            string contrase�a = textBox2.Text;

            // Crear una instancia de la clase Usuario
            Usuario usuarioDatos = new Usuario();

            // Llamar a la funci�n que valida las credenciales
            int resultadoLogin = usuarioDatos.Log_Usu(usuario, contrase�a);

            if (resultadoLogin == 1) // Suponiendo que 1 significa �xito
            {
                MessageBox.Show("Inicio de sesi�n exitoso.");
                // Aqu� puedes redirigir a la siguiente ventana o realizar otras acciones
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos.");
            }
        }
    }
}
