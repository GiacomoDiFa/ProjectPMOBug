using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.CreaPizza
{
    class Pizzaiolo
    {
        private IBuilderPizza builder;
        public IBuilderPizza Builder { set { builder = value; } }
        public void PizzaMargherita()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
        }
        public void PizzaPeperoniSalsiccia()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaPeperone();
            this.builder.CreaSalsiccia();
        }
        public void PizzaPeperoni()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaPeperone();
        }
        public void PizzaSalsicca()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaSalsiccia();
        }
        public void PizzaFunghi()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaFungo();
        }
        public void PizzaSalamePiccante()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaSalamePiccante();
        }
        public void PizzaFunghiSalsiccia()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaFungo();
            this.builder.CreaSalsiccia();
        }
        public void PizzaOlive()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaOliva();
        }
        public void PizzaWustelPatatine()
        {
            this.builder.CreaSalsaPomodoro();
            this.builder.CreaMozzarella();
            this.builder.CreaWustel();
            this.builder.CreaPatatina();
        }
    }
}
