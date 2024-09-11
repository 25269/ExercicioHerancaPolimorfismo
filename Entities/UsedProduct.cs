using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateOnly manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate})");
            return sb.ToString();
        }

    }
}
