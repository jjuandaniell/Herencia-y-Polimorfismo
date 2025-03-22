using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }

        public override void acelerar()
        {
            base.acelerar();
            cargaBateria--;
        }

        public int NivelBateria()
        {
            Console.WriteLine("Nivel de bateria: {0}", cargaBateria);
            return cargaBateria;
        }
        public void cargarBateria()
        {
            cargaBateria++;
        }


    }
}
