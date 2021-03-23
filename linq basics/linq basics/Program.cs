using System;
using System.Collections.Generic;

using System.Collections;
using System.Linq;
namespace linq_basics
{
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }
        class Program
        {
            static void Main(string[] args)
            {
                int m, n, k, i;
                Console.WriteLine("enter the number of students: ");
                n = Convert.ToInt32(Console.ReadLine());
                Student[] stud = new Student[n];
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("enter student {0} name and age", i + 1);
                    stud[i] = new Student();
                    var inp = Console.ReadLine();
                    var data = inp.Split(' ');
                    stud[i].Name = data[0];
                    stud[i].Age = int.Parse(data[1]);
                }
                var data1 = from st in stud
                            orderby st.Name ascending
                            select new { name = st.Name, age = st.Age };   //data1.name er moddhe Name ar data1.age e Age paowa jabe.

                Student[] stud1 = new Student[n];
                i = 0;
                foreach (var s in data1)
                {
                    stud1[i] = new Student();
                    stud1[i].Name = s.name;
                    stud1[i].Age = s.age;
                    i++;
                }
                Student[] stud3 = new Student[n];
                int o = 0;
                List<Student> res = new List<Student>();
                for (i = 0; i < n - 1; i++)
                {
                    if (i == 0)
                        res.Add(stud1[i]);
                    if (stud1[i].Name == stud1[i + 1].Name)
                    {
                        res.Add(stud1[i + 1]);
                    }
                    else
                    {
                        var ans = from t in res
                                  orderby t.Age descending
                                  select t;
                        foreach (var l in ans)
                        {
                            stud3[o] = new Student();
                            stud3[o] = l;
                            o++;
                        }
                        res.Clear();
                        res.Add(stud1[i + 1]);
                    }
                }
                var ans1 = from t in res
                           orderby t.Age descending
                           select t;
                foreach (var l in ans1)
                {
                    stud3[o] = new Student();
                    stud3[o] = l;
                    o++;
                }
                res.Clear();

                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("{0}  {1}", stud3[i].Name, stud3[i].Age);
                }
            }
        }
}
