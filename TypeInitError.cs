using System;

namespace Snippet_14
{
    class TypeInitError
    {
        static TypeInitError()
        {
            throw new ApplicationException("This grogram throws TypeInitializationException error.");
        }
        static void Main(string[] args)
        {
            try
            {
                TypeInitError objType = new TypeInitError();
            }
            catch(TypeInitializationException objEx)
            {
                Console.WriteLine("Error: {0}", objEx);
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: {0}", objEx);
            }
        }
    }
}
