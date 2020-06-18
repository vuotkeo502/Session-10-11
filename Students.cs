using System;

namespace Snippet_7
{
    class Students
    {
        string[] name = { "James", "John", "Alexander" };
        static void Main(string[] args)
        {
            Students objStudents = new Students();
            try
            {
                objStudents.name[4] = "Michael";
            }
            catch(Exception objException)
            {
                Console.WriteLine("Error: " + objException);
            }
        }
    }
}
