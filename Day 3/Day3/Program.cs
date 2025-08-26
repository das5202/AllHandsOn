using System;

namespace day2
{
    class devika
    {
        public static void Main(String[] args)
        {
            //Write a program to check if a number is prime 
            Console.WriteLine("Enter a number to check whether prime or not:");
            int pr = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            if (pr <= 1)
            {
                isprime = false;

            }
            else
            {
                
                    for (int i = 2; i <= Math.Sqrt(pr); i++)
                    {
                        if (pr % i == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }

                
            }
            if (isprime) { Console.WriteLine($"entered number {pr} is prime"); }
            else { Console.WriteLine($"Entered number {pr} is not prime"); }




            //Implement a simple number guessing game

            Random random = new Random();
            int sectretnum = random.Next(1, 101);
            bool isguesssecret = true;
            int attempt = 0;
            int guessnum = 0;
            Console.WriteLine("welcome to guess number game!");
            Console.WriteLine("enter a number between 1 to 100:");

            while (sectretnum != guessnum)
            {
                guessnum = Convert.ToInt32(Console.ReadLine());
                attempt++;
                if (guessnum > sectretnum)
                {
                    Console.WriteLine("Entered number is greater than the correct one");

                }
                else if (guessnum < sectretnum)
                {
                    Console.WriteLine("Entered number is less than the correct one");

                }
                else
                {
                    Console.WriteLine($" your guessed the {sectretnum} in {attempt} ");
                }

            }

            //Write a simple calculator using switch-case that performs +, -, , / —

            int a = 10;
            int b = 20;
            Console.WriteLine("Enter the operator + - * / %");
            char o = Convert.ToChar(Console.ReadLine());
            int c = 0;
            switch (o)
            {
                case '+':
                    Console.WriteLine("Addition of two numbers" + (a + b));
                    break;

                case '-':

                    Console.WriteLine("Subtraction of two numbers" + (a - b));
                    break;
                case '*':

                    Console.WriteLine("Multiplication of two numbers" + (a * b));
                    break;

                case '/':
                    Console.WriteLine("Division of two numbers" + (a / b));
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }
        }
    }

}
     

