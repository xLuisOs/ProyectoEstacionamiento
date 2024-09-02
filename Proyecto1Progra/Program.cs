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
                        RetirarVehiculo(estacionamiento);
                        break;
                    case 3:
                        estacionamiento.MostrarVehiculosEstacionados();
                        Console.WriteLine("Presione cualquier tecla para volver al menú principal");
                        Console.ReadKey();
                        break;
                    case 4:

                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar nuestros servicios :)");
                        break;
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
                Console.WriteLine("Error de formato. Intenta de nuevo");
                Console.ResetColor();
            }
        }
        while (opcion != 5);
    }

    static void MenuAgregarVehiculo(Estacionamiento estacionamiento)
    {
        estacionamiento.MostrarEspaciosDisponibles();

        if (estacionamiento.CapacidadMaxima <= estacionamiento.VehiculosEstacionados.Count)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("No hay espacios disponibles en el estacionamiento");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
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
        Console.WriteLine("Ingrese el color:");
        string color = Console.ReadLine();

        int numeroPuertas;
        while (true)
        {
            Console.WriteLine("Ingrese el número de puertas:");
            try
            {
                numeroPuertas = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Debe ingresar un número válido para el número de puertas.");
                Console.ResetColor();
            }
        }

        Vehiculos vehiculo = new Carro(placa, marca, modelo, color, numeroPuertas);
        estacionamiento.RegistrarVehiculo(vehiculo);
    }

    static void AgregarMoto(Estacionamiento estacionamiento)
    {
        Console.Clear();
        Console.WriteLine("Ingrese la placa:");
        string placa = Console.ReadLine();
        Console.WriteLine("Ingrese la marca:");
        string marca = Console.ReadLine();
        Console.WriteLine("Ingrese el modelo:");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ingrese el color:");
        string color = Console.ReadLine();

        bool sideCar;
        while (true)
        {
            Console.WriteLine("¿Tiene sidecar? (true/false):");
            try
            {
                string input = Console.ReadLine().ToLower();
                sideCar = bool.Parse(input);
                break;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Debe ingresar 'true' o 'false' para el sidecar.");
                Console.ResetColor();
            }
        }

        Vehiculos vehiculo = new Moto(placa, marca, modelo, color, sideCar);
        estacionamiento.RegistrarVehiculo(vehiculo);
    }

    static void AgregarCamion(Estacionamiento estacionamiento)
    {
        Console.Clear();
        Console.WriteLine("Ingrese la placa:");
        string placa = Console.ReadLine();
        Console.WriteLine("Ingrese la marca:");
        string marca = Console.ReadLine();
        Console.WriteLine("Ingrese el modelo:");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ingrese el color:");
        string color = Console.ReadLine();

        double capacidadCarga;
        while (true)
        {
            Console.WriteLine("Ingrese la capacidad de carga (en toneladas, solo números):");
            try
            {
                capacidadCarga = double.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Debe ingresar un número válido para la capacidad de carga.");
                Console.ResetColor();
            }
        }

        Vehiculos vehiculo = new Camion(placa, marca, modelo, color, capacidadCarga);
        estacionamiento.RegistrarVehiculo(vehiculo);
    }
    static void RetirarVehiculo(Estacionamiento estacionamiento)
    {
        Console.Clear();

        if (estacionamiento.VehiculosEstacionados.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("No hay vehículos registrados en el estacionamiento.");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Ingrese la placa del vehículo que desea retirar:");
        string placa = Console.ReadLine().ToLower();

        Vehiculos vehiculo = estacionamiento.VehiculosEstacionados.Find(v => v.Placa.ToLower().Equals(placa));

        if (vehiculo != null)
        {
            TimeSpan tiempoEstacionado = vehiculo.CalcularTiempoEstacionado();

            decimal costoTotal = vehiculo.CalcularCosto();

            Console.WriteLine($"Vehículo con placa {placa.ToUpper()} ha sido retirado");
            Console.WriteLine($"Tiempo estacionado: {tiempoEstacionado.Hours} horas");
            Console.WriteLine($"Costo total: Q{costoTotal}");

            Console.WriteLine("Seleccione el método de pago:");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");

            int metodoPago;
            while (true)
            {
                try
                {
                    metodoPago = Convert.ToInt32(Console.ReadLine());
                    if (metodoPago == 1)
                    {
                        ProcesarPagoEfectivo(costoTotal);
                        break;
                    }
                    else if (metodoPago == 2)
                    {
                        ProcesarPagoTarjeta(costoTotal);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Método de pago no válido. Intente de nuevo");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error de formato. Intente de nuevo");
                    Console.ResetColor();
                }
            }

            estacionamiento.VehiculosEstacionados.Remove(vehiculo);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Vehículo no encontrado");
            Console.ResetColor();
        }

        Console.WriteLine("Presione cualquier tecla para volver al menú principal");
        Console.ReadKey();
    }
    static void ProcesarPagoEfectivo(decimal costoTotal)
    {
        decimal montoEntregado;
        while (true)
        {
            Console.WriteLine($"Ingrese el monto entregado (costo total: Q{costoTotal}):");
            try
            {
                montoEntregado = decimal.Parse(Console.ReadLine());
                if (montoEntregado < costoTotal)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Monto insuficiente. Ingrese un monto adicional.");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error: Ingrese un monto válido.");
                Console.ResetColor();
            }
        }

        decimal cambio = montoEntregado - costoTotal;
        Console.WriteLine($"Cambio a devolver: Q{cambio}");

        int[] billetes = { 200, 100, 50, 20, 10, 5, 1 };
        int[] cantidadBilletes = new int[billetes.Length];

        for (int i = 0; i < billetes.Length; i++)
        {
            if (cambio >= billetes[i])
            {
                cantidadBilletes[i] = (int)(cambio / billetes[i]);
                cambio %= billetes[i];
            }
        }

        for (int i = 0; i < billetes.Length; i++)
        {
            if (cantidadBilletes[i] > 0)
            {
                Console.WriteLine($"Q{billetes[i]}: {cantidadBilletes[i]} billete/s");
            }
        }
    }
    static void ProcesarPagoTarjeta(decimal costoTotal)
    {
        Console.WriteLine("Ingrese los detalles de la tarjeta:");

        string numeroTarjeta;
        while (true)
        {
            Console.WriteLine("Número de Tarjeta (16 dígitos):");
            numeroTarjeta = Console.ReadLine();
            if (numeroTarjeta.Length == 16 && long.TryParse(numeroTarjeta, out _))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Número de tarjeta inválido. Debe ser numérico y tener 16 dígitos.");
                Console.ResetColor();
            }
        }

        Console.WriteLine("Nombre del Titular:");
        string nombreTitular = Console.ReadLine();

        DateTime fechaExpiracion;
        while (true)
        {
            Console.WriteLine("Fecha de Vencimiento (MM/AA):");
            string[] fecha = Console.ReadLine().Split('/');
            if (fecha.Length == 2 && int.TryParse(fecha[0], out int mes) && int.TryParse(fecha[1], out int año))
            {
                fechaExpiracion = new DateTime(2000 + año, mes, 1);
                if (fechaExpiracion > DateTime.Now)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fecha de vencimiento inválida. Debe ser una fecha futura.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Formato de fecha inválido. Intente de nuevo.");
                Console.ResetColor();
            }
        }

        int cvv;
        while (true)
        {
            Console.WriteLine("CVV (3 o 4 dígitos):");
            string cvvInput = Console.ReadLine();
            if ((cvvInput.Length == 3 || cvvInput.Length == 4) && int.TryParse(cvvInput, out cvv))
            {
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("CVV inválido. Debe ser numérico y tener 3 o 4 dígitos.");
                Console.ResetColor();
            }
        }
        Console.WriteLine("Transacción aprobada. ¡Gracias por su pago!");
    }
}
