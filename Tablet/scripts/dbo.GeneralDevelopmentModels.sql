USE [Tablet]
GO

/****** Объект: Table [dbo].[GeneralDevelopmentModels] Дата скрипта: 24.12.2020 18:00:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GeneralDevelopmentModels] (
    [Id]       NVARCHAR (450) NOT NULL,
    [Date]     DATETIME2 (7)  NOT NULL,
    [Forecast] INT            NOT NULL,
    [Progress] INT            NOT NULL
);


