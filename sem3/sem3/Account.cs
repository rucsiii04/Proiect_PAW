using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sem3
{
   public class Account
    {
        private double _balance;
        
        public delegate void Operation(double amount);//delegat
        private Action<double> _operationUsingAction;//dc n aveam parametrii nu puneam nmc acl unde am double nici <>
        //echivalente^^^(dc erau ambele private sau public acu nu s)
        public event Operation  OnDeposit;//de fiecare data cand operation e apelat aleg dc 
        public event Operation OnWithdraw;

        private delegate double MultiplyBalance();//un delegat poate sa si returneze chestii
        private delegate double GetBonus();
        private Operation _operation;//am nev de o instanta a tipului definit anterior, a delegatului
        private MultiplyBalance _multiplyBalance;
        private GetBonus _getBonus;
       
        //delegati de tip actions-?>wrapper; doar catre delegati care returneaza tipul void; ex MultiplyBalance nu l pot transforma ina ctiune
      
        public Account()
        {
            _balance = 0;
        }
        public Account(double balance)
        {
            _balance = balance; 
            
        }
        private double DoubleValue()
        {
            return _balance * 2;
        }
        private double HalfValue()
        {
            return _balance / 2;
        }
        private void Deposit(double amount)
        {
            _balance += amount;
          
            OnDeposit?.Invoke(_balance);//semnul intrebarii verifica daca e null sa nu functia, echiv cu if ul de mai jos
        }
      private void Withdraw(double amount)
        {
            _balance -= amount;
            if(OnWithdraw!=null)
            OnWithdraw.Invoke(_balance);
        }
        private double Bonus_10()
        {
            return _balance * 1.1;
        }
        private double Bonus_15()
        {
            return _balance * 1.15;
        }

        public void Process(double amount)
        {
            if (amount % 2 == 0)
            {
            //_operation = Deposit;
                _multiplyBalance = DoubleValue;
                _operationUsingAction = Deposit;
            }
            else
            {
            //_operation = Withdraw; //pointeaza spre functie
                _multiplyBalance = HalfValue;
                _operationUsingAction = Withdraw;

            }

             //_operation(amount);//apelam functia
            _operationUsingAction(amount);
            var newAmount = _multiplyBalance();
            Console.WriteLine($"New amount is {newAmount}");
        }
        public void Operation_b()
        {
            if (_balance > 100)
            {
                _getBonus = Bonus_10;
            }
            else
            {
                _getBonus = Bonus_15;
            }
            var bonus = _getBonus();
            Console.WriteLine($"The bonus is {bonus}");
        }
        public override string ToString()
        {
            return $"This account has a balance of {_balance}";

        }

    }
}
//delegat care sa calculeze dc soldul este >100 sa returneze un bonus de 10%, dc sold<100 sa returneze un bonus de 15%