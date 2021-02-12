using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class KetchupCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new Ketchup();
        }
        public string GetInfo()
        {
            return "Ketchup ";
        }
        public double GetPrice()
        {
            return 0.50;
        }
    }
}
