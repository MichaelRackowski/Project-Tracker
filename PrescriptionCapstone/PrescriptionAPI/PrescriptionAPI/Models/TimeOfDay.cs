using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrescriptionAPI.Models
{
    public class TimeOfDay
    {
        [Key]
        public int Id { get; set; }
        public string Time { get; set; }
      
    }
}