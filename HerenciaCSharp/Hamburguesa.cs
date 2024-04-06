using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public class Hamburguesa
    {
        protected string tipoPan;
        protected string tipoCarne;
        protected double precioBase;
        protected List<string> ingredientesAdicionales;
        protected double precioIngredientesAdicionales;

        public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
        {
            this.tipoPan = tipoPan;
            this.tipoCarne = tipoCarne;
            this.precioBase = precioBase;
            this.ingredientesAdicionales = new List<string>();
            this.precioIngredientesAdicionales = 0;
        }

        public void AdicionarIngrediente(string ingrediente, double precioAdicional)
        {
            if (ingredientesAdicionales.Count < 4)
            {
                ingredientesAdicionales.Add(ingrediente);
                precioIngredientesAdicionales += precioAdicional;
            }
            else
            {
                Console.WriteLine("¡Ya ha alcanzado el máximo de ingredientes adicionales!");
            }
        }

        public virtual void MontoAPagar()
        {
            Console.WriteLine("Hamburguesa " + tipoCarne + " con " + tipoPan + ":");
            Console.WriteLine("Precio Base: $" + precioBase);
            Console.WriteLine("Ingredientes Adicionales:");
            foreach (var ingrediente in ingredientesAdicionales)
            {
                Console.WriteLine("- " + ingrediente);
            }
            Console.WriteLine("Precio Ingredientes Adicionales: $" + precioIngredientesAdicionales);
            Console.WriteLine("Total: $" + (precioBase + precioIngredientesAdicionales));
        }
    }

}
