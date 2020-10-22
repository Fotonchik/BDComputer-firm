using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Staff
    {
        public long StaffID { get; set; }
        [Display(Name ="ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Возраст")]
        public short Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public int Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }

        public DbSet<Position> PositionID { get; set; }

        public DbSet<Staff> Staffs { get; set; }

    }
}