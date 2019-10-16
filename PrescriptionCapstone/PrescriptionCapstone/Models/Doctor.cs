using DocuSign.eSign.Model;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrescriptionCapstone.Models
{
    public
       class Doctor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        private string Appointment { get; set; }
        private string Patient { get; set; }
    }
}