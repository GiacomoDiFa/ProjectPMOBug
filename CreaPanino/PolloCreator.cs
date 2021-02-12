using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class PolloCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new Pollo();
        }

        public string GetInfo()
        {
            return "Pollo ";
        }

        public double GetPrice()
        {
            return 3.00;
        }
    }
}
