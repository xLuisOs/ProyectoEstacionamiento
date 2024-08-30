using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Estacionamiento
    {
        public int CapacidadMaxima {  get; set; }
        public List<Vehiculos> VehiculosEstacionados { get; set;}
        public Estacionamiento(int capacidadMaxima)
        {
            CapacidadMaxima = capacidadMaxima;
            VehiculosEstacionados = new List<Vehiculos>();
        }
        public void RegistrarVehiculo(Vehiculos vehiculo)
        {
            if (VehiculosEstacionados.Count >= CapacidadMaxima)
            {
                Console.WriteLine("No hay espacios disponibles en el estacionamiento");
            }
            else
            {
                VehiculosEstacionados.Add(vehiculo);
                Console.WriteLine("Vehículo registrado exitosamente");
                vehiculo.RegistrarEntrada();
            }
        }
        public void MostrarVehiculosEstacionados()
        {
            if (VehiculosEstacionados.Count == 0)
            {
                Console.WriteLine("No hay vehículos estacionados actualmente");
                return;
            }
            Console.WriteLine("Vehículos actualmente estacionados: ");
            foreach (var vehiculo in VehiculosEstacionados)
            {
                vehiculo.MostrarInfo();
            }

        }
        public bool HayEspaciosDisponibles()
            {
                return VehiculosEstacionados.Count < CapacidadMaxima;
            }
    }
}
