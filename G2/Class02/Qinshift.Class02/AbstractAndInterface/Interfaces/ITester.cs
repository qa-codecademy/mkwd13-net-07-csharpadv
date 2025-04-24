namespace AbstractAndInterface.Interfaces
{
    public interface ITester : IHuman
    {
        void DocumentBugs();
        void WriteTestCases();
        bool FoundBug();
    }
}
