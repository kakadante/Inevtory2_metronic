namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PupolateLocationTable : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO LOCATIONS(locationname)VALUES('Nairobi')");
			Sql("INSERT INTO LOCATIONS(locationname)VALUES('Kisumu')");
			Sql("INSERT INTO LOCATIONS(locationname)VALUES('Mombasa')");
			Sql("INSERT INTO LOCATIONS(locationname)VALUES('Laikipia')");
			Sql("INSERT INTO LOCATIONS(locationname)VALUES('Wajir')");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM LOCATIONS WHERE Id IN(1,2,3,4,5)");
		}
    }
}
