using System;

namespace DogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = null;
            try
            {
                dog = new Dog("poot", 1);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("error, recovering");
                dog = new Dog("poot", 1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("error, recovering");

            }
            dog.age = -1;
        }
    }
}
