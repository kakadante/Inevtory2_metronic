using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	public class STATUS
	{
		public int Id { get; set; }

        [DisplayName("Status")]
        public string statusname { get; set; }
	}
}