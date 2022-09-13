CREATE TABLE [dbo].[Users] (
    [UserId]   INT          NOT NULL,
    [Username] VARCHAR (40) NULL,
    [Password] VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

