using System;

namespace ClassExample
{
    class Program
    {
        public static Person obj = new Person();
        public static Person obj1 = new Person();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Please enter position ");
            string position = Console.ReadLine();
            Console.WriteLine("Please enter salary ");
            string salary = Console.ReadLine();
            Console.WriteLine("please enter department");
            string department = Console.ReadLine();

            int newsalary = Convert.ToInt32(salary);

            obj.SetMember(position, newsalary, department);

            obj.GetMember(out position, out newsalary, out department);
            Console.WriteLine("position: " + position + " salary " + newsalary);

            Console.WriteLine("Please enter name for Obj1 ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter age Obj1");
            age = Console.ReadLine();

            newAge = Convert.ToInt32(age);

            obj1.SetMember(name, newAge);
            obj1.GetMember(out name, out newAge);
            Console.WriteLine("Name: " + name + " Age " + newAge);
        }
    }
}
