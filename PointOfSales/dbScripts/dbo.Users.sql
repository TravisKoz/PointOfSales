-- To run this query properly, make sure you right click dboProducts.mdf, 
-- left click New Query, then paste this query into the new query

-- Drop the old table if it exists
DROP TABLE IF EXISTS [dbo].[Users]

-- Create the table Products
CREATE TABLE [dbo].[Users] (
    [UserId]   INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (40) NULL,
    [Password] VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

-- Populate table with data | If new table data is added, paste the new table data query over this section
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (1, N'fVargas', N'felixPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (2, N'dKlevgard', N'davisPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (3, N'tKozlowski', N'travisPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (4, N'tQuinn', N'tylerPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (5, N'sRadke', N'samuelPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (6, N'bWerlein', N'brandonPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (7, N'jJohnson', N'johnPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (8, N'bBohnson', N'billPassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (9, N'kUtgure', N'kylePassword')
INSERT INTO [dbo].[Users] ([UserId], [Username], [Password]) VALUES (10, N'jCooley', N'joshPassword')
SET IDENTITY_INSERT [dbo].[Users] OFF
