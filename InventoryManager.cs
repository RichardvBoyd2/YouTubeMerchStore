using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchStore
{
    class InventoryManager
    {

        List<Shirt> shirts = new List<Shirt>();

        public List<Shirt> GetShirts()
        {
            return this.shirts;
        }
        
        public void AddItem(string design, bool longSleeve, string size, string color, int quantity, decimal price)
        {
            shirts.Add(new Shirt(design, longSleeve, size, color, quantity, price));
        }

        public void RemoveItem(int index)
        {
            shirts.RemoveAt(index);
        }

        public void RestockItem(int index, int add)
        {
            shirts[index].AddInventory(add);
        }

        public void DestockItem(int index, int remove)
        {
            shirts[index].RemoveInventory(remove);
        }

        public List<Shirt> SearchByName(string search)
        {
            List<Shirt> temp = new List<Shirt>();
            for (int i = 0; i < shirts.Count; i++)
            {
                Console.WriteLine(i);
                if (this.shirts[i].Design.ToLower().Contains(search.ToLower()))
                {
                    temp.Add(this.shirts[i]);
                }
            }
            return temp;
        }

        public List<Shirt> SearchByColor(string color)
        {
            List<Shirt> temp = new List<Shirt>();
            for (int i = 0; i < shirts.Count; i++)
            {
                if (color.ToLower() == this.shirts[i].Color.ToLower())
                {
                    temp.Add(this.shirts[i]);
                }
            }
            return temp;
        }

    }
}
