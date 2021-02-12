using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class HotDogCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new HotDog();
        }
        public string GetInfo()
        {
            return "Hot Dog ";
        }
        public double GetPrice()
        {
            return 3.00;
        }
    }
}
