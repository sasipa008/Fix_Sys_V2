using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fix_Sys_V2.Models
{
    public class Fix_Sys_V2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Fix_Sys_V2Context() : base("name=Fix_Sys_V2Context")
        {
        }

        public System.Data.Entity.DbSet<Fix_Sys_V2.Models.Building> Buildings { get; set; }

        public System.Data.Entity.DbSet<Fix_Sys_V2.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<Fix_Sys_V2.Models.Report> Reports { get; set; }

        public System.Data.Entity.DbSet<Fix_Sys_V2.Models.Room> Rooms { get; set; }
    }
}
