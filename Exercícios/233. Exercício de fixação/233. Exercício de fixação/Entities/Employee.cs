namespace _233._Exercício_de_fixação.Entities {
    internal class Employee {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary) {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
