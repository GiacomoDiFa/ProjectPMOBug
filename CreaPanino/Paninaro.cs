using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    class Paninaro
    {
        private IBuilderPanino builder;
        public IBuilderPanino Builder { set { builder = value; } }
        public void Hamburger()
        {
            this.builder.CreaHamgurger();
            this.builder.CreaInsalata();
            this.builder.CreaKetchup();
            this.builder.CreaMaionese();
            this.builder.CreaPomodoro();
        }
        public void HotDog()
        {
            this.builder.CreaHotDog();
            this.builder.CreaKetchup();
            this.builder.CreaMaionese();
        }
        public void Cheeseburger()
        {
            this.builder.CreaHamgurger();
            this.builder.CreaInsalata();
            this.builder.CreaKetchup();
            this.builder.CreaMaionese();
            this.builder.CreaPomodoro();
            this.builder.CreaSottiletta();
        }
        public void ChickenBurger()
        {
            this.builder.CreaPollo();
            this.builder.CreaInsalata();
            this.builder.CreaKetchup();
            this.builder.CreaMaionese();
            this.builder.CreaPomodoro();
        }
        public void Toast()
        {
            this.builder.CreaProsciuttoCotto();
            this.builder.CreaSottiletta();
        }
    }
}
