CREATE TABLE [dbo].[State] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy]    NVARCHAR (250) NULL,
    [DateCreated]  DATETIME       NULL,
    [ModifiedBy]   NVARCHAR (250) NULL,
    [DateModified] DATETIME       NULL,
    [Name]         NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

