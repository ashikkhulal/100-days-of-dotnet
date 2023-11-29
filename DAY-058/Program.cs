using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            // Before overriding

            //int i = 10;
            //int j = 20;
            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));

            //Direction D1 = Direction.East;
            //Direction D2 = Direction.South;

            //Console.WriteLine(D1 == D2);
            //Console.WriteLine(D1.Equals(D2));

            Customer C1 = new Customer();
            C1.FirstName = "John";
            C1.LastName = "Doe";

            //Customer C2 = C1;

            //// Reference equality represents value equality
            //Console.WriteLine(C1 == C2);
            //Console.WriteLine(C1.Equals(C2));

            Customer C3 = new Customer();
            C3.FirstName = "John";
            C3.LastName = "Doe";

            //// Value equality does not represent reference equality
            //Console.WriteLine(C1 == C3);
            //Console.WriteLine(C1.Equals(C3));

            // After overriding

            Console.WriteLine(C1 == C3);
            Console.WriteLine(C1.Equals(C3));
        }
    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            if (!(obj is Customer) )
            {
                return false;
            }

            return FirstName == ((Customer)obj).FirstName && LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}