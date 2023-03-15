using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3structur
{
    internal struct Employee
    {
        private int _empid;
        private string _empName;
        private int _salary;

        public Employee(int empid)
        {
            _empid = empid;
            _empName = string.Empty;
            _salary = 0;
        }
        public Employee(int empid, string name)
        {
            _empid = empid;
            _empName = name;
            _salary = 0;
        }

        public Employee(int empid, string name, int salary)
        {
            _empid = empid;
            _empName = name;
            _salary = salary;
        }

        public int empId
        {
            get { return _empid; }
            set { _empid = value; }
        }

        public string empName
        {
            get { return _empName; }
            set { _empName = value; }
        }

        public int salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void compareId(Employee other)
        {
            if (_empid == other._empid)
            {
                Console.WriteLine("both employee employee id same");
            }
            else
            {
                Console.WriteLine("both employee employee id is unique");
            }

        }
        public void compareName(Employee other)
        {
            if (_empName == other._empName)
            {
                Console.WriteLine("both employee employee name same");
            }
            else
            {
                Console.WriteLine("both employee employee name is unique");
            }

        }
        public void compareSalary(Employee other)
        {
            if (_salary == other._salary)
            {
                Console.WriteLine("both employee employee id same");
            }
            else
            {
                if(_salary>other._salary)
                {
                    Console.WriteLine($"emp one salary is max {_salary}");
                    Console.WriteLine($"emp two salary is min {other._salary}");
                }
                else
                {
                    Console.WriteLine($"emp two salary is max { other._salary}");
                    Console.WriteLine($"emp one salary is min {_salary}");
                }
            }

        }

        public void compare(Employee other)
        {
            if (_empName == other._empName && _empid ==other._empid && _salary == other._salary)
            {
                Console.WriteLine("both employee data same");
            }
            else
            {
                Console.WriteLine("both employee data is unique");
            }

        }
    }
}
