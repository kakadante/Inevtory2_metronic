
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	public class MODEL
	{
		public int Id { get; set; }

        [DisplayName("Model")]
        public string modelname { get; set; }
	}
}