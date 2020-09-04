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
            Console.WriteLine("I knew we'd see you again...funds dryin' up?");
            Console.WriteLine($"There are currently {rolodex.Count} operatives in your black book. \n");

            while (nameCheck)
            {
                Console.Write("Got some new blood in mind?: ");
                string Name = Console.ReadLine();
                if (Name == "")
                {
                    nameCheck = false;
                }
                else
                {
                    Console.WriteLine("\nThis ain't a daycare, what are they bringin' to the table? ");
                    Console.WriteLine("Choose one:");
                    Console.WriteLine("1.) Hacker,\n2.) Muscle,\n3.) LockSpecialist");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Hacker newHacker = new Hacker();
                            newHacker.Name = Name;

                            Console.Write("\nA hacker, eh...they any good? On, like, an arbitrary integer based scale of 1 - 100?: ");
                            int SkillLevel = int.Parse(Console.ReadLine());
                            newHacker.SkillLevel = SkillLevel;

                            Console.Write("\nI'll take your word for it...how much they want? Again, in an arbitrary 1-100 percentage kinda way: ");
                            int PercentageCut = int.Parse(Console.ReadLine());
                            newHacker.PercentageCut = PercentageCut;

                            rolodex.Add(newHacker);
                            break;

                        case "2":
                            Muscle newMuscle = new Muscle();
                            newMuscle.Name = Name;

                            Console.Write("\nA Muscle, eh...they any good? On, like, an arbitrary integer based scale of 1 - 100?: ");
                            SkillLevel = int.Parse(Console.ReadLine());
                            newMuscle.SkillLevel = SkillLevel;

                            Console.Write("\nI'll take your word for it...how much they want? Again, in an arbitrary 1-100 percentage kinda way: ");
                            PercentageCut = int.Parse(Console.ReadLine());
                            newMuscle.PercentageCut = PercentageCut;

                            rolodex.Add(newMuscle);
                            break;

                        case "3":
                            LockSpecialist newLockSpecialist = new LockSpecialist();
                            newLockSpecialist.Name = Name;

                            Console.Write("\nA LockSpecialist, eh...they any good? On, like, an arbitrary integer based scale of 1 - 100?: ");
                            SkillLevel = int.Parse(Console.ReadLine());
                            newLockSpecialist.SkillLevel = SkillLevel;

                            Console.Write("\nI'll take your word for it...how much they want? Again, in an arbitrary 1-100 percentage kinda way: ");
                            PercentageCut = int.Parse(Console.ReadLine());
                            newLockSpecialist.PercentageCut = PercentageCut;

                            rolodex.Add(newLockSpecialist);
                            break;

                    }

                }
            }
            foreach (IRobber member in rolodex)
            {
                Console.WriteLine($"{member.Name}, {member.SkillLevel}, {member.PercentageCut}");
            }
        }

    }
}