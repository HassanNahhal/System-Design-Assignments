using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    abstract class PropertySquare : Square
    {
        private int price;
        public int Price
        {
            get { return price; }
        }
        //By expert law, AttemptPurchase is at player's member.
        protected Player owner;
        public Player Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        protected PropertySquare(int index, string name, int price)
            : base(index, name)
        {
            this.price = price;
        }

        public override void LandedOn(Player curPlayer)
        {
            Console.WriteLine(curPlayer.Name + " arrived at " + this.name);
            BuyProperty(curPlayer);
        }

        public virtual void BuyProperty(Player curPlayer)
        {
            if ((this.owner == null) || (curPlayer == this.owner))
            {
                curPlayer.AttemptPurchase(this);
            }
            else if (curPlayer != this.owner)
            {
                PayRent(curPlayer);
            }
        }

        //By polymorphisms, GetRent will be implemented child class
        abstract public int GetRent();
        private bool PayRent(Player curPlayer)
        {
            int r;
            r = this.GetRent();
            this.owner.AddCash(r);
            if (curPlayer.ReduceCash(r) == false)
            {
                return false;
            }
            return true;
        }
    }
}
