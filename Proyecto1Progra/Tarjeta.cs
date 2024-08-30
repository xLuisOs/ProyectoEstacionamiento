using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Tarjeta : Pago
    {
        public string Nombre { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime Expiracion { get; set; }
        public int CVV { get; set; }

        public Tarjeta(double cantidad, string nombre, string numeroTarjeta, DateTime expiracion, int cVV)
            :base (cantidad)
        {
            Nombre = nombre;
            NumeroTarjeta = numeroTarjeta;
            Expiracion = expiracion;
            CVV = cVV;
        }
        public override void ProcesarPago()
        {
            base.ProcesarPago();
            Console.WriteLine($"Pago procesado con tarjeta a nombre de: {Nombre}");
        }

    }
}
