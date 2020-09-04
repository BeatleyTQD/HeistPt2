using System;

namespace heist2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure()
        {
            if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ReconReport()
        {
            if (AlarmScore > VaultScore && AlarmScore > SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Alarm");
            }
            else if (VaultScore > AlarmScore && VaultScore > SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Vault");
            }
            else
            {
                Console.WriteLine("Most Secure: Security Guards");
            }

            if (AlarmScore < VaultScore && AlarmScore < SecurityGuardScore)
            {
                Console.WriteLine("Least Secure: Alarm");
            }
            else if (VaultScore < AlarmScore && VaultScore < SecurityGuardScore)
            {
                Console.WriteLine("Least Secure: Vault");
            }
            else
            {
                Console.WriteLine("Least Secure: Security Guards");
            }
        }
    }
}