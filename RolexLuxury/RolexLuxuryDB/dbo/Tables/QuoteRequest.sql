CREATE TABLE [dbo].[QuoteRequest] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy]    NVARCHAR (250) NULL,
    [DateCreated]  DATETIME       NULL,
    [ModifiedBy]   NVARCHAR (250) NULL,
    [DateModified] DATETIME       NULL,
    [Email]        NVARCHAR (100) NOT NULL,
    [Phone]        NVARCHAR (10)  NOT NULL,
    [Comments]     NVARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

