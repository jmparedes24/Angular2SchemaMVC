﻿CREATE TABLE [dbo].[Watch] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy]        NVARCHAR (250) NULL,
    [DateCreated]      DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (250) NULL,
    [DateModified]     DATETIME       NULL,
    [WatchModelId]     INT            NOT NULL,
    [ShortDescription] NVARCHAR (200) NOT NULL,
    [Description]      NVARCHAR (200) NOT NULL,
    [Price]            DECIMAL (18)   NOT NULL,
    [SalePrice]        DECIMAL (18)   NOT NULL,
    [ItemNumber]       INT            NOT NULL,
    [Manufacturer]     NVARCHAR (200) NOT NULL,
    [ModelNameNumber]  NVARCHAR (200) NOT NULL,
    [SerialYear]       NVARCHAR (200) NOT NULL,
    [Grade]            NVARCHAR (50)  NOT NULL,
    [Gender]           INT            NOT NULL,
    [Features]         NVARCHAR (200) NOT NULL,
    [Case]             NVARCHAR (200) NOT NULL,
    [Dial]             NVARCHAR (200) NOT NULL,
    [Bracelet]         NVARCHAR (200) NOT NULL,
    [BoxPapers]        NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Watch] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_WatchModelId_WatchModel_Id] FOREIGN KEY ([WatchModelId]) REFERENCES [dbo].[WatchModel] ([Id])
);

