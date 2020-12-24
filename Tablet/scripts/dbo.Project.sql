USE [Tablet]
GO

/****** Объект: Table [dbo].[Project] Дата скрипта: 24.12.2020 18:02:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Project] (
    [Id]         NVARCHAR (450) NOT NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [Customer]   NVARCHAR (MAX) NULL,
    [Developer]  NVARCHAR (MAX) NULL,
    [Technology] NVARCHAR (MAX) NULL,
    [Cost]       INT            NOT NULL
);


