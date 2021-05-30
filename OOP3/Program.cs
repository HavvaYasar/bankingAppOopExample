using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager ihtiyacKrediManager = new PersonalFinanceCreditManager();
            
            ILoanManager tasitKrediManager = new CarLoanManager();
            
            ILoanManager konutKrediManager = new HomeLoanManager();

            IloggerService dataBaseLoggerService = new DataBaseLoggerService();

            IloggerService fileLoggerService = new FileLoggerService();

            IloggerService smsLoggerService = new SmsLoggerService();

            ApplyManager basvuruManager = new ApplyManager();

            basvuruManager.BasvuruYap(new ArtizanCreditManager(),new SmsLoggerService() );

            List<ILoanManager> krediler = new List<ILoanManager>() //list to review multiple credit types

            {
                ihtiyacKrediManager,tasitKrediManager,konutKrediManager,new ArtizanCreditManager()
            };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.ReadLine();
        }
    }
}
