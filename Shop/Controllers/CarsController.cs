using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if(string .IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Elektrikli Avtomobil")).OrderBy(i => i.id);
                    currCategory = "Elektrikli Avtomobil";
                }
                else {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Klassik Avtomobil")).OrderBy(i => i.id);
                    currCategory = "Klassik Avtomobil";
                }
            
            }
            var carObj = new CarsListViewModel
                {
                    allCars = cars,
                    currCategory = currCategory
                };
            
            ViewBag.Title = "avtomobil səhifasi";
            
            

            return View(carObj);
        }
    }
}
