using p1bpoo.MisClases;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione una prueba para realizar:");
            Console.WriteLine("1. Prueba Carro de Combustion");
            Console.WriteLine("2. Prueba Carro Electrico");
            Console.WriteLine("3. Prueba Camion");
            Console.WriteLine("4. Prueba Motocicleta");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese su opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    PruebaCarroCombustion();
                    break;
                case "2":
                    PruebaCarroElectrico();
                    break;
                case "3":
                    PruebaCamion();
                    break;
                case "4":
                    PruebaMotocicleta();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void PruebaCarroCombustion()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Prueba Carro de Combustion");
        CarroCombustion miCarroCombustion = new CarroCombustion(2021, "Azul", "Toyota");

        miCarroCombustion.InformacionVehiculo();
        Console.WriteLine("---------------------------------------------");
        miCarroCombustion.NivelCombustible();
        Console.WriteLine("---------------------------------------------");
        while (miCarroCombustion.Velocidadactual < 35)
        {
            miCarroCombustion.acelerar();
        }
        Console.WriteLine("---------------------------------------------");
        miCarroCombustion.frenar();
        Console.WriteLine("---------------------------------------------");
        miCarroCombustion.NivelCombustible();
        Console.WriteLine("---------------------------------------------");
        miCarroCombustion.cargarCombustible();
        miCarroCombustion.cargarCombustible();
        miCarroCombustion.cargarCombustible();
        Console.WriteLine("Se han cargado 3 litros de combustible");
        Console.WriteLine("---------------------------------------------");
        miCarroCombustion.NivelCombustible();
        Console.WriteLine("---------------------------------------------");
    }

    static void PruebaCarroElectrico()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Prueba Carro Electrico");
        CarroElectrico miCarroElectrico = new CarroElectrico(2022, "Verde", "Tesla");

        miCarroElectrico.InformacionVehiculo();
        Console.WriteLine("---------------------------------------------");
        miCarroElectrico.NivelBateria();
        Console.WriteLine("---------------------------------------------");
        while (miCarroElectrico.Velocidadactual < 30)
        {
            miCarroElectrico.acelerar();
        }
        Console.WriteLine("---------------------------------------------");
        miCarroElectrico.frenar();
        Console.WriteLine("---------------------------------------------");
        miCarroElectrico.NivelBateria();
        Console.WriteLine("---------------------------------------------");
        miCarroElectrico.cargarBateria();
        miCarroElectrico.cargarBateria();
        miCarroElectrico.cargarBateria();
        Console.WriteLine("Se ha cargado 3% de la bateria");
        Console.WriteLine("---------------------------------------------");
        miCarroElectrico.NivelBateria();
        Console.WriteLine("---------------------------------------------");
    }

    static void PruebaCamion()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Prueba Camion");
        camion miCamion = new camion(2020, "Rojo", "wolkswagen");

        miCamion.InformacionVehiculo();
        Console.WriteLine("---------------------------------------------");
        miCamion.NivelCarga();
        Console.WriteLine("---------------------------------------------");
        while (miCamion.Velocidadactual < 60)
        {
            miCamion.acelerar();
        }
        Console.WriteLine("---------------------------------------------");
        miCamion.frenar();
        Console.WriteLine("---------------------------------------------");
        miCamion.NivelCarga();
        Console.WriteLine("---------------------------------------------");
        miCamion.cargar(10);
        miCamion.cargar(10);
        miCamion.cargar(10);
        Console.WriteLine("Se han cargado 30 toneladas");
        Console.WriteLine("---------------------------------------------");
        miCamion.NivelCarga();
        Console.WriteLine("---------------------------------------------");
    }

    static void PruebaMotocicleta()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Prueba Motocicleta");
        motocicleta miMotocicleta = new motocicleta(2023, "azulmarino", "suzuki");

        miMotocicleta.InformacionVehiculo();
        Console.WriteLine("---------------------------------------------");
        while (miMotocicleta.Velocidadactual < 50)
        {
            miMotocicleta.acelerar();
        }
        Console.WriteLine("---------------------------------------------");
        miMotocicleta.hacerpippip();
        miMotocicleta.hacerpippip();
        Console.WriteLine("Con permisooooooo");
        Console.WriteLine("---------------------------------------------");
        miMotocicleta.frenar();
        Console.WriteLine("---------------------------------------------");
    }
}
