using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto1Progra
{
    public class Efectivo :Pago
    {
        public Efectivo(double cantidad)
            :base (cantidad){}
        public override void ProcesarPago()
        {
            base.ProcesarPago();
            Console.WriteLine($"Pago procesado con efectivo");
        }
    }
    
}
