/*
 * Creado por SharpDevelop.
 * Usuario: romin
 * Fecha: 1/10/2023
 * Hora: 12:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto2023
{
	/// <summary>
	/// Description of Servicios.
	/// </summary>
	public class Servicio
	{
		//Atributos
		private string nomservicio,tiposervicio,descripcion;
		private int cantidad;
		private float costofinals;
		
		//Constructores
		
		public Servicio(string nomservicio, string tiposervicio, string descripcion, int cantidad, float costofinals){
			this.nomservicio=nomservicio;
			this.tiposervicio=tiposervicio;
			this.descripcion=descripcion;
			this.cantidad=cantidad;
			this.costofinals=costofinals;
		}
		
		//Propiedades
		
		public string Nomservicio{
			set{nomservicio=value;}
			get{return nomservicio;}
		}
		public string Tiposervicio{
			set{tiposervicio=value;}
			get{return tiposervicio;}
		}
		public string Descripcion{
			set{descripcion=value;}
			get{return descripcion;}
		}
		public int Cantidad{
			set{cantidad=value;}
			get{return cantidad;}
		}
		public float Costofinals{
			set{costofinals=value;}
			get{return costofinals;}
		}
		
	}
}
