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
	/// Description of Empleados.
	/// </summary>
	public class Empleado
	{
		//Atributos
		protected string nombre, apellido, tarea;
		protected int dni, numlegajo;
		protected float sueldo;
		
		
		
		//Constructor
		public Empleado(string nombre, string apellido, string tarea, int dni, int numlegajo, float sueldo){
			this.nombre= nombre;
			this.apellido= apellido;
			this.tarea=tarea;
			this.dni= dni;
			this.numlegajo=numlegajo;
			this.sueldo= sueldo;
			
		}
		
		//Propiedades
		public string Nombre{
			set {nombre = value;}
			get {return nombre;}
		}
		public string Apellido{
			set{apellido=value;}
			get{return apellido;}
		}
		public string Tarea{
			set{tarea=value;}
			get{return tarea;}
		}
		public int DNI{
			set{dni=value;}
			get{return dni;}
		}
		public int NumLegajo{
			set{numlegajo=value;}
			get{return numlegajo;}
		}
		public float Sueldo{
			set{sueldo=value;}
			get{return sueldo;}
		}
		
	}
	
}
