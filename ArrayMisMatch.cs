using System;

namespace Snippet_2
{
    class ArrayMisMatch
    {
        static void Main(string[] args)
        {
            string[] names = { "James", "Jack", "Peter" };
            int[] id = { 10, 11, 12 };
            double[] salary = { 1000, 2000, 3000 };
            float[] bonus = new float[3];
            try
            {
                salary.CopyTo(bonus, 0);
            }
            catch(ArrayTypeMismatchException objType)
            {
                Console.WriteLine("Error: " + objType);
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: " + objEx);
            }
        }
    }
}
