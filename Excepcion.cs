

using System;

namespace FarmaciaIntegrador
{

public class NombreIncorrectoException : Exception
	{
		public NombreIncorrectoException(string nombre)
		{
			Console.WriteLine("el nombre ingresado  \"{0}\" no debe contener numeros o ser vacio.", nombre);
		}
	}
	
	
	public class ApellidoIncorrectoException : Exception
	{
		public ApellidoIncorrectoException (string nombre)
		{
			Console.WriteLine("el apellido ingresado  \"{0}\" no debe contener numeros o ser vacio.", nombre);
		}
	}
	
	public class DatoIncorrectoException : Exception
	{
		public DatoIncorrectoException (string dato)
		{
			Console.WriteLine("el valor \"{0}\" debe ser un numero", dato);
		}
	}
	
	public class RangoIncorrectoException : Exception
	{
		public RangoIncorrectoException (string dato)
		{
			Console.WriteLine("el valor \"{0}\" es incorrecto", dato);
		}
	}
}

