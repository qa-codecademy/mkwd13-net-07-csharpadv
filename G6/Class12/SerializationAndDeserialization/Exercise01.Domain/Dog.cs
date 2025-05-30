namespace Exercise01.Domain
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Dog(string name, string color, int age)
        {
            Name = name;
            Color = color;  
            Age = age;
        }
    }
}
