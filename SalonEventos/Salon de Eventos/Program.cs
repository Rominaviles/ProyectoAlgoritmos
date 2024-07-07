﻿/*
 * Creado por SharpDevelop.
 * Usuario: romin
 * Fecha: 1/10/2023
 * Hora: 12:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Proyecto2023
{
	class Program
	{
		public static void Main(string[] args)
		{
			SalonFiesta salonfiesta = new SalonFiesta("MELODY");
			
			bool salir= false;
			while (!salir){
				Console.Clear();
				Console.WriteLine("-------------------------------------");
				Console.ForegroundColor=ConsoleColor.DarkCyan;
				Console.WriteLine("       BIENVENIDO A "+ salonfiesta.Nombre +"     ");
				Console.ResetColor();
				Console.WriteLine("-------------------------------------");
				Console.ForegroundColor=ConsoleColor.Cyan;
				Console.WriteLine("Seleccione una opción: ");
				Console.WriteLine("1) Agregar un servicio");
				Console.WriteLine("2) Eliminar un Servicio");
				Console.WriteLine("3) Dar de alta un empleado/encargado");
				Console.WriteLine("4) Dar de baja un empleado/encargado");
				Console.WriteLine("5) Reservar el salon para un evento");
				Console.WriteLine("6) Cancelar un evento");
				Console.WriteLine("7) Listados");
				Console.WriteLine("0) Salir");
				Console.ResetColor();
				Console.WriteLine("-------------------------------------");
				
				Console.ForegroundColor=ConsoleColor.DarkGray;
				string opcion= Console.ReadLine();
				Console.ResetColor();
			
				
				switch(opcion){
						
					case "1":
						AgregarServicio(salonfiesta);
						break;
					case "2":
						EliminarServicio(salonfiesta);
						break;
					case "3":
						AltaEmpleadoEncargado(salonfiesta);
						break;
					case "4":
						BajaEmpleadoEncargado(salonfiesta);
						break;
					case"5":
						ReservaEvento(salonfiesta);
						break;
					case "6":
						EliminarEvento(salonfiesta);
						break;
					case "7":
						ListadoGeneral(salonfiesta);
						break;
					case"0":
						salir=true;
						break;
					default:
						Console.ForegroundColor=ConsoleColor.DarkRed;
						Console.WriteLine("Opción invalida, intente nuevamente por favor");
						Console.ResetColor();
						Console.ReadKey(true);
						break;
				}
			}
			
		}
		//Metodo de Agregar un Servicio.
		public static void AgregarServicio (SalonFiesta salonfiesta){
			try{
				Console.ForegroundColor=ConsoleColor.DarkGray;
				Console.WriteLine("=== Agregar un Servicio ===");
				Console.ResetColor();
				
				Console.WriteLine("Ingrese el tipo de evento al que desea agregar el servicio");
				Console.ForegroundColor=ConsoleColor.DarkGray;
				string tipopedido=Console.ReadLine().ToLower();
				Console.ResetColor();
				
				Console.WriteLine("Ingrese el nombre del cliente del evento: ");
				Console.ForegroundColor=ConsoleColor.DarkGray;
				string clienteservicio=Console.ReadLine().ToLower();
				Console.ResetColor();
				
				Evento eventoActual=null;
				foreach (Evento tipoevento in salonfiesta.ListaEventos) {
					if(tipoevento.Tipoevento==tipopedido && tipoevento.Nomcliente==clienteservicio){
						eventoActual= tipoevento;
						break;
					}
				}
				
				if(eventoActual!=null){
					bool sigue=true;
					while(sigue){
						Console.WriteLine("Ingrese el nombre del servicio: ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						string nombreServicio=Console.ReadLine().ToLower();
						Console.ResetColor();
						
						Console.WriteLine("Ingrese el tipo de servicio: ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						string tiposervicio=Console.ReadLine().ToLower();
						Console.ResetColor();
						
						Console.WriteLine("Ingrese la descripción del mismo: ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						string descripcion=Console.ReadLine().ToLower();
						Console.ResetColor();
						

						Console.WriteLine("Ingrese la cantidad de servicios que requiere: ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						int cantidad=int.Parse(Console.ReadLine());
						Console.ResetColor();
						
						Console.WriteLine("Ingrese el precio de cada unidad: ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						float precioservicio=float.Parse(Console.ReadLine());
						Console.ResetColor();
						
						float costofinal2= precioservicio*cantidad;
						
						Servicio servicio=new Servicio(nombreServicio,tiposervicio,descripcion,cantidad,costofinal2);
						eventoActual.AgregarUnServicio(servicio);
						Console.ForegroundColor=ConsoleColor.Green;
						Console.WriteLine("Servicio agregado con exito");
						Console.ResetColor();
					
						Console.WriteLine();
						Console.WriteLine("Desea agregar otro servicio al evento? ('si'/'no'): ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						string respuest=Console.ReadLine().ToLower();
						Console.ResetColor();
						
						if (respuest=="si"){
							sigue=true;
						}
						else if (respuest=="no"){
							sigue=false;
						}
						else{
							Console.ForegroundColor=ConsoleColor.DarkRed;
							Console.WriteLine("Datos invalidos, vuelva a intentarlo nuevamente.");
							Console.ReadKey(true);
							Console.ResetColor();
							break;
						}
					}
				}
				else{
					Console.ForegroundColor=ConsoleColor.DarkRed;
					Console.WriteLine("No se encontraron registros de los datos dados para agregar un servicio.");
					Console.ResetColor();
					Console.ReadKey(true);
				}
			}
			catch(FormatException){
				Console.ForegroundColor=ConsoleColor.DarkRed;
				Console.WriteLine("Datos invalidos, por favor intente nuevamente");
				Console.ResetColor();
				Console.ReadKey(true);
			}
		}
			
		//Metodo de Eliminar un Servicio.
		public static void EliminarServicio(SalonFiesta salonfiesta){
			Console.ForegroundColor=ConsoleColor.DarkGray;
			Console.WriteLine("===Eliminacion de un Servicio===");
			Console.ResetColor();
			
			Console.WriteLine("Ingrese el tipo de evento del servicio que desea eliminar: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string tipopedido=Console.ReadLine().ToLower();
			Console.ResetColor();
			
			Console.WriteLine("Ingrese el nombre del cliente: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string clienteservicio=Console.ReadLine().ToLower();
			Console.ResetColor();
			
			Evento eventoActual=null;
			foreach (Evento tipoevento in salonfiesta.ListaEventos) {
				if(tipoevento.Tipoevento==tipopedido&&tipoevento.Nomcliente==clienteservicio){
					eventoActual= tipoevento;
					break;
				}
			}
			
			if(eventoActual!=null){
				Console.WriteLine("Ingrese el nombre del servicio a eliminar: ");
				Console.ForegroundColor=ConsoleColor.DarkGray;
				string nombreserviciou=Console.ReadLine().ToLower();
				Console.ResetColor();
				
				Servicio servicioeliminado=null;
				
				foreach (Servicio serviciou in eventoActual.ListaServicios) {
					if(serviciou.Nomservicio==nombreserviciou){
						servicioeliminado=serviciou;
						break;}
				}
				
				if(servicioeliminado!=null){
					
					eventoActual.EliminarUnServicio(servicioeliminado);
					
					Console.ForegroundColor=ConsoleColor.Green;
					Console.WriteLine("El servicio fue eliminado con exito");
					Console.ResetColor();
					Console.ReadKey(true);
				}
				
				
				else{
					Console.ForegroundColor=ConsoleColor.DarkRed;
					Console.WriteLine("El servicio pedido no fue encontrado, verifique los datos");
					Console.ResetColor();
					Console.ReadKey(true);
				}
			}
			else{
				Console.ForegroundColor=ConsoleColor.DarkRed;
				Console.WriteLine("No se registraron eventos con esos datos. Intente nuevamente");
				Console.ResetColor();
				Console.ReadKey(true);
			}
		}
		
		//Metodo de dar de alta un empleado.
		public static void AltaEmpleadoEncargado(SalonFiesta salonfiesta){
			Console.ForegroundColor=ConsoleColor.DarkCyan;
			Console.WriteLine("=== Agregar Empleado o Encargado ===");
			Console.ResetColor();
			
			Console.WriteLine("Ingrese nombre: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string nomsujeto=Console.ReadLine().ToLower();
			Console.ResetColor();
			
			Console.WriteLine("Ingrese el apellido: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string apelsujeto=Console.ReadLine().ToLower();
			Console.ResetColor();
			
			Console.WriteLine("Ingrese la tarea: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string tareasujeto=Console.ReadLine().ToLower();
			Console.ResetColor();
			
			Console.WriteLine("Ingrese el DNI: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string DNIVerify=(Console.ReadLine());
			Console.ResetColor();
			int DNI;
			while(true){
				if (int.TryParse(DNIVerify, out DNI)){
					break;
		
					}else{Console.ForegroundColor= ConsoleColor.DarkRed;
					Console.WriteLine("Dato incorrecto, ingrese el DNI nuevamente:");
					Console.ResetColor();
					Console.ForegroundColor=ConsoleColor.DarkGray;
					DNIVerify=Console.ReadLine();
					Console.ResetColor();
				}
			}
			
			Console.WriteLine("Ingrese el legajo: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string legajoverify=Console.ReadLine();
			Console.ResetColor();
			int legajosujeto;
			while(true){
				if (int.TryParse(legajoverify, out legajosujeto)){
				    	break;
				    }else {Console.ForegroundColor= ConsoleColor.DarkRed;
					Console.WriteLine("Dato incorrecto, ingrese el legajo nuevamente: ");
					Console.ResetColor();
					Console.ForegroundColor=ConsoleColor.DarkGray;
					legajoverify=Console.ReadLine();
					Console.ResetColor();
				    }
			}
			
			Console.WriteLine("Ingrese el sueldo: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string sueldoverify= Console.ReadLine();
			Console.ResetColor();
			float sueldosujeto;
			while(true){
				if (float.TryParse(sueldoverify, out sueldosujeto)){
				    	break;
				    }else{Console.ForegroundColor= ConsoleColor.DarkRed;
						Console.WriteLine("Dato incorrecto, ingrese el sueldo nuevamente: ");
						Console.ResetColor();
						Console.ForegroundColor=ConsoleColor.DarkGray;
				    	sueldoverify=Console.ReadLine();
				    	Console.ResetColor();
				    }
			}
			
			Console.WriteLine("Los datos brindados son de un encargado?");
			Console.WriteLine("Ponga 'S' si es si, ponga 'N' si es no.");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string respuesta=Console.ReadLine().ToLower();
			Console.ResetColor();
			
			if (respuesta=="s"){
				Console.WriteLine("Ingrese el plus del encargado: ");
				Console.ForegroundColor=ConsoleColor.DarkGray;
				string plusencargadoverify=Console.ReadLine();
				Console.ResetColor();
				float plusencargado;
				while(true){
					if(float.TryParse(plusencargadoverify, out plusencargado)){
						break;
					}else{Console.ForegroundColor=ConsoleColor.DarkRed;
						Console.WriteLine("Dato incorrecto, ingrese el plus del encargado nuevamente: ");
						Console.ResetColor();
						Console.ForegroundColor=ConsoleColor.DarkGray;
						plusencargadoverify=Console.ReadLine();
						Console.ResetColor();
					}
				}
			
				Encargado encargado= new Encargado(nomsujeto,apelsujeto,tareasujeto, DNI,legajosujeto,sueldosujeto,plusencargado);
				salonfiesta.AgregarUnEncargado(encargado);
				
				Console.ForegroundColor=ConsoleColor.Green;
				Console.WriteLine("El encargado ha sido agregado exitosamente.");
				Console.ResetColor();
				Console.ReadKey(true);
				return;
			}
			if (respuesta=="n"){
				Empleado empleado= new Empleado(nomsujeto,apelsujeto,tareasujeto,DNI,legajosujeto,sueldosujeto);
				salonfiesta.AgregarUnEmpleado(empleado);
					
				Console.ForegroundColor=ConsoleColor.Green;
				Console.WriteLine("El empleado ha sido agregado exitosamente.");
				Console.ResetColor();
				Console.WriteLine("Pulse cualuier tecla para continuar");
				Console.ReadKey(true);
				return;
			}
			else{ 
				Console.ForegroundColor= ConsoleColor.DarkRed;
				Console.WriteLine("Hubo un error en su respuesta, vuelva a poner los datos siguiendo las indicaciones por favor.");
				Console.ResetColor();
				Console.WriteLine("Pulse cualquier tecla para continuar");
				Console.ReadKey(true);
			}
			
		}
		
		//Metodo de dar de baja un empleado.
		public static void BajaEmpleadoEncargado(SalonFiesta salonfiesta){
			Console.ForegroundColor=ConsoleColor.DarkCyan;
			Console.WriteLine("===Dar de baja un Empleado/Encargado===");
			Console.ResetColor();
			
			Console.WriteLine("Ingrese el nombre del cual va a dar de baja: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string nombresujeto= Console.ReadLine().ToLower();
			Console.ResetColor();
		
			Console.WriteLine("¿El nombre proporcionado es de un un empleado o un encargado? Ingrese unicamente el cargo del sujeto: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string cargosujeto= Console.ReadLine().ToLower();
			Console.ResetColor();
			
			while(cargosujeto!="empleado" && cargosujeto!="encargado"){
				Console.WriteLine("Respuesta no valida, por favor ingrese unicamente si es 'empleado' o 'encargado': ");
				Console.ForegroundColor=ConsoleColor.DarkGray;
				cargosujeto=Console.ReadLine().ToLower();
				Console.ResetColor();
			}
				
			if (cargosujeto=="empleado"){
				Empleado empleadoencontrado=null;
				foreach (Empleado empleado in salonfiesta.ListaEmpleados) {
					if (empleado.Nombre==nombresujeto){
						empleadoencontrado=empleado;
						break;
					}
				}
				if (empleadoencontrado!=null){
					salonfiesta.EliminarUnEmpleado(empleadoencontrado);
					Console.ForegroundColor=ConsoleColor.Green;
					Console.WriteLine("El empleado fue dado de baja exitosamente.");
					Console.ResetColor();
					Console.ReadKey(true);
				}else {
					Console.ForegroundColor=ConsoleColor.DarkRed;
					Console.WriteLine("No se pudo hallar dicho empleado, por favor verifique los datos nuevamente.");
					Console.ResetColor();
					Console.ReadKey(true);
				}
			}
				
			else if (cargosujeto=="encargado"){
				Encargado encargadoencontrado=null;
				foreach (Encargado encargado in salonfiesta.ListaEncargados) {
					if (encargado.Nombre==nombresujeto){
						encargadoencontrado=encargado;
						break;
					}
				}
				if(encargadoencontrado!=null){
					salonfiesta.EliminarUnEncargado(encargadoencontrado);
					Console.ForegroundColor=ConsoleColor.Green;
					Console.WriteLine("El encargado fue dado de baja exitosamente.");
					Console.ResetColor();
					Console.ReadKey(true);
				}else{
					Console.ForegroundColor=ConsoleColor.DarkRed;
					Console.WriteLine("No se pudo halla dicho encargado, por favor verifique los datos nuevamente");
					Console.ResetColor();
					Console.ReadKey(true);
				}
			}
					
		}
		
		//Metodo auxiliar
		public static int DisponibilidadFecha(SalonFiesta salonfiesta, DateTime fecha){
			int cont=0;
			foreach (Evento evento in salonfiesta.ListaEventos){
				if (evento.Fechahora == fecha){
					cont++;
					break;
				}
			}
			return cont;
		}
		
		//Metodo de agregar un evento.
		public static void ReservaEvento(SalonFiesta salonfiesta){
			Console.ForegroundColor=ConsoleColor.DarkCyan;
			Console.WriteLine("===Reservar Evento===");
			Console.ResetColor();
			
			DateTime fechahora=DateTime.Now;
			
			try{

        		Console.WriteLine("Ingrese el año del evento: ");
        		Console.ForegroundColor=ConsoleColor.DarkGray;
      		  	int añoevento=int.Parse(Console.ReadLine());
      		  	Console.ResetColor();

        		Console.WriteLine("Ingrese el mes del evento: ");
        		Console.ForegroundColor=ConsoleColor.DarkGray;
        		int mesevento=int.Parse(Console.ReadLine());
        		Console.ResetColor();
        		
        		Console.WriteLine("Ingrese el día del evento: ");
        		Console.ForegroundColor=ConsoleColor.DarkGray;
        		int diaevento=int.Parse(Console.ReadLine());
        		Console.ResetColor();
        		
        		Console.WriteLine("Ingrese la hora del evento (0-23): ");
        		Console.ForegroundColor=ConsoleColor.DarkGray;
        		int horaevento=int.Parse(Console.ReadLine());
        		Console.ResetColor();

        		Console.WriteLine("Ingrese los minutos del evento (0-59): ");
        		Console.ForegroundColor=ConsoleColor.DarkGray;
        		int minutosevento=int.Parse(Console.ReadLine());
        		Console.ResetColor();

        		Console.WriteLine("Ingrese los segundos del evento (0-59): ");
        		Console.ForegroundColor=ConsoleColor.DarkGray;
        		int segundosevento=int.Parse(Console.ReadLine());
        		Console.ResetColor();
        		

        		fechahora = new DateTime(añoevento, mesevento, diaevento, horaevento, minutosevento, segundosevento);
        		
        		string nombrecliente="";
        		string tipoevento="";
        		int DNI=0;
        		float costototalevento=0;

        		if (fechahora >= DateTime.Now){
        			try{
        				if(DisponibilidadFecha(salonfiesta,fechahora)==1){
        					throw new DosfechasException();
        				}
        				
        				Console.WriteLine("Ingrese el nombre del cliente: ");
        				Console.ForegroundColor=ConsoleColor.DarkGray;
        				nombrecliente=Console.ReadLine().ToLower();
        				Console.ResetColor();
        				
        				Console.WriteLine("Ingrese el DNI del cliente: ");
        				Console.ForegroundColor=ConsoleColor.DarkGray;
        				string dniverify=Console.ReadLine();
        				Console.ResetColor();
        				while(true){
        					if(int.TryParse(dniverify, out DNI)){
        						break;
        					}else{
        						Console.ForegroundColor=ConsoleColor.DarkRed;
        						Console.WriteLine("Dato incorrecto, ingrese nuevamente el DNI: ");
        						Console.ResetColor();
        						Console.ForegroundColor=ConsoleColor.DarkGray;
        						dniverify=Console.ReadLine();
        						Console.ResetColor();
        					}
        				}
        				
        				Console.WriteLine("Ingrese el tipo de evento que desea reservar: ");
        				Console.ForegroundColor=ConsoleColor.DarkGray;
        				tipoevento=Console.ReadLine().ToLower();
        				Console.ResetColor();
        				
        				Console.WriteLine("Ingrese el costo total del evento: ");
        				Console.ForegroundColor=ConsoleColor.DarkGray;
        				string costotaleventoverify=Console.ReadLine();
        				Console.ResetColor();
        				while(true){
        					if (float.TryParse(costotaleventoverify, out costototalevento)){
        						break;
        					}else {
        						Console.ForegroundColor=ConsoleColor.DarkRed;
        						Console.WriteLine("Dato incorrecto, Ingrese nuevamente el costo total: ");
        						Console.ForegroundColor=ConsoleColor.DarkGray;
        						costotaleventoverify=Console.ReadLine();
        						Console.ResetColor();
        					}
        				}
        				
        				Console.WriteLine("Por ultimo, le pedimos agregar el nombre del encargado: ");
        				Console.ForegroundColor=ConsoleColor.DarkGray;
        				string encargado=Console.ReadLine().ToLower();
        				Console.ResetColor();
        				
        				Encargado encargadodisponible=null;
        				foreach(Encargado encargadoevento in salonfiesta.ListaEncargados){
        					if(encargadoevento.Nombre==encargado){
        						encargadodisponible=encargadoevento;
        						break;
        					}
        				}
        				if (encargadodisponible!=null){
        					Evento evento=new Evento(nombrecliente,tipoevento,encargado,DNI,fechahora, costototalevento);
        					salonfiesta.AgregarUnEvento(evento);
        					Console.ForegroundColor=ConsoleColor.Green;;
        					Console.WriteLine("El evento del cliente {0} ha sido registrado con exito junto con el/la encargado {1}",nombrecliente, encargado);
        					Console.ResetColor();
        					Console.ReadKey(true);
        				}else{
        					Console.ForegroundColor=ConsoleColor.DarkRed;
        					Console.WriteLine("Primero debe registrar el encargado.Intentelo nuevamente despues.");
        					Console.ResetColor();
        					Console.ReadKey(true);
        				}
        			}
        			catch(DosfechasException){
        				Console.ForegroundColor=ConsoleColor.DarkRed;
        				Console.WriteLine("La fecha no esta disponible ya que fue reservada previamente.");
        				Console.ResetColor();
        				Console.ReadKey(true);
        			}
        		}
        		else
        		{
        			Console.ForegroundColor=ConsoleColor.DarkRed;
        			Console.WriteLine("Error: La fecha y hora del evento debe ser posterior a la fecha y hora actual.");
        			Console.ResetColor();
        			Console.ReadKey(true);
        		}
			}
			catch(ArgumentOutOfRangeException){
				Console.ForegroundColor=ConsoleColor.DarkRed;
				Console.WriteLine("Por favor, verifique bien el ingreso de la fecha.");
				Console.ResetColor();
				Console.ReadKey(true);
			}
		}
		
		//Metodo de eliminar un evento. 
		public static void EliminarEvento(SalonFiesta salonfiesta){
			Console.ForegroundColor=ConsoleColor.DarkCyan;
			Console.WriteLine("===Elimina Evento===");
			Console.ResetColor();
			
			Console.WriteLine("Ingrese el tipo del evento que desea dar de baja: ");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string tipoevento= Console.ReadLine().ToLower();
			Console.ResetColor();
			
			Console.WriteLine("Ingrese el nombre del cliente que reservo el evento");
			Console.ForegroundColor=ConsoleColor.DarkGray;
			string nombreclientebaja=Console.ReadLine().ToLower();
			Console.ResetColor();
			
			Evento eventoaeliminar=null;
			
			foreach(Evento eventonombre in salonfiesta.ListaEventos){
				if(eventonombre.Nomcliente==nombreclientebaja && eventonombre.Tipoevento==tipoevento){
					eventoaeliminar=eventonombre;
					break;
				}
			}
			
			if(eventoaeliminar!=null){
				DateTime fechaactual=DateTime.Now;
				DateTime fechaevento;
				
				Console.WriteLine("Ingrese la fecha del evento a eliminar(YYYY/MM/DD): ");
				Console.ForegroundColor=ConsoleColor.DarkGray;
				string fechaeventoverify=Console.ReadLine();
				Console.ResetColor();
				
				if(DateTime.TryParse(fechaeventoverify,out fechaevento)){
					int mesdiferencia=((fechaevento.Year-fechaactual.Year)*12)+fechaevento.Month-fechaactual.Month;
					if(mesdiferencia<1){
						Console.WriteLine("Si desea cancelar el evento, debera abonar el servicio completo");
						Console.WriteLine("¿Desea cancelar el evento? Responda 'si'/'no': ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						string respuestacancelacion=Console.ReadLine().ToLower();
						Console.ResetColor();
						
						if(respuestacancelacion=="si"){
							salonfiesta.EliminarUnEvento(eventoaeliminar);
							Console.ForegroundColor=ConsoleColor.Green;
							Console.WriteLine("El evento se ha eliminado satisfactoriamente");
							Console.ReadKey(true);
							Console.ResetColor();
						}
						
						else if(respuestacancelacion=="no"){
							Console.WriteLine("El evento sigue en curso");
							Console.ReadKey(true);
						}
						else{
							Console.ForegroundColor=ConsoleColor.DarkRed;
							Console.WriteLine("Error al escribir la respuesta. Ingrese nuevamente respentando las opciones");
							Console.ReadKey(true);
							Console.ResetColor();
						}
						
					}else {
						Console.WriteLine("Si desea cancelar el evento no se le reintregara la seña del mismo. ¿Desea cancelarlo? 'si'/'no': ");
						Console.ForegroundColor=ConsoleColor.DarkGray;
						string respuestacancel=Console.ReadLine().ToLower();
						Console.ResetColor();
						
						if (respuestacancel=="si"){
							salonfiesta.EliminarUnEvento(eventoaeliminar);
							Console.ForegroundColor=ConsoleColor.Green;
							Console.WriteLine("El evento se cancelo satisfactoriamente");
							Console.ReadKey(true);
							Console.ResetColor();
						}
						
						else if(respuestacancel=="no"){
							Console.WriteLine("El evento sigue en curso");
							Console.ReadKey(true);
						}
						else{
							Console.ForegroundColor=ConsoleColor.DarkRed;
							Console.WriteLine("Error al escribir la respuesta.Ingrese nuevamente respetando las opciones");
							Console.ReadKey(true);
							Console.ResetColor();
						}
						
					}
				}else{
					Console.ForegroundColor=ConsoleColor.DarkRed;
					Console.WriteLine("Formato no aceptado, ingrese nuevamente respetandolo");
					Console.ReadKey(true);
					Console.ResetColor();
				}
				
			}
			else{
				Console.ForegroundColor=ConsoleColor.DarkRed;
				Console.WriteLine("No se encontraron eventos con los datos brindados");
				Console.ReadKey(true);
				Console.ResetColor();
			}

		}
		
		//Metodo Lista General.
		public static void ListadoGeneral(SalonFiesta salonfiesta){
			Console.ForegroundColor=ConsoleColor.DarkCyan;
			Console.WriteLine("===Listas Generales===");
			Console.ResetColor();
			
			bool exit=false;
			while(!exit){
				Console.Clear();
				Console.WriteLine("-------------------------------------");
				Console.ForegroundColor=ConsoleColor.DarkCyan;
				Console.WriteLine("       BIENVENIDO A "+salonfiesta.Nombre+"        ");
				Console.ResetColor();
				Console.WriteLine("-------------------------------------");
				Console.ForegroundColor=ConsoleColor.Cyan;
				Console.WriteLine("Ingrese la opción que desea: ");
				Console.WriteLine("1)Listado de eventos");
				Console.WriteLine("2)Listado de clientes");
				Console.WriteLine("3)Listado de empleados");
				Console.WriteLine("4)Listado de eventos de un mes");
				Console.WriteLine("0)Volver al menu principal");
				Console.ResetColor();
				Console.WriteLine("-------------------------------------");
				
				Console.ForegroundColor=ConsoleColor.DarkGray;
				string eleccion=Console.ReadLine();
				Console.ResetColor();
				
				
				switch(eleccion){
					case "1":
						
						if (salonfiesta.CantidadEvento()==0){
							Console.WriteLine("No hay eventos para mostrar");
						}
						
						else {
							Console.WriteLine("La lista de eventos agendados se muestran a continuacion: ");
							Console.WriteLine();
							foreach (Evento evento in salonfiesta.ListaEventos) {
								Console.ForegroundColor=ConsoleColor.DarkGray;
								Console.WriteLine("El tipo de evento: {0}",evento.Tipoevento);
								Console.WriteLine("El encargado del evento es: {0}",evento.Encargado);
								Console.WriteLine("La fecha es: {0}", evento.Fechahora.ToLongTimeString());
								Console.WriteLine("El costo total del evento es: {0}", evento.Costotale);
								Console.ResetColor();
								Console.WriteLine();
							}
						}
						Console.ReadKey(true);
						
						break;
					
					case "2":
						
						if(salonfiesta.CantidadEvento()==0){
							Console.WriteLine("No hay clientes para mostrar");
						}
						else {
							Console.WriteLine("La lista de clientes se muestra a continuacion: ");
							Console.WriteLine();
							
							HashSet<int> ClienteUnico= new HashSet<int>();
							
							foreach(Evento evento in salonfiesta.ListaEventos){
								
								if(ClienteUnico.Add(evento.DNIcliente)){
									Console.WriteLine("Nombre: {0}",evento.Nomcliente);
									Console.WriteLine("DNI: {0}",evento.DNIcliente);
									Console.ResetColor();
									Console.WriteLine();
								}
							}
						}
						Console.ReadKey(true);
						break;
					
					case "3":
						
						if(salonfiesta.CantidadEncargado()==0){
							Console.WriteLine("No existen encargados aun");}
						else{
							Console.WriteLine("La lista de encargados con sus respectivos datos se muestra a continuacion: ");
							Console.WriteLine();
							foreach (Encargado encargado in salonfiesta.ListaEncargados) {
								Console.ForegroundColor=ConsoleColor.DarkGray;
								Console.WriteLine("Nombre: {0}",encargado.Nombre);
								Console.WriteLine("Apellido: {0}",encargado.Apellido);
								Console.WriteLine("Tarea que desempeña: {0}",encargado.Tarea);
								Console.WriteLine("DNI: {0}",encargado.DNI);
								Console.WriteLine("Numero de Legajo: {0}",encargado.NumLegajo);
								Console.WriteLine("Sueldo: {0}",encargado.Sueldo);
								Console.WriteLine("Plus sueldo: {0}",encargado.PlusEncargado);
								Console.WriteLine();
								Console.ResetColor();
							}
						}
						if(salonfiesta.CantidadEmpleados()==0){
							Console.WriteLine("No existen empleados aun");
						}
						else {
							Console.WriteLine("La lista de empleados con sus respectivos datos se muestra a continuacion: ");
							Console.WriteLine();
							foreach (Empleado empleado in salonfiesta.ListaEmpleados) {
								Console.ForegroundColor=ConsoleColor.DarkGray;
								Console.WriteLine("Nombre: {0}",empleado.Nombre);
								Console.WriteLine("Apellido: {0}",empleado.Apellido);
								Console.WriteLine("Tarea que desempeña: {0}",empleado.Tarea);
								Console.WriteLine("DNI: {0}",empleado.DNI);
								Console.WriteLine("Numero de Legajo: {0}",empleado.NumLegajo);
								Console.WriteLine("Sueldo: {0}",empleado.Sueldo);
								Console.WriteLine();
								Console.ResetColor();
							}
						
						}
						Console.ReadKey(true);
						break;
						
					case "4":
						if(salonfiesta.CantidadEvento()==0){
							Console.WriteLine("Aun no se cargaron eventos");
							Console.ReadKey(true);
						}
						else {
							try{
								Console.WriteLine("Ingrese el numero del mes de los eventos que quiere ver: ");
								Console.ForegroundColor=ConsoleColor.DarkGray;
								int mes=int.Parse(Console.ReadLine());
								Console.ResetColor();
								
								while(mes<=0 || mes>=13){
									Console.ForegroundColor=ConsoleColor.DarkRed;
									Console.WriteLine("Error, ingrese nuevamente el numero del mes deseado del 1 al 12: ");
									Console.ResetColor();
									Console.ForegroundColor=ConsoleColor.DarkGray;
									mes=int.Parse(Console.ReadLine());
									Console.ResetColor();
								}
								
								foreach(Evento evento in salonfiesta.ListaEventos){
									if (evento.Fechahora.Month == mes){
										Console.WriteLine("La lista del mes pedido se muestra a continuacion: ");
										Console.ForegroundColor=ConsoleColor.DarkGray;
										Console.WriteLine("El tipo de eventos es: {0}",evento.Tipoevento);
										Console.WriteLine("El nombre del cliente es: {0}",evento.Nomcliente);
										Console.WriteLine("El DNI del cliente es: {0}", evento.DNIcliente);
										Console.WriteLine("La fecha del evento es: {0}",evento.Fechahora.ToLongDateString());
										Console.WriteLine("La hora del evento es: {0}",evento.Fechahora.ToShortTimeString());
										Console.WriteLine("El encargado es: {0}",evento.Encargado);
										Console.WriteLine("El costo total es: {0}",evento.Costotale);
										Console.WriteLine();
										Console.ResetColor();
										Console.WriteLine("Pulse cualquier tecla para seguir viendo el listado o terminar");
										Console.ReadKey(true);
									}
								else{
									Console.ForegroundColor=ConsoleColor.DarkRed;
									Console.WriteLine("No se hallaron eventos en el mes indicado");
									Console.ReadKey(true);
									Console.ResetColor();
								}
							}
							}
							catch(FormatException){
								Console.ForegroundColor=ConsoleColor.DarkRed;
								Console.WriteLine("Por favor, respete el formato e ingrese nuevamente");
								Console.ResetColor();
								Console.ReadKey(true);
							}
						}
					
						break;
					case "0":
						exit=true;
						break;
					default:
						Console.ForegroundColor= ConsoleColor.DarkRed;
						Console.WriteLine("Opcion invalida, intente nuevamente por favor.");
						Console.ResetColor();
						Console.ReadKey(true);
						break;
						
				}
			}
			                  
		}
	}

}	