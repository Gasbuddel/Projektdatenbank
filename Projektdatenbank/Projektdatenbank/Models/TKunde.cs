using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projektdatenbank.Models
{
	public class TKunde
	{
		[Key]
		public int KuID { get; set; }
		[Required]
		public string KuName { get; set; }
		[Required]
		public string KuVorname { get; set; }
		public string KuEmail { get; set; }
	}
}