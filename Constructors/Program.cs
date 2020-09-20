using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Default Constructor:");
            DefaultConstructor ctorDfault = new DefaultConstructor();
            Console.WriteLine(ctorDfault.val1);// Output: Val 1 
            Console.WriteLine(ctorDfault.val2); //Output: Val 
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine("Paramaterized Constructor:");
            ParameterizedConstructor ctorParameterized = new ParameterizedConstructor("Stefan", "Brunotte");
            Console.WriteLine(ctorParameterized.firstName); //Stefan
            Console.WriteLine(ctorParameterized.lastName); //Brunotte
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine("Static And Instance Constructor:");
            StaticConstructor ctorStatic = new StaticConstructor();
            Console.WriteLine(ctorStatic.value1);
            Console.WriteLine(ctorStatic.value2);
            Console.WriteLine("-----------------------------\n");

            Console.WriteLine("Private Constructor");
            PrivateConstructor ctorPrivate = new PrivateConstructor("stefan", "brunotte");
            Console.WriteLine(ctorPrivate.fName);
            Console.WriteLine(ctorPrivate.lName);
            Console.WriteLine("-----------------------------\n");

        }
        //DEFAULT CONSTRUCTOR
        class DefaultConstructor
        {
            public string val1, val2;
            public DefaultConstructor() //Default constructor
            {
                this.val1 = "Val 1";
                this.val2 = "Val 2";
            }
        }
        //PARAMETERIZED CONSTRUCTOR
        class ParameterizedConstructor
        {
            public string firstName, lastName;
            public ParameterizedConstructor(string aFirstName, string aLastName) // Parameterized Constructor
            {
                this.firstName = aFirstName;
                this.lastName = aLastName;
            }
            
        }
        //STATIC CONSTRUCTOR
        class StaticConstructor
        {
            public string value1, value2;
            static StaticConstructor() //STATIC Constructor
            {
                // Initialize field that needs to be executed once
                Console.WriteLine("This is a Static constructor, and is only invoked once!");
            }

            public StaticConstructor() // Instance constructor (Default)
            {
                this.value1 = "This is the instance (default) constructor";
                this.value2 = "Instance/default constructor is invoked everytime an object is created.";
            }
        }

        //PRIVATE COSTRUCTOR
        class PrivateConstructor
        {
            public string fName, lName;
            public PrivateConstructor(string aFName, string aLName)
            {
                this.fName = aFName.ToUpper();
                this.lName = aLName;
            }
            private PrivateConstructor()
            {
                Console.WriteLine("This is private constructor that restrict instantiation.");
            }
        }
    }
}
