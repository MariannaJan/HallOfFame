namespace HallOfFame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0bb9d0b5-c39b-4953-9659-c921174d2d1e', N'admin@halloffame.com', 0, N'AOmnjJ1s53fMl+dAZKge3Hung1nYc4+Rj0HVHZdjbCFOYEnddlqkFNiWcy/ht8TykQ==', N'db5b534e-517b-45f3-b094-f4a66c8025f7', NULL, 0, 0, NULL, 1, 0, N'admin@halloffame.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'97891dff-aee7-4052-a5e7-9c7c29f23b34', N'guest@halloffame.com', 0, N'AIMT/o3WEM1lCv5u9s8dJXqWySnesLmauvVG54mzh/kt7oIZRIbeFqGK8Cp43ldiSQ==', N'658ff26d-c1b3-4772-ac0c-fe3f894c6d1d', NULL, 0, 0, NULL, 1, 0, N'guest@halloffame.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6c4bbbb0-beab-454f-96e9-84fd51d0bb14', N'Admin')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0bb9d0b5-c39b-4953-9659-c921174d2d1e', N'6c4bbbb0-beab-454f-96e9-84fd51d0bb14')
");
        }
        
        public override void Down()
        {
        }
    }
}
