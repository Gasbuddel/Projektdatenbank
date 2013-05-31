using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projektdatenbank.Models
{
    public class TSachmittel
    {
        [Key]
        public int SAId { get; set; }
        [Required]
        public string SABeschreibung { get; set; }
        [Required]
        public decimal SAKosten { get; set; }
    }
}