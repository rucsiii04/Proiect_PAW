using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            //account.Deposit(50);
            //account.Withdraw(20);
            //account.Process(50);
            //account.Process(21);
            Console.WriteLine(account.ToString());
            //account.Operation_b();
            Person ion = new Person("Ion",account);
            ion.Process(50);
            ion.Process(21);
            Console.WriteLine(account.ToString());

            Account companyAccount = new Account();
            Company google = new Company("Google", companyAccount);
            google.Process(1000);
            google.Process(211);
            Console.WriteLine(companyAccount.ToString());
        }
    }
}
//delegati=pointeri care pointeaza catre functii ;trb sa aiba aceeasi semnatura-tio returnat si parametri primiti
//Object->baza celorlalte obiecte; mostenesc membrii pe care i expune
//evenimente ->