namespace Inevtory2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DEPARTMENTs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        departmentname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.STATUS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        statusname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EQUIPMENTs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        euipmentname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LOCATIONs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        locationname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InventoryId = c.Int(nullable: false, identity: true),
                        EquipmentId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        SerialNo = c.String(),
                        DateOfPuchaseId = c.DateTime(nullable: false),
                        LocationId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryId)
                .ForeignKey("dbo.DEPARTMENTs", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.EQUIPMENTs", t => t.EquipmentId, cascadeDelete: true)
                .ForeignKey("dbo.LOCATIONs", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.MANUFACTURERs", t => t.ManufacturerId, cascadeDelete: true)
                .ForeignKey("dbo.MODELs", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.STATUS", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.EquipmentId)
                .Index(t => t.ManufacturerId)
                .Index(t => t.ModelId)
                .Index(t => t.LocationId)
                .Index(t => t.StatusId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.MANUFACTURERs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        manufacturername = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MODELs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        modelname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventories", "StatusId", "dbo.STATUS");
            DropForeignKey("dbo.Inventories", "ModelId", "dbo.MODELs");
            DropForeignKey("dbo.Inventories", "ManufacturerId", "dbo.MANUFACTURERs");
            DropForeignKey("dbo.Inventories", "LocationId", "dbo.LOCATIONs");
            DropForeignKey("dbo.Inventories", "EquipmentId", "dbo.EQUIPMENTs");
            DropForeignKey("dbo.Inventories", "DepartmentId", "dbo.DEPARTMENTs");
            DropIndex("dbo.Inventories", new[] { "DepartmentId" });
            DropIndex("dbo.Inventories", new[] { "StatusId" });
            DropIndex("dbo.Inventories", new[] { "LocationId" });
            DropIndex("dbo.Inventories", new[] { "ModelId" });
            DropIndex("dbo.Inventories", new[] { "ManufacturerId" });
            DropIndex("dbo.Inventories", new[] { "EquipmentId" });
            DropTable("dbo.MODELs");
            DropTable("dbo.MANUFACTURERs");
            DropTable("dbo.Inventories");
            DropTable("dbo.LOCATIONs");
            DropTable("dbo.EQUIPMENTs");
            DropTable("dbo.STATUS");
            DropTable("dbo.DEPARTMENTs");
        }
    }
}
