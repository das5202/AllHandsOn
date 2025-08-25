using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
     class second
    {
        public void userDetails()
        {
            Console.WriteLine("Enter your name and Age");
            string Name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {Name} your age is {age}");


        }

    }
}
