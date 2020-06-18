using System;

namespace Snippet_8
{
    class Employee
    {
        static void ThrowException(string name)
        {
            if(name == null)
            {
                throw new ArgumentNullException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Throw Example");
            try
            {
                string empName = null;
                ThrowException(empName);
            }
            catch(ArgumentNullException objNull)
            {
                Console.WriteLine("Exception caught: " + objNull);
            }
        }
    }
}
