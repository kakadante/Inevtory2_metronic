namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEquipmentTable : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO EQUIPMENTS(equipmentname)VALUES('Desktop')");
			Sql("INSERT INTO EQUIPMENTS(equipmentname)VALUES('CPU')");
			Sql("INSERT INTO EQUIPMENTS(equipmentname)VALUES('Keyboard')");
			Sql("INSERT INTO EQUIPMENTS(equipmentname)VALUES('UPS')");
			Sql("INSERT INTO EQUIPMENTS(equipmentname)VALUES('Laptop')");
			Sql("INSERT INTO EQUIPMENTS(equipmentname)VALUES('Printer')");
		}
		public override void Down()
		{
			Sql("DELETE FROM EQUIPMENTS WHERE Id IN(1,2,3,4,5,6)");
		}
	}	
}
