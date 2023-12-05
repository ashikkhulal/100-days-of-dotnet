using System;

namespace ConsoleApp
{
    public partial class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
    }
}
