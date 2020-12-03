using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 1234");
            CEO ceo = new CEO("Abhishek", 101, 2500);
            Console.WriteLine(ceo.CalcNetSalary());
            Console.WriteLine(ceo.EMPNAME);
            Console.WriteLine(ceo.DEPTNO);

            Manager manager = new Manager("RAM", 105, 1000, "GM");
            Console.WriteLine(manager.CalcNetSalary());
            Console.WriteLine(manager.EMPNAME);
            Console.WriteLine(manager.DEPTNO);
        }
    }

   public abstract class Employee
    {
        public static int employee_no = 0;
        public Employee(string name = "nothing", short deptNo = 1, decimal basic = 0)
        {
            employee_no++;
            empNo = employee_no;
            EMPNAME = name;
            DEPTNO = deptNo;
            BASIC = basic;
        }

        private int empNo;
        public int EMPNO
        {
            get
            {
                return empNo;
            }
        }

        private string empName;
        public string EMPNAME
        {
            set {
                if (value != "")
                    empName = value;
                else
                    Console.WriteLine("name not be blanks  ");
                }
            get { return empName; }
        }

        private short deptNo;
        public short DEPTNO
        {
            set {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("DEPTNO Must be greatter than 0");
                 }
            get { return deptNo; }
        }

        public decimal basic;
        public abstract decimal BASIC
        {
            set;
            get;
        }

       public abstract decimal CalcNetSalary();

    }

    public class Manager : Employee
    {
        public Manager(string empnm="nothing", short deptNo = 1, decimal basic = 0, String designation="MGR") : base(empnm, deptNo)
        {
            DESIGNATION = designation;
            BASIC = basic;
        }
        private string Designation;
        public String DESIGNATION
        {
            set {
                if (value != "")
                    Designation = value;
                else
                    Console.WriteLine("DESIGNATION not be blanks  ");
            }
            get { return Designation; }
        }
        public override decimal BASIC
        {
            set { basic = value; }
            get { return this.basic; }
        }

        public override decimal CalcNetSalary()
        {
            return this.basic + 1500;
           // throw new NotImplementedException();
        }
    }

   public class GeneralManager : Manager
    {
        public GeneralManager(string empnm = "nothing", short deptNo = 1, decimal basic = 0, String designation = "General MGR", string prks="none") : base(empnm,deptNo,basic,designation)
        {
            PERKS = prks;
        }
        private string Perks;
        public string PERKS
        {
            set;
            get;
        }
    }

    public class CEO : Employee
    {
        public CEO(string empnm = "nothing", short deptNo = 1, decimal basic = 0):base(empnm,deptNo)
        {
            BASIC = basic;
        }
        public decimal basic1;
        public override decimal BASIC {
            set { basic1 = value; }
            get { return this.basic1; }

        }

        public override sealed decimal CalcNetSalary()
        {
            Console.WriteLine("into the CEO class");
            return this.basic + 500;
            //throw new NotImplementedException();
        }
    }
}
