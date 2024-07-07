/*
 * Creado por SharpDevelop.
 * Usuario: romin
 * Fecha: 1/10/2023
 * Hora: 12:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto2023
{
	/// <summary>
	/// Description of Clientes.
	/// </summary>
	public class Clientes
	{
		//Atributos
		private string nombre;
		private int dni;
		
		//Constructores
		
		public Clientes(string nombre, int dni){
			this.nombre= nombre;
			this.dni= dni;
		
		}
		
		//Propiedades
		public string Nombre{
			set{nombre=value;}
			get{return nombre;}
		}
		public int DNI{
			set{dni=value;}
			get{return dni;}
		}
	}
}
