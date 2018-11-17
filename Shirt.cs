using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchStore
{
    class Shirt
    {
        private String design;
        private Boolean longSleeve;
        private String size;
        private String color;
        private int quantity;
        private decimal price;

        public Shirt() { }

        public Shirt(string design, bool longSleeve, string size, string color, int quantity, decimal price)
        {
            this.Design = design;
            this.LongSleeve = longSleeve;
            this.Size = size;
            this.Color = color;
            this.Quantity = quantity;
            this.Price = price;
        }

        public string Design { get => design; set => design = value; }
        public bool LongSleeve { get => longSleeve; set => longSleeve = value; }
        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }

        public void AddInventory(int add)
        {
            quantity = quantity + add;
        }

        public void RemoveInventory(int remove)
        {
            quantity = quantity - remove;
        }

    }
}
