CREATE TABLE [dbo].[Item] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [ProductName] NVARCHAR (MAX)  NULL,
    [Date]        DATETIME2 (7)   NOT NULL,
    [Quantity]    INT             NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([ID] ASC)
);

