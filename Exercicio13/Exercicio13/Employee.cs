using System.Globalization;

namespace Exercicio13
{
     class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) 
        { 
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AumentarSalario(double percent) 
        { 
            Salary += Salary * percent / 100.0;
        }

        public override string ToString() 
        {
            return
                "Updated list of employees: "
                + Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
