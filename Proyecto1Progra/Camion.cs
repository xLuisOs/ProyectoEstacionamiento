using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Camion : Vehiculos
    {
        public double CapacidadCarga {  get; set; }

        public Camion(string placa, string marca, string modelo, string tipoGasolina, double capacidadCarga)
            :base (placa, marca, modelo, tipoGasolina)
        {
            CapacidadCarga = capacidadCarga;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga}");
        }
    }
}
