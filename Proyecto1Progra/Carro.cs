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

        public Carro(string placa, string marca, string modelo,string color, int numeroPuertas)
            : base(placa, marca, modelo, color)
        {
            NumeroPuertas = numeroPuertas;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Número de Puertas: {NumeroPuertas}");
        }
        public override decimal CalcularCosto()
        {
            TimeSpan tiempoEstacionado = CalcularTiempoEstacionado();
            decimal tarifaPorHora = 20m;
            return tarifaPorHora * tiempoEstacionado.Hours;
        }
    }

}
