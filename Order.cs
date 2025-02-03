using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10257582_prg2assignment
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime TimeReceived { get; set; }
        public DateTime? TimeFulfilled { get; set; }
        public List<IceCream> IceCreamList { get; set; }
        public Order() { }
        public Order(int id, DateTime tr)
        {
            ID = id;
            TimeReceived = tr;
        }
        public void ModifyIceCream(int id)
        {

        }
        public void AddIceCream(IceCream icecream)
        {

        }
        public void DeleteIceCream(int id)
        {

        }
        public double CalculateTotal()
        {
            return 0;
        }
        public override string ToString()
        {
            return "ID: " + ID +
                "\tTimeReceived: " + TimeReceived +
                "\tTimeFulfilled: " + TimeFulfilled +
                "\tIceCreamList: " + IceCreamList;
        }
    }
}
