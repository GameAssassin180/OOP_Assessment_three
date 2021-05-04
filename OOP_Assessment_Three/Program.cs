using System;

namespace OOP_Assessment_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            Player human = new Human();
            Player computer = new Computer();
            while (true)// starts a loop that will continue till the user is finished or the deck is empty.
            {
                Console.Write("\nPress Enter to draw a card");
                string keypress = Console.ReadLine();
                if (keypress == "")
                {
                    Console.WriteLine(human.HandList[0].cardName);
                    Console.WriteLine(human.HandList[1].cardName);
                    Console.WriteLine(human.HandList[2].cardName);
                    Console.WriteLine(human.HandList[3].cardName);
                    Console.WriteLine(human.HandList[4].cardName);
                    Console.WriteLine(human.HandList[5].cardName);
                    Console.WriteLine(human.HandList[6].cardName);
                    Console.WriteLine(human.HandList[7].cardName);
                    Console.WriteLine(human.HandList[8].cardName);
                    Console.WriteLine(human.HandList[9].cardName);
                    Console.WriteLine("");
                    Console.WriteLine(computer.HandList[0].cardName);
                    Console.WriteLine(computer.HandList[1].cardName);
                    Console.WriteLine(computer.HandList[2].cardName);
                    Console.WriteLine(computer.HandList[3].cardName);
                    Console.WriteLine(computer.HandList[4].cardName);
                    Console.WriteLine(computer.HandList[5].cardName);
                    Console.WriteLine(computer.HandList[6].cardName);
                    Console.WriteLine(computer.HandList[7].cardName);
                    Console.WriteLine(computer.HandList[8].cardName);
                    Console.WriteLine(computer.HandList[9].cardName);
                }
                else
                {
                    Console.WriteLine("Invalid entry please try again"); // catches the uesrs invalid input.
                    continue;
                }
            }
        }
    }
}