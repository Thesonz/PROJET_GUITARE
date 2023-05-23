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
La colonne [dbo].[STATISTIQUES].[revenueMois] est en cours de suppression, des données risquent d'être perdues.

La colonne [dbo].[STATISTIQUES].[dateAnnee] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisAout] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisAvri] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisDece] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisFevr] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisJanv] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisJuil] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisJuin] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisMai] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisMars] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisNove] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisOcto] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.

La colonne [dbo].[STATISTIQUES].[revenueMoisSept] de la table [dbo].[STATISTIQUES] doit être ajoutée mais la colonne ne comporte pas de valeur par défaut et n'autorise pas les valeurs NULL. Si la table contient des données, le script ALTER ne fonctionnera pas. Pour éviter ce problème, vous devez ajouter une valeur par défaut à la colonne, la marquer comme autorisant les valeurs Null ou activer la génération de smart-defaults en tant qu'option de déploiement.
*/

IF EXISTS (select top 1 1 from [dbo].[STATISTIQUES])
    RAISERROR (N'Lignes détectées. Arrêt de la mise à jour du schéma en raison d''''un risque de perte de données.', 16, 127) WITH NOWAIT

GO
PRINT N'Début de la régénération de la table [dbo].[STATISTIQUES]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_STATISTIQUES] (
    [Id]              INT IDENTITY (1, 1) NOT NULL,
    [nombreVue]       INT NOT NULL,
    [revenueTotal]    INT NOT NULL,
    [revenueMoisJanv] INT NOT NULL,
    [revenueMoisFevr] INT NOT NULL,
    [revenueMoisMars] INT NOT NULL,
    [revenueMoisAvri] INT NOT NULL,
    [revenueMoisMai]  INT NOT NULL,
    [revenueMoisJuin] INT NOT NULL,
    [revenueMoisJuil] INT NOT NULL,
    [revenueMoisAout] INT NOT NULL,
    [revenueMoisSept] INT NOT NULL,
    [revenueMoisOcto] INT NOT NULL,
    [revenueMoisNove] INT NOT NULL,
    [revenueMoisDece] INT NOT NULL,
    [revenueAnnee]    INT NOT NULL,
    [dateAnnee]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[STATISTIQUES])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_STATISTIQUES] ON;
        INSERT INTO [dbo].[tmp_ms_xx_STATISTIQUES] ([Id], [nombreVue], [revenueTotal], [revenueAnnee])
        SELECT   [Id],
                 [nombreVue],
                 [revenueTotal],
                 [revenueAnnee]
        FROM     [dbo].[STATISTIQUES]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_STATISTIQUES] OFF;
    END

DROP TABLE [dbo].[STATISTIQUES];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_STATISTIQUES]', N'STATISTIQUES';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Mise à jour terminée.';


GO
