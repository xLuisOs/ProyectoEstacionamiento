public class Vehiculos
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public DateTime HoraDeEntrada { get; private set; }

    public Vehiculos(string placa, string marca, string modelo)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
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
        Console.WriteLine($"Hora de Entrada: {HoraDeEntrada}");
    }
    public TimeSpan CalcularTiempoEstacionado()
    {
        DateTime horaActual = DateTime.Now;
        TimeSpan tiempoEstacionado = horaActual - HoraDeEntrada;

        int horasCalculadas = tiempoEstacionado.Seconds + (tiempoEstacionado.Minutes * 60) + (tiempoEstacionado.Hours * 3600);

        return new TimeSpan(horasCalculadas, 0, 0);
    }
    public virtual decimal CalcularCosto()
    {
        return 0;
    }
}
