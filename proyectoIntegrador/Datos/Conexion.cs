using MySql.Data.MySqlClient;

namespace proyectoIntegrador.Datos
{
    public class Conexion
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() // asignamos valores a las variables de la conexion
        {
            this.baseDatos = "clubdeportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "root";
        }

        public MySqlConnection CrearConexion() // corregido el nombre CrearConcexion a CrearConexion
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw; // sería útil arrojar el 'ex' para tener más información del error
            }
            return cadena;
        }

        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con; // corregido return incompleto
        }
    }
}
