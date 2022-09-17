-- To run this query properly, make sure you right click dboProducts.mdf, 
-- left click New Query, then paste this query into the new query

-- Drop the old table if it exists
DROP TABLE IF EXISTS [dbo].[Products]

-- Create the table Products
CREATE TABLE [dbo].[Products] (
    [UPC]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NULL,
    [Price]       DECIMAL (18, 2)  NULL,
    [Description] VARCHAR (500) NULL,
    [Department]  VARCHAR (15)  NULL,
    PRIMARY KEY CLUSTERED ([UPC] ASC)
);

-- Populate table with data | If new table data is added, paste the new table data query over this section
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (1, N'Milk', CAST(3.46 AS Decimal(18, 2)), N'Whole Milk Gallon', N'Grocery')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (2, N'Bacon', CAST(4.48 AS Decimal(18, 2)), N'Thick Slide Bacon Smoked 16oz package', N'Grocery')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (3, N'White Rice', CAST(1.54 AS Decimal(18, 2)), N'Long Grain Rice, 32oz bag', N'Grocery')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (4, N'Cereal', CAST(4.78 AS Decimal(18, 2)), N'Ca''pn Crunch''s 20oz', N'Grocery')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (5, N'Muffins', CAST(4.98 AS Decimal(18, 2)), N'Lemon Muffins, 14oz, 4 count', N'Grocery')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (6, N'Roku', CAST(29.00 AS Decimal(18, 2)), N'Streaming Media Player', N'Electronics')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (7, N'Xbox Controller', CAST(49.49 AS Decimal(18, 2)), N'Microsoft Xbox Wireless Controler - Blue', N'Electronics')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (8, N'Gaming Headset', CAST(38.80 AS Decimal(18, 2)), N'ASTRO Gaming Headset  - Green / Black', N'Electronics')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (9, N'Nintendo Switch', CAST(339.97 AS Decimal(18, 2)), N'Nintendo Switch Console', N'Electronics')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (10, N'TV', CAST(797.99 AS Decimal(18, 2)), N'Samsung 55" QLED 4K smart TV', N'Electronics')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (11, N'Uno', CAST(5.99 AS Decimal(18, 2)), N'Color and number matching card game', N'Toys')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (12, N'Bowling Set', CAST(23.88 AS Decimal(18, 2)), N'Plat Day Jumbo Bowling Set', N'Toys')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (13, N'Dart Gun', CAST(39.82 AS Decimal(18, 2)), N'Dart Blaster - shoots over 125FT', N'Toys')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (14, N'Jenga ', CAST(10.27 AS Decimal(18, 2)), N'Hard Blocks, Stacking game', N'Toys')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (15, N'Mystery Capsule', CAST(6.97 AS Decimal(18, 2)), N'5 Surprise mini brands Series 3', N'Toys')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (16, N'Table lamp', CAST(29.88 AS Decimal(18, 2)), N'Ceramic Table Lamp - White', N'Home')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (17, N'Book shelf', CAST(119.99 AS Decimal(18, 2)), N'Bookshelf with 3 drawers', N'Home')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (18, N'Cube storage', CAST(44.97 AS Decimal(18, 2)), N'Cube storage organizer - balck ', N'Home')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (19, N'Barstool set', CAST(69.99 AS Decimal(18, 2)), N'Metal frame couter stool - 2 units', N'Home')
INSERT INTO [dbo].[Products] ([UPC], [Name], [Price], [Description], [Department]) VALUES (20, N'Coffee table', CAST(85.11 AS Decimal(18, 2)), N'Crastsman mordern coffee table', N'Home')
SET IDENTITY_INSERT [dbo].[Products] OFF