using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15.Entities
{
    internal class ImportedProduct : Product
    {
        //Declarando a classe
        public double CustomsFee { get; set; }

        //construtor do método
        public ImportedProduct() { }

        //Construtor instanciado
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        //método do calculo do produto
        public double Totalprice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return
                Name +
                " $ "
                + Totalprice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
