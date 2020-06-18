using System;

namespace Snippet_15
{
    public class CustomMessage : Exception
    {
        public CustomMessage(string message) : base(message)
        {

        }
    }
    public class CustomException
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomMessage("This illustractes creation and catching of custom exception");
            }
            catch(CustomMessage objCustom)
            {
                Console.WriteLine(objCustom.Message);
            }
        }
    }
}
