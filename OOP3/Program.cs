using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            TransportCreditManager transporterCreditManager = new TransportCreditManager();
            MortageManager mortageManager = new MortageManager();
            ApplicationManager applicationManager = new ApplicationManager();

            ILoggerService fileLogerService = new FileLoggerService();
            applicationManager.Apply(mortageManager,new DataBaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {mortageManager,personalFinanceCreditManager };
            //applicationManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
