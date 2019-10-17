<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrescriptionAPI.Models
{
    public class Treatment
    {
        //public Treatment()
        //{
        //    this.Medications = new HashSet<Medication>();
        //} 
        [Key]
        public int Id { get; set; }
        public string TreatmentType { get; set; }
       // public ICollection<Medication> Medications {get;set;} 
    }
>>>>>>> 1b68758bfe5ffe065d994644d35453c4ad536de8
}