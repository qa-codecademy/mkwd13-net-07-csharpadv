using AbstractAndInterface.Interfaces;

namespace AbstractAndInterface.Entities
{
    public class Tester : Human, ITester
    {
        public Tester(string fullName, int age, long phoneNumber, int bugsFound)
            : base(fullName, age, phoneNumber)
        {
            BugsFound = bugsFound;
        }

        public int BugsFound { get; set; }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"{feature} is being tested....");
            Console.WriteLine("Testing completed!");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {BugsFound} bugs found so far!";
        }

        public void DocumentBugs()
        {
            Console.WriteLine($"The tester has documented {BugsFound} bugs!");
        }

        public void WriteTestCases()
        {
            Console.WriteLine("The tester is writing test cases for the bugs...");
        }

        public bool FoundBug()
        {
            return BugsFound > 0;
        }
    }
}
