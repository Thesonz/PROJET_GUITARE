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
