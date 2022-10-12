-- To run this query properly, make sure you right click dboProducts.mdf, 
-- left click New Query, then paste this query into the new query

-- Drop the old table if it exists
DROP TABLE IF EXISTS [dbo].[Users]

-- Create the table Products
CREATE TABLE [dbo].[Users] (
    [UserId]   INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (40) NULL,
    [Password] VARCHAR (30) NULL,
    [IsAdmin] BIT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

-- Populate table with data | If new table data is added, paste the new table data query over this section
SET IDENTITY_INSERT [dbo].[Users] ON
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(1,N'fVargas',N'felixPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(2,N'dKlevgard',N'davisPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(3,N'tKozlowski',N'travisPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(4,N'tQuinn',N'tylerPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(5,N'sRadke',N'samuelPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(6,N'bWerlein',N'brandonPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(7,N'jJohnson',N'johnPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(8,N'bBohnson',N'billPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(9,N'kUtgure',N'kylePassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(10,N'jCooley',N'joshPassword', CAST(0 AS bit)) 
        INSERT INTO[dbo].[Users]([UserId],[Username],[Password],[IsAdmin])VALUES(11,N'a',N'a', CAST(1 AS bit))
SET IDENTITY_INSERT [dbo].[Users] OFF
