CREATE TABLE [dbo].[GUITARES]
(
	[IdGuitare] INT NOT NULL PRIMARY KEY identity(1,1),
	mancheBoisId int not null,
	toucheBoisId int not null,
	corpBoisId int not null,
	neckMicroId int not null,
	centralMicroId int ,
	bridgeMicroId int not null,
	vibratoId int not null,
	Foreign key (mancheBoisId) References BOISTYPES(IdBois),
	Foreign key (toucheBoisId) References BOISTYPES(IdBois),
	Foreign key (corpBoisId) References BOISTYPES(IdBois),
	Foreign key (neckMicroId) References MICROTYPES(IdMicro),
	Foreign key (centralMicroId) References MICROTYPES(IdMicro),
	Foreign key (bridgeMicroId) References MICROTYPES(IdMicro),
	Foreign key (vibratoId) References VIBRATOTYPES(IdVibrato),

)
