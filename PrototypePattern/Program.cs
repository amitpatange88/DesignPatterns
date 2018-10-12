using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShallowCopyOperation();
            DeepCopyOperation();

            Console.ReadLine();
        }

        private static void ShallowCopyOperation()
        {
            //John
            Employee john = new Employee()
            {
                EmpId = 1,
                Name = "John",
                DeptId = 100,
                address = new Address() { City = "New York", PinCode = "000001" }
            };
            Console.WriteLine(john.ToString());

            //sam
            Employee sam = (Employee)john.Clone();
            sam.EmpId = 2;
            sam.Name = "Sam";
            sam.DeptId = 200;
            Console.WriteLine(sam.ToString());

            //Changes in John object
            john.DeptId = 300;
            john.address.City = "California";
            john.address.PinCode = "000002";

            Console.WriteLine(john.ToString());
            Console.WriteLine(sam.ToString());

            sam.DeptId = 400;
            sam.address.City = "Texas";
            sam.address.PinCode = "000003";

            Console.WriteLine(john.ToString());
            Console.WriteLine(sam.ToString());
            Console.WriteLine("------------------------------------------------------------------------------------");
        }


        private static void DeepCopyOperation()
        {
            //John
            Employee john = new Employee()
            {
                EmpId = 1,
                Name = "John",
                DeptId = 100,
                address = new Address() { City = "New York", PinCode = "000001" }
            };
            Console.WriteLine(john.ToString());

            //sam
            Employee sam = (Employee)john.DeepCopy();
            sam.EmpId = 2;
            sam.Name = "Sam";
            sam.DeptId = 200;
            Console.WriteLine(sam.ToString());

            //Changes in John object
            john.DeptId = 300;
            john.address.City = "California";
            john.address.PinCode = "000002";

            Console.WriteLine(john.ToString());
            Console.WriteLine(sam.ToString());

            sam.DeptId = 400;
            sam.address.City = "Texas";
            sam.address.PinCode = "000003";

            Console.WriteLine(john.ToString());
            Console.WriteLine(sam.ToString());
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }

    public abstract class ClonablePrototype<T>
    {
        //ShallowCopy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }


        //DeepCopy
        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }

    public class Employee : ClonablePrototype<Employee>
    {
        public int EmpId { get; set; }

        public string Name { get; set; }

        public int DeptId { get; set; }

        public Address address { get; set; }

        public override string ToString()
        {
            return string.Format("EmpId: {0}, Name: {1}, DeptId: {2}, City: {3}, PinCode: {4}", EmpId, Name, DeptId, address.City, address.PinCode);
        }
    }


    /// <summary>
    /// No use class. In Future this will be removed.
    /// </summary>
    public partial class EmployeeBase : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Address
    {
        public string City { get; set; }
        public string PinCode { get; set; }
    }
}
