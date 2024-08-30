using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Progra
{
    public class Vehiculos
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoGasolina { get; set; }
        public DateTime HoraDeEntrada { get; set; }

        public Vehiculos(string placa, string marca, string modelo, string tipoGasolina)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            TipoGasolina = tipoGasolina;
            RegistrarEntrada();
        }
        public void RegistrarEntrada()
        {
            HoraDeEntrada = DateTime.Now;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Tipo de Gasolina: {TipoGasolina}");
            
        }
       
        public TimeSpan CalcularTiempoEstacionado()
        {
            DateTime horaActual = DateTime.Now;
            TimeSpan tiempoEstacionado = horaActual - HoraDeEntrada;

            int horasCalculadas = tiempoEstacionado.Seconds + (tiempoEstacionado.Minutes * 60) + (tiempoEstacionado.Hours * 3600);

            return new TimeSpan(horasCalculadas, 0, 0);
        }
    }
}
