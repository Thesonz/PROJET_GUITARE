CREATE TABLE [dbo].[STATISTIQUES]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	nombreVue int NOT NULL,
	revenueTotal int NOT NULL,
	revenueMoisJanv int not null,
	revenueMoisFevr int not null,
	revenueMoisMars int not null,
	revenueMoisAvri int not null,
	revenueMoisMai int not null,
	revenueMoisJuin int not null,
	revenueMoisJuil int not null,
	revenueMoisAout int not null,
	revenueMoisSept int not null,
	revenueMoisOcto int not null,
	revenueMoisNove int not null,
	revenueMoisDece int not null,
	revenueAnnee int not null,
	dateAnnee int not null,

)
