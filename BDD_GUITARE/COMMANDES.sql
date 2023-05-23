CREATE TABLE [dbo].[COMMANDES]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	numeroCom varchar(50),
	reportagePhotoCam varchar(max),
	clientId int not null,
	guitareId int not null,
	[prixTotal] INT NULL, 
    Foreign key (clientId) references CLIENTS(IdClient),
	Foreign key (guitareId) references GUITARES(IdGuitare)
)
