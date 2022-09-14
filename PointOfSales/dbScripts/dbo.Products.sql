CREATE TABLE [dbo].[Products] (
    [UPC]   INT           NOT NULL IDENTITY,
    [Name]        VARCHAR (50)  NULL,
    [Price]       DECIMAL (18)  NULL,
    [Description] VARCHAR (500) NULL,
    [Department] VARCHAR(15) NULL, 
    PRIMARY KEY CLUSTERED ([UPC] ASC)
);

