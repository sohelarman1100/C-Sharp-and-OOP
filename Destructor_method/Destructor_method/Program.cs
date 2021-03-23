using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Destructor_method
{
    public class student

    {
        string name, roll, semester, mobile;

        public void set_val(params string[] data)
        {
            name = data[0];
            roll = data[1];
            semester = data[2];
            mobile = data[3];
        }
        public student()

        {

        }

        // Destructor

        ~student()

        {

        }

        public void display()
        {
            Console.WriteLine("name= {0}\nroll= {1}\nsemester= {2}\nmobile= {3}\n",name,roll,semester,mobile);
        }

    }

    class Program

    {
        public static void Details()

        {
            int n;
            Console.WriteLine("how many students:");
            n = Convert.ToInt32(Console.ReadLine());
            student[] stud = new student[n];
            Console.WriteLine("enter student information like following formate->\nname\nroll\nsemester\nmobile\n");
            for(int i=0; i<n; i++)
            {
                stud[i] = new student();
                string[] info = new string[4];
                Console.WriteLine("student {0} info\n", i+1);
                for(int j=0; j<4; j++)
                {
                    info[j] = Console.ReadLine();
                }
                stud[i].set_val(info);
            }

            Console.WriteLine("\nfollowing are the student's information:\n");
            for (int i = 0; i < n; i++)
            {
                stud[i].display();
            }

        }
        static void Main(string[] args)

        {
            Details();
            GC.Collect();

        }
    }
}
