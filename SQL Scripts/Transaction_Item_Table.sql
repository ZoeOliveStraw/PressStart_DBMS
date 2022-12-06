IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Transaction_Item_Table'))
BEGIN;
    DROP TABLE [Transaction_Itemm_Table];
END;
GO

CREATE TABLE [Transaction_Item_Table] (
	[Transaction_Item_Transaction_ID] INT FOREIGN KEY REFERENCES Transaction_Table(Transaction_ID),
	[Transaction_Item_Product_Instance_ID] INT FOREIGN KEY REFERENCES Product_Instance_Table(Product_Instance_ID),
);

GO