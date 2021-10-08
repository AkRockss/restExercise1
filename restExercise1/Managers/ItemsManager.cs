using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using restExercise1.Models;

namespace restExercise1.Managers
{
    public class ItemsManager
    {
        private static int _nextId = 1;

        private static readonly List<Item> Ilist = new List<Item>
        {
            new Item {Id = _nextId++, Name = "New World", Itemquality = 100, Quantity = 100},
            new Item {Id = _nextId++, Name = "Apex Legends", Itemquality = 100, Quantity = 100}
        };


        public List<Item> GetAll(string substring)
        {
            List<Item> item = Ilist.FindAll(item1 => item1.Name.Contains(substring.ToLower()));

            if (item == null) return null;
            //return Ilist;

            return new List<Item>(Ilist);
        }

      


        public Item GetById(int id)
        {
            return Ilist.Find(Item => Item.Id == id);
        }


        public Item Add(Item newItem)
        {
            newItem.Id = _nextId++;
            Ilist.Add(newItem);
            return newItem;
        }

        public Item Delete(int id)
        {
            Item item = Ilist.Find(item1 => item1.Id == id);
            if (item == null) return null;
            Ilist.Remove(item);
            return item;
        }

        public Item Update(int id, Item updates)
        {
            Item item = Ilist.Find(item1 => item1.Id == id);
            if (item == null) return null;
            item.Name = updates.Name;
            item.Itemquality = updates.Itemquality;
            item.Quantity = updates.Quantity;
            return item;
        }

    
    }

}
