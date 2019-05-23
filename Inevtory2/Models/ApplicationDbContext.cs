using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Inevtory2.Models
{
	//public class ApplicationDbContext
	//{
	//}
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Inventory> MainInventory{ get; set; }
		public DbSet<DEPARTMENT> Departments { get; set; }
		public DbSet<EQUIPMENT> Equipment { get; set; }
		public DbSet<LOCATION> Location { get; set; }
		public DbSet<MANUFACTURER> Manufacturer { get; set; }
		public DbSet<MODEL> Model { get; set; }
		public DbSet<STATUS> Dtatus { get; set; }
		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}