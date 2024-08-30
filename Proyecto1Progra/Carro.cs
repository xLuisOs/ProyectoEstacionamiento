using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Carro : Vehiculos
    {
        public int NumeroPuertas { get; set; }

        public Carro(string placa, string marca, string modelo, string tipoGasolina, int numeroPuertas)
            : base (placa, marca, modelo, tipoGasolina)
        {
            NumeroPuertas = numeroPuertas;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Numero de Puertas: {NumeroPuertas}");
        }
    }
}
