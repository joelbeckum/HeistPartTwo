using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Hacker()
                {
                    Name = "Codin Joe",
                    SkillLevel = 40,
                    PercentageCut = 15
                },
                new Hacker()
                {
                    Name = "Sally Clicks",
                    SkillLevel = 45,
                    PercentageCut = 18
                },
                new LockSpecialist()
                {
                    Name = "Susie Picks",
                    SkillLevel = 35,
                    PercentageCut = 10
                },
                new LockSpecialist()
                {
                    Name = "John Dedondon",
                    SkillLevel = 55,
                    PercentageCut = 30
                },
                new Muscle()
                {
                    Name = "Huggy Bear",
                    SkillLevel = 60,
                    PercentageCut = 20
                }
            };
        }
    }
}
