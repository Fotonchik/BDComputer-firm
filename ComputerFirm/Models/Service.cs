using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Service
    {
        public long ServiceID { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Стоимость")]
        public int Price { get; set; }
        [Display(Name = "Описание")]

        public string Description { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}