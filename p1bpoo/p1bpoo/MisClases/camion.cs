using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class camion : Vehiculo
    {
        private int carga;
        public camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            carga = 0;
        }
        public override void acelerar()
        {
            velocidad += 3;
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
        }
        public override void frenar()
        {
            base.frenar();
        }
        public override void desacelerar()
        {
            velocidad -= 3;
            if (velocidad < 0)
            {
                velocidad = 0;
            }
            Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
        }
        public void cargar(int cuanto)
        {
            carga += cuanto;
        }
        public void descargar(int cuanto)
        {
            carga -= cuanto;
        }
        public int NivelCarga()
        {
            Console.WriteLine("Nivel de carga: {0}", carga);
            return carga;
        }
    }
}
