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
/*
Le type de la colonne adresseMailAuth dans la table [dbo].[AUTHENTIFICATIONS] est actuellement  VARCHAR (50) NULL, mais est remplacé par  VARCHAR (32) NULL. Une perte de données peut se produire et le déploiement risque d'échouer si la colonne contient des données incompatibles avec le type  VARCHAR (32) NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[AUTHENTIFICATIONS])
    RAISERROR (N'Lignes détectées. Arrêt de la mise à jour du schéma en raison d''''un risque de perte de données.', 16, 127) WITH NOWAIT

GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[CLIENTS]...';


GO
ALTER TABLE [dbo].[CLIENTS] DROP CONSTRAINT [FK__CLIENTS__authId__693CA210];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] DROP CONSTRAINT [FK__GUITARES__manche__6C190EBB];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] DROP CONSTRAINT [FK__GUITARES__touche__6D0D32F4];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] DROP CONSTRAINT [FK__GUITARES__corpBo__6E01572D];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[COMMANDES]...';


GO
ALTER TABLE [dbo].[COMMANDES] DROP CONSTRAINT [FK__COMMANDES__clien__6A30C649];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[COMMANDES]...';


GO
ALTER TABLE [dbo].[COMMANDES] DROP CONSTRAINT [FK__COMMANDES__guita__6B24EA82];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] DROP CONSTRAINT [FK__GUITARES__neckMi__6EF57B66];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] DROP CONSTRAINT [FK__GUITARES__centra__6FE99F9F];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] DROP CONSTRAINT [FK__GUITARES__bridge__70DDC3D8];


GO
PRINT N'Suppression de Clé étrangère contrainte sans nom sur [dbo].[GUITARES]...';


GO
ALTER TABLE [dbo].[GUITARES] DROP CONSTRAINT [FK__GUITARES__vibrat__71D1E811];


GO
PRINT N'Début de la régénération de la table [dbo].[AUTHENTIFICATIONS]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_AUTHENTIFICATIONS] (
    [IdAuth]          INT          IDENTITY (1, 1) NOT NULL,
    [adresseMailAuth] VARCHAR (32) NULL,
    [passwordAuth]    VARCHAR (32) NULL,
    PRIMARY KEY CLUSTERED ([IdAuth] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[AUTHENTIFICATIONS])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_AUTHENTIFICATIONS] ON;
        INSERT INTO [dbo].[tmp_ms_xx_AUTHENTIFICATIONS] ([IdAuth], [adresseMailAuth], [passwordAuth])
        SELECT   [IdAuth],
                 [adresseMailAuth],
                 [passwordAuth]
        FROM     [dbo].[AUTHENTIFICATIONS]
        ORDER BY [IdAuth] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_AUTHENTIFICATIONS] OFF;
    END

DROP TABLE [dbo].[AUTHENTIFICATIONS];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_AUTHENTIFICATIONS]', N'AUTHENTIFICATIONS';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Début de la régénération de la table [dbo].[BOISTYPES]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_BOISTYPES] (
    [IdBois]          INT          IDENTITY (1, 1) NOT NULL,
    [nomBois]         VARCHAR (32) NULL,
    [descriptionBois] VARCHAR (32) NULL,
    [dispoBois]       BIT          NULL,
    PRIMARY KEY CLUSTERED ([IdBois] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[BOISTYPES])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_BOISTYPES] ON;
        INSERT INTO [dbo].[tmp_ms_xx_BOISTYPES] ([IdBois], [nomBois], [descriptionBois], [dispoBois])
        SELECT   [IdBois],
                 [nomBois],
                 [descriptionBois],
                 [dispoBois]
        FROM     [dbo].[BOISTYPES]
        ORDER BY [IdBois] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_BOISTYPES] OFF;
    END

DROP TABLE [dbo].[BOISTYPES];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_BOISTYPES]', N'BOISTYPES';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Début de la régénération de la table [dbo].[CLIENTS]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_CLIENTS] (
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

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[CLIENTS])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_CLIENTS] ON;
        INSERT INTO [dbo].[tmp_ms_xx_CLIENTS] ([IdClient], [nomClient], [prenomClient], [adresseClient], [cpClient], [villeClient], [photoClient], [authId])
        SELECT   [IdClient],
                 [nomClient],
                 [prenomClient],
                 [adresseClient],
                 [cpClient],
                 [villeClient],
                 [photoClient],
                 [authId]
        FROM     [dbo].[CLIENTS]
        ORDER BY [IdClient] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_CLIENTS] OFF;
    END

DROP TABLE [dbo].[CLIENTS];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_CLIENTS]', N'CLIENTS';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Début de la régénération de la table [dbo].[COMMANDES]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_COMMANDES] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [numeroCom]         VARCHAR (50)  NULL,
    [reportagePhotoCam] VARCHAR (MAX) NULL,
    [clientId]          INT           NOT NULL,
    [guitareId]         INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[COMMANDES])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_COMMANDES] ON;
        INSERT INTO [dbo].[tmp_ms_xx_COMMANDES] ([Id], [numeroCom], [reportagePhotoCam], [clientId], [guitareId])
        SELECT   [Id],
                 [numeroCom],
                 [reportagePhotoCam],
                 [clientId],
                 [guitareId]
        FROM     [dbo].[COMMANDES]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_COMMANDES] OFF;
    END

DROP TABLE [dbo].[COMMANDES];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_COMMANDES]', N'COMMANDES';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Début de la régénération de la table [dbo].[MICROTYPES]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_MICROTYPES] (
    [IdMicro]          INT          IDENTITY (1, 1) NOT NULL,
    [nomMicro]         VARCHAR (32) NULL,
    [descriptionMicro] VARCHAR (32) NULL,
    [dispoMicro]       BIT          NULL,
    PRIMARY KEY CLUSTERED ([IdMicro] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[MICROTYPES])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_MICROTYPES] ON;
        INSERT INTO [dbo].[tmp_ms_xx_MICROTYPES] ([IdMicro], [nomMicro], [descriptionMicro], [dispoMicro])
        SELECT   [IdMicro],
                 [nomMicro],
                 [descriptionMicro],
                 [dispoMicro]
        FROM     [dbo].[MICROTYPES]
        ORDER BY [IdMicro] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_MICROTYPES] OFF;
    END

DROP TABLE [dbo].[MICROTYPES];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_MICROTYPES]', N'MICROTYPES';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Début de la régénération de la table [dbo].[VIBRATOTYPES]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_VIBRATOTYPES] (
    [IdVibrato]          INT          IDENTITY (1, 1) NOT NULL,
    [nomVibrato]         VARCHAR (32) NULL,
    [descriptionVibrato] VARCHAR (32) NULL,
    [dispoVibrato]       BIT          NULL,
    PRIMARY KEY CLUSTERED ([IdVibrato] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[VIBRATOTYPES])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_VIBRATOTYPES] ON;
        INSERT INTO [dbo].[tmp_ms_xx_VIBRATOTYPES] ([IdVibrato], [nomVibrato], [descriptionVibrato], [dispoVibrato])
        SELECT   [IdVibrato],
                 [nomVibrato],
                 [descriptionVibrato],
                 [dispoVibrato]
        FROM     [dbo].[VIBRATOTYPES]
        ORDER BY [IdVibrato] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_VIBRATOTYPES] OFF;
    END

DROP TABLE [dbo].[VIBRATOTYPES];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_VIBRATOTYPES]', N'VIBRATOTYPES';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Création de Table [dbo].[STATISTIQUES]...';


GO
CREATE TABLE [dbo].[STATISTIQUES] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [nombreVue]    INT NOT NULL,
    [revenueTotal] INT NOT NULL,
    [revenueMois]  INT NOT NULL,
    [revenueAnnee] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Création de Clé étrangère contrainte sans nom sur [dbo].[CLIENTS]...';


GO
ALTER TABLE [dbo].[CLIENTS] WITH NOCHECK
    ADD FOREIGN KEY ([authId]) REFERENCES [dbo].[AUTHENTIFICATIONS] ([IdAuth]);


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
