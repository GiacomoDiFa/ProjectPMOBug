using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPanino
{
    interface IBuilderPanino
    {
        public void CreaHamgurger();
        public void CreaHotDog();
        public void CreaInsalata();
        public void CreaKetchup();
        public void CreaMaionese();
        public void CreaPollo();
        public void CreaPomodoro();
        public void CreaProsciuttoCotto();
        public void CreaSottiletta();
    }
}
