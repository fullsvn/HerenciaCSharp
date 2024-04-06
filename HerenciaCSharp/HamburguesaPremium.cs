using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public class HamburguesaPremium : Hamburguesa
    {
        private const double PrecioPapitas = 2.5;
        private const double PrecioBebida = 1.5;

        public HamburguesaPremium(string tipoPan, string tipoCarne, double precioBase)
            : base(tipoPan, tipoCarne, precioBase)
        {
            AdicionarIngrediente("Papitas", PrecioPapitas);
            AdicionarIngrediente("Bebida", PrecioBebida);
        }

        public override void MontoAPagar()
        {
            base.MontoAPagar();
        }
    }

}
