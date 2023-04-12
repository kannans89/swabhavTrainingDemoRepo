using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AccountCounterApp.Model
{
    internal class Account
    {
        private readonly int _accouno;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        private static int _instanceCount=100;


        static Account() {
            _instanceCount = 100;
            Console.WriteLine("inside static constructor");
        
        }
        public Account(int accno, string name,
            double balance)
        {
            Console.WriteLine("inside normal constructor");
            _balance = balance;
            _name = name;
            _accouno = accno;
            _instanceCount += 1;
        }

        public Account(int accno,string name)
            : this(accno, name, MIN_BALANCE)
        {
            
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

        public int InstanceCount {
            get {
               
                return _instanceCount;
            }
        }

        public static int HeadCount() {
            
            return _instanceCount;
        }
    }
}
