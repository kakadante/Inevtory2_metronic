namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateModelTable : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO MODELS(modelname)VALUES('ProBook')");
			Sql("INSERT INTO MODELS(modelname)VALUES('Elitebook')");
			Sql("INSERT INTO MODELS(modelname)VALUES('Dell Inspiron')");
			Sql("INSERT INTO MODELS(modelname)VALUES('Taskalfa')");
			Sql("INSERT INTO MODELS(modelname)VALUES('SonyXA')");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM MODELS WHERE Id IN(1,2,3,4,5)");
		}
    }
}
