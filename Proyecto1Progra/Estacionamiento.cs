using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Estacionamiento
    {
        private int capacidadMaxima;
        private List<Vehiculos> vehiculosEstacionados;

        public int CapacidadMaxima
        {
            get { return capacidadMaxima; }
        }

        public List<Vehiculos> VehiculosEstacionados
        {
            get { return vehiculosEstacionados; }
        }

        public Estacionamiento(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima;
            this.vehiculosEstacionados = new List<Vehiculos>();
        }

        public void RegistrarVehiculo(Vehiculos vehiculo)
        {
            if (vehiculosEstacionados.Count >= capacidadMaxima)
            {
                Console.WriteLine("No hay espacios disponibles en el estacionamiento");
            }
            else
            {
                vehiculosEstacionados.Add(vehiculo);
                Console.WriteLine("Vehículo registrado exitosamente");
                vehiculo.RegistrarEntrada();
            }
        }

        public void MostrarEspaciosDisponibles()
        {
            int espaciosDisponibles = capacidadMaxima - vehiculosEstacionados.Count;

            if (espaciosDisponibles > 0)
            {
                Console.WriteLine($"Espacios disponibles en el estacionamiento: {espaciosDisponibles}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No hay espacios disponibles en el estacionamiento.");
                Console.ResetColor();
            }

        }
        public void MostrarVehiculosEstacionados()
        {
            if (vehiculosEstacionados.Count == 0)
            {
                Console.WriteLine("No hay vehículos estacionados.");
            }
            else
            {
                foreach (var vehiculo in vehiculosEstacionados)
                {
                    vehiculo.MostrarInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
