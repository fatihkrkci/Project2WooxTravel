namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Surname", c => c.String());
            AddColumn("dbo.Reservations", "ReservationStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "ReservationEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reservations", "CreatedAt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "ReservationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "ReservationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "CreatedAt");
            DropColumn("dbo.Reservations", "ReservationEndDate");
            DropColumn("dbo.Reservations", "ReservationStartDate");
            DropColumn("dbo.Reservations", "Surname");
        }
    }
}
