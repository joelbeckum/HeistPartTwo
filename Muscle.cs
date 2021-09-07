using System;

namespace HeistPartTwo
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= 50;
            Console.WriteLine($"{Name} is handling the security guards. Decreased security 50 points");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has taken out all the guards!");
            }
        }
    }
}