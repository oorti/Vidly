namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataToMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies (name,genreid,dateadded,releasedate,numberinstock) values ('Hangover', 1,GETDATE(),GetDate()-987,5)");
            Sql("insert into Movies (name,genreid,dateadded,releasedate,numberinstock) values ('Die Hard', 1,GETDATE(),GetDate()-654,4)");
            Sql("insert into Movies (name,genreid,dateadded,releasedate,numberinstock) values ('The Terminator', 1,GETDATE(),GetDate()-789,7)");
            Sql("insert into Movies (name,genreid,dateadded,releasedate,numberinstock) values ('Toy Story', 1,GETDATE(),GetDate()-2015,6)");
            Sql("insert into Movies (name,genreid,dateadded,releasedate,numberinstock) values ('Titanic', 1,GETDATE(),GetDate()-3045,8)");
        }
        
        public override void Down()
        {
        }
    }
}
