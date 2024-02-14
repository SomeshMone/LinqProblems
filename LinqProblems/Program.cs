using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = GetAllEmployees();
            List<Students> students=GetAllStudents();
            // Employees who are older than 30 their name and Department
            Console.WriteLine("Employees who are older than 30 their name and Department");
            var EmployeeAbove30 = employees.Where(e => e.Age > 30).ToList();
            foreach (var employee in EmployeeAbove30)
            {
                Console.WriteLine(employee.Name+" "+employee.Department);
            }
            // Total Salary of the employees
            Console.WriteLine("Total Salary of the employees");
            var totalSum=employees.Sum(e => e.Salary);
            Console.WriteLine(totalSum);
            // Employee who is getting max Salary;
            Console.WriteLine(" Employee who is getting max Salary;");
            var max_Salary=employees.Max(e => e.Salary);
            string employeeWithMaxSalary = employees.OrderByDescending(e => e.Salary).FirstOrDefault().Name;
            Console.WriteLine(employeeWithMaxSalary+" "+max_Salary);
            // Employee who is getting min Salary;
            Console.WriteLine(" Employee who is getting max Salary;");
            var min_Salary = employees.Min(e => e.Salary);
            string employeeWithMinSalary = employees.OrderBy(e => e.Salary).FirstOrDefault().Name;
            Console.WriteLine(employeeWithMinSalary + " " + min_Salary);

            //Students Information
            Console.WriteLine("Students ordered by their cgpa");

            var orderStudentsCgpa = students.OrderByDescending(s => s.CGP);
            foreach(var student in orderStudentsCgpa)
            {
                Console.WriteLine(student.sname + " " + student.CGP);
            }

            


        }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID= 101, Name = "Pooja", Salary = 10000, Department = "IT", Age = 30},
                new Employee{ID= 102, Name = "Priyanka", Salary = 15000, Department = "Sales", Age = 28},
                new Employee{ID= 103, Name = "Manoj", Salary = 25000, Department = "Sales", Age = 35},
                new Employee{ID= 104, Name = "Santosh", Salary = 20000, Department = "IT", Age = 32},
                new Employee{ID= 105, Name = "Vishal", Salary = 30000, Department = "IT", Age = 29},
                new Employee{ID= 106, Name = "Sandhya", Salary = 25000, Department = "IT", Age = 31},
                new Employee{ID= 107, Name = "Mahesh", Salary = 35000, Department = "IT", Age = 33},
                new Employee{ID= 108, Name = "Manoj", Salary = 11000, Department = "Sales", Age = 27},
                new Employee{ID= 109, Name = "Pradeep", Salary = 20000, Department = "Sales", Age = 34},
                new Employee{ID= 110, Name = "Saurav", Salary = 25000, Department = "Sales", Age = 30},
                new Employee{ID= 111, Name = "Lokesh", Salary = 22000, Department = "IT", Age = 26},
                new Employee{ID= 112, Name = "Rajsekhar", Salary = 18000, Department = "Sales", Age = 29}
            };
                    return listEmployees;
        }
        public static List<Students> GetAllStudents()
        {
            List<Students> students = new List<Students>()
            {
                new Students{sid=1, sname="lokesh", CGP=4.5},
                new Students{sid=2, sname="smith", CGP=4.0},
                new Students{sid=3, sname="will", CGP=4.6},
                new Students{sid=4, sname="mark", CGP=3.6}

            };
            return students;
        }

    }
}
