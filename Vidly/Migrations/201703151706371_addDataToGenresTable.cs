namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataToGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into genres (id,Name) values (1,'Action')");
            Sql("Insert into genres (id,Name) values (2,'Thriller')");
            Sql("Insert into genres (id,Name) values (3,'Family')");
            Sql("Insert into genres (id,Name) values (4,'Romance')");
            Sql("Insert into genres (id,Name) values (5,'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
