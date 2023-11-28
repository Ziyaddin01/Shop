using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(content => content.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                   new Car { name = "Tesla Model S",
                       year = 2021,
                       HP = "761 a.g",
                       engine = "0.0 L",
                       img = "/img/tesla.jpg",
                       price = 55000,
                       isFavourite = true,
                       available = true,
                       Category = Categories["Elektrikli Avtomobil"]
                   },
                   new Car { name = "Bentley Continental GT",
                       year = 2010,
                       HP = "610 a.g",
                       engine = "6.0 L",
                       img = "/img/bentley.jpg",
                       price = 35000,
                       isFavourite = true,
                       available = true,
                       Category = Categories["Klassik Avtomobil"]
                   },
                   new Car { name = "BMW 530i",
                       year = 2018,
                       HP = "249 a.g",
                       engine = "2.0 L",
                       img = "/img/bmw.jpg",
                       price = 36900,
                       isFavourite = true,
                       available = true,
                       Category = Categories["Klassik Avtomobil"]
                   },
                   new Car { name = "Porsche Panamera GTS",
                       year = 2018,
                       HP = "460 a.g",
                       engine = "4.0 L",
                       img = "/img/porsche.jpg",
                       price = 64000,
                       isFavourite = true,
                       available = true,
                       Category = Categories["Klassik Avtomobil"]
                   }
                    );
            }

            content.SaveChanges();

        }
        private static Dictionary<String, Category> category;
        public static Dictionary<String, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Elektrikli Avtomobil", desc = "Müasir nəqliyyat növü" },
                    new Category { categoryName = "Klassik Avtomobil", desc = "Daxili yanma mühərriki olan avtomobillər" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    
                        category.Add(el.categoryName, el);
                     
                }
                return category;
            }
        } 
    }
}
