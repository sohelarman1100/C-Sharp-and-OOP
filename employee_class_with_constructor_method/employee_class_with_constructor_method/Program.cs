using System;

namespace employee_class_with_constructor_method
{
    class employee
    {
        string id, name, age, workig_age, salary,pre_date,joining_date;
        public employee(params string[] data)
        {
            id = data[0];
            name = data[1];
            age = data[2];
            pre_date = data[3];
            joining_date = data[4];

            int k = Convert.ToInt32(pre_date);
            int l = Convert.ToInt32(joining_date);
            k = k - l;

            workig_age = Convert.ToString(k);
            salary = data[5];
        }

        public void display()
        {
            Console.WriteLine("name= {0}\nid= {1}\nage= {2}\nworking_age= {3}\nsalary= {4}\n", name, id, age, workig_age, salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter employee info");
            var inp = Console.ReadLine();
            var data = inp.Split(' ');
            employee emp = new employee(data);
            emp.display();
        }
    }
}
