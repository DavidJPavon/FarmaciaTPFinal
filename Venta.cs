
using System;

namespace FarmaciaIntegrador
{
public class Venta
    {

        public string nombreMedicamento { get; set; }
        public string droga { get; set; }
        public string obraSocial { get; set; }
        public double importe { get; set; }
        public int codigoVendedor { get; set; }
        public DateTime fechaHoraVenta { get; set; }
        public int nroFactura { get; set; }
		
		public Venta(
			string nombreMedicamento,
			string droga,
			string obraSocial,
			double importe,
			int codigoVendedor,
			DateTime fechaHoraVenta,
			int nroFactura
			
		)
		{
			this.nombreMedicamento = nombreMedicamento;
            this.droga = droga;
            this.obraSocial = obraSocial;
            this.importe= importe;
            this.codigoVendedor= codigoVendedor;
            this.fechaHoraVenta = fechaHoraVenta;
            this.nroFactura = nroFactura;
		}

   



    }
}