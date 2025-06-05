using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.OopAdv.Class15.Practices
{
    //BAD EXAMPLE
    class user
    {
        public int id;
        public string name;
        public bool valid;
        private string userPath;
        public void printUser() { }
    }

    //GOOD EXAMPLE
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }
        private string _userPath { get; set; }
        public void PrintUser() { }

        //BAD EXAMPLE EXCEPTION
        class LoginProblem : Exception {}
        //GOOD EXAMPLE EXCEPTION
        public class LoginException : Exception {}
    }
}
