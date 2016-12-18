using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fix_Sys_V2.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        public string Build { get; set; }
        public string RoomNo { get; set; }
        public string Floor { get; set; }
    }
}