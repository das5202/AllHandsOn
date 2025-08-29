using System;
using System.ComponentModel;
using System.Diagnostics;

namespace methods
{
    class Day5
    {
        public static void Main(String[] args)
        {
            //Implement Add() with int, float & double parameters
            Console.WriteLine("Implementing methods");
            Add d = new Add();
            d.add(2, 3);
            d.add(2.5f, 3.4);
            d.add(9.999, 8.999);
            calculator cal = new calculator();
            cal.calc(2,3);
            cal.calc(2.3f, 3.4f);
            cal.calc(2, 3,"*");
            statexam.stame("Devika", 23);
            
        }
        class Add
        {
            public void add(int x, int y)
            {
                Console.WriteLine("int method : "+ (x + y) );
            }
            public void add(float x, float y)
            {
                Console.WriteLine("Float method : " + (x + y));
            }
            public void add(double x, double y)
            {
                Console.WriteLine("double  method : " + (x + y));
            }
        }
        class calculator
        {
            public void calc(int x, int y)
            {
                Console.WriteLine(" calculator int : " + (x + y));
            }
            public void calc(float x, float y)
            {
                Console.WriteLine(" calculator Float :" + (x + y));
            }
            public void calc(int x, int y, string op)
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine("if + then : " + (x + y));
                        break;
                    case "-":
                        Console.WriteLine("if - then :  " + (x - y));
                        break;
                    case "*":
                        Console.WriteLine("if * then :" + (x * y));
                        break;
                    case "/":
                        if (y != 0)
                            Console.WriteLine("if / then : " + (x / y));
                        else
                            Console.WriteLine("cannot be divided by zero");
                        break;

                    default:
                        Console.WriteLine("Invalid Operator");
                        break;


                }
            }
        }
             class statexam
            {
                public static void stame(string name,int age)
                {
                    Console.WriteLine($"Hello my name is {name} and age is {age}");
                }
            }
           

        
    }
}
