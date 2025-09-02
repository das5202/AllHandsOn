namespace day10
{
    abstract class Animal
    {
        //Create an abstract class Animal and implement Dog and Cat classes
        public abstract void sound();
        
    }
    class cat:Animal
    {
        public override void sound()
        {
            Console.WriteLine("Cat is Making sound Meow");
        }
    }
    class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog is making sound Bow");
        }
    }

    interface IShape
    {
        public void Area();
        public void Perimeter();
    }
    class Circle : IShape
    {
        public int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public void Area()
        {
            double x = Math.PI * radius * radius;
            Console.WriteLine($"Area of circle :{x}");
        }
        public void Perimeter()
        {
           double  y= 2*Math.PI * radius;
            Console.WriteLine($"Perimeter of circle :{y}");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            cat c= new cat();   
            c.sound();
            Dog d = new Dog();
            d.sound();
            //Animal a1 = new Cat();
            //Animal a2 = new Dog();
            //a1.sound();
            //a2.sound();
            IShape s = new Circle(3); //or Circle s= new Circle(3);
            s.Area();
            s.Perimeter();


        }
    }
}