using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class Product
    {
        public string Name { get; set; } // Dentro estarian sus variables privadas
        public int Id { get; set; }
        public float Price { get; set; }
        public Guid Guid { get; set; }

        public Product()// Si no se pone, C# lo pondra por mi, pero siempre es mejor ponerlo, ya que si pones el constructor sobrecargado no te lo genera.
        {
            Guid= Guid.NewGuid();
        }
        public Product(int id, String name, float price)//Es importante poner este porq C# no lo creará por mi.
        {
            Name = name; //A diferencia de JAVA, C# hace tanto el set como el get. 
            Id = id;
            Price = price;
            Guid = Guid.NewGuid();
        }
        public override string ToString()
        {
            return "Product: " + Name + "," + Price; // No es necesario llamar al get porque ya todo lo hace C#.

        }

    }
    
}
