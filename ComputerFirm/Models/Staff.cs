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
        [Display(Name ="���")]
        public string FullName { get; set; }
        [Display(Name = "�������")]
        public short Age { get; set; }
        [Display(Name = "���")]
        public string Gender { get; set; }
        [Display(Name = "�����")]
        public string Address { get; set; }
        [Display(Name = "�������")]
        public int Phone { get; set; }
        [Display(Name = "���������� ������")]
        public string PassportData { get; set; }

        public DbSet<Position> PositionID { get; set; }

        public DbSet<Staff> Staffs { get; set; }

    }
}