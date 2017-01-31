CREATE TABLE [dbo].[BuyRequestInfo] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [CreatedBy]       NVARCHAR (250) NULL,
    [DateCreated]     DATETIME       NULL,
    [ModifiedBy]      NVARCHAR (250) NULL,
    [DateModified]    DATETIME       NULL,
    [BuyRequestId]    INT            NOT NULL,
    [FirstName]       NVARCHAR (100) NOT NULL,
    [LastName]        NVARCHAR (100) NOT NULL,
    [AddressLine1]    NVARCHAR (200) NOT NULL,
    [AddressLine2]    NVARCHAR (200) NOT NULL,
    [City]            NVARCHAR (200) NOT NULL,
    [StateId]         INT            NOT NULL,
    [Zip]             NVARCHAR (12)  NOT NULL,
    [Phone]           NVARCHAR (10)  NOT NULL,
    [Email]           NVARCHAR (100) NOT NULL,
    [TypeInformation] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ StateId_State_Id] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([Id]),
    CONSTRAINT [FK_BuyRequestId_BuyRequest_Id] FOREIGN KEY ([BuyRequestId]) REFERENCES [dbo].[BuyRequest] ([Id])
);

