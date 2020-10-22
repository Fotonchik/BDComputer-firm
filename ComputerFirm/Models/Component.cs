using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Component
    {
        public long ComponentID { get; set; }


        [Display(Name = "Марка")]
        public string Brand { get; set; }


        [Display(Name = "Цена")]
        public int Price{ get; set; }


        [Display(Name = "Дата выпуска")]

        public DateTime DataofIssue { get; set; }


        [Display(Name = "Срок гарантия")]
        public DateTime WarrantyPeriod { get; set; }


        [Display(Name = "Описание")]

        public string Described{ get; set; }


        [Display(Name = "Характеристики")]
        public string Specificatrion { get; set; }


        [Display(Name = "Страна производитель")]
        public string CountryProduced{ get; set; }

        public DbSet<Staff> StaffID { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<TypesofСomponent> TypesofСomponent { get; set; }


    }
}