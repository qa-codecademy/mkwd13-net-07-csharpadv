namespace Qinshift.SerializeDeserialize
{
    /*
        {
            "FirstName": "Bob",
            "LastName": "Bobsky",
            "Age": 40,
            "IsPartTime": false
        }
    */
    public class OurJsonSerializer
    {
        public string SerializeStudent(Student student)
        {
            string json = string.Empty;
            json += "{";
            json += $"\"FirstName\": \"{student.FirstName}\",";
            json += $"\"LastName\": \"{student.LastName}\",";
            json += $"\"Age\": {student.Age},";
            json += $"\"IsPartTime\": {student.IsPartTime.ToString().ToLower()}";
            json += "}";
            return json;
        }

        /*
            {
                "FirstName": "Bob",
                "LastName": "Bobsky",
                "Age": 40,
                "IsPartTime": false
            }
        */
        public Student DeserializeStudent(string studentJson)
        {
            // Cleaning the json 
            string content = studentJson
                .Substring(studentJson.IndexOf('{') + 1, studentJson.IndexOf('}') - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(',');

            Dictionary<string, string> propertiesDictionary = new();

            foreach (string property in properties)
            {
                string[] pair = property.Split(':');
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            // Creating dictionary with clean keys (properties) and values
            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }
    }
}
