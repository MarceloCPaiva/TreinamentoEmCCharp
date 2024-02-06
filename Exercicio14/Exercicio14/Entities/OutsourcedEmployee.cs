
namespace Exercicio14.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        //Declarando a classe
        public double AdditionalCharge { get; set; }

        //Construtor do Método
        public OutsourcedEmployee() { }

        //Construtor instanciado recebendo o que já existe do Método Employee
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }


        //Método de pagamento do funcionário terceirizado herdado do método no Employee
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
