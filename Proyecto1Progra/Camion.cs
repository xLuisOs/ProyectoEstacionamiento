using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Camion : Vehiculos
    {
        public double CapacidadCarga { get; set; }

        public Camion(string placa, string marca, string modelo,string color, double capacidadCarga)
            : base(placa, marca, modelo, color)
        {
            CapacidadCarga = capacidadCarga;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} kg");
        }
        public override decimal CalcularCosto()
        {
            TimeSpan tiempoEstacionado = CalcularTiempoEstacionado();
            decimal tarifaPorHora = 50m; 
            return tarifaPorHora * tiempoEstacionado.Hours;
        }
    }

}
