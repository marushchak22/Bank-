using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вітаю ви потрапили в НазарБанк!");

            User user = new User(100);

            Console.WriteLine("Якщо ви хочете зняти кошти натисніть 1 якщо покласти то 2 якщо переглянути баланс 3");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine("скільки грошей ви хочете зняти з балансу?");
                    user.Withbraw(1000);
                    break;
                case 2:
                    Console.WriteLine("скільки грошей ви хочете покласти на баланс?");
                    user.Recive(1000);
                    break;
                case 3:
                    user.ShowBalance(1);
                    break;

            }Console.ReadKey();
        }
        


       
    }
}

