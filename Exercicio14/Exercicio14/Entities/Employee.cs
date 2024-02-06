
namespace Exercicio14.Entities
{
    internal class Employee
    {
        //Declarando a classe
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //Construtor do Método
        public Employee() { }

        //Construtor Instanciado
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //Método de pagamento
        public virtual double Payment()
        { 
            return Hours * ValuePerHour;
        }
    }
}
