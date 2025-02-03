using s10257582_prg2assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10257582_prg2Assignment
{
    public class Cone:IceCream
    {
        public bool Dipped { get; set; }
        public Cone() { }
        public Cone(string option, int scoops, List<Flavour> f, List<Topping> t, bool dipped) : base(option, scoops, f, t)
        {
            Dipped = dipped;
        }
        public override double CalculatePrice()
        {
            if (base.Scoops == 1)
            {
                return 4;
            }
            else if (base.Scoops == 2)
            {
                return 5.5;
            }
            return 6.5;
        }
    }
}
