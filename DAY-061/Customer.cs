using System;

namespace ConsoleApp
{
    public class FullCustomer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public string GetFullName()
        {
            return _lastName + ", " + _firstName;
        }
    }
}
