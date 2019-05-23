using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	public class MANUFACTURER
	{
		public int Id { get; set; }

        [DisplayName("Manufacturer")]
        public string manufacturername { get; set; }
	}
}