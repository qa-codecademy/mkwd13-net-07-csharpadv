namespace Qinshift.Practices.GoodPractices
{
    /*
        *** LOOPS GOOD PRACTICES ***
        
         NOTE: 
         1. Use foreach whenever possible
         2. Don't request fixed values inside a loop, declare a variable outside with the value
         3. Use 'break' or 'continue' where there is a possibility 
         *** AVOID EXECUTION OF UNNECESSERY CODE *** 
         4. Don't make changes on the collections' length you are looping, inside the loop
    */

    internal class Loops
    {
        public List<string> Names = new List<string>() { "Bob", "Jordan", "Jill", "Greg", "Anne", "Maximilian" };

        // REQUIREMENT: Print the first Jordan
        public void PrintJordan()
        {
            // Bad example
            foreach (string name in Names)
            {
                if (name == "Jordan")
                {
                    Console.WriteLine(name);
                }
            }

            // Good example
            foreach (string name in Names)
            {
                if (name == "Jordan")
                {
                    Console.WriteLine(name);
                    break; // avoid unnecessery iterations (use break when needed)
                }
            }
        }

        // REQUIREMENT: Print all names that are the same length of the list
        public void PrintNames()
        {
            // Bad example
            for (int counter = 0; counter < Names.Count; counter++)
            {
                if (Names[counter].Length == Names.Count)
                {
                    Console.WriteLine(Names[counter]);
                }
            }

            // Good example
            int listLength = Names.Count;
            for (int counter = 0; counter < listLength; counter++)
            {
                if (Names[counter].Length == listLength)
                {
                    Console.WriteLine(Names[counter]);
                }
            }
        }

        // REQUIREMENT: Remove all names from the collection except the ones that start with the letter "J"
        public void RemoveNames()
        {
            // Bad example
            // can result in unexpected behavior and errors
            for (int i = 0; i < Names.Count; i++)
            {
                if (!Names[i].StartsWith('J'))
                {
                    Names.RemoveAt(i);
                }
            }

            // Good example
            List<string> namesToRemove = new List<string>();
            for (int j = 0; j < Names.Count; j++)
            {
                if (!Names[j].StartsWith('J'))
                {
                    namesToRemove.Add(Names[j]);
                }
            }

            foreach (var name in namesToRemove)
            {
                Names.Remove(name);
            }

            // Also good :)
            Names = Names.Where(n => n.StartsWith('J')).ToList();
        }

    }
}
