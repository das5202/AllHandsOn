using System.ComponentModel;

namespace cosntructor
{
    //Implement a Car class with constructor overloading
    class car
    {
        public car()
        {
            Console.WriteLine("Hello i'm car ");
        }
        public car(string name)
        {
            
            Console.WriteLine(name);
        }
        public car(string name,int price)
        {
            
            Console.WriteLine($"{name},{price}");
        }
    }

//Write a Book class where objects initialize with constructor values
    class Book
    {
        public string BookName;
        public string AuthorName;
        public int Price;
        public Book(string bookName, string authorName, int price)
        {
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author: {AuthorName}, Price: {Price}");

        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            car c = new car();
            car c1= new car("Range Rover");
            car c2 = new car("Audi", 3500000);
            Book b = new Book("Atomic Habits", "san", 340);
            b.Display();
        }
    }
}