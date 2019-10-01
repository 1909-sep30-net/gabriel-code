using System;

namespace CSharpIntro
{
    class Program
    {
        static void doSomething(){
            Console.WriteLine("did something");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // make bool, string, int variables
            bool myBool = true;
            string str = "my string";
            int myInt = 42;

            // change their values
            myBool = false;
            str = "your string";
            myInt++;

            // print their values with console
            Console.WriteLine(myBool + " " + str + " " + myInt);
            
            // for loop
            for (int i=0;i<10;i++){
                myInt++;
            }


            // while loop
            while (myInt < 100){
                Console.Write('.');
                myInt++;
            }
            Console.WriteLine("");

            // switch statement
            int caseSwitch = 1;
            switch (caseSwitch){
                case 1: // if case switch == 1, falls through to 2 anyway
                case 2:
                    Console.WriteLine("case 2");
                    break;

                default:
                    Console.WriteLine("default case");
                    break;

            }

            // if, else if, else
            int a = 50;
            if (a > 50){
                Console.WriteLine("a > 50");
            } else 
            if (a < 50){
                Console.WriteLine("a < 50");
            } else {
                Console.WriteLine("a == 50");
            }

            // multi-line comments in C#

            /* 
            does
            this
            work?
            */

            // format document in VS Code

                // File -> Preferences -> Settings
                // actually::: alt+shift+f

            // extra: make new static method to do something, call it
            doSomething();

            // extra: learn what var means in C# and use it
                // an implicit type; the compiler decides the type, useful for when working with anonymous type variables
            var j = 10;
            

        }
    }
}
