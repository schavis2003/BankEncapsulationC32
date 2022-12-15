using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;  //The must important part is the protect the privacy and can't be maniputlated or modified.

        //Define a method maned Deposit that will accept a 
        //double and store that value in the balance field.

        //My NOTES: This is called Encapsulation method.
        public void Deposit(double amount)
        {
            balance = amount;
        }

        //Define a method named GetBalance that will return the amount stored in the balance field.
        public string GetBalance()
        {
            return $"${balance}";
        }

    }
}
