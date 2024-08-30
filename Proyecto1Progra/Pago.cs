using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Pago
    {
        public double Cantidad { get; set; }

        public Pago(double cantidad)
        {
            Cantidad = cantidad;
        }
        public virtual void ProcesarPago()
        {
            Console.WriteLine("Procesando Pago");
        }
    }
}
