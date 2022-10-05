-- To run this query properly, make sure you right click dboProducts.mdf, 
-- left click New Query, then paste this query into the new query

-- Drop the old table if it exists
DROP TABLE IF EXISTS [dbo].[Transactions]

-- Create the table Transactions
CREATE TABLE [dbo].[Transactions] (
    [TransactionID] INT      IDENTITY (1, 1) NOT NULL,
    [Time]          DATETIME NULL
);
