using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class SottilettaCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new Sottiletta();
        }

        public string GetInfo()
        {
            return "Sottiletta ";
        }

        public double GetPrice()
        {
            return 1.00;
        }
    }
}
