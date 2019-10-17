using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrescriptionAPI.Models
{
    public class Treatment
    {
        [Key]
        public int Id { get; set; }
        public string TreatmentType { get; set; }
    }
}