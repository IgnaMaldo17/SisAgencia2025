Sistema Conquista tu Mundo - Ignacio Leonel Maldonado 2024.

Links: 

www.linkedin.com/in/ignacio-leonel-maldonado-251b7b344
https://github.com/IgnaMaldo17



***** Lea este documento de texto antes de comenzar con la instalación del sistema "Conquista tu Mundo" o de cualquiera de sus requisitos.



*Requisitos:

Windows 10 o posterior.
Microsoft SQL Server 2022 o posterior (Se recomienda instalarla siguiendo los pasos en este texto).
Microsoft .NET SDK 8.0.100 o posterior.



*Instrucciones de instalación:

1) Al ejecutar el instalador como administrador, es posible que SmartScreen de MS Defender no deje continuar. En ese caso, desactivelo momentaneamente para proseguir con la instalación.

Para desactivar SmartScreen debe abrir "Seguridad de Windows", luego "Control de aplicaciones y explorador", posteriormente
haga click en "Configuración de Protección basada en reputación" y entonces desactive "Comprobar aplicaciones y archivos".

2) En caso de no tener SQL Server instalado, aparecerá una ventana para comenzar una instalación.

	Instrucciones de instalación de SQL (Importante):
	
	* Debido a que la aplicación está configurada en base a una llamada "SISAGENCIA" debe ponerse dicho nombre
	al instalar.
	
	a) Seleccione el botón "Personalizado" para comenzar la instalación.
	Es posible que le recomiende cambiar la instalación al idioma inglés, hágalo.
	
	b) Seleccione la ubicación de instalación para SQL Server.

	c) Se abrirá el panel "SQL Server Installation Center", marque la casilla de términos y condiciones y presione "Next".
	Es posible que salga una ventana diciendo que la base de datos "SisAgencia" no existe y que se creará una.
	No cierre el mensaje ni presione aceptar, prosiga con los siguientes pasos.
	
	d) Se recomienda desactivar "Windows Firewall" antes de proseguir. Una vez se complete la barra de carga,
	presione "Next".

	e) Se recomienda desmarcar la casilla "Azure Extension for SQL" ya que no será necesaria para ejecutar el programa.
	Luego, presione "Next" nuevamente.
	
	f) No se recomienda marcar o desmarcar casillas en "Features". Presione "Next".

	*g) Marque el botón "Named instance" y en el cuadro de texto escriba: "SISAGENCIA", en caso de que el cuadro de texto de "Instance ID" no se actualice automaticamente a "SISAGENCIA", hágalo manualmente.
	Este paso es obligatorio para que el programa funcione correctamente. Al finalizar, presione "Next".

	h) Se recomienda presionar "Next" nuevamente sin modificar nada en la sección "Server Configuration".

	i) En "Authentication Mode" mantenga marcado "Windows authentication mode". Prosiga al botón "Next".
	En este momento comenzará la instalación de SQL, la barra indica el progreso. Al terminar la carga, presione "Close" para finalizar la instalación.
	Puede cerrar la ventana de "SQL Server Installation Center". Ahora prosiga con la instalación del sistema.


* Se recomienda encarecidamente seguir el paso 3) de "Posibles errores en la instalación y ejecución temprana del programa" por completo en este momento, para evitar errores futuros.

3) Aparecerá una ventana diciendo que la base de datos "SisAgencia" no existe. Presione aceptar para que proceda a su creación.

4) Seleccione la carpeta de destino de la aplicación y presione siguiente. 

5) Se recomienda tildar la casilla "Crear un acceso directo en el escritorio". Luego, presione siguiente.

6) Finalmente, presione "Instalar". Al finalizar la barra de carga, aparecerá un mensaje diciendo que la base de datos "SisAgencia" ya existe y si desea restaurarla. Presione Sí.

7) Ya puede ejecutar el programa normalmente.
Si al ejecutar el programa sale un error de permisos, cierrelo y ejecutelo como administrador.
Si al ejecutar el programa sale una ventana que avise que se debe instalar Microsoft .NET, continúe a la página oficial para proceder con su instalación.

8) Para comenzar a usar el programa, le proporcionaré un usuario "Administrador" y un usuario "Empleado".

	Administrador:
		
		Usuario: iguazu2024
		Contraseña: 123
		
	Empleado:

		Usuario: iguazu2023
		Contraseña: 123


*Posibles errores en la instalación y ejecución temprana del programa:

1) En caso de tener problemas con la creación y/o restauración de la base de datos, debe reinciar el servicio de "SISAGENCIA".
	
	Instrucciones para reiniciar el servicio:

	a) Abra el programa "Servicios", también puede apretar las teclas Win + R, lo que abre "Ejecutar" y en el cuadro de texto escriba "services.msc".
	
	b) Ahora busque el servicio llamado "SQL Server (SISAGENCIA)". Para encontrarlo más rápido puede hacer un click a cualquier servicio y escribir rápidamente "SQL", entonces puede empezar buscando por los servicios que comiencen con "SQL".

	c) Al encontrarlo, presione dicho servicio y en el lado izquierdo de la ventana, aparecerán tres opciones: Detener el servicio, Pausar el servicio, Reiniciar el servicio.

	d) Presione "Reiniciar el servicio" y espere que la barra de carga se complete. 
	En caso de que aparezca un cuadro llamado "Reiniciar otros servicios", presione Sí.

2) Es posible que haya errores de permisos en caso de ejecutar tanto el programa como el instalador sin ser administrador.
	
	a) Para hacer más rápido el inicio de la aplicación, solo presione botón derecho en el acceso directo y en el cuadro que aparece, presione "Propiedades".
	
	b) Se abrirá la ventana de propiedades, estará seleccionada la solapa "Acceso directo", en la parte inferior de la ventana habrá un botón que dice "Opciones avanzadas...", presionelo.
	
	c) Aparecerá un cuadro que tiene una casilla que dice "Ejecutar como administrador", marque dicha casilla, presione "Aceptar" y en la ventana de propiedades presione "Aplicar".
	Si sale un recuadro diciendo que se debe proporcionar permisos, presione "Continuar" y luego "Aceptar".

3) Si sale el error "Could not find stored procedure", debe cambiar la configuración del servicio de SQL.
	
	Instrucciones para configurar el servicio de SQL:

	a) Abra el programa "Servicios", también puede apretar las teclas Win + R, lo que abre "Ejecutar" y en el cuadro de texto escriba "services.msc".
	
	b) Ahora busque el servicio llamado "SQL Server (SISAGENCIA)". Para encontrarlo más rápido puede hacer un click a cualquier servicio y escribir rápidamente "SQL", entonces puede empezar buscando por los servicios que comiencen con "SQL".

	c) Al encontrarlo, presione con el botón derecho del mouse dicho servicio. Aparecerá un recuadro con diversas opciones, haga click en la que dice "Propiedades".

	d) Se abrirá una ventana de propiedades, en la parte superior habrá 4 solapas, presione la que dice "Iniciar Sesión".

	e) El cuadro dirá "Iniciar sesión como:", debajo hay dos botones, seleccione el que dice "Cuenta del sistema local" y luego marque la casilla "Permitir que el servicio interactúe con el escritorio".

	f) Finalmente presione "Aplicar" y reincie el servicio. Si no sabe como reiniciarlo, se explica en el punto 1) de la lista de posibles errores.
	
4) En caso de que haya ocurrido uno de los anteriores errores, es posible que en la instalación no se haya restaurado correctamente la base de datos. En ese caso, una vez hecho los pasos anteriores, vuelva a ejecutar el instalador y proceda normalmente. Al aparecer el mensaje de restaurar la base, hágalo.
Es posible que al finalizar la instalación vuelva a saltar un error en cuanto a permisos, solo ejecute como administrador el acceso directo del programa "Sistema Conquista tu Mundo" como administrador y todos los errores deberían estar solucionados.
