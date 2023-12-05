using System;

namespace ConsoleApp
{
    public partial class Customer
    {
        public string GetFullName()
        {
            return _lastName + ", " + _firstName;
        }
    }
}
