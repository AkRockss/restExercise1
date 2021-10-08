using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace restExercise1.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Itemquality { get; set; }

        public  int Quantity { get; set; }

        public Item(int id, string name, int itemquality, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Itemquality = itemquality;
            this.Quantity = quantity;
        }

        public Item()
        {
                
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
