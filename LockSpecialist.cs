using System;

namespace HeistPartTwo
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= 50;
            Console.WriteLine($"{Name} is cracking the vault. Decreased security 50 points");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked open the vault!");
            }
        }
    }
}