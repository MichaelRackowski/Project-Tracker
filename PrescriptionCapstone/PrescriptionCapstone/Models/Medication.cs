using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrescriptionCapstone.Models
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Generic Name")]
        public string Name { get; set; }

        [Display(Name = "Medication was Taken Today")]
        public bool MedicationConfirmed { get; set; }

        [Display(Name = "When to Take Medication")]
        public DateTime ScheduledTimeToTake { get; set; }
    }
}