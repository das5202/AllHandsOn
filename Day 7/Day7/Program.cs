using System.Runtime.Intrinsics.X86;

namespace enacap
{
    class bankAccount
    {
        //Implement a BankAccount class with private balance and deposit/withdraw methods


        private int balance;
        //Random blance =new Random(10000,20000)

        public bankAccount()
        {
            Random random = new Random();
            balance = random.Next(10000, 20001);
        }
        public void deposit(int money)
        {

            balance += money;
        }
        public void withdraw(int money)
        {


            if (balance >= money)
            {
                balance -= money;
            }
            else
            {
                Console.WriteLine("Insuffiencient Balance");
            }
        }
        public int getBalance()
        {
            return balance;
        }

    }
    class EmployeeDetails
    {
        //Use properties to manage employee details securely
        private string name;
        private int id;
        private int salary;
        public string Employename
        {
            get { return name; }
            set { name = value; }
        }
        public int Employid
        {
            get { return id; }
            set { id = value; }
        }
        public int Employesalary
        {
            get { return salary; }
            set { salary = value; }
        }
    }


   
        class program
        {
            public static void Main(string[] args)
            {
                bankAccount b = new bankAccount();
                Console.WriteLine($"Your current Balance:{b.getBalance()}");
                Console.WriteLine("Enter Deposit amount");
                int dep = Convert.ToInt32(Console.ReadLine());
                b.deposit(dep);
                Console.WriteLine($"Your current Balance:{b.getBalance()}");
                Console.WriteLine("Enter withdraw amount");
                int with = Convert.ToInt32(Console.ReadLine());
                b.withdraw(with);
                Console.WriteLine($"Your current Balance:{b.getBalance()}");
            EmployeeDetails emp = new EmployeeDetails();
            Console.WriteLine("Enter Employee Name:");
            emp.Employename = Console.ReadLine();
            Console.WriteLine("Enter Employee Id:");
            emp.Employid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary:");
            emp.Employesalary =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Employe Name:{emp.Employename},Employe Id :{emp.Employid},Employe Salary:{emp.Employesalary}");






        }
        }

    
}
