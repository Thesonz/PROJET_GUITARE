/*
Script de déploiement pour BDD_GUITARE

Ce code a été généré par un outil.
La modification de ce fichier peut provoquer un comportement incorrect et sera perdue si
le code est régénéré.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "BDD_GUITARE"
:setvar DefaultFilePrefix "BDD_GUITARE"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Détectez le mode SQLCMD et désactivez l'exécution du script si le mode SQLCMD n'est pas pris en charge.
Pour réactiver le script une fois le mode SQLCMD activé, exécutez ce qui suit :
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Le mode SQLCMD doit être activé de manière à pouvoir exécuter ce script.';
        SET NOEXEC ON;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [sys].[databases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
PRINT N'Création de Table [dbo].[AUTHENTIFICATIONS]...';


GO
CREATE TABLE [dbo].[AUTHENTIFICATIONS] (
    [IdAuth]          INT          IDENTITY (1, 1) NOT NULL,
    [adresseMailAuth] VARCHAR (32) NULL,
    [passwordAuth]    VARCHAR (32) NULL,
    PRIMARY KEY CLUSTERED ([IdAuth] ASC)
);


GO
PRINT N'Création de Table [dbo].[BOISTYPES]...';


GO
CREATE TABLE [dbo].[BOISTYPES] (
    [IdBois]          INT          IDENTITY (1, 1) NOT NULL,
    [nomBois]         VARCHAR (32) NULL,
    [descriptionBois] VARCHAR (32) NULL,
    [dispoBois]       BIT          NULL,
    PRIMARY KEY CLUSTERED ([IdBois] ASC)
);


GO
PRINT N'Création de Table [dbo].[CLIENTS]...';


GO
CREATE TABLE [dbo].[CLIENTS] (
    [IdClient]      INT          IDENTITY (1, 1) NOT NULL,
    [nomClient]     VARCHAR (32) NULL,
    [prenomClient]  VARCHAR (32) NULL,
    [adresseClient] VARCHAR (32) NULL,
    [cpClient]      VARCHAR (32) NULL,
    [villeClient]   VARCHAR (32) NULL,
    [photoClient]   VARCHAR (32) NULL,
    [authId]        INT          NULL,
    PRIMARY KEY CLUSTERED ([IdClient] ASC),
    UNIQUE NONCLUSTERED ([authId] ASC)
);


GO
PRINT N'Création de Table [dbo].[COMMANDES]...';


GO
CREATE TABLE [dbo].[COMMANDES] (
    [Id]                INT             IDENTITY (1, 1) NOT NULL,
    [numeroCom]         VARCHAR (50)    NULL,
    [reportagePhotoCam] VARBINARY (MAX) NULL,
    [clientId]          INT             NOT NULL,
    [guitareId]         INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de Table [dbo].[GUITARES]...';


GO
CREATE TABLE [dbo].[GUITARES] (
    [IdGuitare]      INT IDENTITY (1, 1) NOT NULL,
    [mancheBoisId]   INT NOT NULL,
    [toucheBoisId]   INT NOT NULL,
    [corpBoisId]     INT NOT NULL,
    [neckMicroId]    INT NOT NULL,
    [centralMicroId] INT NULL,
    [bridgeMicroId]  INT NOT NULL,
    [vibratoId]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IdGuitare] ASC)
);


GO
PRINT N'Création de Table [dbo].[MICROTYPES]...';


GO
CREATE TABLE [dbo].[MICROTYPES] (
    [IdMicro]          INT          IDENTITY (1, 1) NOT NULL,
    [nomMicro]         VARCHAR (32) NULL,
    [descriptionMicro] VARCHAR (32) NULL,
    [dispoMicro]       BIT          NULL,
    PRIMARY KEY CLUSTERED ([IdMicro] ASC)
);


GO
PRINT N'Création de Table [dbo].[VIBRATOTYPES]...';


GO
CREATE TABLE [dbo].[VIBRATOTYPES] (
    [IdVibrato]          INT          IDENTITY (1, 1) NOT NULL,
    [nomVibrato]         VARCHAR (32) NULL,
    [descriptionVibrato] VARCHAR (32) NULL,
    [dispoVibrato]       BIT          NULL,
    PRIMARY KEY CLUSTERED ([IdVibrato] ASC)
);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[CLIENTS]...';


GO
ALTER TABLE [dbo].[CLIENTS] WITH NOCHECK
    ADD FOREIGN KEY ([authId]) REFERENCES [dbo].[AUTHENTIFICATIONS] ([IdAuth]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[COMMANDES]...';


GO
ALTER TABLE [dbo].[COMMANDES] WITH NOCHECK
    ADD FOREIGN KEY ([clientId]) REFERENCES [dbo].[CLIENTS] ([IdClient]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[COMMANDES]...';


GO
ALTER TABLE [dbo].[COMMANDES] WITH NOCHECK
    ADD FOREIGN KEY ([guitareId]) REFERENCES [dbo].[GUITARES] ([IdGuitare]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] WITH NOCHECK
    ADD FOREIGN KEY ([mancheBoisId]) REFERENCES [dbo].[BOISTYPES] ([IdBois]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] WITH NOCHECK
    ADD FOREIGN KEY ([toucheBoisId]) REFERENCES [dbo].[BOISTYPES] ([IdBois]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] WITH NOCHECK
    ADD FOREIGN KEY ([corpBoisId]) REFERENCES [dbo].[BOISTYPES] ([IdBois]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] WITH NOCHECK
    ADD FOREIGN KEY ([neckMicroId]) REFERENCES [dbo].[MICROTYPES] ([IdMicro]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] WITH NOCHECK
    ADD FOREIGN KEY ([centralMicroId]) REFERENCES [dbo].[MICROTYPES] ([IdMicro]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] WITH NOCHECK
    ADD FOREIGN KEY ([bridgeMicroId]) REFERENCES [dbo].[MICROTYPES] ([IdMicro]);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] WITH NOCHECK
    ADD FOREIGN KEY ([vibratoId]) REFERENCES [dbo].[VIBRATOTYPES] ([IdVibrato]);


GO
