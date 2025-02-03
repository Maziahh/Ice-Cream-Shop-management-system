using s10257582_prg2Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10257582_prg2assignment
{
    public abstract class IceCream
    {
        public string Option { get; set; }
        public int Scoops { get; set; }
        public List<Flavour> flavours { get; set; }
        public List<Topping> toppings { get; set; }
        public IceCream() { }
        public IceCream(string option, int scoops, List<Flavour> f, List<Topping> t)
        {
            Option = option;
            Scoops = scoops;
            flavours = f;
            toppings = t;
        }
        public abstract double CalculatePrice();

    }
}
