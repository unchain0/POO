#pragma warning disable CS8600
#pragma warning disable CS8602

using System.Globalization;

namespace _202._Interface_IComparable.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vs = csvEmployee.Split(',');
            Name = vs[0];
            Salary = double.Parse(vs[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is not Employee)
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}
