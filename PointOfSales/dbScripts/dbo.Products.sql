CREATE TABLE [dbo].[Products] (
    [UPC]		  INT           NOT NULL IDENTITY,
    [Name]        VARCHAR (50)  NULL,
    [Price]       DECIMAL (10, 2)  NULL,
    [Description] VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([UPC] ASC)
);

