using System;
using PTCGA = ProjectA.TeamC.GroupA;
using PTCGB = ProjectA.TeamC.GroupB;


namespace ProjectA
{
    class Program
    {
        static void Main(string[] args) 
        {
            TeamA.ClassA.Print();
            ProjectA.TeamB.ClassA.Print();
            PTCGA.ClassA.Print();
            PTCGB.ClassB.Print();

        }
    }

    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method...");
            }
        }
    }
}


namespace ProjectA.TeamB
{
    class ClassA
    {
        public static void Print()
        {
            Console.WriteLine("Team B print method...");
        }
    }
}

namespace ProjectA.TeamC
{
    namespace GroupA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team C Group A print method...");
            }
        }
    }

    namespace GroupB
    {
        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine("Team C Group B print method...");
            }
        }
    }

}

// All the namespaces fall under ProjectA and it has been further separated into TeamA, TeamB and TeamC, which has GroupA and GroupB.