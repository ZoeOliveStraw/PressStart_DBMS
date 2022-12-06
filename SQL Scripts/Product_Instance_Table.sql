IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Product_Instance_Table'))
BEGIN;
    DROP TABLE [Product_Instance_Table];
END;
GO

CREATE TABLE [Product_Instance_Table] (
    [Product_Instance_ID] INTEGER NOT NULL IDENTITY(1, 1),
	[Product_Instance_Product_ID] INT FOREIGN KEY REFERENCES Product_Table(Product_ID),
	[Product_Instance_Customer_ID_Seller] INT FOREIGN KEY REFERENCES Customer_Table(Customer_ID),
	[Product_Instance_Store_ID] INT FOREIGN KEY REFERENCES Store_Table(Store_Table_ID),
	[Product_Instance_Used] BIT NOT NULL,
	[Product_Instance_Price] MONEY NOT NULL,
	[Product_instance_Condition] INT,
    PRIMARY KEY ([Product_Instance_ID])
);

GO