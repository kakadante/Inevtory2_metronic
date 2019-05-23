using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	public class EQUIPMENT
	{
		public int Id { get; set; }

        [DisplayName("Equipment")]
        public string equipmentname { get; set; }
	}
}