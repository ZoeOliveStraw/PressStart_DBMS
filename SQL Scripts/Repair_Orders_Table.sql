IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('Repair_Order_Table'))
BEGIN;
    DROP TABLE [Repair_Order_Table];
END;
GO

CREATE TABLE [Repair_Order_Table] (
    [Repair_Order_ID] INTEGER NOT NULL IDENTITY(1, 1),
	[Repair_Staff_ID] INT FOREIGN KEY REFERENCES Staff_Table(Staff_ID),
	[Repair_Customer_ID] INT FOREIGN KEY REFERENCES Customer_Table(Customer_ID),
	[Repair_Order_Date] DATE NOT NULL,
	[Repair_Order_Description] VARCHAR(2000) NOT NULL,
	[Repair_Order_Store_ID] INT FOREIGN KEY REFERENCES Store_Table(Store_Table_ID),
    PRIMARY KEY ([Repair_Order_ID])
);

GO