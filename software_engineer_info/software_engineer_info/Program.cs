using System;

namespace software_engineer
{
    public class engineer_info
    {
        public string developer_name, developer_id, developer_current_salary, developer_joining_year, developer_sex, developer_skills;
        public string comitted_to_work_till, salary_increase,new_salary;
        public void set_val(params string[] data)
        {
            developer_name = data[0];
            developer_sex = data[1];
            developer_id = data[2];
            developer_current_salary = data[3];
            developer_joining_year = data[4];
            developer_skills = data[5];
        }

        public void calculation()
        {
            int k = Convert.ToInt32(developer_joining_year);
            k = k + 2;
            comitted_to_work_till = Convert.ToString(k);

            var data = developer_skills.Split(',');
            int l = data.Length;
            if(l>2)
            {
                k = (5000 * (l - 2));
                int nw_sal = k;
                salary_increase = Convert.ToString(k);
                nw_sal = nw_sal + Convert.ToInt32(developer_current_salary);
                new_salary = Convert.ToString(nw_sal);
            }
        }
        public void display()
        {
            Console.WriteLine("name: {0}\nsex: {1}\nid: {2}\njoining_year: {3}\ncurrent_salary: {4}\n", developer_name, developer_sex, 
                developer_id, developer_joining_year, developer_current_salary);
            Console.WriteLine("salary increase: {0}\nnew salary: {1}\n must work till: {2}\n{3}\n", salary_increase, new_salary, comitted_to_work_till);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            string s1, s2;
            Console.Write("enter the number of software engineer: ");
            k = Convert.ToInt32(Console.ReadLine());

            engineer_info[] developer = new engineer_info[k];
            Console.WriteLine("enter software engineer's info like following formate->\nname\nsex\nid\ncurrent salary\njoining year\nskills->skill1,skill2,...\n");
            for (i = 0; i < k; i++)
            {
                string s="th";
                if (i == 0)
                    s = "st";
                else if (i == 1)
                    s = "nd";
                else if (i == 2)
                    s = "rd";
                developer[i] = new engineer_info();
                Console.WriteLine("enter {0}{1} software engineer's information: \n",i+1,s);
                string[] inp = new string[6];
                for (j = 0; j < 6; j++)
                    inp[j] = Console.ReadLine();

                Console.WriteLine("\n\n");
                developer[i].set_val(inp);
                developer[i].calculation();
            }

            for (i = 0; i < k; i++)
            {
                string s = "th";
                if (i == 0)
                    s = "st";
                else if (i == 1)
                    s = "nd";
                else if (i == 2)
                    s = "rd";

                Console.WriteLine("{0}{1} engineer's updated information\n", i + 1, s);
                developer[i].display();
                Console.WriteLine("\n\n");
            }
        }
    }
}
