using System;
using System.Collections.Generic;
using System.Text;

namespace MenuInterattivo.Model
{
    public class Cibo
    {
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual double Price { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return base.Equals(obj);
            }
            var other = obj as Cibo;
            return string.Compare(Identifier(this),
                Identifier(other)) == 0;
        }
        public override string ToString()
        {
            return $"Name: {Name} Description: {Description} Price: {Price}";
        }
        private string Identifier(Cibo cibo)
        {
            return cibo.Name;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) ^ Name.GetHashCode();
                hash = (hash * 23) ^ Description.GetHashCode();
                hash = (hash * 23) ^ Price.GetHashCode();
                return hash;
            }
        }
    }
}
