using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Moto : Vehiculos
    {
        bool SideCar {  get; set; }

        public Moto(string placa, string marca, string modelo, string tipoGasolina, bool sideCar)
            :base (placa, marca, modelo, tipoGasolina)
        {
            SideCar = sideCar;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tiene side car?: {SideCar}");
        }
    }
}
