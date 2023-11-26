using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Elektrikli Avtomobil", desc = "Müasir nəqliyyat növü" },
                    new Category { categoryName = "Klassik Avtomobil", desc = "Daxili yanma mühərriki olan avtomobillər" }
                };
            }
        }
    }
}
