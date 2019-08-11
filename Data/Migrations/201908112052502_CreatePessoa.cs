namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePessoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Contatos_Id = c.Int(),
                        Endereco_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contatos", t => t.Contatos_Id)
                .ForeignKey("dbo.Enderecoes", t => t.Endereco_Id)
                .Index(t => t.Contatos_Id)
                .Index(t => t.Endereco_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoas", "Endereco_Id", "dbo.Enderecoes");
            DropForeignKey("dbo.Pessoas", "Contatos_Id", "dbo.Contatos");
            DropIndex("dbo.Pessoas", new[] { "Endereco_Id" });
            DropIndex("dbo.Pessoas", new[] { "Contatos_Id" });
            DropTable("dbo.Pessoas");
        }
    }
}
