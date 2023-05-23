CREATE TABLE [dbo].[MICROTYPES]
(
	[IdMicro] INT NOT NULL PRIMARY KEY identity(1,1),
	[nomMicro] varchar(32),
	[descriptionMicro] varchar(max),
	[dispoMicro] bit,
	prix int,
)
