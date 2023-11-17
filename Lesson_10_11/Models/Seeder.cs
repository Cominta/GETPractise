using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_11.Models
{
    public static class Seeder
    {
  
        public static List<Category> InitCategory()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category()
            {
                Name="Книги"
            });
            list.Add(new Category()
            {
                Name = "Напитки"
            });
            list.Add(new Category()
            {
                Name = "Канцтовары"
            });
            list.Add(new Category()
            {
                Name = "Ноутбуки"
            });
            list.Add(new Category()
            {
                Name = "Смартфоны"
            });
            return list;
        }

        public static List<Product> InitProduct(List<Category> category)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product()
            {
                Name = "CocaCola",
                Price = 34m,
                Quantity = 170,
                IdCategory = category.Where(e=>e.Name.Equals("Напитки")).First().Id
            });
            list.Add(new Product()
            {
                Name = "Гарри Поттер",
                Price = 100m,
                Quantity = 17,
                IdCategory = category.Where(e => e.Name.Equals("Книги")).First().Id,
            });
            list.Add(new Product()
            {
                Name = "MacBook",
                Price = 70000m,
                Quantity = 10,
                IdCategory = category.Where(e => e.Name.Equals("Ноутбуки")).First().Id
            });
            list.Add(new Product()
            {
                Name = "LG",
                Price = 17000m,
                Quantity = 100,
                IdCategory = category.Where(e => e.Name.Equals("Смартфоны")).First().Id
            });
            list.Add(new Product()
            {
                Name = "Ножницы",
                Price = 56m,
                Quantity = 67,
                IdCategory = category.Where(e => e.Name.Equals("Канцтовары")).First().Id
            });
            list.Add(new Product()
            {
                Name = "Ergo",
                Price = 1000m,
                Quantity = 100,
                IdCategory = category.Where(e => e.Name.Equals("Смартфоны")).First().Id
            });
            list.Add(new Product()
            {
                Name = "Nokia",
                Price = 45m,
                Quantity = 100,
                IdCategory = category.Where(e => e.Name.Equals("Смартфоны")).First().Id
            });
            list.Add(new Product()
            {
                Name = "Motorola",
                Price = 23m,
                Quantity = 100,
                IdCategory = category.Where(e => e.Name.Equals("Смартфоны")).First().Id
            });
            list.Add(new Product()
            {
                Name = "IPhone",
                Price = 23m,
                Quantity = 100,
                IdCategory = category.Where(e => e.Name.Equals("Смартфоны")).First().Id
            });
            list.Add(new Product()
            {
                Name = "Xiaomi",
                Price = 65m,
                Quantity = 100,
                IdCategory = category.Where(e => e.Name.Equals("Смартфоны")).First().Id
            });
            return list;
        }

    }
}
