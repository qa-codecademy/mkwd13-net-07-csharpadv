namespace NullableValues
{
    public class Person
    {
        public int Id { get; set; } //default 0

        //nullable int as type, has default value null
        //Score can get any whole number as a value, but it can also get null
        public int? Score { get; set; } //default is null

        public bool IsStudent { get; set; } //default value is false

        //IsEmployed can get true, false or null as values
        //nullable bool as type
        public bool? IsEmployed { get; set; }//default is null

        public string Name { get; set; } //default is null

        public List<int> Numbers { get; set; } //default value is null, this is a reference type - we need to create an empty list in the constructor if we want to use this list
    }
}
