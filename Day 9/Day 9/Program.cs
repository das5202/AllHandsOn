using System.Security.Cryptography.X509Certificates;

namespace day9
{
    class vehicle
    {
        //Create a Vehicle class and a Car class inheriting from it


        public void Brand()
        {
            Console.WriteLine("In vehicles so many brands are there");

        }
        public void speed()
        {
            Console.WriteLine("Speed of the brand car depends on the engine");
        }
        public virtual void startEngine()
        {
            Console.WriteLine("Engine will start when turn on key");
        }

    }
    class car : vehicle
    {
        // Override a StartEngine() method in the Car class
        public void carbrand()
        {
            Console.WriteLine("The brand of our car is Audi");
        }
        public void carspeed(int speed)
        {
            Console.WriteLine($"Speed of Audi car is {speed}");
        }
        public override void startEngine()
        {
            Console.WriteLine("Audi engine will start after gviing key");
        }
    }

    class progam
        {
        public static void Main(string[] args)
        {
            car c = new car();
            c.Brand();
            c.carbrand();
           c.speed();
           c.carspeed(200);
           c.startEngine();
          
            
        }
        }
}
