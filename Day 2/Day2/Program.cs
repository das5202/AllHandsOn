using System.Transactions;

namespace Data
{
    class Day2
    {
        public static void Main(string[] args)
        {
            //Variables & Data Types Problems
            //Simple Variable Declaration & Print
            int a = 20;
            float b = 20.5f;
            char c = 'D';
            String d = "Devika";
            Console.WriteLine($"{a}, {b} ,{c},{d}");
            Console.WriteLine("a:{0},b:{1},c:{2},d:{3}",a,b,c,d);
            Console.WriteLine("a:" +a+" "+ "b:" +b);
            //Addition of Two Numbers
            Console.WriteLine("Enter first value:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Value:");
            int second = Convert.ToInt32(Console.ReadLine());
            int add = first + second;
            Console.WriteLine($"Addition of Two Numbers:{add}");
            //Area of a Circle
            Console.WriteLine("Enter Radius of circle");
            int r=Convert.ToInt32(Console.ReadLine());
            int Area = Convert.ToInt32(Math.PI* r * r);
            Console.WriteLine("Area of a circle:"+Area);
            //Simple Interest Calculation
           // SI = (P * R * T) / 100
            Console.WriteLine("Enter Principal");
            int Prin =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest");
            int Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Peiord of time");
            int time= Convert.ToInt32(Console.ReadLine());
            int Simpleinterest = (Prin * Rate * time) / 100;
            Console.WriteLine("Simple Interest :"+Simpleinterest);
            //Swapping Two Variables (Using 3rd Variable)
            Console.WriteLine("Enter fist variale");
            int firstv=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Variable");
            int Secondv=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swap:{firstv},{Secondv}");

            int temp = firstv;
            firstv = Secondv;
            Secondv = temp;
            Console.WriteLine($"After Swap:{firstv},{Secondv}");

           // without using 3rd variable
             //a=   a+b
             // b=  a-b
             //   a=a-b
            // Operators (Arithmetic, Logical, Comparison) Problems


            int numb1 = 10;
            int numb2 = 20;
            Console.WriteLine("Sum of 2 :"+(numb1 + numb2));
            Console.WriteLine("Diff of 2:"+(numb1- numb2));
            Console.WriteLine("Product of 2:" + (numb1 * numb2));
            Console.WriteLine("Quotient of 2:" + (numb1 / numb2));
            Console.WriteLine("Remainder of 2:" + (numb1 % numb2));
            Console.WriteLine("a <b" + (numb1 < numb2));
            Console.WriteLine("a>b" + (numb1 > numb2));
            Console.WriteLine("a=b"+(numb1==numb2));
            Console.WriteLine("a!=b"+(numb1!=numb2));
            // Logical Operations (AND, OR, NOT)
            Console.WriteLine("Enter a number :");
            int compNum=Convert.ToInt32(Console.ReadLine());

            bool isbetween = compNum >=10 && compNum <=20;
            if(!isbetween)
            {
                Console.WriteLine($"Entered Number {compNum} is not inbetween 10 and 20");
            }
            else
            {
                Console.WriteLine($"Entered number {compNum} is between 10 and 20");
            }


            //Even or Odd Check
            Console.WriteLine("Enter a number:");
                int evnod=Convert.ToInt32(Console.ReadLine());
            int dev = evnod % 2;
            if (dev == 0)
            {
                Console.WriteLine($"Entered number{evnod} is even");
            }
            else
            {
                Console.WriteLine($"Entered number{evnod} is odd");
            }
            //Max of Three Numbers (Nested Ternary or if-else)
            Console.WriteLine("ENter first number FisNU");
            int FisNu=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter first number SecNU");
            int SecNu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter first number ThirNU");
            int ThirNU = Convert.ToInt32(Console.ReadLine());

            int largest = (FisNu > SecNu) ? 
                (FisNu > ThirNU ? FisNu : ThirNU) :
                (SecNu> ThirNU?SecNu: ThirNU);
            Console.WriteLine($"Largest Number is {largest}");


            //Type Casting & Conversion
            Console.WriteLine("Enter a decimal Number:");
            decimal dec=Convert.ToDecimal(Console.ReadLine());
            int intvar = (int)dec;
            int intanoth=Convert.ToInt32(dec);
            Console.WriteLine($"Decimal number is {dec} and int number is explicit {intvar} , convertclass {intanoth}");
            //String to Integer Conversion
            Console.WriteLine("Enter age as string input");
            string s = Console.ReadLine();
            int conage = Convert.ToInt32(s);
            if(conage>=18)
            {
                Console.WriteLine("Eligible");

            }
            else
            {
                Console.WriteLine("Not Eligible");
            }

            //String to Boolean Conversion (using bool.Parse)
            Console.WriteLine("Do you agree with me enter only true/false");
            string agdis=Console.ReadLine();
            bool agreedisag=bool.Parse(agdis);
            if(agreedisag=true)
            {
                Console.WriteLine("User agreed:" + (agreedisag));
            }
            else
            {
                Console.WriteLine("User agreed:" + (agreedisag));
            }
        }
    }
}