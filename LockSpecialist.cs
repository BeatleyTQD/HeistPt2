using System;

namespace heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is crackin' the code. Decreased security by {SkillLevel}.");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has popped all the locks!");
            }
        }

        public void RolodexReport()
        {
            Console.WriteLine($"{Name} The Lock Specialist. Skill Level: {SkillLevel}. Asking Price: {PercentageCut}%.");
        }
    }
}