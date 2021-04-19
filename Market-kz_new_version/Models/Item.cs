using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market_kz_MVC.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public DateTime Year { get; set; }

        public string image { get; set; }

        public Country country { get; set; }

        public Category category { get; set; }

    }
}
