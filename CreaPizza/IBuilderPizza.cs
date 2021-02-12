using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    interface IBuilderPizza
    {
        public void CreaMozzarella();
        public void CreaSalsaPomodoro();
        public void CreaPeperone();
        public void CreaSalsiccia();
        public void CreaFungo();
        public void CreaSalamePiccante();
        public void CreaOliva();
        public void CreaWustel();
        public void CreaPatatina();
    }
}
