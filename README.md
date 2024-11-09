# Proyecto-Integrador-DSOO

## Requisitos del Sistema

- **Sistema Operativo**: Windows 10 o superior.
- **Entorno de Desarrollo**: Visual Studio 2019 o superior.
- **Base de Datos**: SQL Server 2017 o superior.
- **Framework**: .NET Framework 4.7.2 o superior.

## Tecnologías Utilizadas

- **C#**: Lenguaje de programación principal utilizado en el proyecto.
- **Windows Forms**: Para el desarrollo de la interfaz gráfica de usuario.
- **Entity Framework**: Utilizado para la interacción con la base de datos.
- **Git**: Control de versiones y manejo del código fuente.

## Funcionalidades Principales

- Gestión de clientes: inscripción, actualización y eliminación de registros.
- Gestión de actividades: creación y programación de nuevas actividades.
- Inscripción a actividades: permite a los clientes inscribirse en actividades disponibles.
- Gestión de pagos: registro y seguimiento de pagos realizados por los clientes.

## Instalación

1. Clona el repositorio:
    ```sh
    git clone <URL_DEL_REPOSITORIO>
    ```
2. Abre el proyecto en Visual Studio.
3. Restaura los paquetes NuGet:
    ```sh
    dotnet restore
    ```
4. Configura la cadena de conexión a la base de datos en el archivo `app.config`.

## Uso

1. Compila y ejecuta el proyecto desde Visual Studio.
2. Inicia sesión en la aplicación.
3. Utiliza las diferentes funcionalidades disponibles en la pantalla principal.

## Contribución

1. Haz un fork del repositorio.
2. Crea una nueva rama:
    ```sh
    git checkout -b feature/nueva-funcionalidad
    ```
3. Realiza tus cambios y haz commit:
    ```sh
    git commit -m "Añadir nueva funcionalidad"
    ```
4. Sube tus cambios:
    ```sh
    git push origin feature/nueva-funcionalidad
    ```
5. Abre un Pull Request.

