namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatus : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO STATUS(statusname)VALUES('Functional')");
			Sql("INSERT INTO STATUS(statusname)VALUES('Malfunctional')");
			Sql("INSERT INTO STATUS(statusname)VALUES('Obsolete')");
		}
        
        public override void Down()
        {
		Sql("DELETE FROM STATUS WHERE Id IN(1,2,3)");
		}
    }
}
