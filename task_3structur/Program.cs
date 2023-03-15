using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3structur
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("enter a employee-id :");
            emp.empId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your Name:");
            emp.empName = Console.ReadLine();

            Console.WriteLine("enter your salary");
            emp.salary = int.Parse(Console.ReadLine());

            Employee emp1 = new Employee();

            Console.WriteLine("enter a employee-id :");
            emp1.empId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your Name:");
            emp1.empName = Console.ReadLine();

            Console.WriteLine("enter your salary");
            emp1.salary = int.Parse(Console.ReadLine());

            Console.WriteLine("how to compare employee");
            Console.WriteLine("if you compare by employee id then press 1");
            Console.WriteLine("if you compare by employee Name then press 2");
            Console.WriteLine("if you compare by employee Salary then press 3");
            Console.WriteLine("if you compare by all deatil then press 4");

            int no = int.Parse(Console.ReadLine());

            if (no == 1)
            {
                emp.compareId(emp1);
            }
            else if (no == 2)
            {
                emp.compareName(emp1);
            }
            else if (no == 3)
            {
                emp.compareSalary(emp1);
            }
            else if (no == 4)
            {
                emp.compare(emp1);
            }

            Console.ReadKey();

        }

    }
}
