using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class PomodoroCreator : IIngredienteCreator
    {
        public IIngrediente FactoryMethod()
        {
            return new Pomodoro();
        }

        public string GetInfo()
        {
            return "Pomodoro ";
        }

        public double GetPrice()
        {
            return 2.00;
        }
    }
}
