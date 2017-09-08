using System;

namespace ForIterationDavis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Sometimes you will have to loop through a series of items & checks until find a match
            //Do this more than you will anticipate
            //WARNING: THIS SYNTAX IS VERY COMPLEX!!!

            //"int i = 0" is creating a variable called 'i' and setting it to zero
            //"i < 10" is evaluate and ask is i less than 10?
            //"i++" increment operator, equal to writing "i = i + 1;"/Adds 1 when statement is executed
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i.ToString());
                //this code will run until "i < 10" is no longer true, then it will stop and skip to next
                //code line
                //The above Console will prints #'s 0 through 9

                if (i == 7) 
                {
                    Console.WriteLine("Found seven!");
                    break;
                    //The "break;" will stop the for loop automatically so i = 8, etc. will not be evaluated
                    //Here "break;" will cause the code to immediately go to "Console.ReadLine();"
                }
            }

            //Type "for" then hit tab key for the automatic structure of the for loop below. This is a code "snippet"
            //Now you can replace the "i's" and other things with your own characters, 
            //and "max" here with a number
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
        }
    }
}
