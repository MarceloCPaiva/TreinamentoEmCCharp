using System;
using System.Globalization;

namespace Exercicio15.Entities
{
    internal class Product
    {
        //declarando a classe
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtor
        public Product()
        {

        }

        //Construtor instanciado
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //Método de preço
        public virtual string PriceTag()
        {
            return
                Name +
                " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
