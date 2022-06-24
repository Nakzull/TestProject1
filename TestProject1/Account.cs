using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Account
    {
        public int balance;
        Card card;

        public void AddCard(string cardNumber, string pin)
        {
            Card newCard = new Card(cardNumber, pin);
        }

        public Account(int balance, string cardNumber, string pin)
        {
            this.balance = balance;
            card = new Card(cardNumber, pin);
        }

        public string GetPin()
        {
            return card.pin;
        }
    }
}
