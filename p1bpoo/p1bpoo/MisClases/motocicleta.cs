using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class motocicleta : Vehiculo
    {
        public motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
        }
        public override void acelerar()
        {
            velocidad += 8;
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
        }
        public override void frenar()
        {
            base.frenar();
        }
        public override void desacelerar()
        {
            velocidad -= 8;
            if (velocidad < 0)
            {
                velocidad = 0;
            }
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
        }
        public void hacerpippip()
        {
            Console.WriteLine("Pip Pip (sonidos de bocina)");
        }
    }
}
