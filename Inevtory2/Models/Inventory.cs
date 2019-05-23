using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	public class Inventory
	{
		public int InventoryId { get; set; }
		public EQUIPMENT EQUIPMENT { get; set; }
		public int EquipmentId { get; set; }
		public MANUFACTURER MANUFACTURER { get; set; }
		public int ManufacturerId { get; set; }
		public MODEL MODEL { get; set; }
		public int ModelId { get; set; }

        [DisplayName("Serial Number")]
        public string SerialNo { get; set; }

        [DisplayName("Date of Purchase")]
        public DateTime DateOfPuchaseId { get; set; }
		public LOCATION LOCATION { get; set; }
		public int LocationId { get; set; }
		public STATUS STATUS { get; set; }
		public int StatusId { get; set; }
		public DEPARTMENT DEPARTMENT { get; set; }
		public int DepartmentId { get; set; }


	}
}