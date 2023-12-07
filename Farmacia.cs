using System;
using System.Collections;

namespace FarmaciaIntegrador
{
public class Farmacia
    {

     public ArrayList listaVentas { get; set; }
     public ArrayList listaEmpleados { get; set; }
		
     public int contadorFacturas { get; set; }

        

     public Farmacia()
        {

            listaVentas= new ArrayList();
            listaEmpleados= new ArrayList();
            contadorFacturas = 1;
            
        }

     public void agregarVenta(Venta venta){

            listaVentas.Add(venta);
            contadorFacturas+=1;

        }

     public void eliminarVenta(Venta venta){
            listaVentas.Remove(venta);
        }
        
     public bool hayVentas(){
            return listaVentas.Count>0;
        }

     public void EliminarEmpleado(Empleado empleado){
           listaEmpleados.Remove(empleado);
        }
		
     public void agregarEmpleado(Empleado empleado){
        	listaEmpleados.Add(empleado);
        }
       
      public int cantidadEmpleados(){
        	return listaEmpleados.Count;
        }
		
      public int cantidadVentas(){
        	return listaVentas.Count;
        }
		
      public bool hayEmpleados(){
            return listaVentas.Count>0;
            
        }
        
      public void imprimirEmpleados(){
       		foreach(Empleado empleado in listaEmpleados){
        		string nom=empleado.nombre;
        		string ape=empleado.apellido;
        		int dni=empleado.dni;
        		Console.WriteLine("Nombre:{0},Apellido:{1},DNI:{2}",nom,ape,dni);
        	}
        }
        
      public void imprimirVentas(){
        	foreach(Venta elem in listaVentas){
        		string nombre=elem.nombreMedicamento;
				string droga=elem.droga;
				string obra=elem.obraSocial;
				double importe=elem.importe;
				int codigo=elem.codigoVendedor;
				DateTime fecha=elem.fechaHoraVenta;
				int nro=elem.nroFactura;
        		Console.WriteLine("Nombre del Medicamento:{0}, Droga:{1},Obra Social:{2},Importe:{3},Codigo:{4},Fecha de venta:{5}, Numero de factura:{6}"+nombre,droga,obra,importe,codigo,fecha,nro);
        	}
    }
      public Object verEmpleado(int k){
          return listaEmpleados[k];
        }
        
      public Object verVenta(int k){
        	return listaVentas[k];
        }
     
     public ArrayList todosEmpleados(){
     	return listaEmpleados;
       
     }
     
     public ArrayList todasVentas(){
     	return listaVentas;
       
     }
     
  }
}