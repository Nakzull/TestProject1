using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class ATM
    {
        Account account = new Account(10000, "12345678", "1111");
        ValidationManager validationManager = new ValidationManager();
        string enteredPin = "1234";
        bool pinChcker = true;
        bool withdrawChecker = true;
        double withdrawRequest = 4000;

        public double WithdrawAmount(double withdrawAmount)
        {
            if (pinChcker == true)
            {
                if (withdrawChecker == true)
                {
                    double newbalance = account.balance - withdrawAmount;
                    return newbalance;
                }
                return account.balance;
            }
            else
                return account.balance;
        }

        public void PinCheck()
        {
            if (validationManager.CheckPin(account.GetPin(), enteredPin) == true)
            {
                pinChcker = true;
            }
            else
                pinChcker = false;
        }

        public void WithdrawRequestChecker()
        {
            if (validationManager.CheckBalance(withdrawRequest, account.balance) == true)
                withdrawChecker = true;
            else
                withdrawChecker = false;
        }
    }


}
