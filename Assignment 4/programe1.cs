/*
3. Create a struct Student with the following properties. Put in appropriate validations.
string Name
int RollNo
decimal Marks
Create a parameterized constructor.
Create an array to accept details for 5 students
*/
using System;
using System.Collections;
namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student [] arr = new Student[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter student details :");
                Console.WriteLine("Enter rollNo : ");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter  Name :");
                string nm = Console.ReadLine();

                Console.WriteLine("Enter  Marks  :");
                decimal mks = Convert.ToDecimal(Console.ReadLine());

                Student s2 = new Student(nm, no, mks);
                arr[i] = s2;
            }

            for (int i = 0; i < 5; i++)
            {
                 Console.WriteLine(arr[i].RollNo+ " "+ arr[i].Name + "  "+ arr[i].Marks);
            }
           
            
            Console.WriteLine();

        }

        struct Student
        {
            public string Name;
            public int RollNo;
            public decimal Marks;

            public Student(string Nm="none", int no=1, decimal mks=100)
            {
                Name = "";
                RollNo = 0;
                Marks = 0;
                ROLLNO = no;
                MARKS = mks;
                NAME = Nm;
            }
            public String NAME
            {
                set {
                    if (value != "")
                        Name = value;
                    else
                        Console.WriteLine("Name can not be blank");
                }
                get { return Name; }
            }

            public int ROLLNO
            {
                set
                {
                    if (value > 0)
                        RollNo= value;
                    else
                        Console.WriteLine("ROLLNO can not be negative ... it must be greatter than 0.");
                }
                get { return RollNo; }
            }

            public decimal MARKS
            {
                set
                {
                    if (value >= 0 && value <= 100)
                        Marks = value;
                    else
                        Console.WriteLine("MARKS between 0 to 100.");
                }
                get { return Marks; }
            }
        }



    }
}
