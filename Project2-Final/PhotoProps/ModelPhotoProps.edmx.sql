
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/31/2020 14:04:33
-- Generated from EDMX file: C:\Users\vladb\source\repos\PhotoProps\PhotoProps\ModelPhotoProps.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [project2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotoProps]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Props] DROP CONSTRAINT [FK_PhotoProps];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[Props]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Props];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Photo_Id] int IDENTITY(1,1) NOT NULL,
    [Photo_Path] nvarchar(max)  NOT NULL,
    [Photo_Date] datetime  NOT NULL
);
GO

-- Creating table 'Props'
CREATE TABLE [dbo].[Props] (
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

-- Creating primary key on [Property_Id] in table 'Props'
ALTER TABLE [dbo].[Props]
ADD CONSTRAINT [PK_Props]
    PRIMARY KEY CLUSTERED ([Property_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhotoPhoto_Id] in table 'Props'
ALTER TABLE [dbo].[Props]
ADD CONSTRAINT [FK_PhotoProps]
    FOREIGN KEY ([PhotoPhoto_Id])
    REFERENCES [dbo].[Photos]
        ([Photo_Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoProps'
CREATE INDEX [IX_FK_PhotoProps]
ON [dbo].[Props]
    ([PhotoPhoto_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------