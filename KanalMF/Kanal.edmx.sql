
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/30/2021 19:30:04
-- Generated from EDMX file: C:\Users\STUDENT1\source\repos\KanalMF\KanalMF\Kanal.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Yayin];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KanalSet'
CREATE TABLE [dbo].[KanalSet] (
    [KanalId] int IDENTITY(1,1) NOT NULL,
    [KanalAdi] nvarchar(max)  NOT NULL,
    [KanalCiro] decimal(18,0)  NOT NULL,
    [KAdres] nvarchar(max)  NOT NULL,
    [KReyting] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'YayinSet'
CREATE TABLE [dbo].[YayinSet] (
    [YayinId] int IDENTITY(1,1) NOT NULL,
    [YAdi] nvarchar(max)  NOT NULL,
    [YTarihi] nvarchar(max)  NOT NULL,
    [YReyting] decimal(18,0)  NOT NULL,
    [KanalKanalId] int  NOT NULL
);
GO

-- Creating table 'SorumluSet'
CREATE TABLE [dbo].[SorumluSet] (
    [SorumluId] int IDENTITY(1,1) NOT NULL,
    [SAdSoyad] nvarchar(max)  NOT NULL,
    [SGorevi] nvarchar(max)  NOT NULL,
    [SMaas] decimal(18,0)  NOT NULL,
    [SorumluGorevSayisi] nvarchar(max)  NOT NULL,
    [YayinYayinId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [KanalId] in table 'KanalSet'
ALTER TABLE [dbo].[KanalSet]
ADD CONSTRAINT [PK_KanalSet]
    PRIMARY KEY CLUSTERED ([KanalId] ASC);
GO

-- Creating primary key on [YayinId] in table 'YayinSet'
ALTER TABLE [dbo].[YayinSet]
ADD CONSTRAINT [PK_YayinSet]
    PRIMARY KEY CLUSTERED ([YayinId] ASC);
GO

-- Creating primary key on [SorumluId] in table 'SorumluSet'
ALTER TABLE [dbo].[SorumluSet]
ADD CONSTRAINT [PK_SorumluSet]
    PRIMARY KEY CLUSTERED ([SorumluId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KanalKanalId] in table 'YayinSet'
ALTER TABLE [dbo].[YayinSet]
ADD CONSTRAINT [FK_KanalYayin]
    FOREIGN KEY ([KanalKanalId])
    REFERENCES [dbo].[KanalSet]
        ([KanalId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KanalYayin'
CREATE INDEX [IX_FK_KanalYayin]
ON [dbo].[YayinSet]
    ([KanalKanalId]);
GO

-- Creating foreign key on [YayinYayinId] in table 'SorumluSet'
ALTER TABLE [dbo].[SorumluSet]
ADD CONSTRAINT [FK_YayinSorumlu]
    FOREIGN KEY ([YayinYayinId])
    REFERENCES [dbo].[YayinSet]
        ([YayinId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_YayinSorumlu'
CREATE INDEX [IX_FK_YayinSorumlu]
ON [dbo].[SorumluSet]
    ([YayinYayinId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------