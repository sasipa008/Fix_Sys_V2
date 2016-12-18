using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fix_Sys_V2.Models
{
    public class Report
    {
        [Key]
        public int id { get; set; }
        public string RoomNo { get; set; }
        public string Detail { get; set; }
        public string Status { get; set; }
        public string Technicail { get; set; }
    }
}