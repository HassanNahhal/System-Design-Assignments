using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{
    /// <summary>
    /// The ticket class employs different cancellation strategies, set up in individual classes
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

        /*public void Add(string name)
        {
            _list.Add(name);
        }*/

        public void Cancel()
        {
            _cancelstrategy.Cancel(this);

            // Iterate over list and display results
            //foreach (string name in _list)
           // {
             //   Console.WriteLine(" " + name);
            //}
          //  Console.WriteLine("Ticket can be cancelled:" + );
        }



        public DateTime PurchaseDate
        {
            get
            {
                return purchaseDate;
                //throw new System.NotImplementedException();
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
            //list.Sort(); // Default is Quicksort

            DateTime CurrentTime = DateTime.Now;

            if ((CurrentTime - ticketToCancel.PurchaseDate).TotalHours <= 24)
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

            if ((CurrentTime - ticketToCancel.PurchaseDate).TotalHours <= 48)
            {
                Console.WriteLine("Premium Economy Ticket price can be refunded if cancelled now.");
                return true;
            }
            else
            {
                Console.WriteLine("Premium Economy Ticket price can not be refunded if cancelled now.");
                return false;
            }
            //list.ShellSort(); not-implemented
            //Console.WriteLine("ShellSorted list ");
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

            if ((CurrentTime - ticketToCancel.PurchaseDate).TotalHours <= 96)
            {
                Console.WriteLine("Business Class Ticket price can be refunded if cancelled now.");
                return true;
            }
            else
            {
                Console.WriteLine("Business Class Ticket can not be refunded if cancelled now.");
                return false;
            }
            //list.MergeSort(); not-implemented
            //Console.WriteLine("MergeSorted list ");
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
  //  class CancelTicket
  //  {
       // private Ticket _ticketToCancel;
     //   private CancelStrategy _cancelstrategy;

    //    public void SetCancelStrategy(CancelStrategy cancelstrategy)
     //   {
     //       this._cancelstrategy = cancelstrategy;
     //   }

        /*public void Add(string name)
        {
            _list.Add(name);
        }*/

    //    public void Cancel()
    //    {
      //      _cancelstrategy.Cancel(_ticketToCancel);

            // Iterate over list and display results
            //foreach (string name in _list)
           // {
             //   Console.WriteLine(" " + name);
            //}
          //  Console.WriteLine("Ticket can be cancelled:" + );
       // }
   // }

}

