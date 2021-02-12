using MenuInterattivo.Calculation;
using MenuInterattivo.CreaPanino;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Model
{
    class Panino : Cibo, IVisitorHost
    {
        private List<IIngrediente> ingredienti = new List<IIngrediente>();
        private string descrizione;
        private double prezzo;
        public override string Name { get; set; }
        public override string Description
        {
            get
            {
                foreach (IIngrediente item in ingredienti)
                {
                    descrizione += item.Name;
                }
                return descrizione;
            }
            set => descrizione = value;
        }
        public override double Price
        {
            get
            {
                foreach (IIngrediente item in ingredienti)
                {
                    prezzo += item.Price;
                }
                return prezzo;
            }
            set => prezzo = value;
        }
        public void Add(IIngrediente ingrediente)
        {
            this.ingredienti.Add(ingrediente);
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
