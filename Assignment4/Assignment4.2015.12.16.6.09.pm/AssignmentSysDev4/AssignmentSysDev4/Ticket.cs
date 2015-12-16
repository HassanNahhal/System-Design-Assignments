using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{
    /// <summary>
    /// The ticket class employs different cancellation strategies, set up in individual classes
    /// The use of the stragegy pattern for this would, potentially, allow other characteristics
    /// of the different ticket classes to be set up.  
    /// </summary>
    public class Ticket
    {
        private string ticketNumber;
        private DateTime purchaseDate;

         private CancelStrategy _cancelstrategy;

        public void SetCancelStrategy(CancelStrategy cancelstrategy)
        {
            this._cancelstrategy = cancelstrategy;
        }


        public void Cancel()
        {
            _cancelstrategy.Cancel(this);
          
        }



        public DateTime PurchaseDate
        {
            get
            {
                return purchaseDate;
               
            }
            set
            {
                purchaseDate = value;
            }
        }

    }

    public abstract class CancelStrategy
    {
        public abstract bool Cancel(Ticket ticketToCancel);
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// This stragegy class allows an Economy ticket's purchase price to be refunded if it is cancelled within 24 hours of purchase.  
    /// </summary>
    class EconomyCancel : CancelStrategy
    {
        public override bool Cancel(Ticket ticketToCancel)
        {
            int hoursToCancelForEconomy = 24;

            DateTime CurrentTime = DateTime.Now;

            if ((CurrentTime - ticketToCancel.PurchaseDate).TotalHours <= hoursToCancelForEconomy)
            {
                Console.WriteLine("Economy Ticket price can be refunded if cancelled now.");
                return true;
            }
            else
            {
                Console.WriteLine("Economy Ticket price can not be refunded cancelled now.");
                return false;
            }
            
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// This strategy class allows a Premium Economy ticket's price to be refunded if the ticket is cancelled within 48 hours of purchase.  
    /// 
    /// </summary>
    class PremiumEconomyCancel : CancelStrategy
    {
        public override bool Cancel(Ticket ticketToCancel)
        {
            DateTime CurrentTime = DateTime.Now;
            int hoursToCancelForPremium = 48;

            if ((CurrentTime - ticketToCancel.PurchaseDate).TotalHours <= hoursToCancelForPremium)
            {
                Console.WriteLine("Premium Economy Ticket price can be refunded if cancelled now.");
                return true;
            }
            else
            {
                Console.WriteLine("Premium Economy Ticket price can not be refunded if cancelled now.");
                return false;
            }
           
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// This strategy class allows the purchase price of Business class tickets to be refunded if the ticket is cancelled within 96 hours, i.e. four days of puchase
    /// </summary>
    class BusinessClassCancel : CancelStrategy
    {
        public override bool Cancel(Ticket ticketToCancel)
        {
            DateTime CurrentTime = DateTime.Now;
            int hoursToCancelForBusiness = 96;

            if ((CurrentTime - ticketToCancel.PurchaseDate).TotalHours <= hoursToCancelForBusiness)
            {
                Console.WriteLine("Business Class Ticket price can be refunded if cancelled now.");
                return true;
            }
            else
            {
                Console.WriteLine("Business Class Ticket can not be refunded if cancelled now.");
                return false;
            }            
        }
    }   

}

