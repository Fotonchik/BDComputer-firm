using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Position
    {
        public long PositionID { get; set; }

        [Display(Name = "Наименование должности")]
        public string NamePosition { get; set; }

        [Display(Name = "Оклад")]
        public string Salary { get; set; }

        [Display(Name = "Обязанности")]
        public string Duties { get; set; }

        [Display(Name = "Требования")]
        public string Requirements { get; set; }
        public DbSet<Position> Positions { get; set; } 
    }
}