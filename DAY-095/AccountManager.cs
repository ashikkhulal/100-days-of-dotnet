using System;
using System.Threading;

namespace ConsoleApp
{
    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;

        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.Id.ToString());
            lock (_fromAccount) 
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action from 1 second sleep and trying to acquire lock on " + _fromAccount.Id.ToString());
                lock (_toAccount) 
                {
                    Console.WriteLine("This code will not execute due to deadlock!");
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }

            }
        }
    }
}
