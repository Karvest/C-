using System;

namespace Domasno
{
    class Program
    {
        static void Main(string[] args)
        {
            //domasno od minatiot cas
            Console.WriteLine("=== Real Calculator ==="); 
            Console.WriteLine("Enter a number");
            int firstInputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int secondInputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator ( +, - , * , / )");
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Your result: {firstInputNumber} + {secondInputNumber} = " + (firstInputNumber + secondInputNumber));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {firstInputNumber} - {secondInputNumber} = " + (firstInputNumber - secondInputNumber));
                    break;
                case "*":
                    Console.WriteLine($"Your result: {firstInputNumber} * {secondInputNumber} = " + (firstInputNumber * secondInputNumber));
                    break;
                case "/":
                    Console.WriteLine($"Your result: {firstInputNumber} / {secondInputNumber} = " + (firstInputNumber / secondInputNumber));
                    break;
            }

            Console.WriteLine("=== Average Number ===");
            Console.WriteLine("Enter a number");
            int firstAverageNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int secondAverageNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third number");
            int thirdAverageNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a forth number");
            int forthAverageNumber = int.Parse(Console.ReadLine());
            int sumAverageNumber = firstAverageNumber + secondAverageNumber + thirdAverageNumber + forthAverageNumber;
            Console.WriteLine($"The average of your numbers is: {sumAverageNumber / 4} ");

            Console.WriteLine("=== Swap ===");
            Console.WriteLine("Enter a number");
            int firstSwapNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int secondSwapNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your first number is: {firstSwapNumber}");
            Console.WriteLine($"Your second number is: {secondSwapNumber}");
            Console.WriteLine("Type Swap And watch the magic happen");
            Console.ReadLine();
            firstSwapNumber = firstSwapNumber * secondSwapNumber;
            secondSwapNumber = firstSwapNumber / secondSwapNumber;
            firstSwapNumber = firstSwapNumber / secondSwapNumber;
            Console.WriteLine($"Now your first number is: {firstSwapNumber}");
            Console.WriteLine($"And your second number is: {secondSwapNumber}");

            // Domasno od ovoj cas

            Console.WriteLine("=== Sum Of Even ===");
            int[] userArray = new int[6];
            int sumEvenNumbers = 0;
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                userArray[i] = int.Parse(Console.ReadLine());
                if (userArray[i] % 2 == 0)
                {
                  sumEvenNumbers += userArray[i];
                }
                
            }
            Console.WriteLine($"Sum of the even numbers is {sumEvenNumbers}");

            Console.WriteLine("=== Student Group ===");

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentG2 = { "Ace", "Marko", "David", "Gabi", "Ana", "Maja" };
            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            int studentGroup = int.Parse(Console.ReadLine());
            if (studentGroup == 1)
            {
                foreach(string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            if (studentGroup == 2)
            {
                foreach(string student in studentG2)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
