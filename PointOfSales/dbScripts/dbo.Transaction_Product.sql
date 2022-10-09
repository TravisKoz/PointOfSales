-- To run this query properly, make sure you right click dboProducts.mdf, 
-- left click New Query, then paste this query into the new query

-- Drop the old table if it exists
DROP TABLE IF EXISTS [dbo].[Transaction_Product]

-- Create the table Transactions
CREATE TABLE [dbo].[Transaction_Product]
(
	[TransactionID] INT NOT NULL PRIMARY KEY, 
    [UPC] INT NOT NULL, FOREIGN KEY ([UPC]) REFERENCES [dbo].[Products],
    [Quantity] INT NULL,
);

