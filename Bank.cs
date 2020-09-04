namespace heist2
{
    public class Bank
    {
        private int CashOnHand {get; set;}
        private int AlarmScore {get; set;}
        private int VaultScore {get; set;}
        private int SecurityGuardScore {get; set;}

        private bool IsSecure() 
        {
            if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
            {
                return false;
            } else {
                return true;
            }
        }
    }
}