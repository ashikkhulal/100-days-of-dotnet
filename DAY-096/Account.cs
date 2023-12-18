using System;
using System.Threading;

namespace ConsoleApp
{
    public class Account
    {
        double _balance;
        int _id;

        public Account(int id, double balance) 
        {
            this._id = id;
            this._balance = balance;
        }

        public int Id { get { return _id; } }
        public double Balance { get { return _balance; } }

        public void Withdraw(double amount) 
        {
            this._balance -= amount;
        }

        public void Deposit(double amount)
        {
            this._balance += amount;
        }
    }
}
