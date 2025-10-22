using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10_2
{
    internal class Employee
    {
        private string name;
        private int salary;
        private bool er_salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set

            {
                if (value < 0 || value > 1000000)
                {
                    Console.WriteLine("Ошибка. Зарплата не должна быть отрицательной.");
                    er_salary = true;
                }
                else
                {
                    salary = value;
                    er_salary = false;
                }
            }
        }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public Employee(string name) : this(name, 50000) { }
        public void Work()
        {
            Console.WriteLine($"{name} работает, зарплата: {salary}.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Маркус", 80000);
            employee.Work();
            Employee employee1 = new Employee("Cерёга");
            employee1.Work();
        }
    }
}

