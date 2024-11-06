using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IUser
    {
        public double Withbraw(double SizeOfWithdrow);

        public double Recive(double SizeOfRecive);

        public double ShowBalance(int Id);

        
    }
}
