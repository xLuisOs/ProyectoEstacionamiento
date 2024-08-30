using Proyecto1Progra;

class Program
{
    static void Main(string[] args)
    {
        Estacionamiento estacionamiento = new Estacionamiento(10);
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Agregar Vehiculo");
            Console.WriteLine("2. Retirar Vehiculo");
            Console.WriteLine("3. Consultar Vehiculos Estacionados");
            Console.WriteLine("4. Consultar disponibilidad de espacio");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Ingresar una opcion: ");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MenuAgregarVehiculo(estacionamiento);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar nuestros servicios :)");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error de formato. Intenta de nuevo");
            }
        }
        while (opcion != 5);
    }
    static void MenuAgregarVehiculo(Estacionamiento estacionamiento)
    {
        if (!estacionamiento.HayEspaciosDisponibles())
        {
            Console.WriteLine($"No hay espacios disponibles en el estacionamiento");
            return;
        }

        int tipoVehiculo = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Seleccione el tipo de vehículo:");
            Console.WriteLine("1. Carro");
            Console.WriteLine("2. Moto");
            Console.WriteLine("3. Camion");
            Console.WriteLine("4. Volver al menu principal");
            Console.WriteLine("Ingresar una opción: ");
            try
            {
                tipoVehiculo = Convert.ToInt32(Console.ReadLine());

                switch (tipoVehiculo)
                {
                    case 1:
                        AgregarCarro(estacionamiento);
                        return;
                    case 2:
                        AgregarMoto(estacionamiento);
                        return;
                    case 3:
                        AgregarCamion(estacionamiento);
                        return;
                    case 4:
                        Console.WriteLine("Cancelado");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opción no válida. Intenta de nuevo");
                        Console.ResetColor();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error de formato. Intenta de nuevo.");
                Console.ResetColor();
            }
        }
        while (tipoVehiculo != 4);
    }

    static void AgregarCarro(Estacionamiento estacionamiento)
    {
        Console.Clear();
        Console.WriteLine("Ingrese la placa:");
        string placa = Console.ReadLine();
        Console.WriteLine("Ingrese la marca:");
        string marca = Console.ReadLine();
        Console.WriteLine("Ingrese el modelo:");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ingrese el tipo de gasolina:");
        string tipoGasolina = Console.ReadLine();
        Console.WriteLine("Ingrese el número de puertas:");
        int numeroPuertas = int.Parse(Console.ReadLine());

        Vehiculos vehiculo = new Carro(placa, marca, modelo, tipoGasolina, numeroPuertas);
        estacionamiento.RegistrarVehiculo(vehiculo);
    }
    static void AgregarMoto(Estacionamiento estacionamiento)
    {
        Console.WriteLine("Ingrese la placa:");
        string placa = Console.ReadLine();
        Console.WriteLine("Ingrese la marca:");
        string marca = Console.ReadLine();
        Console.WriteLine("Ingrese el modelo:");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ingrese el tipo de gasolina:");
        string tipoGasolina = Console.ReadLine();
        Console.WriteLine("¿Tiene sidecar? (true/false):");
        bool sideCar = bool.Parse(Console.ReadLine());

        Vehiculos vehiculo = new Moto(placa, marca, modelo, tipoGasolina, sideCar);
        estacionamiento.RegistrarVehiculo(vehiculo);
    }

    static void AgregarCamion(Estacionamiento estacionamiento)
    {
        Console.WriteLine("Ingrese la placa:");
        string placa = Console.ReadLine();
        Console.WriteLine("Ingrese la marca:");
        string marca = Console.ReadLine();
        Console.WriteLine("Ingrese el modelo:");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ingrese el tipo de gasolina:");
        string tipoGasolina = Console.ReadLine();
        Console.WriteLine("Ingrese la capacidad de carga:");
        double capacidadCarga = double.Parse(Console.ReadLine());

        Vehiculos vehiculo = new Camion(placa, marca, modelo, tipoGasolina, capacidadCarga);
        estacionamiento.RegistrarVehiculo(vehiculo);
    }
}
