using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Computerfirm.Models
{
    public class Order
    {
        public long ID { get; set; }

        [Display(Name = "Дата заказа")]
        public DateTime OrderData { get; set; }
        [Display(Name = "Дата исполнения")]
        
        public DateTime DueData { get; set; }

        [Display(Name = "Доля предоплаты")]
        public int ShareofPrepayment { get; set; }


        [Display(Name = " Отметка об оплате")]
        public Boolean  PaymentMark { get; set; }


        [Display(Name = "Отметка об исполнении")]
        public Boolean  ExecutionMark{ get; set; }
        [Display(Name = "Срок общей гарантии")]
        public DateTime GeneralWarranttyPeriod { get; set; }
        [Display(Name = "Общая стоимость")]
        
        public int TotalCost { get; set; }
        public DbSet<Customer> CustomerID { get; set; }
        public DbSet<Component> Component1ID { get; set; }
        public DbSet<Component> Component2ID { get; set; }
        public DbSet<Component> Component3ID { get; set; }
        public DbSet<Service> Service1ID { get; set; }
        public DbSet<Service> Service2ID { get; set; }
        public DbSet<Service> Service3ID { get; set; }


    }
}