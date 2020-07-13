namespace Kitaplik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 100),
                        Yazari = c.String(nullable: false, maxLength: 100),
                        Kategori = c.String(nullable: false, maxLength: 50),
                        YayinEvi = c.String(nullable: false, maxLength: 150),
                        BasimYili = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kitaps");
        }
    }
}
