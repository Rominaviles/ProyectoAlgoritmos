/*
 * Creado por SharpDevelop.
 * Usuario: romin
 * Fecha: 1/10/2023
 * Hora: 13:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto2023
{
	/// <summary>
	/// Description of SalonFiesta.
	/// </summary>
	public class SalonFiesta
	{
		//Atributos
		private string nombre;
		private ArrayList listaeventos;
		private ArrayList listaempleados;
		private ArrayList listaencargados;
		
		
		//Constructores
		
		public SalonFiesta(string nombre){
			this.nombre= nombre;
			listaeventos= new ArrayList ();
			listaempleados= new ArrayList();
			listaencargados= new ArrayList();
		}
		
		//Propiedades
		
		public string Nombre{
			set{nombre=value;}
			get{return nombre;}
		}
		public ArrayList ListaEventos{
			get{return listaeventos;}
		}
		public ArrayList ListaEmpleados{
			get{return listaempleados;}
		}
		public ArrayList ListaEncargados{
			get {return listaencargados;}
		}
		

		
		//Metodos clase Empleados
		
		public void AgregarUnEmpleado(Empleado x){
			listaempleados.Add(x);
		}
		public void EliminarUnEmpleado(Empleado x){
			listaempleados.Remove(x);
		}
		public bool existeEmpleado(string nom){
			bool flag= false;
			foreach (Empleado empleado in listaempleados){
				if (empleado.Nombre==nom)
					{flag= true;
					return flag;}
			}
				return flag;
		}
		public int CantidadEmpleados(){
			return listaempleados.Count;
		}
		public ArrayList todoslosEmpleados(){
			return listaempleados;
		}
		public Empleado verEmpleados(int x){
			return(Empleado)listaempleados[x];
		}
		
		//Metodos clase Eventos
		
		public void AgregarUnEvento(Evento x){
			listaeventos.Add(x);
		}
		public void EliminarUnEvento(Evento x){
			listaeventos.Remove(x);
		}
		public bool ExisteEvento(string nomcliente, string tipoevento){
			bool flag= false;
			foreach (Evento evento in listaeventos){
				if (evento.Nomcliente==nomcliente && evento.Tipoevento==tipoevento)
					{flag= true;
					return flag;}
			}
				return flag;
		}
		public int CantidadEvento(){
			return listaeventos.Count;
		}
		public ArrayList todosLosEventos(){
			return listaeventos;
		}
		public Evento verEventos(int x){
			return(Evento)listaeventos[x];
		}
		
		
		//Metodos clase Encargados
		public void AgregarUnEncargado(Encargado x){
			listaencargados.Add(x);
		}
		public void EliminarUnEncargado(Encargado x){
			listaencargados.Remove(x);	
		}
		public bool ExisteEncargado(string nom){
			bool flag= false;
			foreach (Encargado encargado in listaencargados){
				if (encargado.Nombre==nom)
					{flag= true;
					return flag;}
			}
				return flag;
		}
		public int CantidadEncargado(){
			return listaencargados.Count;
		}
		public ArrayList TodosLosEncargados(){
			return listaencargados;
		}
		public Encargado VerEncargados(int x){
			return (Encargado)listaencargados[x];
		}
		
	}
}
