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
            Console.WriteLine("Enter Number Of Batches :");
            int batches = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[batches][];
          
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Number of the Student in Batch {0} : ", i);
                int no = Convert.ToInt32(Console.ReadLine());
                int[] temp = new int[no];
                for (int k = 0; k < no; k++)
                {
                    Console.WriteLine("Enter marks of student :");
                    temp[k] = Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = temp;


            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int l = 0; l < arr[i].Length; l++)
                {
                    Console.WriteLine(arr[i][l]);
                }
                Console.WriteLine();
            }
        }

    }
}
