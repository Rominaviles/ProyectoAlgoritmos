/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 4/10/2023
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Proyecto2023
{
	/// <summary>
	/// Description of Encargados.
	/// </summary>
	public class Encargado : Empleado
	{
		//Atributos
		private float plusencargado;
		
		
		//Contructores
		public Encargado(string nombre, string apellido, string tarea, int dni, int numlegajo, float sueldo, float plusencargado): base (nombre,apellido,tarea,dni,numlegajo,sueldo){
			this.plusencargado=plusencargado;
		}
		
		//Propiedades
		public float PlusEncargado{
			set{plusencargado=value;}
			get{return plusencargado;}
			
		
		}
	}
}
