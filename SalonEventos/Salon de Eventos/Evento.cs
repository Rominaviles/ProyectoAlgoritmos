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
	/// Description of Eventos.
	/// </summary>
	public class Evento
	{
		//Atributos
		private string nomcliente, tipoevento, encargado;
		private int dnicliente;
		private DateTime fechahora;
		private float costototale;
		private ArrayList listaservicios;
		
		//Constructor
		public Evento(string nomcliente, string tipoevento, string encargado, int dnicliente, DateTime fechahora,float costototale){
			this.nomcliente=nomcliente;
			this.tipoevento=tipoevento;
			this.encargado=encargado;
			this.dnicliente=dnicliente;
			this.fechahora=fechahora;
			this.costototale=costototale;
			listaservicios= new ArrayList();
		}
		//Propiedades
		public string Nomcliente{
			set{nomcliente=value;}
			get{return nomcliente;}
		}
		public string Tipoevento{
			set{tipoevento=value;}
			get{return tipoevento;}
		}
		public string Encargado{
			set{encargado=value;}
			get{return encargado;}
		}
		public int DNIcliente{
			set{dnicliente=value;}
			get{return dnicliente;}
		}
		public DateTime Fechahora{
			set{fechahora=value;}
			get{return fechahora;}
		}
		public float Costotale{
			set{costototale=value;}
			get{return costototale;}
		}
		public ArrayList ListaServicios{
			get{return listaservicios;}
		}
		
		//Metodos Servicio
		
		public void AgregarUnServicio(Servicio x){
			listaservicios.Add(x);
		}
		public void EliminarUnServicio(Servicio x){
			listaservicios.Remove(x);
		}
		public bool ExisteServicio(string tiposervicio,string nomservicio){
			bool flag= false;
			foreach (Servicio servicio in listaservicios){
				if (servicio.Tiposervicio==tiposervicio && servicio.Nomservicio==nomservicio)
					{flag= true;
					return flag;}
			}
				return flag;
		}
		public int CantidaddeServicio(){
			return listaservicios.Count;
		}
		public ArrayList TodoslosServicios(){
			return listaservicios;
		}
		public Servicio verServicio(int x){
			return (Servicio)listaservicios[x];
		}
	}
}
