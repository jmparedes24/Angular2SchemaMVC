CREATE TABLE [dbo].[BuyRequest] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy]     NVARCHAR (250) NULL,
    [DateCreated]   DATETIME       NULL,
    [ModifiedBy]    NVARCHAR (250) NULL,
    [DateModified]  DATETIME       NULL,
    [DateRequested] DATETIME       NOT NULL,
    CONSTRAINT [PK_BuyRequest] PRIMARY KEY CLUSTERED ([Id] ASC)
);

