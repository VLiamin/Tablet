USE [Tablet]
GO

/****** Объект: Table [dbo].[Structures] Дата скрипта: 24.12.2020 18:02:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Structures] (
    [Id]         NVARCHAR (450) NOT NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [Proportion] INT            NOT NULL
);


