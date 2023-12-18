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

        // Approach 1: Acquiring locks in a specific defined order
        public void Transfer()
        {
            object _lock1, _lock2;
            if (_fromAccount.Id < _toAccount.Id)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }

            Console.WriteLine(Thread.CurrentThread.Name + " is trying to acquire lock on " + ((Account)_lock1).Id.ToString());
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock1).Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " is suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " is back in action from 1 second sleep and trying to acquire lock on " + ((Account)_lock2).Id.ToString());
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock2).Id.ToString());
                    Console.WriteLine("Transferring amount from account {0} to account {1} of amount ${2}", this._fromAccount.Id, this._toAccount.Id, this._amountToTransfer);
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);

                    Console.WriteLine("---Account Status:---");
                    Console.WriteLine("Account Id: {0}, Balance: ${1}", this._fromAccount.Id, this._fromAccount.Balance.ToString("0.00"));
                    Console.WriteLine("Account Id: {0}, Balance: ${1}", this._toAccount.Id, this._toAccount.Balance.ToString("0.00"));
                    Console.WriteLine("---------------------\n");
                }

            }
        }
    }
}
