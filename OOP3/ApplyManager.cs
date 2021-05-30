using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        public void BasvuruYap(ILoanManager krediManager,IloggerService ıloggerService)
        {

            //basvuru bilgi degerlendirme
            
            krediManager.Calculate();

            ıloggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ILoanManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }


        }

    }
}
