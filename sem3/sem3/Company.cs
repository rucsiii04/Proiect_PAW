using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3
{
    public class Company
    {
        private string _name;
        private Account _account;
        public Company(string name,Account account)
        {
            _name = name;
            _account = account;
            account.OnWithdraw +=OnWithdrawEventHandler;
        }

        private void OnWithdrawEventHandler(double amount)
        {
            Console.WriteLine($"Company {_name} doesn't care about withdraws");
            
        }
        public void Process(double amount)
        {
            _account.Process(amount);
        }
       
    }
}
