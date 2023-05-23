CREATE TABLE [dbo].[BOISTYPES]
(
	[IdBois] INT NOT NULL PRIMARY KEY identity(1,1),
	[nomBois] varchar(32),
	[descriptionBois] varchar(max),
	[dispoBois] bit,
	prix int,

)
