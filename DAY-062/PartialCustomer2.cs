using System;

namespace ConsoleApp
{
    // (X - all partial class parts needs to have same access modifiers)  internal partial class PartialCustomer
    // (if one partial class part is declared abstract, all parts of that partial class will be abstract) public abstract partial class PartialCustomer
    // (if one partial class part is declared sealed, all parts of that partial class will be sealed) public sealed partial class PartialCustomer
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _lastName + ", " + _firstName;
        }
    }
}
