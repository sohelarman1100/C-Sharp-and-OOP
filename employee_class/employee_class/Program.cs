using System;

namespace employee_class
{
    public class Employee
    {
        public string emp_name, emp_id, emp_salary, emp_joining_year;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            string s1, s2;
            Console.Write("enter the number of emoployee: ");
            k = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[k];
            for(i=0; i<k; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("enter employee information: ");
                s1 = Console.ReadLine();
                emp[i].emp_name = s1;
                s1 = Console.ReadLine();
                emp[i].emp_id = s1;
                s1 = Console.ReadLine();
                emp[i].emp_salary = s1;
                s1 = Console.ReadLine();
                emp[i].emp_joining_year = s1;
            }

            Console.WriteLine("\n\nemployee information->\n ");
            for(i=0; i<k; i++)
                Console.WriteLine("name = {0}\nid = {1}\nsalary = {2}\njoining_year = {3}\n\n", emp[i].emp_name, emp[i].emp_id, emp[i].emp_salary, emp[i].emp_joining_year);
        }
    }
}
