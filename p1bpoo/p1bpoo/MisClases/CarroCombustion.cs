using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroCombustion : Vehiculo
    {
        private int combustible;

        public CarroCombustion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            combustible = 50;
        }

        public override void acelerar()
        {
            velocidad += 6;
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
            combustible--;
        }

        public override void frenar()
        {
            base.frenar();
            combustible--;
        }

        public override void desacelerar()
        {
            base.desacelerar();
            combustible--;
        }

        public int NivelCombustible() 
        { 
            Console.WriteLine("Nivel de combustible: {0}", combustible);
            return combustible; 
        }

        public void cargarCombustible()
        {
            combustible++;
        }
    }
}
