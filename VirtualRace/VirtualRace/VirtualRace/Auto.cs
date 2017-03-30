using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRace
{
    public class Auto
    {
        #region Atributos

        public eFabricante fabricante;
        public Rueda DD;
        public Rueda DI;
        public Rueda TD;
        public Rueda TI;

        public static int contadorDeObjetos;
        private static Random miNumeroRandom;

        #endregion

        #region Constructores

        public Auto()
        {
            
            this.DD = new Rueda();
            this.DI = new Rueda();
            this.TD = new Rueda();
            this.TI = new Rueda();

            fabricante = (eFabricante)miNumeroRandom.Next(0, 3);

            contadorDeObjetos++;
        }

        static Auto()
        {
            contadorDeObjetos = 0;
            miNumeroRandom = new Random();
        }

        #endregion
    }
}
