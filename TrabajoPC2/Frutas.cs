using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPC2
{
    public class Frutas : Producto
    {
        private double desc;
        public Frutas(string nombre, string categoria, int cantidad, double precio, double desc) : base(nombre, categoria, cantidad, precio)
        {
            this.desc = desc;
        }
        public Frutas(string nombre, string categoria, int cantidad) : base(nombre, categoria, cantidad)
        {
        }

        public override double getDescuento()
        {
            return desc;
        }

        public override void setDescuento(double descuento)
        {
            this.desc = descuento;
        }

        public override double aplicarDescuento(double monto)
        {
            return monto * (100 - desc)/100;
        }
    }
}
