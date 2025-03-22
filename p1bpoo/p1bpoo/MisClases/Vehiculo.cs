using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get;  }
        public int Year { get;  }

        protected int velocidad = 0;

        public int Velocidadactual => velocidad; //solo sirve para conocer la velociadad actual, pero no modificarla
                                                 //la verdad es solo para el ciclo while para subir la velocidad sin estar llamanda a cada rato

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar()
        {
            velocidad += 5;
            Console.WriteLine("vas a {0} KMS / Hora",velocidad);
        }

        public virtual void desacelerar()
        {
            velocidad -= 5;
            if (velocidad < 0)
            {
                velocidad = 0;
            }
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
        }

        public virtual void frenar()
        {
            while (velocidad > 0)
            {
                velocidad -= Math.Min(10, velocidad);
                Console.WriteLine("Has disminuido la velocidad a {0} KMS / Hora", velocidad);
                System.Threading.Thread.Sleep(1000);
            }
        }

    }
}
