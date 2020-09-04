using System;

namespace heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is knockin' noggins. Decreased security by {SkillLevel}.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has clobbered all the guards!");
            }
        }

        public void RolodexReport()
        {
            Console.WriteLine($"{Name}, The Muscle. Skill Level: {SkillLevel}. Asking Price: {PercentageCut}%.");
        }
    }
}