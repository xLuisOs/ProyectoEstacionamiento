using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Tarjeta : Pago
    {
        private string nombre;
        private string numeroTarjeta;
        private DateTime expiracion;
        private int cvv; 
        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public string NumeroTarjeta
        {
            get { return "**** **** **** " + numeroTarjeta.Substring(numeroTarjeta.Length - 4); } 
            private set { numeroTarjeta = value; }
        }

        public DateTime Expiracion
        {
            get { return expiracion; }
            private set { expiracion = value; }
        }

        public int CVV
        {
            get { return cvv; }
            private set { cvv = value; }
        }
        public Tarjeta(double cantidad, string nombre, string numeroTarjeta, DateTime expiracion, int cvv)
            : base(cantidad)
        {
            this.Nombre = nombre;
            this.numeroTarjeta = numeroTarjeta;
            this.Expiracion = expiracion;
            this.CVV = cvv;
        }

        public override void ProcesarPago()
        {
            base.ProcesarPago();
            Console.WriteLine($"Pago procesado con tarjeta a nombre de: {Nombre}");
        }
    }
}
