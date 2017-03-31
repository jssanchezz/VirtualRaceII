using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualRace
{
    class Carrera
    {
        #region Atributos

        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;

        private static Random miRandom;

        #endregion

        #region Constructores

        public Carrera()
        {
            auto1 = new Auto();
            auto2 = new Auto();
            auto3 = new Auto();
            auto4 = new Auto();
            auto5 = new Auto();
            auto6 = new Auto();
        }

        static Carrera()
        {
            miRandom = new Random();
        }

        #endregion

        #region Métodos

        public void MostrarCarrera()
        {
           auto1.MostrarAuto();
           auto2.MostrarAuto();
           auto3.MostrarAuto();
           auto4.MostrarAuto();
           auto5.MostrarAuto();
           auto6.MostrarAuto();
        }

        public void PorTiempo(int minutos)
        {
            for (int i = 0; i < minutos; i++)
            {
                auto1.AgregarKilometros(miRandom.Next(0, 100));
                auto2.AgregarKilometros(miRandom.Next(0, 100));
                auto3.AgregarKilometros(miRandom.Next(0, 100));
                auto4.AgregarKilometros(miRandom.Next(0, 100));
                auto5.AgregarKilometros(miRandom.Next(0, 100));
                auto6.AgregarKilometros(miRandom.Next(0, 100));
            }
        }

        #endregion
    }
}
