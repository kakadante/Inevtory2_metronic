namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateManufactererTable : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO MANUFACTURERS(manufacturername)VALUES('HP')");
			Sql("INSERT INTO MANUFACTURERS(manufacturername)VALUES('DELL')");
			Sql("INSERT INTO MANUFACTURERS(manufacturername)VALUES('LENOVO')");
			Sql("INSERT INTO MANUFACTURERS(manufacturername)VALUES('CISCO')");
			Sql("INSERT INTO MANUFACTURERS(manufacturername)VALUES('KYOCERA')");
			Sql("INSERT INTO MANUFACTURERS(manufacturername)VALUES('SONY')");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM MANUFACTURERS WHERE Id IN(1,2,3,4,5,6)");
		}
    }
}
