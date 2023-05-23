CREATE TABLE [dbo].[AUTHENTIFICATIONS]
(
	[IdAuth] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[adresseMailAuth] varchar(max),
	[passwordAuth] varchar(max)
)
