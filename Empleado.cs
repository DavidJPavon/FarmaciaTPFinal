using System;

namespace FarmaciaIntegrador
{

public class Empleado
    {
      

        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }

          public Empleado(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
	}
}
