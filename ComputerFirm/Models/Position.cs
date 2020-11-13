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
        public long ID { get; set; }
        [Display(Name = "��� ���������")]
        public long PositionID { get; set; }

        [Display(Name = "������������ ���������")]
        public string NamePosition { get; set; }

        [Display(Name = "�����")]
        public string Salary { get; set; }

        [Display(Name = "�����������")]
        public string Duties { get; set; }

        [Display(Name = "����������")]
        public string Requirements { get; set; }

    }
}