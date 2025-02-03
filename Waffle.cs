using s10257582_prg2assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10257582_prg2Assignment
{
    public class Waffle:IceCream
    {
        public string WaffleFlavour { get; set; }

        public Waffle() { }

        public Waffle(string option, int scoops, List<Flavour> f, List<Topping> t,string wf) : base(option, scoops, f, t)
        {
            WaffleFlavour = wf;
        }
        public override double CalculatePrice()
        {
            if (base.Scoops == 1)
            {
                return 7;
            }
            else if(base.Scoops == 2)
            {
                return 8.5;
            }
            return 9.5;
        }

    }
}
