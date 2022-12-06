IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Transaction_Table'))
BEGIN;
    DROP TABLE [Transaction_Table];
END;
GO

CREATE TABLE [Transaction_Table] (
    [Transaction_ID] INTEGER NOT NULL IDENTITY(1, 1),
	[Transaction_Customer_ID] INT FOREIGN KEY REFERENCES Customer_Table(Customer_ID),
	[Transaction_Store_ID] INT FOREIGN KEY REFERENCES Store_Table(Store_Table_ID),
	[Transaction_Date] DATE NOT NULL,
	[Transaction_Amount] MONEY NOT NULL,
    PRIMARY KEY ([Transaction_ID])
);

GO