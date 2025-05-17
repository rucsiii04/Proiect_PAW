using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3
{
    public class Person
    {
        private string _name;
        private Account _account;
        public Person(string name,Account account)
        {
            _name = name;
            _account = account;
            _account.OnDeposit += OnDepositEventHandler;
            _account.OnWithdraw += OnWithdrawEventHandler;
        }

        private void OnWithdrawEventHandler(double amount)
        {
            Console.WriteLine($"User {_name} has now an amount of {amount} after the latest withdraw");
        }

        private void OnDepositEventHandler(double amount)
        {
            Console.WriteLine($"User {_name} has now an amount of {amount} after the latest deposit");

        }
        
        public void Process(double amount)
        {
            _account.Process(amount);
        }
    }
}
