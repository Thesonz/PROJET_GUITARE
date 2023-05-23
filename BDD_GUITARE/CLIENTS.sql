CREATE TABLE [dbo].[CLIENTS]
(
	[IdClient] INT NOT NULL PRIMARY KEY identity(1,1),
	[nomClient] varchar(32),
	prenomClient varchar(32),
	adresseClient varchar(32),
	cpClient varchar(32),
	villeClient varchar(32),
	photoClient varchar(32),
	authId int,
	unique(authId),
	Foreign key (authId) References AUTHENTIFICATIONS(IdAuth),
)
