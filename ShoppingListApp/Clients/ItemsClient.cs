using ShoppingListApp.Models;
using System.Runtime.CompilerServices;

namespace ShoppingListApp.Clients
{
    public class ItemsClient
    {
        private readonly List<Item> items;

        public ItemsClient ()
        {
            items = [
            new Item()
            {
                Id = 1,
                Name = "Buy Milk",
                IsPicked = false,
            },
                new Item()
                {
                    Id = 2,
                    Name = "Buy Bread",
                    IsPicked = false,
                },
                new Item()
                {
                    Id = 3,
                    Name = "Hoover",
                    IsPicked = true,
                },
                new Item()
                {
                    Id = 4,
                    Name = "Mop the bathroom",
                    IsPicked = false,
                },
                new Item()
                {
                    Id = 5,
                    Name = "Tidy Kitchen",
                    IsPicked = false,
                }
        ];
        }        

        public List<Item> GetItems { get { return items; } }

        public void AddNewItem(Item item)
        {
            items.Add(item);
        }

        public Item? GetItem(int id)
        {
            Item? myItem = items.Find(item => item.Id == id);

           return myItem ?? null;
            
        }

        public void UpdateItem(Item item)
        {
            Item? itemToUpdate = items.FirstOrDefault(i => i.Id == item.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = item.Name;
                itemToUpdate.IsPicked = item.IsPicked;
            }
        }

        public void UpdatePicked(int id)
        {
            Item? itemToUpdate = items.FirstOrDefault(i => i.Id == id);
      
            if (itemToUpdate != null)
            {
                itemToUpdate.IsPicked = !itemToUpdate.IsPicked;
            }
        }

        public void DeleteItem(int id)
        {
            Item? deletedItem = GetItem(id);    
            if (deletedItem != null)
            {
                items.Remove(deletedItem);
            }
        }
    }
}
