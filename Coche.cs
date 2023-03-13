using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueVehiculos
{
    internal class Coche : Vehiculo
    {
        private int numAirbags;
        private bool techoSolar;

        public Coche():base()
        {
        }


        public Coche(int numAirbags, bool techoSolar): base()
        {
            this.numAirbags = numAirbags;
            this.techoSolar = techoSolar;
        }

        public override void Acelerar()
        {
            throw new NotImplementedException();
        }

        public override void Arrancar()
        {
            throw new NotImplementedException();
        }

        public override void Frenar()
        {
            throw new NotImplementedException();
        }
    }
}
