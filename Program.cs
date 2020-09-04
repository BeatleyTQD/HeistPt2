using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nameCheck = true;

            Hacker Strongbad = new Hacker();
            Strongbad.Name = "StrongBad";
            Strongbad.SkillLevel = 33;
            Strongbad.PercentageCut = 25;

            Hacker Schwartz = new Hacker();
            Schwartz.Name = "Schwartz";
            Schwartz.SkillLevel = 8;
            Schwartz.PercentageCut = 1;

            Muscle Akai = new Muscle();
            Akai.Name = "Akai";
            Akai.SkillLevel = 81;
            Akai.PercentageCut = 41;

            Muscle HeavyWeaponsGuy = new Muscle();
            HeavyWeaponsGuy.Name = "HeavyWeaponsGuy";
            HeavyWeaponsGuy.SkillLevel = 66;
            HeavyWeaponsGuy.PercentageCut = 12;

            Muscle FatTimAllen = new Muscle();
            FatTimAllen.Name = "FatTimAllen";
            FatTimAllen.SkillLevel = 19;
            FatTimAllen.PercentageCut = 33;

            LockSpecialist Genichiro = new LockSpecialist();
            Genichiro.Name = "Genichiro";
            Genichiro.SkillLevel = 81;
            Genichiro.PercentageCut = 41;

            List<IRobber> rolodex = new List<IRobber>()
            {
                Strongbad,
                Schwartz,
                Akai,
                HeavyWeaponsGuy,
                FatTimAllen,
                Genichiro
            };

            Console.WriteLine($"There are currently {rolodex.Count} operatives in your black book.");

            while (nameCheck)
            {
                Console.Write("Do you have a recruit in mind?: ");
                string newRecruit = Console.ReadLine();

            }
        }
    }
}