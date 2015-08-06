using System;

namespace RoslynTestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var temp = ClassWithStaticField.Dictionary;

                Console.WriteLine(temp["String1"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
