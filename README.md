# Sistema "Conquista tu Mundo" - Ignacio Leonel Maldonado 2024

## Enlaces de Interés

- [Perfil de LinkedIn](https://www.linkedin.com/in/ignacio-leonel-maldonado-251b7b344)
- [Repositorio en GitHub](https://github.com/IgnaMaldo17)

## Instrucciones Importantes

Por favor, lea este documento detenidamente antes de comenzar la instalación del sistema "Conquista tu Mundo" o de cualquiera de sus requisitos.

---

## Requisitos del Sistema

- **Sistema Operativo:** Windows 10 o posterior.
- **Base de Datos:** Microsoft SQL Server 2022 o posterior. (Se recomienda seguir las instrucciones detalladas en este documento).
- **SDK:** Microsoft .NET SDK 8.0.100 o posterior.

---

## Instrucciones de Instalación

1. **Ejecutar el instalador como administrador:**
   Si SmartScreen de Microsoft Defender bloquea la instalación, desactívelo temporalmente:
   - Abra "Seguridad de Windows".
   - Vaya a "Control de aplicaciones y explorador".
   - Seleccione "Configuración de protección basada en reputación" y desactive "Comprobar aplicaciones y archivos".

2. **Instalación de SQL Server:**
   Si no tiene SQL Server instalado, aparecerá una ventana para iniciar su instalación. Siga estos pasos:

   a. Seleccione la opción "Personalizado" y cambie el idioma a inglés si se le recomienda.

   b. Seleccione la ubicación de instalación.

   c. Acepte los términos y condiciones en el "SQL Server Installation Center" y haga clic en "Next". Si aparece un mensaje indicando que la base de datos "SisAgencia" no existe, no cierre la ventana y prosiga con los pasos siguientes.

   d. Desactive "Windows Firewall" antes de continuar y, una vez que la barra de carga se complete, presione "Next".

   e. Desmarque la opción "Azure Extension for SQL", ya que no es necesaria.

   f. En la sección "Features", no modifique las configuraciones predeterminadas y haga clic en "Next".

   g. Seleccione "Named instance" y escriba "SISAGENCIA" en el cuadro de texto. Si "Instance ID" no se actualiza automáticamente, escríbalo manualmente. Este paso es obligatorio.

   h. Mantenga las configuraciones predeterminadas en "Server Configuration" y haga clic en "Next".

   i. En "Authentication Mode", seleccione "Windows authentication mode" y haga clic en "Next". Una vez completada la instalación, cierre el "SQL Server Installation Center".

3. **Creación de la Base de Datos:**
   Aparecerá una ventana indicando que la base de datos "SisAgencia" no existe. Haga clic en "Aceptar" para proceder con su creación.

4. **Continuar con la Instalación del Sistema:**
   - Seleccione la carpeta de destino y haga clic en "Siguiente".
   - Active la opción "Crear un acceso directo en el escritorio" y haga clic en "Siguiente".
   - Finalmente, haga clic en "Instalar". Si aparece un mensaje indicando que la base de datos "SisAgencia" ya existe, seleccione "Sí" para restaurarla.

5. **Ejecutar el Programa:**
   - Si encuentra errores de permisos, cierre el programa y ejecúte como administrador.
   - Si aparece una ventana solicitando la instalación de Microsoft .NET, siga el enlace proporcionado para completar la instalación.

6. **Usuarios de Acceso Inicial:**

   - **Administrador:**
     - Usuario: `iguazu2024`
     - Contraseña: `123`

   - **Empleado:**
     - Usuario: `iguazu2023`
     - Contraseña: `123`

---

## Solución de Problemas Comunes

1. **Problemas con la Creación o Restauración de la Base de Datos:**
   - Reinicie el servicio "SISAGENCIA" desde el programa "Servicios" (tecla `Win + R`, escriba `services.msc`).
   - Busque "SQL Server (SISAGENCIA)", haga clic en "Reiniciar el servicio" y espere a que se complete.

2. **Errores de Permisos:**
   - Configure el acceso directo del programa para que siempre se ejecute como administrador:
     - Haga clic derecho en el acceso directo y seleccione "Propiedades".
     - En "Opciones avanzadas", marque "Ejecutar como administrador" y guarde los cambios.

3. **Error "Could not find stored procedure":**
   - Configure el servicio de SQL para iniciar sesión como "Cuenta del sistema local" y permita que interactúe con el escritorio.
   - Reinicie el servicio "SISAGENCIA" después de realizar estos cambios.

4. **Errores Persistentes:**
   - Ejecute nuevamente el instalador y siga los pasos indicados, restaurando la base de datos al finalizar.
   - Asegúrese de ejecutar el programa como administrador.

---

