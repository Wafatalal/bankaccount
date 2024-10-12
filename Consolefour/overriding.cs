/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefour
{
    class Person
    {
        int id;
        string name;
        public Person()
        {
            this.id = 101;
            this.name = "Wafa";
        }
        public void DisplayDetails()
        {
            Console.WriteLine("id: {0} , Name:{1}", this.id, this.name);
        }
    }

    class Empolyee: Person
        {
        String OrganizationName;
        float Salary;
        public Empolyee()
        {
            this.OrganizationName = "si";
            this.Salary = 123.67F;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("OrganizationName: {0} , Salary:{1}", this.OrganizationName, this.Salary);

        }
    }
    class overriding
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            //person.DisplayDetails();

            //Empolyee emp = new Empolyee();
            //emp.DisplayDetails();

            Person person = new Empolyee();
            person.DisplayDetails();

            Console.ReadKey();
        }
    }
}
*/