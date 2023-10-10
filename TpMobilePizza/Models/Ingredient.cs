using System.ComponentModel.DataAnnotations.Schema;

namespace TpMobilePizza.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(MyPizza))]
        public int PizzaId { get; set; }
        public MyPizza MyPizza { get; set; }

        public static implicit operator string(Ingredient ingredient) => ingredient.Name ?? "";
        public static implicit operator Ingredient(string str) => new Ingredient() { Name = str };

        public override string ToString()
        {
            return Name ?? "";
        }
    }
}
