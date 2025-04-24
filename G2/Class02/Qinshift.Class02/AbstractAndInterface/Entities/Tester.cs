namespace AbstractAndInterface.Entities
{
    public class Tester : Human
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
    }
}
