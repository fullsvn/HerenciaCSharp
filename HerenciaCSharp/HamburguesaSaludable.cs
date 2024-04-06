using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public class HamburguesaSaludable : Hamburguesa
    {
        private List<string> ingredientesSaludables;
        private double precioIngredientesSaludables;

        public HamburguesaSaludable(string tipoPan, string tipoCarne, double precioBase)
            : base(tipoPan, tipoCarne, precioBase)
        {
            ingredientesSaludables = new List<string>();
            precioIngredientesSaludables = 0;
        }

        public void AdicionarIngredienteFit(string ingrediente, double precioAdicional)
        {
            if (ingredientesSaludables.Count < 2)
            {
                ingredientesSaludables.Add(ingrediente);
                precioIngredientesSaludables += precioAdicional;
            }
            else
            {
                Console.WriteLine("¡Ya ha alcanzado el máximo de ingredientes saludables!");
            }
        }

        public override void MontoAPagar()
        {
            base.MontoAPagar();
            Console.WriteLine("Ingredientes Saludables:");
            foreach (var ingrediente in ingredientesSaludables)
            {
                Console.WriteLine("- " + ingrediente);
            }
            Console.WriteLine("Precio Ingredientes Saludables: $" + precioIngredientesSaludables);
            Console.WriteLine("Total: $" + (precioBase + precioIngredientesAdicionales + precioIngredientesSaludables));
        }
    }

}
