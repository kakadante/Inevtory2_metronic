using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	public class DEPARTMENT
	{
		public int Id { get; set; }

        [DisplayName("Department")]
        public string departmentname { get; set; }
	}
}