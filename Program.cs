using System.Security.AccessControl;
using System;
using System.Collections;


namespace FarmaciaIntegrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			//ArrayList ListaVenta = new ArrayList();
			//ArrayList ListaEmpleados = new ArrayList();

            Farmacia far = new Farmacia();
			
			int OpcionMenu = 0;
			
			do
			{
				
				
				Console.WriteLine("A que module desea ingresar? ");
				Console.WriteLine("1) Sistema de Control de Ventas\n" +
				                  "2) Sistema de Control de Personal\n" +
				                  "3) Salir del sistema\n");
				
				try
				{
                    
					OpcionMenu = int.Parse(Console.ReadLine());
                    
					if (OpcionMenu <=0 || OpcionMenu > 3)
					{
						throw new FormatException();
					}
				    }
				       catch(FormatException)
				    {
					       Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-3. Presione una tecla para continuar...");
					       OpcionMenu = 0;
					       Console.ReadKey();
					       Console.Clear();
				    }
				
				switch(OpcionMenu)
				     {
									//Parte del Codigo para Administrar la Venta.
						case 1:
						     int opcion1 = 0;
						     Console.Clear();
						
						     do
						         {
							        Console.WriteLine("1) Agregar Venta de Medicamento\n" +
				                                      "2) Eliminar Venta de Medicamento por Numero de tiket\n" +
				                                      "3) Porcentaje de ventas Primera Quincena por Obra Social\n" +
				                  			          "4) Listar medicamento que Contenga determinada Droga\n" +
				                  			          "5) Listar medicamento vendidos no repetidos\n" +
							                          "6) volver\n");
							
							try
							{
								opcion1 = int.Parse(Console.ReadLine());
								if (opcion1 <=0 || opcion1 > 6)
								   {
									throw new FormatException();
								   }
							       }
							        catch(FormatException)
							       {
								         Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-6. Presione una tecla para continuar...");
								         opcion1 = 0;
								         Console.ReadKey();
								         Console.Clear();
							       }
							
							
							       switch (opcion1)
							           {
									    //agregar venta.
								       case 1:
									        Console.Clear();
                                            AgregarVenta(far);
									        Console.Clear();
									        break;
									
									   //eliminar venta.
								       case 2:
									      Console.Clear();
									      EliminarVenta(far);
									      Console.Clear();
									      break;
									
									    //porcentaje de venta.
								       case 3:
									      Console.Clear();
									      porcentajeVenta(far);
									      Console.Clear();
									      break;
									       //listar venta.
								       case 4:
									       Console.Clear();
									       medicamentoConDroga(far);
									       Console.Clear();
									       break;
									        //listar venta no repetidas.
								       case 5:
									      Console.Clear();
									      medicamentoNoRepetido(far);
									      Console.Clear();
									      break;
							        }
							
						         }
						     while(opcion1 != 6);
						           Console.Clear();
						            break;
								
					    case 2:
						     int Opcion2 = 0;
						     Console.Clear();
						
						     do
						        {
							        Console.WriteLine("1) Agregar Empleado\n" +
							                          "2) Borrar Empleado\n" +
							                          "3) Listar Empleados\n" +
							                          "4) Volver\n");
							try
							{
								Opcion2 = int.Parse(Console.ReadLine());
								if (Opcion2 <=0 || Opcion2 > 4)
								{
									throw new FormatException();
								}
							}
							catch(FormatException)
							{
								Console.WriteLine("Ingreso un digito incorrecto. Ingrese valor entre 1-4. Presione una tecla para continuar...");
								Opcion2 = 0;
								Console.ReadKey();
								Console.Clear();
							}
							switch (Opcion2)
							              {
									//agregar empleado.
								case 1:
									Console.Clear();
									DarAltaEmpleado(far.listaEmpleados);
									Console.Clear();
									break;
									
									//borrar empleado
								 case 2:
									 Console.Clear();
									EliminarEmpleado(far);
									Console.Clear();
									break;
									 //listar empleados.
							     case 3:
									Console.Clear();
                               		ImprimirEmpleados(far);
									//Console.WriteLine("porcentaje de Venta");
									Console.Clear();
									break;
									
							              }
							
						}
						
						while(Opcion2 != 4);
						Console.Clear();
						break;
					}
				}
				
				while(OpcionMenu != 3);
						Console.WriteLine("saliendo del programa...");
						Console.ReadKey(true);
			}
		
		static void DarAltaEmpleado(ArrayList ListaEmpleados)
		{
			//SOLICITO NOMBRE
			bool nombrecorrecto = false;
			string nombre = "";
			while (! nombrecorrecto)
			{
				Console.Write("ingrese el nombre: ");
				nombre = Console.ReadLine();
				nombrecorrecto = true;
				try
				{
					if (nombre == "") 
					{
						throw new NombreIncorrectoException(nombre);
					}
					for (int i = 0; i < nombre.Length; i++)
					{
						if (char.IsNumber(nombre[i]))
						{
							throw new NombreIncorrectoException(nombre);
							
						}
					}
					
				}
				catch(NombreIncorrectoException)
				{
					nombrecorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			Console.Clear();
			//SOLICITO APELLIDO
			bool apellidocorrecto = false;
			string apellido = "";
			while (! apellidocorrecto) 
			{
				try
				{
					Console.Write("ingrese el nombre: {0}\n", nombre);
					Console.Write("ingrese el apellido: ");
					apellido = Console.ReadLine();
					apellidocorrecto = true;
					if (apellido == "") 
					{
						throw new ApellidoIncorrectoException(apellido);
					}
					for (int i = 0; i < apellido.Length; i++) 
					{
						if (char.IsNumber(apellido[i])) 
						{
							throw new ApellidoIncorrectoException(apellido);
						}
					}
				}
				catch(ApellidoIncorrectoException)
				{
					apellidocorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			Console.Clear();
			//SOLICITO DNI
			bool dnicorrecto = false;
			int DNI = 0;
			while (! dnicorrecto) 
			{
				Console.Write("ingrese el nombre: {0}\n", nombre);
				Console.Write("ingrese el apellido: {0}\n", apellido);
				Console.Write("ingrese el DNI: ");
				try 
				{
					DNI = int.Parse(Console.ReadLine());
					if (DNI != 0 && DNI > 0) 
					{
						dnicorrecto = true;
					}
					else throw new FormatException();
					
				} 
				catch (FormatException)
				{
					Console.WriteLine("el DNI ingresado debe contener solo numeros. Sin puntos(.) o comas(,) y ser distinto de 0.");
					dnicorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			
			}
			
			if (ListaEmpleados.Count == 0) 
			{
				Empleado NuevoUsuario = new Empleado(nombre, apellido, DNI);
				ListaEmpleados.Add(NuevoUsuario);
				Console.WriteLine("El empleado {0},{1} ha sido dado de alta correctamente.\n" +
					                  "presione una tecla para continuar...", apellido.ToUpper(),nombre.ToUpper());
				Console.ReadKey();
			}
			else
			{
				bool UsuarioDuplicado = false;
				for (int i = 0; i < ListaEmpleados.Count; i++) 
				{
					Empleado Ucargado = (Empleado)ListaEmpleados[i];
					if (DNI == Ucargado.dni)
					{
						Console.Write("Ya existe un empleado con ese DNI en el sistema. Presione una tecla para continuar...");			
						UsuarioDuplicado = true;
						Console.ReadKey();
						break;
					}
					else
					{
						UsuarioDuplicado = false;
					}
					
				}
				if (! UsuarioDuplicado) 
				{
					Empleado NuevoUsuario = new Empleado(nombre, apellido, DNI);
					ListaEmpleados.Add(NuevoUsuario);
					Console.WriteLine("El usuario {0},{1} ha sido dado de alta correctamente.\n" +
					                  "presione una tecla para continuar...", apellido.ToUpper(),nombre.ToUpper());
					Console.ReadKey();
				}
				
			}


            
			
		}
		
		static void ImprimirEmpleados(Farmacia far)
        {
            foreach (Empleado empleado in far.listaEmpleados){
                Console.Write("Nombre: {0}  ", empleado.nombre);
                Console.Write("Apellido: {0}    ", empleado.apellido);
                Console.Write("DNI: {0}\n", empleado.dni);
               
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        
        static void EliminarEmpleado(Farmacia far){
            try{
                int dni;
                bool dniExiste=false;
                Console.Write("Ingresar DNI: ");
                dni = int.Parse(Console.ReadLine());
                foreach(Empleado empleado in far.listaEmpleados){
                    if (empleado.dni == dni){
                        dniExiste=true;                   
                        far.EliminarEmpleado(empleado);
                        break;
                    }
                }
            
                if (dniExiste){
                    Console.WriteLine("El empleado ha sido eliminado");
                }else{ Console.WriteLine("El empleado con el DNI ingresado no existe");}
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                
            }
            catch{
                Console.WriteLine("El dato ingresado es incorrecto");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        static void AgregarVenta(Farmacia far){

            Console.Write("Nombre del medicamento: ");
            string nombreMedicamento = Console.ReadLine();

            Console.Write("Tipo de droga: ");
            string droga = Console.ReadLine();

            Console.Write("Obra social: ");
            string obraSocial = Console.ReadLine();
       		
            double importe= PedirPrecio("importe");
           	int codigoVendedor= PedirDatoNumerico("codigo vendedor");
           	int anio= PedirDatoNumerico("anio");
           	int mes= PedirDatoNumerico("mes", 12);
           	int dia= PedirDatoNumerico("dia",31);
           	int hora= PedirDatoNumerico("hora", 23);
           	int minuto= PedirDatoNumerico("minutos", 59);
			DateTime fechaHoraVenta = new DateTime(anio, mes, dia, hora, minuto, 0);
  
		    Console.WriteLine("El codigo de factura es: {0}", far.contadorFacturas);
		    Venta venta = new Venta(nombreMedicamento,droga, obraSocial, importe, codigoVendedor, fechaHoraVenta, far.contadorFacturas);
		    far.agregarVenta(venta);
            Console.WriteLine("Venta agregada exitosamente");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

        }
		
		static int PedirDatoNumerico(string nombreDato, int valorMaximo)
		{
			//SOLICITO DATO
			bool datoCorrecto = false;
			string dato = "";
			while (! datoCorrecto)
			{
				Console.Write("ingrese el {0}: ", nombreDato);	
				dato = Console.ReadLine();
				datoCorrecto = true;
				try
				{
					if (dato == "") 
					{
						throw new DatoIncorrectoException(dato);
					}
					for (int i = 0; i < dato.Length; i++)
					{
						if (!char.IsNumber(dato[i]))
						{
							throw new DatoIncorrectoException(dato);
							
						}
					}
			
					if (Int32.Parse(dato) > valorMaximo || Int32.Parse(dato) < 1)
					{
						throw new RangoIncorrectoException(dato);
					}
				}
				catch(Exception e)
				{
					if (e is RangoIncorrectoException || e is DatoIncorrectoException)
					{
						datoCorrecto = false;
						Console.ReadKey();
						Console.Clear();
					}
				
				}
				
			}
			
			int datoInt = Int32.Parse(dato);
			return datoInt;		
			
		}
		
		static int PedirDatoNumerico(string nombreDato)
		{
			//SOLICITO DATO
			bool datoCorrecto = false;
			string dato = "";
			while (! datoCorrecto)
			{
				Console.Write("ingrese el {0}: ", nombreDato);	
				dato = Console.ReadLine();
				datoCorrecto = true;
				try
				{
					if (dato == "") 
					{
						throw new DatoIncorrectoException(dato);
					}
					for (int i = 0; i < dato.Length; i++)
					{
						if (!char.IsNumber(dato[i]))
						{
							throw new DatoIncorrectoException(dato);
							
						}
					}
				}
				catch(DatoIncorrectoException)
				{
					datoCorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			
			int datoInt = Int32.Parse(dato);
			return datoInt;
			
		}
		
		static double PedirPrecio(string nombreDato)
		{
			//SOLICITO DATO
			bool datoCorrecto = false;
			string dato = "";
			while (! datoCorrecto)
			{
				Console.Write("ingrese el {0}: ", nombreDato);	
				dato = Console.ReadLine();
				datoCorrecto = true;
				try
				{
					if (dato == "") 
					{
						throw new DatoIncorrectoException(dato);
					}
					for (int i = 0; i < dato.Length; i++)
					{
						if (!char.IsNumber(dato[i]))
						{
							throw new DatoIncorrectoException(dato);
							
						}
					}
				}
				catch(DatoIncorrectoException)
				{
					datoCorrecto = false;
					Console.ReadKey();
					Console.Clear();
				}
			}
			
			
			double datoDouble = Double.Parse(dato);
			return datoDouble;
			
		}
		
		
		
        static void EliminarVenta(Farmacia far){
            try{
                int nroFactura;
                bool nroFacturaExiste=false;
                Console.Write("Ingresar número de ticket: ");
                nroFactura = int.Parse(Console.ReadLine());
                foreach(Venta venta in far.listaVentas){
                    if (venta.nroFactura == nroFactura){
                        nroFacturaExiste=true;                   
                        far.eliminarVenta(venta);
                        break;
                    }
                }
            
                if (nroFacturaExiste){
                    Console.WriteLine("La venta ha sido eliminada");
                }else{ Console.WriteLine("La venta con el número de ticket ingresado no existe");}
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                
            }
            catch{
                Console.WriteLine("El dato ingresado es incorrecto");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
// porcentaje de ventas primera quincena por obra social
		static void porcentajeVenta(Farmacia far){
	ArrayList listaVentas=new ArrayList();
	ArrayList listaVentasPrimeraQuincena=ventasPrimeraQuincena(far.listaVentas);
	foreach(Venta venta in listaVentasPrimeraQuincena)
	{
		if(venta.obraSocial.ToLower()!="particular"){
			listaVentas.Add(venta);
		}
	}
	try{
		Console.WriteLine(listaVentas.Count*100/listaVentasPrimeraQuincena.Count+"% de las ventas fueron hechas por obra social");
		}
	catch{
		Console.WriteLine("El 0% de las ventas de la primera quincena fueron hechas por obra social");
		
	}
	
	Console.WriteLine("Presione una tecla para continuar");
	
		Console.ReadKey();
			
		}
		
public static ArrayList ventasPrimeraQuincena(ArrayList ventas){
	ArrayList primeraQuincena=new ArrayList();
	foreach(Venta venta in ventas){
		if (venta.fechaHoraVenta.Day>= 1 && venta.fechaHoraVenta.Day<=15){
			primeraQuincena.Add(venta);
		}
	
	}
	return primeraQuincena;
}

		
 //imprime los medicamentos que sean de una droga especifica
        static void medicamentoConDroga(Farmacia far){

            Console.Write("Nombre de la droga: ");
            string droga = Console.ReadLine();
            bool drogaExiste= false;
            foreach(Venta venta in far.listaVentas){
                if (venta.droga == droga){
                    drogaExiste=true;
                    Console.WriteLine("Medicamento: {0} ", venta.nombreMedicamento);                   
                }
            }

            if(!drogaExiste){Console.WriteLine("No hay medicamentos de la droga ingresada");}
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

        }

        //imprime los medicamentos vendidos sin repetir nombres
        static void medicamentoNoRepetido(Farmacia far){

            ArrayList listaMedicamentos = new ArrayList();
            if (far.hayVentas()){
             foreach(Venta venta in far.listaVentas){
                if (!listaMedicamentos.Contains(venta.nombreMedicamento)){
                    Console.WriteLine("Medicamento: {0} ", venta.nombreMedicamento);
                    listaMedicamentos.Add(venta.nombreMedicamento);                   
                }
            }
            } else{Console.WriteLine("No hay medicamentos");}

            Console.WriteLine("Presione una tecla para continuar");
            
            Console.ReadKey();
            
        }

	}
		
}

