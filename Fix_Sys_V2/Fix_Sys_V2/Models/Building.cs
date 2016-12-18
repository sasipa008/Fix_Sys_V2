using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fix_Sys_V2.Models
{
    public class Building
    {
        [Key]
        public int ID { get; set; }
        public string Build { get; set; }
        public string FloorNum { get; set; }
    }
}