using System;
using System.Collections;

namespace UndoFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack directionsStack = new Stack();

            string input = null;

            while (input != "E")
            {
                PrintInstructions();
                input = Console.ReadLine();

                if (input == "D")
                {
                    Console.WriteLine("Type in the direction");
                    input = Console.ReadLine();
                    directionsStack.Push(input);
                    PrintStack(directionsStack);
                }
                else if(input == "U")
                {
                    if (directionsStack.Count > 0)
                    {
                        string removedItem = Convert.ToString(directionsStack.Peek());
                        directionsStack.Pop();
                        Console.WriteLine($"{ removedItem } has been removed from the directions list");
                        PrintStack(directionsStack);
                    }
                    else
                    {
                        Console.WriteLine("Unable to Undo, Stack is Empty");
                    }

                }
                else if(input == "E")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Option, please try again");
                }

            }

            Console.ReadLine();
        }

        public static void PrintInstructions()
        {
            Console.WriteLine("Press D to enter new direction, U to cancel last entry and E to quit the program");
        }


        public static void PrintStack(Stack stack)
        {
            Console.WriteLine("LIST OF DIRECTIONS");
            Object[] arrayStack = stack.ToArray();

            for (int i = arrayStack.Length; i > 0; i--)
            {
                Console.WriteLine(arrayStack[i-1]);
            }

        }


    }
}
