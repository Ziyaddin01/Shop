using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>{
                   new Car { name = "Tesla Model S",
                       year = 2021,
                       HP = "761 a.g",
                       engine = "0.0 L",
                       img = "/img/tesla.jpg",
                       price = 55000,
                       isFavourite = true,
                       available = true,
                       Category = _categoryCars.AllCategories.First()
                   },
                   new Car { name = "Bentley Continental GT",
                       year = 2010,
                       HP = "610 a.g",
                       engine = "6.0 L",
                       img = "/img/bentley.jpg",
                       price = 35000,
                       isFavourite = true,
                       available = true,
                       Category = _categoryCars.AllCategories.Last()
                   },
                   new Car { name = "BMW 530i",
                       year = 2018,
                       HP = "249 a.g",
                       engine = "2.0 L",
                       img = "/img/bmw.jpg",
                       price = 36900,
                       isFavourite = true,
                       available = true,
                       Category = _categoryCars.AllCategories.Last()
                   },
                   new Car { name = "Porsche Panamera GTS",
                       year = 2018,
                       HP = "460 a.g",
                       engine = "4.0 L",
                       img = "/img/porsche.jpg",
                       price = 64000,
                       isFavourite = true,
                       available = true,
                       Category = _categoryCars.AllCategories.Last()
                   }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carsId)
        {
            throw new NotImplementedException();
        }
    }
}
