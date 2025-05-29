using System.Reflection.Metadata.Ecma335;

namespace SerializationAndDeserialization
{
    public static class CustomSerializerAndDeserializer
    {
        public static string SerializeStudent(Student student)
        {
            //we are trying to convert our student into JSON format which is key value pairs where the key is a string
            string json = "{";
            json += $"\"FirstName\" : {student.FirstName},";
            json += $"\"LastName\" :{student.LastName},";
            json += $"\"Age\" :{student.Age},";
            json += $"\"IsPartTime\" :\"{student.IsPartTime.ToString().ToLower()}\"";
            json += "}";
            return json;
        }

        public static Student DeserializeStudent (string json)
        {
            //clean the json string from unnecessary characters
            //we use substring to get only the content between the {}
            //we dont want to include the {} that's why we go one char before/after

            //{"FirstName" :"Petko", "LastName":"Petkovski", "Age":25, "IsPartTime":"false"}
            string content = json.Substring(json.IndexOf("{") + 1, json.IndexOf("}") -1)
                .Replace("\n", "")
                .Replace("\r", "")
                .Replace("\"", ""); //we want to remove the empty lines and the "

            //FirstName :"Petko", LastName:"Petkovski", Age:25, IsPartTime:false
            string[] properties = content.Split(",");
            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();
            foreach (string property in properties)
            {
                string[] pair = property.Split(":"); //we split the property by : to get the key and the value
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim()); //we are adding our key and our value in the dictionary
            }

            //Creating a Student object with the values from the dictionary
            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"]; //we are using the key to access the value
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]); //potential error in parsing,  safest way is to use TryParse
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]); //potential error in parsing, safest way is to use TryParse

            return student;
        }
    }
}
