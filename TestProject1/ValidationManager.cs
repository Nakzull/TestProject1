using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class ValidationManager
    {
        public bool CheckPin(string cardPin, string enteredPin)
        {
            if (cardPin == enteredPin)
                return true;
            else
                return false;
        }

        public bool CheckBalance(double withdrawAmount, double balance)
        {
            if (withdrawAmount <= balance)
                return true;
            else
                return false;
        }
    }
}
