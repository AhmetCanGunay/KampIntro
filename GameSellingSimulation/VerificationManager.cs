using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation
{
    class VerificationManager : IEdevletVerification
    {
        public void EDevletVerification(EDevletUserData userData)
        {
            Console.WriteLine("Verification successful : {0}",userData.FirstName);
        }
    }
}
