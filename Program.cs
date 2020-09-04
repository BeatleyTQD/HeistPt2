using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            //used for adding new member at the beginning
            bool nameCheck = true;
            //used for adding members to heist
            bool crewCheck = true;
            //Cut for heist
            int heistProfits = 100;

            Random rand = new Random();

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
            Akai.PercentageCut = 50;

            Muscle HeavyWeaponsGuy = new Muscle();
            HeavyWeaponsGuy.Name = "HeavyWeaponsGuy";
            HeavyWeaponsGuy.SkillLevel = 66;
            HeavyWeaponsGuy.PercentageCut = 50;

            Muscle FatTimAllen = new Muscle();
            FatTimAllen.Name = "FatTimAllen";
            FatTimAllen.SkillLevel = 19;
            FatTimAllen.PercentageCut = 33;

            LockSpecialist Genichiro = new LockSpecialist();
            Genichiro.Name = "Genichiro";
            Genichiro.SkillLevel = 81;
            Genichiro.PercentageCut = 0;

            //List of team members to choose from.///////////
            List<IRobber> rolodex = new List<IRobber>()
            {
                Strongbad,
                Schwartz,
                Akai,
                HeavyWeaponsGuy,
                FatTimAllen,
                Genichiro
            };

            //User constructed team for the heist.////////////
            List<IRobber> crew = new List<IRobber>();

            Console.WriteLine("I knew we'd see you again...funds dryin' up?");
            Console.WriteLine($"There are currently {rolodex.Count} operatives in your black book. \n");

            //Prompts continue until user enters no name for a new robber.
            while (nameCheck)
            {
                Console.WriteLine("Got some new blood in mind?");
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
                    //changes set of prompts and class generation based on user choice
                    switch (choice)
                    {
                        case "1":
                            Hacker newHacker = new Hacker();
                            newHacker.Name = Name;

                            Console.WriteLine("\nA hacker, eh...they any good? On, like, an arbitrary integer based scale of 1 - 100?");
                            int SkillLevel = int.Parse(Console.ReadLine());
                            newHacker.SkillLevel = SkillLevel;

                            Console.WriteLine("\nI'll take your word for it...how much they want? Again, in an arbitrary 1-100 percentage kinda way");
                            int PercentageCut = int.Parse(Console.ReadLine());
                            newHacker.PercentageCut = PercentageCut;

                            rolodex.Add(newHacker);
                            break;

                        case "2":
                            Muscle newMuscle = new Muscle();
                            newMuscle.Name = Name;

                            Console.WriteLine("\nA Muscle, eh...they any good? On, like, an arbitrary integer based scale of 1 - 100?");
                            SkillLevel = int.Parse(Console.ReadLine());
                            newMuscle.SkillLevel = SkillLevel;

                            Console.WriteLine("\nI'll take your word for it...how much they want? Again, in an arbitrary 1-100 percentage kinda way");
                            PercentageCut = int.Parse(Console.ReadLine());
                            newMuscle.PercentageCut = PercentageCut;

                            rolodex.Add(newMuscle);
                            break;

                        case "3":
                            LockSpecialist newLockSpecialist = new LockSpecialist();
                            newLockSpecialist.Name = Name;

                            Console.WriteLine("\nA LockSpecialist, eh...they any good? On, like, an arbitrary integer based scale of 1 - 100?");
                            SkillLevel = int.Parse(Console.ReadLine());
                            newLockSpecialist.SkillLevel = SkillLevel;

                            Console.WriteLine("\nI'll take your word for it...how much they want? Again, in an arbitrary 1-100 percentage kinda way");
                            PercentageCut = int.Parse(Console.ReadLine());
                            newLockSpecialist.PercentageCut = PercentageCut;

                            rolodex.Add(newLockSpecialist);
                            break;

                    }

                }
            }
            Console.WriteLine("\nWell, let's get started then...\n");
            Console.ReadLine();

            //Generates a new bank with random security values.
            Bank newBank = new Bank();
            newBank.AlarmScore = rand.Next(0, 101);
            newBank.VaultScore = rand.Next(0, 101);
            newBank.SecurityGuardScore = rand.Next(0, 101);
            newBank.CashOnHand = rand.Next(50_000, 1_000_000);
            newBank.ReconReport();

            Console.WriteLine("~^*~^*~^*~^*Rogue Gallery*^~*^~*^~*^~");
            foreach (IRobber member in rolodex)
            {
                int i = rolodex.IndexOf(member);
                Console.Write($"{i}.) ");
                member.RolodexReport();
            }
            Console.WriteLine("\nNow that you know who you've got to pick from, let's get to work...");

            while (crewCheck)
            {
                Console.Write("\nWho do you want to add?: ");
                string crewChoice = Console.ReadLine();
                if (crewChoice == "")
                {
                    crewCheck = false;
                }
                else
                {
                    int crewChoiceNum = int.Parse(crewChoice);
                    crew.Add(rolodex[crewChoiceNum]);
                    heistProfits -= rolodex[crewChoiceNum].PercentageCut;
                    Console.WriteLine($"\n{heistProfits}");
                    rolodex.RemoveAt(crewChoiceNum);
                    foreach (IRobber member in rolodex)
                    {
                        if (member.PercentageCut < heistProfits)
                        {
                            int i = rolodex.IndexOf(member);
                            Console.Write($"{i}.) ");
                            member.RolodexReport();
                        }
                        else
                        {
                            int i = rolodex.IndexOf(member);
                            Console.WriteLine($"{i}.) Sorry bub, they're too expensive.");

                        }
                    }
                }

            }

            Console.WriteLine("\n~^*~^*~^*~^*Your Team*^~*^~*^~*^~");
            foreach (IRobber member in crew)
            {
                member.RolodexReport();
            }
            Console.WriteLine("Let's get to work!");
            Console.ReadLine();

        }

    }
}