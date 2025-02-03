using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10257582_prg2assignment
{
    public class Customer
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public DateTime DOB { get; set; }
        public Order CurrentOrder { get; set; }
        public List<Order> OrderHistory { get; set; }
        public PointCard Rewards { get; set; }

        public Customer() { }
        public Customer(string name, int id, DateTime dob)
        {
            Name = name;
            MemberID = id;
            DOB = dob;
        }
        /*public Order MakeOrder()
        {
            return ;
        }*/
        public bool IsBirthday()
        {
            if (CurrentOrder.TimeReceived == DateTime.Now)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "Name: " + Name +
                "\tMemberID: " + MemberID +
                "\tDOB: " + DOB +
                "\tCurrentOrder: " + CurrentOrder +
                "\tOrderHistory: " + OrderHistory +
                "\tRewards: " + Rewards;
        }
    }
}
