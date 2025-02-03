using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s10257582_prg2assignment
{
    public class PointCard
    {
        public int Points { get; set; }
        public int PunchCard { get; set; }
        public string Tier { get; set; }
        public PointCard() { }
        public PointCard(int point, int pc)
        {
            Points = point;
            PunchCard = pc;
        }
        public void AddPoints(int point)
        {
            Points = Points + point;
        }
        public void RedeemPoints(int punchcard)
        {
            Points -= punchcard;
        }
        public void Punch()
        {

        }
        public override string ToString()
        {
            return "Points: " + Points +
                "\tPunchCard: " + PunchCard +
                "\tTier: " + Tier;
        }
    }
}
