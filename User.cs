using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Balance {  get; set; }



        public User(double Balance)
        {
         
            this.Balance = Balance;
       }

        public double ShowBalance(int Id)
        {
            return Balance;
            Console.WriteLine($"Ваш баланс {Balance}");
        }


        public double Withbraw(double SizeOfWithdrow)
        {
            double withdrow = Balance - SizeOfWithdrow;
            Balance = withdrow;
            return withdrow;

            Console.WriteLine($"Зняття успішне! Ваш баланс {Balance} ");
        }

        public double Recive(double SizeOfRecive)
        {
            double recive = Balance + SizeOfRecive;
            Balance = recive;
            Console.WriteLine($"Депозит успішний! Ваш баланс {this.Balance} ");
            return recive;
        }
    }
}
