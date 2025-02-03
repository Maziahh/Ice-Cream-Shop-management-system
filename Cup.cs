using s10257582_prg2assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10257582_prg2Assignment
{
    public class Cup : IceCream
    {
        public Cup() { }
        public Cup(string option, int scoops, List<Flavour> f, List<Topping> t) : base(option, scoops, f, t) { }
        public override double CalculatePrice()
        {
            if (base.Scoops == 1)
            {
                return 4;
            }
            else if(base.Scoops == 2)
            {
                return 5.5;
            }
            return 6.5;
            
        }
    }
}
