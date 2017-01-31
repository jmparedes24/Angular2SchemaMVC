CREATE TABLE [dbo].[WatchModel] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy]    NVARCHAR (250) NULL,
    [DateCreated]  DATETIME       NULL,
    [ModifiedBy]   NVARCHAR (250) NULL,
    [DateModified] DATETIME       NULL,
    [Description]  NVARCHAR (200) NOT NULL,
    [Category]     NVARCHAR (200) NULL,
    CONSTRAINT [PK_WatchModel] PRIMARY KEY CLUSTERED ([Id] ASC)
);

