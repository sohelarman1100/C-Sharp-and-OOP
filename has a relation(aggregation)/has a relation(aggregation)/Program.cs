using System;

namespace has_a_relation_aggregation_
{
    public class Address
    {
        public string division, district, policeStation, postOffice;
        public Address(string division, string district, string policeStation, string postOffice)
        {
            this.division = division;
            this.district = district;
            this.policeStation = policeStation;
            this.postOffice = postOffice;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address;//Employee HAS-A Address  
        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
              address.division + " " + address.district + " " + address.policeStation+" "+address.postOffice);
        }
    }
    public class TestAggregation
    {
        public static void Main(string[] args)
        {
            Address a1 = new Address("Chittagong", "Cumilla", "Adarsha Sadar", "Cumilla-3500");
            Employee e1 = new Employee(1509, "safayet", a1);
            e1.display();
        }
    }
}
