namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartmentTable : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO DEPARTMENTS(departmentname)VALUES('ICT')");
			Sql("INSERT INTO DEPARTMENTS(departmentname)VALUES('CID')");
			Sql("INSERT INTO DEPARTMENTS(departmentname)VALUES('PET')");
			Sql("INSERT INTO DEPARTMENTS(departmentname)VALUES('Reforms')");
			Sql("INSERT INTO DEPARTMENTS(departmentname)VALUES('HR')");
		}
        
        public override void Down()
        {
			Sql("DELETE FROM DEPARTMENTS WHERE Id IN(1,2,3,4,5)");
        }
    }
}
