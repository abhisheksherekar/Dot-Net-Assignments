/*
1. Create an array of Employee class objects
        Accept details for all Employees
        Display the Employee with highest Salary
        Accept EmpNo to be searched. Display all details for that employee. 
*/

using System;
using System.Collections;
namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
                Employee[] arr = new Employee[4];
            Console.WriteLine("Enter Employee details : \n");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter Employee No.");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name :");
                string nm = Console.ReadLine();
                Console.WriteLine("Enter Employee Department :");
                string department = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary :");
                decimal salary = Convert.ToDecimal(Console.ReadLine());
                Employee e1 = new Employee(no, nm, salary, department);
                arr[i] = e1;
            }
           
            decimal max_sal = 0;
            for (int i = 0; i < 4; i++)
            {
                 max_sal = arr[0].salary;
                if(arr[i].salary > max_sal)
                {
                    max_sal = arr[i].salary;
                    Console.WriteLine("Highest Salary : " + max_sal);
                }                
            }

           
            Console.WriteLine("Enter employee No to be search is : ");
            int search = Convert.ToInt32(Console.ReadLine());
            Employee temp = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if(search == arr[i].empNo)
                {
                     temp = arr[i];
                    
                }
            }

            Console.WriteLine(temp.empNo+ " "+temp.empName+"  "+temp.department+ "  "+temp.salary );


        }

        class Employee
        {
            public int empNo;
            public String empName;
            public decimal salary;
            public String department;

            public Employee(int empNo=101, String empName="no-name", decimal salary =1000, String department="none")
            {
                EMPNO  = empNo;
                this.empName = empName;
                this.salary = salary;
                this.department = department;
            }

            public int EMPNO
            {
                set { empNo = value;  }
                get { return empNo; }
            }
        }
    }
}
