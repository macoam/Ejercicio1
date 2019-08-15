using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Enemigo
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set;}
        private int _puntos;
        public int Puntos
        {

            get
            {
                return _puntos;
            }

            set
            {
                if (value >=100)
                {
                    _puntos = value;
                }

                else
                {
                    throw new Exception("Debe ser mayor a 100");
                }
            }
        }
        

    }
}
