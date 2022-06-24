using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Card
    {
         public string cardNumber;
         public string pin;

        public Card(string cardnumber, string pincode)
        {
            cardNumber = cardnumber;
            pin = pincode;
        }
    }
}
