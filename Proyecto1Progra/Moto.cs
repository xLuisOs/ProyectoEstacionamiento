using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Moto : Vehiculos
    {
        public bool SideCar { get; set; }
        public Moto(string placa, string marca, string modelo,string color, bool sideCar)
            : base(placa, marca, modelo, color)
        {
            SideCar = sideCar;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tiene SideCar: {SideCar}");
        }
        public override decimal CalcularCosto()
        {
            TimeSpan tiempoEstacionado = CalcularTiempoEstacionado();
            decimal tarifaPorHora = 10m;
            return tarifaPorHora * tiempoEstacionado.Hours;
        }
    }
}
