namespace Naloga22.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Studentis",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Ime = c.String(),
                        Priimek = c.String(),
                        Vpisna_stevilka = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Studentis");
        }
    }
}
