using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortageManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
