-- To run this query properly, make sure you right click dboProducts.mdf, 
-- left click New Query, then paste this query into the new query

-- Drop the old table if it exists
DROP TABLE IF EXISTS [dbo].[Transaction_Product]

-- Create the table Transactions
CREATE TABLE [dbo].[Transaction_Product] (
    [TransactionID] INT NOT NULL,
    [UPC]           INT NOT NULL,
    [Quantity]      INT NULL,
    [Discount]      DECIMAL(4, 4) NULL,
    FOREIGN KEY ([TransactionID]) REFERENCES [dbo].[Transactions] ([TransactionID]),
    FOREIGN KEY ([UPC]) REFERENCES [dbo].[Products] ([UPC])
);



