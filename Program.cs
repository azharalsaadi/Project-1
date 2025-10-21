namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 - Write a C# program to print the first 10 even numbers.
            Console.WriteLine("The First 10 even numbers are :");

            for (int i = 1; i <= 10; i++)
            {
                int evenNumber = i * 2;
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------");

            //2 - Write a C# program to print the first 15 Fibonacci numbers.
            int n1 = 0, n2 = 1, n3, i, count = 15;

            Console.WriteLine("The first 15 Fibonacci numbers are:");
            Console.Write(n1 + " " + n2 + " ");

            for (i = 3; i <= count; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //3 - Write a C# program to print the first 10 powers of 2.
            int baseNumber = 2;

            Console.WriteLine("The first 10 powers of 2 are:");

            for (int i = 0; i < 10; i++)
            {
                double result = Math.Pow(baseNumber, i);
                Console.WriteLine($"2^{i} = {result}");
            }

            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //4-Write a C# program to find the largest number in an array of integers.
            int[] numbers = { 5, 12, 3, 19, 7, 8 };

            // نفترض أن أول عنصر هو الأكبر
            int largest = numbers[0];

            // نبحث في بقية المصفوفة
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine("The largest number in the array is: " + largest);
            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");


            //5-Write a C# program to print a pattern of stars.(Square)
            int size = 5; // حجم المربع

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); // للسطر الجديد بعد كل صف
            }

            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //6-Write a C# program to check if a given number is prime or not.
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }

            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //7 - Write a C# program to calculate the sum of the digits of a given integer
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = Math.Abs(number); // نتأكد أن العدد موجب

            while (temp > 0)
            {
                sum += temp % 10; // نضيف الرقم الأخير
                temp /= 10;       // نحذف الرقم الأخير
            }

            Console.WriteLine($"The sum of the digits of {number} is: {sum}");
            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //8-Write a C# program to reverse a string..
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine("Reversed string: " + reversed);
            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //9-Write a C# program to count the number of vowels in a given string.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower(); // نجعل كل الحروف صغيرة لتسهيل المقارنة

            int vowelCount = 0;
            string vowels = "aeiou";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //10-Write a C# program to find the sum of all even numbers from 1 to 100.
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all even numbers from 1 to 100 is: " + sum);
            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");

            //11-Write a C# program to find the factorial of a number.
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"The factorial of {number} is: {factorial}");
            Console.ReadKey();

            Console.WriteLine("----------------------------------------------------------");


            //12-Write a C# program to sort an array of integers in ascending order
            int[] numbers = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            // Sort the array in ascending order
            Array.Sort(numbers);

            Console.WriteLine("\n\nArray after sorting in ascending order:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
