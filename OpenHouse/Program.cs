using System;
using System.Threading;
namespace OpenHouse
{
    class Program
    {
        static void TypeWrite(string message, int delayByMilliseconds)
        {
            foreach (char letter in message)
            {
                Thread.Sleep(delayByMilliseconds);
                Console.Write(letter);
            }

        }
        static void Main(string[] args)f
        {
            TypeWrite("Welcome to the open House! ", 40);
            TypeWrite("Would you like to come inside? ", 40);
            Console.WriteLine();
            string response = Console.ReadLine();

            if (response.ToUpper() == "Y" || response.ToUpper() == "YES")
            {
                TypeWrite("Come on inside! ", 40);
                TypeWrite("Let's see the living room first. ", 40);
                TypeWrite("The room is painted grey and there's a big couch, a love seat, a tv, and a coffee table. ", 100);
                TypeWrite("Do you like this? ", 40);
                string response1 = Console.ReadLine();

                if (response1.ToUpper() == "Y" || response1.ToUpper() == "YES")
                {
                    TypeWrite("I'm glad you like it! ", 40);
                    TypeWrite("Now lets go see the kitchen next! ", 40);
                    TypeWrite("In the kitchen there's a large table, a gas powered stove, and a large kitchen counter. ", 40);
                    TypeWrite("Could you see yourself living in a house with this kind of kitchen? ", 40);
                    string response2 = Console.ReadLine();

                    if (response2.ToUpper() == "Y" || response2.ToUpper() == "YES")
                    {
                        TypeWrite("I do think this would be a great fit for you! ", 40);
                    }
                    else
                    {
                        TypeWrite("Well maybe you can change it up if you get the house. ", 140);
                    }
                    TypeWrite("I'm going to take you to the Master bedroom now.", 40);
                    TypeWrite("In the Master bedroom there is a king sized bed, 2 closets, a large bathroom and a tv stand. ", 40);
                    TypeWrite("Would this bedroom make you happy? ", 40);
                    string response3 = Console.ReadLine();

                    if (response3.ToUpper() == "Y" || response3.ToUpper() == "YES")
                    {
                        TypeWrite("I'm glad you like it! ", 40);
                        TypeWrite("Now we'll go to the final rooms of the house, the guest bedrooms. then we'll go to the basement. ", 40);
                        TypeWrite("Both guest rooms look the same, but one is just a little bigger. ", 40);
                        TypeWrite("There's enough room for a queen sized bed in each room, a dresser and a bedside table. ", 40);
                        TypeWrite("Do you like the look of this? ", 40);
                        string response4 = Console.ReadLine();

                        if (response4.ToUpper() == "Y" || response4.ToUpper() == "YES")
                        {
                            TypeWrite("Excellent! I think this house would be a great fit for you! ", 40);

                        }
                        else
                        {
                            TypeWrite("Well maybe these rooms can become something different! ", 40);

                        }
                        Console.ReadLine();

                    }
                    else
                    {
                        TypeWrite("Well you can change it up however you like! ", 40);
                    }
                    Console.ReadLine();
                }
                else
                {
                    TypeWrite("Well if you don't like this room then you won't like the rest of the house, so you might as well leave. Bye!", 40);
                }
                Console.ReadLine();
            }
            else
            {
                TypeWrite("Okay then, bye. You're no fun.", 100);
            }
            Console.ReadLine();



        }
    }
}
