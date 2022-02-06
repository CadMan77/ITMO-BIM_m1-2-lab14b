using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_2_lab14
{
    public enum Categories
    {
        Еда,
        Бытовая_техника /* пробел вместо " _" невозможен? */
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public Categories Category { get; set; }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
