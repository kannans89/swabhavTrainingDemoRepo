using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AccountApp.Model
{
    internal class Account
    {
        private readonly int _accouno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;

        public Account(int accno, string name, double balance)
        {
            _balance = balance;
            _name = name;
            _accouno = accno;
        }

        public Account(int accno, string name) {
            _accouno = accno;
            _name = name;
            _balance = MIN_BALANCE;
        }

        public void Deposit(double amount) { 
        
           _balance+=amount;
        }

        public void Withdraw(double amount) {
           
            if (HasSufficientFunds(amount))
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("ERROR:No funds");
               
            }
        }

        private bool HasSufficientFunds(double withawAmount) {
            double amountAfterWithdraw = _balance - withawAmount;
            return amountAfterWithdraw >= MIN_BALANCE;
        }
        public double Balance {
            get { 
              return _balance;
            }
        }
        public double Accouno
        {
            get {
                return _accouno;
            }
        }

        public string Name {
            get {
                return _name;
            }
        }
    }
}
