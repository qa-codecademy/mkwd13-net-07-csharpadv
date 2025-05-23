namespace Qinshift.SerializeDeserialize.Entities
{

    public class OurJsonSerializer
    {
        public string SerializeStudent(Student student)
        {
            string json = "{";
            json += $@"""FirstName"" : ""{student.FirstName}"",";
            json += $@"""LastName"" : ""{student.LastName}"",";
            json += $@"""Age"" : {student.Age},";
            json += $@"""IsPartTime"" : {student.IsPartTime.ToString().ToLower()}";
            json += "}";
            return json;
        }

        /*
            {
                "FirstName": "Bob",
                "LastName": "Bobsky",
                "Age": 23,
                "IsPartTime": false
            }
        */

        public Student DeserializeStudent(string json)
        {
            // Cleaning up our json
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(',');

            // Creating dictionary with clean keys (properties) and values
            Dictionary<string, string> propertiesDictionary =
                new Dictionary<string, string>();

            foreach (string property in properties)
            {
                string[] pair = property.Split(':');
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            // Creating a Student object with the values from the dictionary
            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }
    }
}
