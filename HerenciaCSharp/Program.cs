using HerenciaCSharp;
class Program
{
    static void Main(string[] args)
    {
        Hamburguesa hamburguesaClasica = new Hamburguesa("Blanco", "Pollo", 3.0);
        hamburguesaClasica.AdicionarIngrediente("Lechuga", 1.0);
        hamburguesaClasica.AdicionarIngrediente("Tomate", 0.5);
        hamburguesaClasica.AdicionarIngrediente("Cebolla", 0.5);
        hamburguesaClasica.MontoAPagar();

        HamburguesaSaludable hamburguesaSaludable = new HamburguesaSaludable("Integral", "Pavo", 6.0);
        hamburguesaSaludable.AdicionarIngrediente("Espinacas", 1.0);
        hamburguesaSaludable.AdicionarIngredienteFit("Aguacate", 1.5);
        hamburguesaSaludable.MontoAPagar();

        HamburguesaPremium hamburguesaPremium = new HamburguesaPremium("Blanco", "Carne Angus", 15.0);
        hamburguesaPremium.MontoAPagar();
    }
}


