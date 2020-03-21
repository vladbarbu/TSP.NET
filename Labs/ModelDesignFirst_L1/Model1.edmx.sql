
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 12:12:37
-- Generated from EDMX file: C:\Users\Vlad\source\repos\ModelDesignFirst_L1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PhotoProps];
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

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Photo_Id] int IDENTITY(1,1) NOT NULL,
    [Photo_Path] nvarchar(max)  NOT NULL,
    [Photo_Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Properties'
CREATE TABLE [dbo].[Properties] (
    [Property_Id] int IDENTITY(1,1) NOT NULL,
    [Property_Name] nvarchar(max)  NOT NULL,
    [Property_Description] nvarchar(max)  NOT NULL,
    [PhotoPhoto_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Photo_Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Photo_Id] ASC);
GO

-- Creating primary key on [Property_Id] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [PK_Properties]
    PRIMARY KEY CLUSTERED ([Property_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhotoPhoto_Id] in table 'Properties'
ALTER TABLE [dbo].[Properties]
ADD CONSTRAINT [FK_PhotoProperties]
    FOREIGN KEY ([PhotoPhoto_Id])
    REFERENCES [dbo].[Photos]
        ([Photo_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoProperties'
CREATE INDEX [IX_FK_PhotoProperties]
ON [dbo].[Properties]
    ([PhotoPhoto_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------