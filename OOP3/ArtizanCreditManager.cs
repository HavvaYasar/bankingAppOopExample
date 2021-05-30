using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtizanCreditManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Artizan credit calculated");
        }

        public void Method1()
        {
            throw new NotImplementedException();
        }
    }
}
