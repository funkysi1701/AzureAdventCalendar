/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
declare @num int
select @num = count(*) from dbo.Reindeer
If(@num = 0)
BEGIN
insert into dbo.Reindeer (Name,Speed) Values ('Dasher',655)
insert into dbo.Reindeer (Name,Speed) Values ('Dancer',653)
insert into dbo.Reindeer (Name,Speed) Values ('Prancer',650)
insert into dbo.Reindeer (Name,Speed) Values ('Vixen',649)
insert into dbo.Reindeer (Name,Speed) Values ('Comet',657)
insert into dbo.Reindeer (Name,Speed) Values ('Cupid',656)
insert into dbo.Reindeer (Name,Speed) Values ('Donner',662)
insert into dbo.Reindeer (Name,Speed) Values ('Blitzen',659)
insert into dbo.Reindeer (Name,Speed) Values ('Blitzen',1655)
END