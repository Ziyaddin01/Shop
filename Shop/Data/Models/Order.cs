using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {

        [BindNever]
        public int id { get; set; }

        
        [Display(Name = "Adinizi daxil edin")]
        [StringLength(25)]
        [Required(ErrorMessage = "Ad uzunluğu ən azi 5 simvoldan ibarət olmalidir!")]
        public string name { get; set; }

        
        [Display(Name = "Soyadinizi daxil edin")]
        [StringLength(25)]
        [Required(ErrorMessage = "Soyad uzunluğu ən azi 5 simvoldan ibarət olmalidir!")]
        public string surname { get; set; }

        
        [Display(Name = "Ünvan")]
        [StringLength(35)]
        [Required(ErrorMessage = "Ünvan uzunluğu ən azi 5 simvoldan ibarət olmalidir!")]
        public string address { get; set; }

        
        [Display(Name = "Əlagə nömrəsi")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Nömrənin uzunluğu ən azi 10 simvoldan ibarət olmalidir!")]
        public string phone { get; set; }


        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Email uzunluğu ən azi 15 simvoldan ibarət olmalidir!")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public  DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
