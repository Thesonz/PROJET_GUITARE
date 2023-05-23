CREATE TABLE [dbo].[VIBRATOTYPES]
(
	[IdVibrato] INT NOT NULL PRIMARY KEY identity(1,1),
	[nomVibrato] varchar(32),
	[descriptionVibrato] varchar(max),
	[dispoVibrato] bit,
	prix int,
)
