using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15.Entities
{
    internal class UsedProduct : Product
    {
        //Declarando a classe
        public DateTime ManufactureDate { get; set; }

        //Construtor
        public UsedProduct() { }

        //Construtor instanciado
        public UsedProduct(string name, double price, DateTime manufactureData) : base (name, price)
        {
            ManufactureDate = manufactureData;
        }

        public override string PriceTag()
        {
            return
                Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
