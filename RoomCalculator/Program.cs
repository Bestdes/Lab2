using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double roomLength;
            double roomWidth;
            double roomHeight;
            Boolean flag = true;
            Boolean flag2 = true;

            while (flag) {

                Console.WriteLine("What is the length of the room?");
                String input = Console.ReadLine();

                roomLength = double.Parse(input);

                Console.WriteLine("What is the width of the room?");
                String input2 = Console.ReadLine();

                roomWidth = double.Parse(input2);

                Console.WriteLine("What is the height of the room?");
                String input3 = Console.ReadLine();

                roomHeight = double.Parse(input3);

                double areaOfRoom = roomLength * roomWidth;
                double perimeterOfRoom = (roomLength * 2) + (roomWidth * 2);
                double volumeOfRoom = roomWidth * roomLength * roomHeight;

                Console.WriteLine("The area of the room is: " + areaOfRoom);
                Console.WriteLine("The perimeter of the room is: " + perimeterOfRoom);
                Console.WriteLine("The volume of the room is: " + volumeOfRoom);

                while (flag2) {

                    Console.WriteLine("Continue? y/n");

                    String ifContinueInput = Console.ReadLine();

                    if (ifContinueInput == "y")
                    {
                        flag = true;
                        flag2 = false;
                    }

                    if (ifContinueInput == "n")
                    {
                        flag = false;
                        flag2 = false;
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid repsonse try again!");
                    }
                }
            }

        }
    }
}
