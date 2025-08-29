using System.Security.Cryptography.X509Certificates;

namespace day6
{
    class person
    {

        //Create a Person class with name, age, and a method Introduce()
        public string name;
        public int age;

        public void Introduce()
        {
            Console.WriteLine($"Hello i'm {name} and my age is :{age}");
        }
    }
    class student
    {
        //Implement a Student class with static count of students
        public string Section;
        public int Rollnum;
        public static int Count;
        public student(string section,int rollnum)

        {
            Section = section;
            Rollnum = rollnum;
            Count++;
        }
        public void Studetails()
        {
            Console.WriteLine($"students in {Section} and Roll numbers are :{Rollnum}");
        }


    }

     class program 
    {
        public static void Main(string[] args)
        {
            person meth = new person();
            meth.name = "Devika";
            meth.age = 23;
            meth.Introduce();
            student s1 = new student("A", 001);
            s1.Studetails();
            student s2 = new student("B", 002);
            s2.Studetails();
            student s3 = new student("C", 003);
            s3.Studetails();
            student s4 = new student("D", 004);
            s4.Studetails();
            Console.WriteLine($"Number of students are {student.Count}");
        }
    }

}
