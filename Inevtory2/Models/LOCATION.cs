using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	public class LOCATION
	{
		public int Id { get; set; }

        [DisplayName("Location")]
        public string locationname { get; set; }
	}
}