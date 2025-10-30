using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10._2
{
    //2
    class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0 && value <= 1000000)
                { salary = value; }
                else if (value < 0)
                { Console.WriteLine("Зарплата не может быть отрицательной!"); }
            }
        }

        public Employee(string name, double salary)
        {
            this.name = name;
            Salary = salary;
        }
        public Employee(string name)
        {
            this.name = name;
            this.salary = 50000;
        }

        public void Work()
        {
            Console.WriteLine($"{name} работает, зарплата: {salary}.");
        }

        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Sad", -1000);
            employee1.Work();

            Employee employee2 = new Employee("Sue");
            employee2.Work();
        }

    }
}
