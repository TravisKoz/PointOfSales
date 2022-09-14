CREATE TABLE [dbo].[Products] (
    [ProductId]   INT           NOT NULL,
    [Name]        VARCHAR (50)  NULL,
    [Price]       DECIMAL (18)  NULL,
    [Description] VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

